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

            var pagamento = new Pagamento();
            pagamento.ToString();
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
        public virtual void Pagar() { }

        public override string ToString()
        {
            return Vencimento.ToString("yy");
        }
    }

    // classe filho 1
    class PagamentoBoleto : Pagamento  // herança utilizando dois pontos ( pagamento boleto herdando de pagamento)
    {
        public string NumeroBoleto;

        public override void Pagar()
        {
            // regra do boleto
        }
    }

    // classe filho 2
    class PagamentoCartaoCredito : Pagamento
    {
        public string Numero;

            public override void Pagar()
        {
            // regra do cartão de crédito
        }
    }
}