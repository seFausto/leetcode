// See https://aka.ms/new-console-template for more information
public class RegularExpressionMatching
{
    public bool IsMatch(string s, string p)
    {
        if (s == null || p == null)
            return false;

        return MatchHere(p, s);
    }

    private bool MatchHere(string pattern, string input)
    {
        if (pattern.Length == 0)
        {
            return string.IsNullOrEmpty(input);
        }

        if (pattern.Length > 1 && IsZeroOrMoreSymbol(pattern[1]))
        {
            for (int index = 0; index <= input.Length; index++)
            {
                if (MatchHere(pattern.Substring(2), input.Substring(index)))
                    return true;
                if (index >= input.Length)
                    break;
                if (!IsDot(pattern[0]) && IsCharMatch(pattern[0], input[index]))
                    break;
            }
        }
        else
        {
            if (input.Length > 0 && IsCharMatch(input[0], pattern[0]))
                return MatchHere(pattern.Substring(1), input.Substring(1));
        }

        return false;
    }


    private bool IsCharMatch(char wordChar, char patternChar)
    {
        if (patternChar == '.')
            return true;

        return wordChar == patternChar;
    }

    private bool IsZeroOrMoreSymbol(char c)
    {
        return c == '*';
    }

    private bool IsDot(char c)
    {
        return c == '.';
    }
}
