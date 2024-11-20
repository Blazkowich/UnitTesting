namespace BinaryGap
{
    public class BinaryGapClass
    {
        public int Solution(int n)
        {
            string binary = Convert.ToString(n, 2);
            int maxGap = 0;
            int currentGap = 0;
            bool counting = false;

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
