using System;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {

            string nome = "";
            Console.Clear();
            Console.Write("Insira seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine($"Olá, {nome}");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("");

            Console.Write($"{nome}, digite sua idade: ");
            int idade = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("--------------------------------------------------------------------");
 
            if (idade <= 17)
            {
                Console.WriteLine($"Olá, {nome}. \nVocê tem apenas {idade} anos e é menor de idade.");
            }

            else
            {
                Console.WriteLine($"Olá, {nome}. \nVocê ja tem {idade} anos, você é maior de idade.");
            }
            Console.WriteLine();

        }
    }
}