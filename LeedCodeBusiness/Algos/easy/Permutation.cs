using System;

namespace LeedCodeBusiness.Algos.easy
{
    // nr 1920
    public class Permutation
    {
        public int[] BuildArray(int[] nums)
        {
            int n = 1001;
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = nums[i] + (nums[nums[i]] % n) * n;
              
            }

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = nums[i] / n;
            }
            return nums;
        }
    }
}