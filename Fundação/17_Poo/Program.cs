namespace Poo
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.Clear();
            Console.WriteLine("Classe de Pagamento");
            Console.WriteLine("-------------------");

            using(var pagamento = new Pagamento())
            {
                Console.WriteLine("Processando o PAgamento");
            }
        }
    }
    // private, protected, internal e public
    public class Pagamento : IDisposable
    {   
        // Garbage
        public Pagamento()
        {
            Console.WriteLine("Iniciando o pagamento");
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Finalizando pagamento");
        }
    }

}