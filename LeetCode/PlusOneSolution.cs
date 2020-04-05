using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSACore.LeetCode
{

    // https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/559/
    public class PlusOneSolution
    {
        public int[] PlusOne(int[] digits)
        {
            bool overflow = false;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                var result = digits[i] + 1;
                if (result / 10 < 1)
                {
                    digits[i] = result;
                    overflow = false;
                    return digits;
                }
                digits[i] = 0;
                overflow = true;
            }

            if (overflow)
            {
                var resultarray = new int[] { 1 };
                Array.Resize(ref resultarray, digits.Length + 1);
                Array.Copy(digits, 0, resultarray, 1, digits.Length);
                return resultarray;
            }

            return digits;
        }
    }
}
