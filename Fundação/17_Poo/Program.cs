namespace Poo
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.Clear();
            Console.WriteLine("Classe de Pagamento");
            var pagamento = new Pagamento();
        }
    }
    // private, protected, internal e public
    public class Pagamento
    {
        // Propriedades
        protected DateTime Vencimento;
        private void Pagar() { }
    }
        public class PagamentoBoleto : Pagamento
    {
        void Test() { }
    }
}