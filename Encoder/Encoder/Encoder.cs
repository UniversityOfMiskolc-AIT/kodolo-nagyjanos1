using System.Collections.Generic;
using System.Text;

namespace Encoder
{
    /// <summary>
    /// Encoder -decoder osztály.
    /// Az alábbiak szerint működik:
    ///     - Az első karakternek a kódja a karakter ASCII értéke. 
    ///     - A következő számok kódja az előző karakter ASCII kódjától való eltérés, 
    ///         pl.: A + 2 → C, vagy z - 1 → y 
    /// </summary>
    public class Encoder
    {
        /// <summary>
        /// A paraméterben megkapott string-et kódolja a fenti algoritmus szerint.
        /// </summary>
        /// <param name="input">A kódolni kívánt string</param>
        /// <returns>int típusú tömb, amelyben a kódok szerepelnek.</returns>
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

        /// <summary>
        /// A paraméterben megkapott kód tömböt visszaalakítja stringé
        /// </summary>
        /// <param name="input">int típusú tömb, amelyben a kódolt string található.</param>
        /// <returns>A dekódolt string.</returns>
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
