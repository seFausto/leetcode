public class ContainerWithMostWaterSolution
{
    public int MaxArea(int[] height)
    {
        var left = 0;
        var right = height.Length - 1;
        var result = 0;

        while (left < right)
        {
            var water = Math.Min(height[left], height[right]) * (right - left);

            if (water > result)
                result = water;

            if (height[left] > height[right])
                right--;
            else
                left++;

        }

        return result;
    }
}