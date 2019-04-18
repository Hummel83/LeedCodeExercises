namespace LeedCodeBusiness.Algos.easy
{
    public class Sum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] sum = new int[2];
            bool targethit = false;

            for (int firstNumber = 0; firstNumber < nums.Length; firstNumber++)
            {
                int currenFirstNumber = nums[firstNumber];              

                for (int secondNumber = nums.Length - 1; secondNumber > 0; secondNumber--)
                {
                    int currentSecondNumber = nums[secondNumber];

                    if (target == currentSecondNumber + currenFirstNumber)
                    {
                        if (secondNumber != firstNumber)
                        {
                            sum[0] = firstNumber;
                            sum[1] = secondNumber;
                            targethit = true;
                            break;
                        }
                    }
                }
                if (targethit == true)
                {
                    break;
                }
            }

            return sum;
        }
    }
}