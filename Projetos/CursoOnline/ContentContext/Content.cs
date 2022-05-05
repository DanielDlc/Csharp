namespace CursoOnline.ContentContext
{
    public abstract class Content
    {
        public Content(string title, string url)
        {
            // criando Id no construtor da classe Pai. indicando um Spof
            Id = Guid.NewGuid();
            Title = title;
            Url = url;
        }

        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Url { get; set; }
    }
}