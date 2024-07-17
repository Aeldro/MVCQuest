using MVCQuest.Models.Entities;

namespace MVCQuest.Repositories
{
    public static class ArticleRepository
    {
        public static List<Article> _articles = new List<Article>()
        {
            new Article(1, "Fromage", "C'est du fromage"),
            new Article(2, "Saucisse", "C'est une saucisse"),
            new Article(3, "Paté", "C'est du paté")
        };

        public static List<Article> GetArticles() => _articles;

        public static Article GetArticle(int id) => _articles.Find(x => x.Id == id);

        public static void EditArticle(Article article)
        {
            Article articleToEdit = GetArticle(article.Id);
            articleToEdit.Title = article.Title;
            articleToEdit.Text = article.Text;
        }

        public static void DeleteArticle(int id)
        {
            _articles.Remove(_articles.Find(x => x.Id == id));
        }

        public static void CreateArticle(string title, string text)
        {
            Article article = new Article(_articles.Max(x => x.Id)+1, title, text);
            _articles.Add(article);
        }
    }
}
