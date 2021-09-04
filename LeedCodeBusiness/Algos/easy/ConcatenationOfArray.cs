namespace LeedCodeBusiness.Algos.easy
{
    //number 1929
    public class ConcatenationOfArray
    {
        public int[] GetConcatenation(int[] nums)
        {
            int cn = nums.Length;
            int[] vl = new int[cn*2];             

            for (int i = 0; i < cn; i++)
            {
                vl[i] = nums[i];                 ;
                vl[i +cn] = nums[i];

            }          

            return vl;

        }

    }
}