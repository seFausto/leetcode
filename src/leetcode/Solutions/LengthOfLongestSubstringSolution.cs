public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        if (string.IsNullOrEmpty(s))
            return 0;

        if (s.Length == 1)
            return 1;

        var list = new List<char>();
        var currentIndex = 0;
        var winningCount = -1;
        var winningIndex = 0;

        var currentCount = 0;
        for (int index = 0; index < s.Length; index++)
        {
            if (list.Contains(s[index]))
            {
                if (currentCount > winningCount)
                {
                    winningIndex = currentIndex;
                    winningCount = currentCount;
                }

                var indexToRemove = list.IndexOf(s[index]);

                for (int subIndex = 0; subIndex <= indexToRemove; subIndex++)
                {
                    list.RemoveAt(0);
                    currentCount--;
                    currentIndex++;
                }
            }

            list.Add(s[index]);
            currentCount++;
        }

        return Math.Max(winningCount, list.Count);
    }
}