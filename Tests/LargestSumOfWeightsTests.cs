using Algorithms;

namespace Tests
{
    public class LargestSumOfWeightsTests
    {
        private readonly LargestSumOfWeights _algorithm = new LargestSumOfWeights();

        [Test]
        [TestCase(31, 5, new int[] { 2, 2, 1, 2 }, new int[] { 1, 3, 4, 4 })]
        [TestCase(5, 3, new int[] { 1 }, new int[] { 3 })]
        [TestCase(10, 4, new int[] { 1, 3 }, new int[] { 2, 4 })]
        public void TestExample(int solution, int n, int[] a, int[] b)
        {
            var result = _algorithm.Solution(n, a, b);

            Assert.That(result, Is.EqualTo(solution));
        }

        [Test]
        [TestCase(23, 5, new int[] { 5, 2, 3 }, new int[] { 2, 3, 4 })]
        public void TestCustomExample(int solution, int n, int[] a, int[] b)
        {
            var result = _algorithm.Solution(n, a, b);

            Assert.That(result, Is.EqualTo(solution));
        }
    }
}
