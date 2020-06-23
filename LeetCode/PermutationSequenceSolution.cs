using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace DSACore.LeetCode
{
    /*
    https://leetcode.com/problems/permutation-sequence/
    The set [1,2,3,...,n] contains a total of n! unique permutations.

    By listing and labeling all of the permutations in order, we get the following sequence for n = 3:

    "123"
    "132"
    "213"
    "231"
    "312"
    "321"
    Given n and k, return the kth permutation sequence.

    Note:

    Given n will be between 1 and 9 inclusive.
    Given k will be between 1 and n! inclusive.
    Example 1:

    Input: n = 3, k = 3
    Output: "213"
    Example 2:

    Input: n = 4, k = 9
    Output: "2314"
    */
    public class PermutationSequenceSolution
    {
        public string GetPermutation(int n, int k)
        {
            int[] factorials = new int[n];
            List<int> nums = new List<int> { 1 };

            factorials[0] = 1;
            for (int i = 1; i < n; ++i)
            {
                // generate factorial system bases 0!, 1!, ..., (n - 1)!
                factorials[i] = factorials[i - 1] * i;
                // generate nums 1, 2, ..., n
                nums.Add(i + 1);
            }

            // fit k in the interval 0 ... (n! - 1)
            --k;

            // compute factorial representation of k
            StringBuilder sb = new StringBuilder();
            for (int i = n - 1; i > -1; --i)
            {
                int idx = k / factorials[i];
                k -= idx * factorials[i];

                sb.Append(nums[idx]);
                nums.RemoveAt(idx);
            }
            return sb.ToString();
        }
    }
}