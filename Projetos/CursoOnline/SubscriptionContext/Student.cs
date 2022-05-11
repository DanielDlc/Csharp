using CursoOnline.SharedContext;

namespace CursoOnline.SubscriptionContext
{
    public class Student : Base
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public User? User { get; set; }
    }
}