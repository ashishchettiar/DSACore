using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.Algorithms
{
    public class BinarySearch
    {
        public int Find(int[] nums, int numberToFind)
        {
            int low = 0;
            int high = nums.Length -1;
            
            return 0;
        }

        private int FindIndex(int[] nums, int numberToFind, int low, int high)
        {
            return GetMid(low, high);
        }

        private int GetMid(int low, int high)
        {
            return (low + high) / 2;
        }
        
    }
}
