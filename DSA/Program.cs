using DSA.Leetcode.Algorithm_I.Day1;
using System;

namespace DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { -1, 0, 3, 5, 9, 12 };
            BinarySearch704 binarySearch704 = new BinarySearch704();
            int result = binarySearch704.Search(array, 2);
            Console.WriteLine(result);
            Console.WriteLine("Hello World!");
        }
    }
}
