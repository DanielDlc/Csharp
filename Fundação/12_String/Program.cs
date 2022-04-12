namespace String
{
    static class Program
    {
        static void Main()
        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.Replace("Este", "Isto"));  // trocar Este por Isto

            Console.WriteLine("---------");

            var divisao = texto.Split(" ");
            Console.WriteLine(divisao[0]);
            Console.WriteLine(divisao[1]);
            Console.WriteLine(divisao[2]);
            Console.WriteLine(divisao[3]);
            Console.WriteLine(divisao[4]);

            Console.WriteLine("---------");

            var resultado = texto.Substring(13, 2);  // irá pegar o 13° índice e ira retornar 2 caracteres (um)
            Console.WriteLine(resultado);

            Console.WriteLine("---------");

            Console.WriteLine(texto.Trim());  // limpa os espaços no início e no final
        }
    }
}