using NUnit.Framework;

namespace Encoder.Test
{
    public class EncoderTests
    {
        [TestCase(new int[] { 65, 1, 1 }, "ABC")]
        [TestCase(new int[] { 97, 1, 1 }, "abc")]
        [TestCase(new int[] { 77, 45, -75, 41 }, "Mz/X")]
        public void Test_Encoding(int[] input, string result)
        {
            var encoder = new Encoder();

            Assert.AreEqual(result, encoder.Decode(input));
        }

        [TestCase("ABC", new int[] { 65, 1, 1 })]
        [TestCase("Mz/X", new int[] { 77, 45, -75, 41 })]
        [TestCase("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", new int[] { 76, 35, 3, -13, 8, -77, 73, 7, 3, 2, -8, -77, 68, 11, -3, 3, 3, -82, 83, -10, 11, -84, 65, 12, -8, 15, -72, -12, 67, 12, -1, 5, -14, -2, 17, -15, 15, 1, -3, -82, 65, 3, 5, 7, -7, 10, -16, 6, 5, -7, -71, 69, 7, -3, 11, -72, -12, 83, -14, -1, -68, 68, 11, -79, 69, 4, 12, -2, -6, 2, -11, -68, 84, -15, 8, 3, -1, 3, -82, 73, 5, -11, 6, -5, 5, -5, 17, -7, 6, -84, 85, -1, -84, 76, -11, 1, 13, 3, -13, -69, 69, 15, -84, 68, 11, -3, 3, 3, -13, -69, 77, -12, 6, 7, -13, -65, 65, 11, -3, 8, 4, -20 })]
        public void Test2(string input, int[] result)
        {
            var encoder = new Encoder();

            Assert.AreEqual(result, encoder.Encode(input));
        }
    }
}