namespace MVCQuest.Models.Entities
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }

        public Article(int id, string title, string text)
        {
            Id = id;
            Title = title;
            Text = text;
        }
        public Article() { }
    }
}
