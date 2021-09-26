using System.Linq;

namespace LeedCodeBusiness.Algos.easy
{
    public class SingleNum
    {
        public int SingleNumber(int[] nums)
        {
            return nums.Aggregate(0, (x, y) => x ^ y);
        }
    }
}