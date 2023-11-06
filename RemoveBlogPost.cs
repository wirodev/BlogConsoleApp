using System;
using System.Collections.Generic;

namespace BlogManagerSystem
{
    public class RemoveBlogPost
    {
        public void RemoveSinglePost(BlogPostList blogPostList)
        {
            if (blogPostList.blogPosts.Count == 0) // check if list is empty
            {
                Console.WriteLine("You have no published blog posts.");
                return;
            }

            // iterate through the list of BlogPost objects
            Console.WriteLine("\nList of published blog posts: ");
            for (int i = 0; i < blogPostList.blogPosts.Count; i++) 
            {
                // access BlogPost object at index i and its BlogTitle property
                Console.WriteLine($"[{i + 1}] {blogPostList.blogPosts[i].BlogTitle}");
            }

            Console.Write("Type the number of the post you want to remove: ");
            if (int.TryParse(Console.ReadLine(), out int itemNumber) && itemNumber >= 1 && itemNumber <= blogPostList.blogPosts.Count)
            {
                string removedTitle = blogPostList.blogPosts[itemNumber - 1].BlogTitle;
                blogPostList.blogPosts.RemoveAt(itemNumber - 1);
                Console.WriteLine($"You have removed the following post: {removedTitle}");
            }
            else
            {
                Console.WriteLine("Not a valid option. Try again.");
            }
        }
    }
}
