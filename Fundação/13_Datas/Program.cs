namespace Datas
{
    class Program
    {
        static void Main (String[] args)
        {
            Console.Clear();

            var timeSpan = new TimeSpan();
            Console.WriteLine(timeSpan);

            var timeSpanNanosegundos = new TimeSpan(1);
            Console.WriteLine(timeSpanNanosegundos);

            var timeSpanHoraMinutoSegundo = new TimeSpan(11, 37, 8);
            Console.WriteLine(timeSpanHoraMinutoSegundo);

            var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 10, 50, 10);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo);

            Console.WriteLine("----------------------");

            // subtrair horas, minutos e segundos por dia, hora, minutos e segundos.
            var subtrair = (timeSpanHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundo);
            Console.WriteLine(subtrair);

            // pegar os dias com .days
            var dias = timeSpanDiaHoraMinutoSegundo.Days;
            Console.WriteLine(dias);            
            
            // criando um novo TimeSpan
            var novo = timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(12, 0, 0));
            Console.WriteLine(novo);
        }
    }
}