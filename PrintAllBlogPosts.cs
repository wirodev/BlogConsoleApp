using System;

namespace BlogManagerSystem
{
    public class PrintAllBlogPosts
    {
        public void PrintBlogPosts(BlogPostList blogPostList)
        {
            if (blogPostList.blogPosts.Count == 0) // check for empty list
            {
                Console.WriteLine("You have no published blog posts.");
                return;
            }
            
            Console.WriteLine("\nList of published blog posts: ");

            // iterate through the list of BlogPost objects
            foreach (BlogPost post in blogPostList.blogPosts)
            {
                Console.WriteLine($"Title: {post.BlogTitle}");
                Console.WriteLine($"Date: {post.BlogDate.ToShortDateString()}");
                Console.WriteLine($"Content: {post.BlogContent}");
                Console.WriteLine("-------------");
            }

        }
    }
}
