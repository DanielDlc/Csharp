namespace String
{
    static class Program
    {
        static void Main()
        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.StartsWith("Este"));  // comparar string no início
            Console.WriteLine(texto.StartsWith("este"));
            Console.WriteLine(texto.StartsWith("texte"));        

            Console.WriteLine("------------------");

            Console.WriteLine(texto.EndsWith("teste"));  // comparar string no final 
            Console.WriteLine(texto.EndsWith("Teste"));
            Console.WriteLine(texto.EndsWith("xpto"));
        }
    }
}