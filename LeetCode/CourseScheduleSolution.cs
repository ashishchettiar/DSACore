using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace DSACore.LeetCode
{
    /*
    https://leetcode.com/problems/course-schedule/
    There are a total of numCourses courses you have to take, labeled from 0 to numCourses-1.

    Some courses may have prerequisites, for example to take course 0 you have to first take course 1, which is expressed as a pair: [0,1]

    Given the total number of courses and a list of prerequisite pairs, is it possible for you to finish all courses?

    

    Example 1:

    Input: numCourses = 2, prerequisites = [[1,0]]
    Output: true
    Explanation: There are a total of 2 courses to take. 
                To take course 1 you should have finished course 0. So it is possible.
    Example 2:

    Input: numCourses = 2, prerequisites = [[1,0],[0,1]]
    Output: false
    Explanation: There are a total of 2 courses to take. 
                To take course 1 you should have finished course 0, and to take course 0 you should
                also have finished course 1. So it is impossible.
    

    Constraints:

    The input prerequisites is a graph represented by a list of edges, not adjacency matrices. Read more about how a graph is represented.
    You may assume that there are no duplicate edges in the input prerequisites.
    1 <= numCourses <= 10^5
    */
    public class CourseScheduleSolution
    {
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            // create graph with adjacency list
            List<List<int>> adj = new List<List<int>>(numCourses);
            List<int> visited = new List<int>(numCourses);
            for(int i=0;i<numCourses;i++)
            {
                adj.Add(new List<int>());
                visited.Add(0);
            }
            //Make adjacency matrix (Directed graph)
            for (int i = 0; i < prerequisites.Length; i++)
            {
                adj[prerequisites[i][0]].Add(prerequisites[i][1]);
            }

            for (int i = 0; i < numCourses; i++)
            {
                if (visited[i] == 0)
                {
                     if(IsCyclic(adj, visited, i)) return false;
                }
            }

            return true;
        }

        //graph depth first search
        private bool IsCyclic(List<List<int>> graph, List<int> visited, int currentNode)
        {
            if (visited[currentNode] == 2) return true;

            visited[currentNode] = 2;
            foreach (var node in graph[currentNode])
            {
                if (visited[currentNode] != 1)
                {
                    if(IsCyclic(graph, visited, node)) return true;
                }
            }

            visited[currentNode] = 1;
            return false;
        }
    }
}