namespace Poo
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.Clear();
            var pagamentoBoleto = new PagamentoBoleto();
            pagamentoBoleto.Pagar();
            pagamentoBoleto.Vencimento = DateTime.Now;
            pagamentoBoleto.NumeroBoleto = "123";

            // um objeto sempre é um tipo de referência
            // -> armazena apeas o endereço dos dados.
            Console.WriteLine("Classe de Pagamento");
        }
    }

    // classe pai
    class Pagamento
    {
        // Propriedades
        public DateTime Vencimento;

        // Métodos
        public void Pagar() { }
    }

    // classe filho 1
    class PagamentoBoleto : Pagamento  // herança utilizando dois pontos ( pagamento boleto herdando de pagamento)
    {
        public string NumeroBoleto;
    }

    // classe filho 2
    class PagamentoCartaoCredito : Pagamento
    {
        public string Numero;
    }
}