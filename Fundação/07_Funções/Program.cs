namespace Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            {   
                // chamando meu método (1.1)
                MeuMetodo();

                // chamando nome, sobrenome e idade (2.3)
                string nome = RetornaNome("Daniel", "Louro Costa", 38);
                Console.WriteLine(nome);
            }
            
            // declarando o meu método (1.0)
            static void MeuMetodo()
            {
                Console.WriteLine("Testando Funções com meu método");
            }

            // declarando nome e idade (2.0)
            static string RetornaNome(
                string nome, 
                string sobrenome, 
                int idade
            )

            {
                // retornando nome, sobrenome e idade convertida (2.1)
                return nome + " " + sobrenome + " tem " + idade + " anos. ".ToString();
            }
            
        }
    }
}