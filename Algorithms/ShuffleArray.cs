namespace Algorithms
{
    // Fisher-Yates Algorithm
    public class ShuffleArray
    {
        private int[] original;
        private int[] temp;

        private Random rand = new Random();

        public ShuffleArray(int[] nums)
        {
            temp = nums;
            original = (int[])nums.Clone();
        }

        public int[] Reset()
        {
            temp = original;
            original = (int[])original.Clone();

            return original;
        }

        public int[] Shuffle()
        {
            for (int i = 0; i < temp.Length; i++)
            {
                int swapIndex = rand.Next(temp.Length - i) + i;

                int aux = temp[i];
                temp[i] = temp[swapIndex];
                temp[swapIndex] = aux;
            }

            return temp;
        }
    }
}
