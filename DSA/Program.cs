using DSA.GeeksforGeeks.Amazon.Arrays;
using DSA.Leetcode.Algorithm_I.Day1;
using System;

namespace DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 98, 78, 10, 12, 59, 37, 45, 18, 1, 56, 37, 14, 3, 32, 85, 10, 69, 89, 29, 93, 44, 16, 26, 13, 50, 75, 79, 21, 20, 33, 55, 17, 63, 64, 80, 21, 52, 24, 90, 52, 80, 26, 18, 34, 57, 2, 95, 25, 42, 23, 17, 85, 39, 94, 50, 40, 21, 28, 12, 40, 61, 67, 9, 23, 30, 88, 95, 34, 64, 85, 85, 95, 62, 54, 28, 19, 55, 22, 95, 49, 97, 64, 33 };
            Minimumdistancebetweentwonumbers minimumdistancebetweentwonumbers = new Minimumdistancebetweentwonumbers();
            var result = minimumdistancebetweentwonumbers.minDist(array, 83, 34, 56);

            Console.WriteLine(result);
            Console.WriteLine("Hello World!");
        }
    }
}
