namespace Datas
{
    class Program
    {
        static void Main (String[] args)
        {
            Console.Clear();

            // saber quantos dias tem no mês
            Console.WriteLine(DateTime.DaysInMonth(2022,4));
            Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));
            Console.WriteLine(DateTime.Now.IsDaylightSavingTime());  // horário de verão
        }

        // saber se é fim de semana ou não
        static bool IsWeekend(DayOfWeek today)
        {
            return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
        }
    }
}