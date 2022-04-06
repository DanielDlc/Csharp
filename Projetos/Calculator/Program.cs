﻿namespace Calculator
{
    class Porgram
    {
        static void Main(string[] args)
        {
            //Soma();
            Subtracao();
        }  

        static void Soma()
        {
            Console.Clear();
             
            // criando o primeiro valor
            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());  // convertendo string para o tipo float

            // criando o segundo valor
            Console.WriteLine("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            // deixar uma linha em branco 
            Console.WriteLine("");

            // calcular o resultado do primeiro valor 
            float resultado = v1 + v2;

            // imprimir mostrando o resultado
            Console.WriteLine($"A soma do resultado é = {resultado}");

            // não deixar o console sair da tela
            Console.ReadKey();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 - v2;

            Console.WriteLine($"O resultado da subtração é: {resultado}");

            Console.ReadKey();
        }
   
    }  
}