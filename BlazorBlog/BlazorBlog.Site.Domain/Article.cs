
namespace BlazorBlog.Site.Domain
{
    /// <summary>
    /// Represents a written work for the propagation of news, research, analysis or debate.
    /// </summary>
    public class Article
    {
        /// <summary>
        /// The key of the tenant this article belongs to.
        /// </summary>
        public string TenantKey { get; }

        /// <summary>
        /// A number that uniquley identifies this article from all others in a tenant.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// The version of the article.
        /// </summary>
        public ArticleVersion Version { get; }

        /// <summary>
        /// The name of the article. It identifies and summarise the work in a short sentence or phrase.
        /// </summary>
        public string Title { get; private set; }

        /// <summary>
        /// The people who created the work.
        /// </summary>
        public IReadOnlyList<Author> Authors { get; private set; }

        /// <summary>
        /// The primary content of the work.
        /// </summary>
        public IReadOnlyList<IContentBlock> Content { get; private set; }

        /// <summary>
        /// Creates a new instance of the <see cref="Article"/> class.
        /// </summary>
        public Article(string tenantKey, string title, IEnumerable<Author> authors, IEnumerable<IContentBlock> content)
        {
            CheckTitleIsValid(title);
            CheckAuthorsAreValid(authors);

            TenantKey = tenantKey;
            Id = -1;
            Version = new ArticleVersion();
            Title = title;
            Authors = authors.ToList();
            Content = content.ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Revise(string? title, IEnumerable<Author>? authors, IEnumerable<IContentBlock>? content)
        {
            var revised = false;

            if (title != null)
            {
                CheckTitleIsValid(title);
                Title = title;
                revised = true;
            }

            if (authors != null)
            { 
                CheckAuthorsAreValid(authors);
                Authors = authors.ToList();
                revised = true;
            }

            if (content != null)
            {
                Content = content.ToList();
                revised |= true;
            }

            if (revised)
            {
                Version.Increment();
            }
        }

        private static void CheckTitleIsValid(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException($"'An article cannot have an empty title.", nameof(title));
            }
        }

        private static void CheckAuthorsAreValid(IEnumerable<Author> authors)
        {
            if (!authors.Any())
            {
                throw new ArgumentException("An article must have at least one author.", nameof(authors));
            }
        }
    }
}
