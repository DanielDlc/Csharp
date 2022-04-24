namespace Poo
{
    class Program
    {
        static void RealizarPagamento(double valor)
        {
            Console.Clear();
            Console.WriteLine($"Pago o valor de {valor}");
        }
        static void Main(String[] args)
        {
            var pagar = new Pagamento.Pagar(RealizarPagamento);
            pagar(400);
        }    
    }


    public class Pagamento
    {
        public delegate void Pagar(double valor);
    }
}