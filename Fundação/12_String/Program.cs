namespace String
{
    static class Program
    {
        static void Main()
        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.IndexOf("é"));  // irá pegar a posição 11 
            Console.WriteLine(texto.IndexOf("s"));
            Console.WriteLine(texto.LastIndexOf("s"));
        }
    }
}