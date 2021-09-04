using System;

namespace LeedCodeBusiness.Algos.easy
{
    //Number 7
    public class ReverseInteger
    {
        public int ReverseOneInteger(int integerValue)
        {
            var valueType = false;

            if (integerValue < 0) valueType = true;

            var text = integerValue.ToString();

            var cArray = text.ToCharArray();
            var reverse = string.Empty;

            for (var i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
                if (valueType && i == 0)
                {
                    reverse = reverse.Remove(cArray.Length - 1);
                    reverse = reverse.Insert(0, "-");
                }
            }

            var rev = 0;
            try
            {
                if (reverse != null) rev = int.Parse(reverse);
            }
            catch (Exception)
            {
                return 0;
            }

            return rev;
        }
    }
}