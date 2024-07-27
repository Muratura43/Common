namespace Algorithms
{
    public class LargestSumOfWeights
    {
        public int Solution(int N, int[] A, int[] B)
        {
            int result = 0;

            var apparitions = new Dictionary<int, int>();
            var values = new Dictionary<int, int>();

            for (int i = 1; i <= N; i++)
            {
                apparitions.Add(i, 0);
            }

            foreach (int i in A)
            {
                if (apparitions.ContainsKey(i))
                {
                    apparitions[i]++;
                }
            }

            foreach (int i in B)
            {
                if (apparitions.ContainsKey(i))
                {
                    apparitions[i]++;
                }
            }

            int val = 1;
            foreach (var n in apparitions.OrderBy(x => x.Value))
            {
                values.Add(n.Key, val);
                val++;
            }

            for (int i = 0; i < A.Length; i++)
            {
                result += values[A[i]] + values[B[i]];
            }

            return result;
        }
    }
}
