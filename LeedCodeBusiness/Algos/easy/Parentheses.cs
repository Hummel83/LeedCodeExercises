using System;
using System.Linq;
using System.Text;

namespace LeedCodeBusiness.Algos.easy
{
    //1021. Remove Outermost Parentheses
    public class Parentheses
    {
        public string RemoveOuterParentheses(string TestString)
        {
            var muh = TestString.ToCharArray().ToList();

            var output = "";
            var builder = new StringBuilder();

            try
            {
                for (var i = 0; i < muh.Count - 1; i++)
                    if (muh[i] == muh[i + 1])
                        muh.RemoveAt(i);

                foreach (var bla in muh) builder.Append(bla);

                if (builder.Length > 0) output = builder.ToString();
            }
            catch (Exception)
            {
                output = TestString;
            }

            return output;
        }
    }
}