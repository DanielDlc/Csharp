namespace Poo
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.Clear();
            // um objeto sempre é um tipo de referência
            // -> armazena apeas o endereço dos dados.
            Console.WriteLine("Classe de Pagamento");
        }
    }

    class Pagamento
    {
        // Propriedades
        DateTime Vencimento;

        // Métodos
        void Pagar()
        {
            ConsultarSaldoDoCartao();

        }

        // Abstração: esconder detalhes do cartão 
        private void ConsultarSaldoDoCartao()
        {

        }

    }
}