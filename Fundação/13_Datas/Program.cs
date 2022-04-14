using System;

namespace Datas
{
    class Program
    {
        static void Main (String[] args)
        {
            Console.Clear();
            var data = DateTime.Now;
            var formatada = String.Format("{0:r}", data);
            // var formatada = String.Format("{0:s}", data);
            // var formatada = String.Format("{0:u}", data);
            Console.WriteLine(formatada);
        }
    }
}