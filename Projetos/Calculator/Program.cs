namespace Calculator
{
    class Porgram
    {
        static void Main(string[] args)
        {
            Menu();
        }  

        static void Menu()
        {
            Console.Clear();
            
            Console.WriteLine("Qual operador deseja utilizar para calcular?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");

            Console.WriteLine("-------------------");
            Console.WriteLine("Selecione uma opção:");
            short operador = short.Parse(Console.ReadLine());

            switch (operador)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                default: Menu(); break;

            }   
            
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

            // chamar o menu novamente para não sair do menu("função dentro de função")
            Menu();
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
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();
            
            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 / v2;

            Console.WriteLine($"O resultado da divisão é: {resultado}");

            Console.ReadKey();
            Menu();

        }
    
        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 * v2;

            Console.WriteLine($"O resultado da multiplicação é: {resultado}");

            Console.ReadKey();
            Menu();
        }
    }  
}