using System;
using System.Globalization;

namespace Datas
{
    class Program
    {
        static void Main (String[] args)
        {
            Console.Clear();

            var pt = new CultureInfo("pt-PT");
            var br = new CultureInfo("pt-BR");
            var en = new CultureInfo("en-US");
            var de = new CultureInfo("de-DE");

            Console.WriteLine(DateTime.Now.ToString("D", en));

        }
    }
}