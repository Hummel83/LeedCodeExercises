
namespace LeedCodeBusiness.Algos.easy
{
    //Number 7
    public class ReverseInteger
    {
        public int ReverseOneInteger(int integerValue)
        {
            bool valueType = false;

            if (integerValue < 0)
            {
                valueType = true;
            }

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