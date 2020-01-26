using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeBusiness.Algos.easy
{
    public class RemoveParentheses
    {
        public string RemoveOuterParentheses(string S)
        {
            var output = "";
            var chars = S.ToCharArray().ToList(); 

            for (int i = 0; i < chars.Count; i++)
            {
                var char1 = output.Count();
                if (chars[i] != chars[chars.Count - 1])
                {
                    if (chars[i] == chars[i+1])
                    {
                        output = S.Remove(0, i);
                           
                    }

                }
            }


            return output;
        }
    }
}
