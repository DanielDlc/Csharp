namespace String
{
    static class Program
    {
        static void Main()
        {
            var texto = "Testando a palavra teste";
            Console.WriteLine(texto.CompareTo("Testando a palavra teste"));  // retorna 0
            Console.WriteLine(texto.CompareTo("testando a palavra teste"));  // retorna 1
            Console.WriteLine(texto.Contains("teste"));  // verificar se existe essa palavra
            Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase));  // ignorar case sensitive
        }
    }
}