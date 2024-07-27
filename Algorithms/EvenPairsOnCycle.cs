namespace Algorithms
{
    public class EvenPairsOnCycle
    {
        public int Solution(int[] A)
        {
            if (A.Length <= 1)
            {
                return 0;
            }

            int result = 0;

            if (IsPair(A[0] + A[A.Length - 1]))
            {
                result = 1;
            }

            int i = result;
            while (i < A.Length - 1)
            {
                if (IsPair(A[i] + A[i + 1]))
                {
                    result++;
                    i += 2;
                }
                else
                {
                    i += 1;
                }
            }

            return result;
        }

        private bool IsPair(int n)
        {
            return n % 2 == 0;
        }
    }
}
