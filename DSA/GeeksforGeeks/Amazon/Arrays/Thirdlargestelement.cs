namespace DSA.GeeksforGeeks.Amazon.Arrays
{
    /*
        Problem Statement:
            Given an array of distinct elements. Find the third largest element in it.
            Suppose you have A[] = {1, 2, 3, 4, 5, 6, 7}, its output will be 5 because 
            it is the 3 largest element in the array A.
        Example 1:
            Input:
                N = 5
                A[] = {2,4,1,3,5}
            Output: 3          
        Example 2:
            Input:
                N = 2
                A[] = {10,2}
            Output: -1
    */
    public class Thirdlargestelement
    {
        public int ThirdLargest(int[] a, int n)
        {
            if (n < 3)
            {
                return -1;
            }
            // Sorted first 3 elements of the array in descending order. Complexity is O(n2)
            for (int i = 0; i < 3; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] < a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }

            return a[2];
        }
    }
}
