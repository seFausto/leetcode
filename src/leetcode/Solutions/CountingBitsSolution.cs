using System.Text;

public class CoutingBitSolution
{
    int NumberBase = 2;
    public int[] CountBits(int n)
    {
        var ans = new int[n + 1];

        for (int i = 0; i <= n; i++)
        {
            var currentCount = 0;
            var bits = Convert.ToString(i, NumberBase);

            //count all the 1
            foreach (var bit in bits)
            {
                if (bit == '1')
                    currentCount++;
            }

            ans[i] = currentCount;
        }

        return ans;
    }
}