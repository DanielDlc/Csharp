using System.Collections.Generic;

namespace CursoOnline.ContentContext
{
    public class Course : Content
    {
        public Course()
        {
            Modules = new List<Module>();
        }
        public string Tag { get; set; }
        public IList<Module> Modules { get; set; }
        public int  DurationInMinutes { get; set; }
        public EContentLevel Level { get; internal set; }

    }
}