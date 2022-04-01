using System;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            // do (faça), executa primeiro e depois analisa a condição.
            int valor = 0;
            do  
            {
                Console.WriteLine(valor);
                valor ++;
            } while (valor <= 5);
        }
    }
}