using System;

namespace Datas
{
    class Program
    {
        static void Main (String[] args)
        {
            Console.Clear();
            var data = DateTime.Now;
            Console.WriteLine(data);

            // verificar a data após 12 dias
            Console.WriteLine(data.AddDays(-12));

            // verificar a data após 1 mês
            Console.WriteLine(data.AddMonths(1));           

            // verificar a data após um ano
            Console.WriteLine(data.AddYears(1));
        }
    }
}