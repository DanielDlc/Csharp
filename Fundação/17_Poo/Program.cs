namespace Poo
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.Clear();
             
            var pagamento = new Pagamento();
            pagamento.DataPagamento = DateTime.Now;

            Console.WriteLine("Classe de Pagamento");
        }
    }
    // private, protected, internal e public
    public class Pagamento
    {
        // Propriedades
        public DateTime Vencimento { get; set; }

        private DateTime _dataPagamento;
        public DateTime DataPagamento
        {
            get 
            { 
                Console.WriteLine("Lendo o valor"); 
                return _dataPagamento; 
            }
            
            set 
            { 
                Console.WriteLine("Atribuindo o valor");
                _dataPagamento = value; 
            }
        }
                
         
        void Pagar() { }
    }
}