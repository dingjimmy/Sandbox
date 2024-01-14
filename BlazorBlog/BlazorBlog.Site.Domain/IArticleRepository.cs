namespace BlazorBlog.Site.Domain
{
    public interface IArticleRepository
    {
        Article GetArticle(string tenentKey, int articleId);

        void UpdateArticle(Article article);
    }
}
