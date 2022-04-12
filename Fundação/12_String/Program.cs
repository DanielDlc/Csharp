namespace String
{
    static class Program
    {
        static void Main()
        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.ToLower());  // letras em minúscula
            Console.WriteLine(texto.ToUpper());  // letras em maiúscula
            Console.WriteLine(texto.Insert(11, "aqui "));  // inserir na posição 11 a palavra aqui
            Console.WriteLine(texto.Remove(10, 11));  // remover os 11 caracteres após o 10°
            Console.WriteLine(texto.Length);  // contar os caracteres
        }
    }
}