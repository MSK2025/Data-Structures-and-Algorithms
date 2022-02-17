namespace DSA.Leetcode.Algorithm_I.Day1
{
    /*
       Problem Statement:
            You are a product manager and currently leading a team to develop a new product. Unfortunately, the latest version of your product fails the 
            quality check. Since each version is developed based on the previous version, all the versions after a bad version are also bad.
            Suppose you have n versions [1, 2, ..., n] and you want to find out the first bad one, which causes all the following ones to be bad.
            You are given an API bool isBadVersion(version) which returns whether version is bad. Implement a function to find the first bad version. 
            You should minimize the number of calls to the API.
       Example 1:
            Input: n = 5, bad = 4
            Output: 4
            Explanation:
                call isBadVersion(3) -> false
                call isBadVersion(5) -> true
                call isBadVersion(4) -> true
                Then 4 is the first bad version.
       Example 2:
            Input: n = 1, bad = 1
            Output: 1
   */
    public class FirstBadVersion278
    {
        // C# code is not working, is not recognizing framework method. 
        public int FirstBadVersion(int n)
        {
            if (n == 1 && isBadVersion(n))
                return n;
            else return BinaryBadVersion(n, 1, n);

        }
        int BinaryBadVersion(int n, int min, int max)
        {
            while (min < max)
            {
                // Min + Max will give stack overflow as it may exceed integer limit, would work in python as we don't have any limitation
                int mid = min + (max - min) / 2;
                if (isBadVersion(mid))
                {
                    max = mid;
                }
                else
                {
                    min = mid + 1;
                }
            }

            return min;
        }

        // not required in leetcode as it is given by the framework.
        bool isBadVersion(int n)
        {
            return n >= 4;

        }
    }
}
