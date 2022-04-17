using System;

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

        // tratar outros tipos de erros
        catch (Exception ex)
        {   
            Console.WriteLine(ex.InnerException);
            Console.WriteLine(ex.Message);
            Console.WriteLine("Ops, algo deu errado!");
        }
    }

    static void Cadastrar(string texto)
    {
        if (string.IsNullOrEmpty(texto))
        {
            throw new ArgumentNullException("O texto não pode ser nulo ou vazio");
        }
    }
}