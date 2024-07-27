using Algorithms;

namespace Tests
{
    public class EvenPairsOnCycleTests
    {
        private readonly EvenPairsOnCycle _algorithm = new EvenPairsOnCycle();

        [Test]
        [TestCase(2, new int[] { 4, 2, 5, 8, 7, 3, 7 })]
        [TestCase(1, new int[] { 14, 21, 16, 35, 22 })]
        [TestCase(3, new int[] { 5, 5, 5, 5, 5, 5 })]
        public void TestExample(int solution, int[] inputs)
        {
            var result = _algorithm.Solution(inputs);

            Assert.That(result, Is.EqualTo(solution));
        }

        [Test]
        [TestCase(3, new int[] { 1, 1, 3, 9, 2, 4, 2 })]
        [TestCase(3, new int[] { 1, 3, 9, 2, 4, 2, 1 })]
        public void TestCustomExample(int solution, int[] inputs)
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

        [Test]
        public void TestTwoElement()
        {
            var result = _algorithm.Solution([2, 2]);

            Assert.That(result, Is.EqualTo(1));
        }
    }
}
