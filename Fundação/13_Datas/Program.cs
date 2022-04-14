using System;

namespace Datas
{
    class Program
    {
        static void Main (String[] args)
        {
            Console.Clear();
            var data = DateTime.Now;
            var formatada = String.Format("{0:dd,MM,yyyy hh:mm:ss}", data);
            Console.WriteLine(formatada);
        }
    }
}