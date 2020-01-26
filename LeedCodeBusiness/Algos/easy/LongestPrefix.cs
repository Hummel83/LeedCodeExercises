using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeBusiness.Algos.easy
{
    //Nr.14 Longest Common Prefix
    public class LongestPrefix
    {
        public string LongestCommonPrefix(string[] values)
        {
            var liste = new List<char[]>();
            string counter ="";

            for (int i = 0; i < values.Length; i++)
            {               
                var currentstring = values[i].ToCharArray();
                liste.Add(currentstring);
                if (i== values.Length-1)
                {
                    if (liste[i][i] == liste[i + 1][i] && liste[i][i] == liste[i + 2][i])
                    {
                        counter += liste[i][i];
                    }
                }
              
            }
          

            return counter;
        }
    }
}
