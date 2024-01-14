namespace BlazorBlog.Site.Domain
{
    public class ImageBlock : IContentBlock
    {
        public Uri Location { get; set; }

        public int Position { get; set; }

        public ImageBlock(Uri location)
        {
            Location = location;
        }
    }
}
