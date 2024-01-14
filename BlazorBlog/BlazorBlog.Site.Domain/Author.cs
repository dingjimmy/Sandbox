using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBlog.Site.Domain
{
    public class Author
    {
        public string Name { get; }

        public Author(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException($"An authors {nameof(name)} cannot be null or whitespace.", nameof(name));
            }

            Name = name;
        }
    }
}
