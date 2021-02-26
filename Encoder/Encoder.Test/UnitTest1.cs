using NUnit.Framework;

namespace Encoder.Test
{
    public class Tests
    {
        [TestCase(new int[] { 65, 1, 1 }, "ABC")]
        [TestCase(new int[] { 97, 1, 1 }, "abc")]
        [TestCase(new int[] { 77, 45, -34 }, "MzX")]
        public void Test1(int[] input, string result)
        {
            var encoder = new Encoder();

            Assert.AreEqual(result, encoder.Decode(input));
        }

        [TestCase("ABC", new int[] { 65, 1, 1 })]
        [TestCase("MzX", new int[] { 77, 45, -34 })]
        public void Test2(string input, int[] result)
        {
            var encoder = new Encoder();

            Assert.AreEqual(result, encoder.Encode(input));
        }
    }
}