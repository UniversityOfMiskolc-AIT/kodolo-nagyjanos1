using System.Collections.Generic;
using System.Text;

namespace Encoder
{
    public class Encoder
    {
        public int[] Encode(string input)
        {
            var chArr = input.ToCharArray();
            var chNum = input[0];

            var result = new List<int>() { chNum };
            for (var i = 1; i < chArr.Length; i++)
            {
                var distance = (chNum - chArr[i]) * -1;
                result.Add(distance);
                chNum = chArr[i];
            }
            return result.ToArray();
        }

        public string Decode(int[] input)
        {            
            var detCh = input[0];
            var stringBuilder = new StringBuilder();
            stringBuilder.Append((char)input[0]);
            for (var i = 1; i < input.Length; i++)
            {
                detCh += input[i];
                stringBuilder.Append((char)detCh);
            }
            return stringBuilder.ToString();
        }
    }
}
