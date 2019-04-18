using System.Text.RegularExpressions;

namespace LeedCodeBusiness.Algos.easy
{
    //Number 13
    public class Roman
    {    

        public int RomanToInt(string romanNumber)
        {
            int output = 0;
            //string[] romNumbers = new string[] { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };
            //int[] arabNumbers = new int[] { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };

            char[] cArray = romanNumber.ToCharArray();
            int anzahlzeichen = cArray.Length;

            for (int i = 0; i < anzahlzeichen; i++)
            {
                string currentChar = cArray[i].ToString();
                switch (currentChar)
                {
                    case "I":
                        output += 1;
                        break;

                    case "V":
                   
                        output += 5;
                        break;

                    case "X":                    
                        output += 10;
                        break;

                    case "L":
                        output += 50;
                        break;

                    case "C":
                        output += 100;
                        break;

                    case "D":
                        output += 500;
                        break;

                    case "M":
                        output += 1000;
                        break;

                    default:
                        return output;
                }
                
            }
            return output;
        }
        
    }
}