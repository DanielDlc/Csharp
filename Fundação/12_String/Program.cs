namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            var price = 400.9;
            var texto = "o preço do produto é " + price + " apenas na promoção";
            //var texto = string.Format(  "O preço do porduto é {1} apenas na promoção {0}", price, true);
            //var texto = $"O preço do produto é {price}";

            Console.WriteLine(texto);
        }
    }
}