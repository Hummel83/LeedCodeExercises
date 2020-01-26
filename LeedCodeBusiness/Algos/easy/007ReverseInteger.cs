
namespace LeedCodeBusiness.Algos.easy
{
    //Number 7
    public class ReverseInteger
    {
        public int ReverseOneInteger(int integerValue)
        {
<<<<<<< HEAD:LeedCodeBusiness/Algos/easy/ReverseInteger.cs
            bool valueType = false;

            if (IntegerValue < 0)
            {
                valueType = true;
            }
=======
            bool valueType = integerValue < 0;
>>>>>>> 56aa67e8057ad554a89dea415a72d77c60df0afe:LeedCodeBusiness/Algos/easy/007ReverseInteger.cs

            string text = integerValue.ToString();

            char[] cArray = text.ToCharArray();
            string reverse = string.Empty;

            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
                if (valueType == true && i==0)
                {
                    reverse = reverse.Remove(cArray.Length - 1);
                    reverse = reverse.Insert(0, "-");
                }
            }

            try
            {
                var rev = int.Parse(reverse);

                return rev;
            }
            catch (System.Exception)
            {
                return 0;
            }
        }
    }
}