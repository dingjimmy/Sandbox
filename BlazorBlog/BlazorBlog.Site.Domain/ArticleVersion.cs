namespace BlazorBlog.Site.Domain
{
    public class ArticleVersion
    {
        public int Number { get; private set; } = 1;

        public void Increment()
        {
            Number ++;
        }
    }
}