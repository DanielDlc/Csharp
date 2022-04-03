using System;

namespace Valor
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new string[2];
            arr[0] = "item1";
            var arr2 = arr;
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]);
            
            Console.WriteLine("-----");
            
            arr[0] = "item2";
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]);
        }
    }
}