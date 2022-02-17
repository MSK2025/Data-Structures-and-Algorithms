namespace DSA.Leetcode.Algorithm_I.Day1
{
    public class BinarySearch704
    {
        /*
        Problem Statement:
            Given an array of integers nums which is sorted in ascending order, and an integer target, 
            write a function to search target in nums. If target exists, then return its index. Otherwise, return -1.
            You must write an algorithm with O(log n) runtime complexity.
        Example 1:
            Input: nums = [-1,0,3,5,9,12], target = 9
            Output: 4
            Explanation: 9 exists in nums and its index is 4
        Example 2:
            Input: nums = [-1,0,3,5,9,12], target = 2
            Output: -1
            Explanation: 2 does not exist in nums so return -1
    */
        public int Search(int[] nums, int target)
        {
            return BinarySearch(nums, target, 0, nums.Length - 1);
        }

        public int BinarySearch(int[] nums, int target, int minIndex, int maxIndex)
        {
            if (minIndex > maxIndex)
                return -1;

            int midIndex = (minIndex + maxIndex) / 2;
            if (target == nums[midIndex])
            {
                return midIndex;
            }
            else if (target < nums[midIndex])
            {
                return BinarySearch(nums, target, minIndex, midIndex-1);
            }
            else if (target > nums[midIndex])
            {
                return BinarySearch(nums, target, midIndex +1, maxIndex);
            }
            else
            {
                return -1;
            }
        }
    }
}
