using System;

namespace Structs 
{
    class Program
    {
        static void Main(string[] args)
        {
            // instanciando uma estrutura
            Product mouse = new Product(1, "Mouse Razer", 229.90);
            mouse.Id = 10;
            
            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
        }


    }

    struct Product
    {
        public Product(int id, string name, double price)  // método construtor
        {
            Id =id;
            Name = name;
            Price = price;
        }
        public int Id;
        public string Name;
        public double Price;
        public double PriceIndolar(double dolar)
        {
            return Price * dolar;
        }
    }
}