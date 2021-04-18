using System;
using System.Linq;
using System.Text;

namespace Encoder
{


    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length <= 1)
            {
                WriteInformation();
            }

            var encoder = new Encoder();

            switch (args[0].ToLower())
            {
                case "-e":
                    var stringBuilder = new StringBuilder();
                    stringBuilder.AppendJoin(' ', args.Skip(1).ToArray());
                    var encodedChars = encoder.Encode(stringBuilder.ToString());
                    stringBuilder.Clear();
                    stringBuilder.AppendJoin(' ', encodedChars);
                    Console.WriteLine(stringBuilder);
                    break;

                case "-d":
                    var encodedText = args.Skip(1)
                                        .Select(x => int.TryParse(x, out int distance) ? distance : (int?)null)
                                        .Where(x => x.HasValue)
                                        .Select(x => x.Value)
                                        .ToArray();
                    var decodedText = encoder.Decode(encodedText);
                    Console.WriteLine(decodedText);
                    break;

                default:
                    WriteInformation();
                    break;
            }

            Console.ReadKey();
        }

        private static void WriteInformation()
        {
            Console.WriteLine("SYNOPSIS:");

            Console.WriteLine("DESCRIPTOM:");
            Console.WriteLine("\t -e,-E {text} Kódolja a paraméterben kapott szöveget a fehér karakterek mentén.");
            Console.WriteLine("\t -d,-D {array} Dekódolja a paraméterben kapott integer tömböt a fehér karakterek mentén.");
        }
    }
}
