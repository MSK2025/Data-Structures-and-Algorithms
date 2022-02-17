using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Leetcode.Algorithm_I.Day1
{
    /*
      Problem Statement:
           Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where 
            it would be if it were inserted in order. You must write an algorithm with O(log n) runtime complexity.
      Example 1:
            Input: nums = [1,3,5,6], target = 5
            Output: 2
      Example 2:
           Input: nums = [1,3,5,6], target = 2
            Output: 1
    Example 3:
         Input: nums = [1,3,5,6], target = 7
        Output: 4
  */
    public class SearchInsertPosition35
    {
        public int SearchInsert(int[] nums, int target)
        {

            int min = 0; 
            int max = nums.Length;
            while(min<nums.Length &&  min<= max)
            {

                int mid = (min + max) / 2;
                int value = nums[mid];
                if (value == target)
                {
                    return mid;
                }
                else if (value < target)
                {
                    min = mid + 1;
                }
                else 
                {
                  
                    max = mid - 1;
                }
            }

            return min;
        }
    }
}
