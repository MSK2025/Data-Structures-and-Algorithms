using System;

namespace DSA.GeeksforGeeks.Amazon.Arrays
{
    /*
      Problem Statement:
     You are given an array A, of N elements. Find minimum index based distance between two elements of the array, x and y.
      Example 1:
          Input:
            N = 4
            A[] = {1,2,3,2}
            x = 1, y = 2
            Output: 1
            Explanation: x = 1 and y = 2. There are
            two distances between x and y, which are
            1 and 3 out of which the least is 1.
      Example 2:
          Input:
            N = 7
            A[] = {86,39,90,67,84,66,62}
            x = 42, y = 12
            Output: -1
            Explanation: x = 42 and y = 12. We return
            -1 as x and y don't exist in the array.
   */
    public class Minimumdistancebetweentwonumbers
    {
        public int minDist(int[] a, int n, int x, int y)
        {
            // code here

            int firstIndex = -1;
            int secondIndex = -1;
            int minLength = -1;

            for (int i=0; i<n; i++)
            {
                if(a[i] == x)
                {
                    firstIndex = i;
                    for (int j = 0; j < n; j++)
                    {
                        if (a[j] == y)
                        {
                            secondIndex = j;
                            var length = Math.Abs(j - i);
                            if(minLength > length || minLength == -1)
                                minLength = length;

                        }
                    }
                }                
            }

            return minLength;
        }
    }
}
