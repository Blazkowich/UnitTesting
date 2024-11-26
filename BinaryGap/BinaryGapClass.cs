namespace BinaryGap
{
    public class BinaryGapClass
    {
        public static int Solution(int n)
        {
            var binary = Convert.ToString(n, 2);
            var maxGap = 0;
            var currentGap = 0;
            var counting = false;

            foreach (char bit in binary)
            {
                if (bit == '1')
                {
                    if (counting)
                    {
                        maxGap = Math.Max(maxGap, currentGap);
                        currentGap = 0;
                    }
                    counting = true;
                }
                else if (counting && bit == '0')
                {
                    currentGap++;
                }
            }

            return maxGap;
        }
    }
}
