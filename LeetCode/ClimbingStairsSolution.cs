using System.Collections.Generic;

namespace DSACore.LeetCode
{
    // LC: https://leetcode.com/problems/climbing-stairs/
    public class ClimbingStairsSolution
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();

        public int ClimbStairs(int n)
        {
            if (n == 0) return 1;
            if (n == 1) return 1;
            dict.Add(0, 1);
            dict.Add(1, 1);
            return Climb(n);
        }

        private int Climb(int n)
        {
            int a = 0;
            int b = 0;

            if (dict.ContainsKey(n - 1))
            {
                a = dict[n - 1];
            }
            else
            {
                a = Climb(n - 1);
                dict.Add(n - 1, a);
            }

            if (dict.ContainsKey(n - 2))
            {
                b = dict[n - 2];
            }
            else
            {
                b = Climb(n - 2);
                dict.Add(n - 2, b);
            }
            return a + b;
        }
    }
}
