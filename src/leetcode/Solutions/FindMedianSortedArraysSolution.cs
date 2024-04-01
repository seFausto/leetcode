public class FindMedianSortedArraysSolution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {

        if (nums1 == null && nums2 == null)
            return -1;

        if (nums1 == null)
        {
            return GetMedian(nums2);
        }

        if (nums2 == null)
        {
            return GetMedian(nums1);
        }

        var resultingArrayLength = nums1.Length + nums2.Length;
        var arr = new int[resultingArrayLength];

        int leftIndex = 0;
        int rightIndex = 0;
        int resultIndex = 0;
        while (leftIndex < nums1.Length && rightIndex < nums2.Length)
        {
            if (nums1[leftIndex] < nums2[rightIndex])
            {
                arr[resultIndex] = nums1[leftIndex];
                leftIndex++;
            }
            else
            {
                arr[resultIndex] = nums2[rightIndex];
                rightIndex++;
            }

            resultIndex++;
        }

        while (leftIndex < nums1.Length)
        {
            arr[resultIndex] = nums1[leftIndex];
            leftIndex++;
            resultIndex++;
        }

        while (rightIndex < nums2.Length)
        {
            arr[resultIndex] = nums2[rightIndex];
            rightIndex++;
            resultIndex++;
        }


        return GetMedian(arr);

    }

    double GetMedian(int[] arr)
    {


        if (arr.Length % 2 == 0)
        {
            int midPoint = arr.Length / 2;
            //this index, plus the pervious, avg
            return ((double)arr[midPoint] + (double)arr[midPoint - 1]) / 2;
        }
        else
        {
            int midPoint = arr.Length / 2;
            return arr[midPoint];
        }
    }
}