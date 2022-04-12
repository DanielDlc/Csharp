namespace String
{
    static class Program
    {
        static void Main()
        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.Equals("Este texto é um teste"));
            Console.WriteLine(texto.Equals("este texto é um teste"));
            Console.WriteLine(texto.Equals("este texto é um teste", StringComparison.OrdinalIgnoreCase));
        }
    }
}