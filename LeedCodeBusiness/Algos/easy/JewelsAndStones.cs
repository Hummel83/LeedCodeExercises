using System;

namespace LeedCodeBusiness.Algos.easy
{
    //Number 771
    public class JewelsAndStones
    {
        public int NumJewelsInStones(string J, string S)
        {
            if (string.IsNullOrEmpty(J)) throw new ArgumentException("message", nameof(J));
            if (string.IsNullOrEmpty(S)) throw new ArgumentException("message", nameof(S));

            var Output = 0;

            var inputchars1 = J.ToCharArray();
            var JCount = inputchars1.Length;

            var inputchars2 = S.ToCharArray();
            var SCount = inputchars2.Length;

            for (var SCountIndex = 0; SCountIndex < SCount; SCountIndex++)
            for (var JCountIndex = 0; JCountIndex < JCount; JCountIndex++)
                if (inputchars1[JCountIndex] == inputchars2[SCountIndex])
                    Output++;
            return Output;
        }
    }
}