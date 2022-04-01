using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)        
        {
            // contador de 1 até 10
            int valor = 1;
            while(valor <= 10)  // while, analisa a condição antes de executar.
            {
                Console.WriteLine(valor);
                valor ++;
            }
        }
    }
}