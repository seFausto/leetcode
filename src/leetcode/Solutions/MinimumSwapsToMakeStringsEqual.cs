

public class MinimumSwapsToMakeStringsEqual
{
    public int MinimumSwap(string s1, string s2)
    {
        if (!HasSolution(s1, s2))
            return -1;


        while (s1 != s2)
        { 
            
        }

        return -1;
    }

    private bool HasSolution(string s1, string s2)
    {
        if (s1.Length != s2.Length)
            return false;

        var s1LetterCount = GetLetterCount(s1);
        var s2LetterCount = GetLetterCount(s2);

        return s1LetterCount.XCount == s2LetterCount.XCount
                && s1LetterCount.YCount == s2LetterCount.YCount;
    }

    private LetterCount GetLetterCount(string s1)
    {
        var result = new LetterCount();
        foreach (var c in s1)
        { 
            if (c == 'x')
                result.XCount++;

            if (c == 'y')
                result.YCount++;
        }

        return result;
    }

    private class LetterCount
    {
        public int YCount = 0;
        public int XCount = 0;
    }
}
