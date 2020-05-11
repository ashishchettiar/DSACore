using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSACore.Algorithms
{
    public class BinarySearch
    {
        public int Find(int[] nums, int numberToFind)
        {
            int low = 0;
            int high = nums.Length -1;
            
            while(high > low)
            {
                var mid = low + (high - low) / 2;
                if(nums[mid] > numberToFind)
                {
                    high = mid - 1;
                }
                else if(nums[mid] < numberToFind)
                {
                    low = mid + 1;
                }
                else
                {
                    return nums[mid];
                }
            }

            return -1;
        }
    }
}
