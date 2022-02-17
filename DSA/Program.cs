using DSA.Leetcode.Algorithm_I.Day1;
using System;

namespace DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3,5,6};
            SearchInsertPosition35 searchInsertPosition35 = new SearchInsertPosition35();
            int result = searchInsertPosition35.SearchInsert(array, 7);

            Console.WriteLine(result);
            Console.WriteLine("Hello World!");
        }
    }
}
