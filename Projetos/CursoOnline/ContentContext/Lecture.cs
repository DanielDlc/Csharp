using CursoOnline.ContentContext.Enums;

namespace CursoOnline.ContentContext
{
    public class Lecture
    {
        public int Ordem { get; set; }
        public string? Title { get; set; }

        private int durationInMinutes;

        public int GetDurationInMinutes()
        {
            return durationInMinutes;
        }

        public void SetDurationInMinutes(int value)
        {
            durationInMinutes = value;
        }

        public int DurationInMinutes { get; set; }
        public EcontentLevel Level { get; set; }
    }
}