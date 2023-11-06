using System;
using System.Collections.Generic;

namespace BlogManagerSystem
{
	public class BlogPostList
	{
		public List<BlogPost> blogPosts { get; set; }
		
		public BlogPostList()
		{
			blogPosts = new List<BlogPost>();
		}
		
		public void AddBlogPost(BlogPost blogPost)
        {
            blogPosts.Add(blogPost);
        }

        internal void AddBlogPost(string blogTitle)
        {
            throw new NotImplementedException();
        }
    }
}