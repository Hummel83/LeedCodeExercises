namespace LeedCodeBusiness.Algos.easy
{
    //number 1
    public class Sum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var sum = new int[2];
            var targethit = false;

            for (var firstNumber = 0; firstNumber < nums.Length; firstNumber++)
            {
                var currenFirstNumber = nums[firstNumber];

                for (var secondNumber = nums.Length - 1; secondNumber > 0; secondNumber--)
                {
                    var currentSecondNumber = nums[secondNumber];

                    if (target == currentSecondNumber + currenFirstNumber)
                        if (secondNumber != firstNumber)
                        {
                            sum[0] = firstNumber;
                            sum[1] = secondNumber;
                            targethit = true;
                            break;
                        }
                }

                if (targethit) break;
            }

            return sum;
        }
    }
}