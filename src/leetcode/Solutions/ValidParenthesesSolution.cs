public class ValidParenthesesSolution
{
    public bool IsValid(string s)
    {
        var stack = new Stack<char>();

        foreach (char c in s)
        {
            if (IsOpening(c))
            {
                stack.Push(c);
            }
            else
            {
                //if it's the first char, then false
                if (stack.Count == 0)
                    return false;

                if (CanClose(stack.Peek(), c))
                    stack.Pop();
                else
                    return false;

            }
        }

        return stack.Count == 0;
    }

    private bool CanClose(char s, char c)
    {
        if (s == '{')
            return c == '}';

        if (s == '[')
            return c == ']';

        if (s == '(')
            return c == ')';

        return false;
    }

    private bool IsOpening(char c)
    {
        return c == '(' || c == '[' || c == '{';
    }
}