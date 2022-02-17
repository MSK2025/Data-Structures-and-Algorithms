using DSA.Arrays;
using System;

namespace DSA
{
    class Program
    {
        static void Main(string[] args)
        {

            Replace0With5 replace = new Replace0With5();
            int data  =  replace.ConvertFive(1004);

            Console.WriteLine(data);
            Console.WriteLine("Hello World!");
        }
    }
}
