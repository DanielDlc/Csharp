using CursoOnline.ContentContext;

namespace CursoOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, Mundo Poo");
            var course = new Course();
            course.Level = ContentContext.Enums.EContentLevel.Beginner;
            foreach (var item in course.Modules)
            {

            }
        }

    }
}