namespace DSA.GeeksforGeeks.Amazon.Arrays
{
    /*
      Problem Statement:
      You are given an integer N. You need to convert all zeroes of N to 5.Given an array arr[] of size N of
        positive integers which may have duplicates. The task is to find the maximum and second maximum from the 
        array, and both of them should be distinct, so If no second max exists, then the second max will be -1.
      Example 1:
          Input:
            N = 3
            arr[] = {2,1,2}
            Output: 2 1
            Explanation: From the given array 
            elements, 2 is the largest and 1 
            is the second largest.
      Example 2:
          Input:
            N = 5
            arr[] = {1,2,3,4,5}
            Output: 5 4
            Explanation: From the given array 
            elements, 5 is the largest and 4 
            is the second largest.
   */
    public class MaxandSecondMax
    {
        public int[] largestAndSecondLargest(int[] A, int N)
        {
            int max = int.MinValue;
            int secondMax = int.MinValue;
            //Your code here

            foreach (var item in A)
            {
                if (max < item)
                {
                    max = item;
                }
            }
            foreach (var item in A)
            {
                if (secondMax < item && item != max)
                {
                    secondMax = item;
                }
            }

            if (secondMax == max || secondMax == 0)
            {
                secondMax = -1;
            }

            return new int[] { max, secondMax };
        }
    }
}
