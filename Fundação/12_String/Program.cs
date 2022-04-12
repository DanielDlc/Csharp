using System.Text;

namespace String
{
    static class Program
    {
        static void Main()
        {
            var texto = new StringBuilder();  // construtor
            texto.Append("Este texto é um teste ");
            texto.Append("e estamos testando ");
            texto.Append("esses caracteres ");
            texto.Append("para deixar na mesma linha.");

            Console.Clear();
            Console.WriteLine(texto);
        }
    }
}