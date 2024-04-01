public class PalindromeNumber
{
    public bool IsPalindrome(int x)
    {
        var s = Convert.ToString(x);
        var left = 0;
        var right = s.Length - 1;
        while (left < right)
        {
            if (s[left] != s[right])
                return false;

            left++;
            right--;
        }

        return true;


    }
}