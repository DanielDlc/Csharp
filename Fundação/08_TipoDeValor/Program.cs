using System;

namespace Valor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 38;
            int numeroFixo = numero;  // criando uma cópia do número 38 na memória.
            Console.WriteLine(numero);
            Console.WriteLine(numeroFixo);

            Console.WriteLine("--------");

            numero = 40;  // mudando número 38 para o número 40
            Console.WriteLine($"O número modificado possui o valor {numero}");
            Console.WriteLine($"O número fixo continua no valor {numeroFixo}");

        }
    }
}