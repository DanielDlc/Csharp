namespace Calculator
{
    class Porgram
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());  // convertendo string para o tipo float

            Console.WriteLine(v1);
        }
    }    
}