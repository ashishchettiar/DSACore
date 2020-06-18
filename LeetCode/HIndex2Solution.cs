using System;
using System.Linq;
using System.Collections.Generic;

namespace DSACore.LeetCode
{
    /*
    */
    public class HIndex2Solution
    {
        public int HIndex(int[] citations)
        {
            int low = 0;
            int high = citations.Length - 1;
            int mid;
            int n = citations.Length;

            if (n == 0) return 0;

            while (low < high)
            {
                mid = (low + high) / 2;

                if (citations[mid] < n - mid)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid;
                }
            }

            return (citations[low] > 0) ? n - low : 0;
        }
    }
}