using Algorithms;

namespace Tests
{
    public class MakeNumbersEqualTests
    {
        private readonly MakeNumbersEqual _algorithm = new MakeNumbersEqual();

        [Test]
        [TestCase(5, new int[] { 3, 2, 1, 1, 2, 3, 1 })]
        [TestCase(6, new int[] { 4, 1, 4, 1 })]
        [TestCase(0, new int[] { 3, 3, 3 })]
        public void TestExample(int solution, int[] inputs)
        {
            var result = _algorithm.Solution(inputs);

            Assert.That(result, Is.EqualTo(solution));
        }

        [Test]
        public void TestOneElement()
        {
            var result = _algorithm.Solution([1]);

            Assert.That(result, Is.EqualTo(0));
        }
    }
}
