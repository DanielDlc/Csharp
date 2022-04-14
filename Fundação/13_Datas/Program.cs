using System;

namespace Datas
{
    class Program
    {
        static void Main (String[] args)
        {
            Console.Clear();
            var data = new DateTime(2022, 04, 14, 7, 26, 11);
            //var data = DateTime.Now;
            Console.WriteLine(data);
            Console.WriteLine(data.Year);
            Console.WriteLine(data.Month);
            Console.WriteLine(data.Day);
            Console.WriteLine(data.Hour);
            Console.WriteLine(data.Minute);
            Console.WriteLine(data.Second);
            Console.WriteLine(data.DayOfYear);
        }
    }
}