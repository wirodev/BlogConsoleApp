using System;

namespace BlogManagerSystem
{
    public class AddBlogPost
    {
        public void AddPost(BlogPostList blogPostList)
        {
            while (true)
            {
                Console.WriteLine("\nLet's add your Blog Post!");

                Console.Write("Give your post a title: ");
                string blogTitle = Console.ReadLine();

                Console.Write("Give your post a date (yyyy-MM-dd): ");
                DateTime blogDate;
                while (!DateTime.TryParse(Console.ReadLine(), out blogDate))
                {
                    Console.Write("Invalid date, please enter a valid date (yyyy-MM-dd): ");
                }

                Console.Write("Add content: ");
                string blogContent = Console.ReadLine();

                // Create a new BlogPost object with the collected information
                BlogPost newPost = new BlogPost(blogTitle, blogDate, blogContent);
                blogPostList.AddBlogPost(newPost);

                Console.WriteLine($"You have added a new blog post: \nBlog Title: {blogTitle} \nDate: {blogDate.ToShortDateString()} \nContent:\n{blogContent}");

                Console.Write("Do you want to add another blog post? (y / n): ");
                string choice = Console.ReadLine().ToLower();
                if (choice != "y")
                {
                    break; // Exit the loop
                }
            }
        }
    }
}
