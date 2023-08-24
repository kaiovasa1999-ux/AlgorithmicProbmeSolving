namespace LeetCodeAlgorithms
{
    internal class SubStringWtihoutRepetition
    {
        public static int LengthOfLongestSubstringSolution(string input)
        {
            int n = input.Length;
            int maxLength = 0;
            int left = 0, right = 0;
            HashSet<char> uniqueChars = new HashSet<char>();

            while (right < n)
            {
                if (!uniqueChars.Contains(input[right]))
                {
                    uniqueChars.Add(input[right]);
                    maxLength = Math.Max(maxLength, right - left + 1);
                    right++;
                }
                else
                {
                    uniqueChars.Remove(input[left]);
                    left++;
                }
            }

            return maxLength;
        }
    }
}
