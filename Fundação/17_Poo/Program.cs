namespace Poo
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.Clear();
            Console.WriteLine("Classe de Pagamento");
            Console.WriteLine("-------------------");

            
        }
    }
    public class PagamentoCartaoCredito : IPagamento
    {
        public DateTime Vencimento { get; set; }

        public void Pagar(double valor)
        {
            throw new NotImplementedException();
        }
    }

    public class Pagamento : IPagamento
    {
        public DateTime Vencimento { get; set; }

        public void Pagar(double valor)
        {
            throw new NotImplementedException();
        }
    }
    // interface é como um contrato
    public interface IPagamento
    {
        DateTime Vencimento { get; set; }

        void Pagar(double valor);
    }

}