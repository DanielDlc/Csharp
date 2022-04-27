namespace CursoOnline.ContentContext
{
    public class Content
    {
        public Content()
        {
            // criando Id no construtor da classe Pai. indicando um Spof
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Url { get; set; }
    }
}