using System;

namespace Structs 
{
    class Program
    {
        static void Main(string[] args)
        {
            // instanciando uma estrutura
            Product mouse = new Product(1, "Mouse Razer", 229.90, EProductType.Product);
            var manutencaoEletrica = new Product(2, "Manutenção elétrica residencial", 500, EProductType.Service);
            mouse.Id = 10;
            
            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
            Console.WriteLine(mouse.Type);
            Console.WriteLine((int)mouse.Type);
        }


    }

    struct Product
    {
        public Product(int id, string name, double price, EProductType type)  // método construtor
        {
            Id =id;
            Name = name;
            Price = price;
            Type = type;
        }
        public int Id;
        public string Name;
        public double Price;
        public EProductType Type;

        public double PriceIndolar(double dolar)
        {
            return Price * dolar;
        }
    }

    enum EProductType
    {
        Product = 1,
        Service = 2

    }
}