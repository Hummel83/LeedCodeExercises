using System;
using System.Linq;
using System.Text;

namespace LeedCodeBusiness.Algos.easy
{
    //1021. Remove Outermost Parentheses
    public class Parentheses
    {
        public string RemoveOuterParentheses(string s)
        {
            int level = 0;
            var sb = new StringBuilder(s.Length);
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    if (level != 0)
                        sb.Append(s[i]);
                    level++;
                }
                else
                {
                    if (level != 1)
                        sb.Append(s[i]);
                    level--;
                }
            }
            return sb.ToString();
        }
    }
}