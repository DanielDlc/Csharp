using System;

namespace Switch 
{
    class Program
    {
        static void Main(String[] args)
        {
            
            string nome = "Paulo";
            switch (nome)
            {
                case "Diego": Console.WriteLine("Diego é o player"); break;
                case "Jean": Console.WriteLine("Jean é o player"); break;
                case "Paulo": Console.WriteLine("Paulo é o player"); break;
                case "Rogerio": Console.WriteLine("Rogerio é o player"); break;
                case "Daniel": Console.WriteLine("Daniel é o player"); break;
                default: Console.WriteLine("Não encontrei o player"); break;
            }
        }
    }
}