using System.Linq;

namespace LeedCodeBusiness.Algos.easy
{
    //Number 136. Single Number
    public class SingleNum
    {
        public int SingleNumber(int[] nums)
        {
            return nums.Aggregate(0, (x, y) => x ^ y);
        }
    }
}