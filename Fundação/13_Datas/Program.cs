using System;

namespace Datas
{
    class Program
    {
        static void Main (String[] args)
        {
            Console.Clear();
            var data = DateTime.Now;

            // comparar as datas
            if (data.Date == DateTime.Now.Date);
                Console.WriteLine(" é igual");

            Console.WriteLine(data);

        }
    }
}