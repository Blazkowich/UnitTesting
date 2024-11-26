namespace BearAndSteadyGene
{
    public class BearAndSteadyGeneClass
    {
        public int MinimumReplacementLength(int n, string s)
        {
            var targetCount = n / 4;
            var freq = new Dictionary<char, int> { { 'A', 0 }, { 'C', 0 }, { 'T', 0 }, { 'G', 0 } };

            foreach (char c in s)
            {
                freq[c]++;
            }

            if (freq['A'] == targetCount && freq['C'] == targetCount && freq['T'] == targetCount && freq['G'] == targetCount)
            {
                return 0;
            }

            var minLength = n;
            var left = 0;

            for (var right = 0; right < n; right++)
            {
                freq[s[right]]++;

                while (IsValid(freq, targetCount))
                {
                    minLength = Math.Min(minLength, right - left + 1);
                    freq[s[left]]--;
                    left++;
                }
            }

            return minLength;
        }

        private static bool IsValid(Dictionary<char, int> freq, int targetCount)
        {
            return freq['A'] <= targetCount && freq['C'] <= targetCount && freq['T'] <= targetCount && freq['G'] <= targetCount;
        }
    }
}
