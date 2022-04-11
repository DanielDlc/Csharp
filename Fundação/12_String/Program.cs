namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            var price = 400.9;
            //var texto = "o preço do produto é " + price + " apenas na promoção";
            var texto = string.Format(  "O preço do porduto é {0} apenas na promoção {1}", price, true);
            Console.WriteLine(texto);
        }
    }
}