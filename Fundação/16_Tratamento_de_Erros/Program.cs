﻿using System;

namespace Exceptions;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        var arr = new int[3];
        for (var index =0; index < 10; index++)
        {
            // System.IndexOutOfRangeException
            Console.WriteLine(arr[index]);
        }
    }
}