namespace Exceptions;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        var arr = new int[3];

        try
        {
            // for (var index =0; index < 10; index++)
            // {
            // // System.IndexOutOfRangeException
            // Console.WriteLine(arr[index]);
            // }

            Cadastrar("");
        }

        // tratar o erro específico 
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.InnerException);
            Console.WriteLine(ex.Message);
            Console.WriteLine("Não encontrei o índice na lista");
        }

        // tratar null
        catch (ArgumentNullException ex)
        {
            Console.WriteLine(ex.InnerException);
            Console.WriteLine(ex.Message);
            Console.WriteLine("Falha ao cadastrar o texto");
        }

        // tratar null
        catch (MinhaException ex)
        {
            Console.WriteLine(ex.InnerException);
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.QuandoAconteceu);
            Console.WriteLine("Excecão customizada");
        }

        // tratar outros tipos de erros
        catch (Exception ex)
        {   
            Console.WriteLine(ex.InnerException);
            Console.WriteLine(ex.Message);
            Console.WriteLine("Ops, algo deu errado!");
        }

        // verificar se um arquivo esta aberto.
        finally
        {
            Console.WriteLine("Chegou ao fim!");
        }
    }

    static void Cadastrar(string texto)
    {
        if (string.IsNullOrEmpty(texto))
        {
            throw new MinhaException(DateTime.Now);
        }
    }

    public class MinhaException : Exception
    {
        public MinhaException(DateTime date)
        {
            QuandoAconteceu = date;
        }
        public DateTime QuandoAconteceu { get; set; }

    }
}