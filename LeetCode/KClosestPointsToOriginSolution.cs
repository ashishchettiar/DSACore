using System;
using System.Text;
using System.Collections.Generic;

namespace DSACore.LeetCode
{
    /*
    https://leetcode.com/problems/k-closest-points-to-origin/
    We have a list of points on the plane.  Find the K closest points to the origin (0, 0).

    (Here, the distance between two points on a plane is the Euclidean distance.)

    You may return the answer in any order.  The answer is guaranteed to be unique (except for the order that it is in.)

    

    Example 1:

    Input: points = [[1,3],[-2,2]], K = 1
    Output: [[-2,2]]
    Explanation: 
    The distance between (1, 3) and the origin is sqrt(10).
    The distance between (-2, 2) and the origin is sqrt(8).
    Since sqrt(8) < sqrt(10), (-2, 2) is closer to the origin.
    We only want the closest K = 1 points from the origin, so the answer is just [[-2,2]].
    Example 2:

    Input: points = [[3,3],[5,-1],[-2,4]], K = 2
    Output: [[3,3],[-2,4]]
    (The answer [[-2,4],[3,3]] would also be accepted.)
    */
    public class KClosestPointsToOriginSolution
    {
        public int[][] KClosest(int[][] points, int K)
        {
            var sortedList = new SortedList<double, List<int[]>>();
            foreach(var point in points)
            {
                var distance = GetEuclideanDistance(point);
                if(sortedList.ContainsKey(distance))
                {
                    sortedList[distance].Add(point); 
                }
                else
                {
                    sortedList.Add(distance, new List<int[]> { point });
                }
            }

            var result = new int[K][];
            var sortedValues = sortedList.Values;
            for(int i=0; i<K; i++)
            {
                if(sortedValues[i].Count == 1)
                {
                    result[i] = sortedValues[i][0];
                }
                else
                {
                    foreach(var p in sortedValues[i])
                    {
                        result[i] = p;
                        i++;
                    }
                }
            }
            return result;
        }

        //calulate distance to origin
        //dist((x, y), (a, b)) = √(x - a)² + (y - b)²
        private double GetEuclideanDistance(int[] a)
        {
            var d = (a[0] * a[0]) + (a[1] * a[1]);
            return Math.Sqrt(d);
        }
    }
}