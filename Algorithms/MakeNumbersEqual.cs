namespace Algorithms
{
    public class MakeNumbersEqual
    {
        public int Solution(int[] A)
        {
            if (A.Length <= 1)
            {
                return 0;
            }

            Array.Sort(A);

            int mid1 = A[A.Length / 2];
            int mid2 = A[A.Length / 2 - 1];

            int result1 = 0;
            int result2 = 0;

            foreach (int a in A)
            {
                result1 += Math.Abs(a - mid1);
                result2 += Math.Abs(a - mid2);
            }

            return Math.Min(result1, result2);
        }
    }
}
