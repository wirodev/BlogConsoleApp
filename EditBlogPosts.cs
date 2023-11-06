using System;

namespace BlogManagerSystem
{
    public class EditBlogPosts
    {
        public void EditPost(BlogPostList blogPostList)
        {
            if (blogPostList.blogPosts.Count == 0)
            {
                Console.WriteLine("You have no published blog posts.");
                return;
            }

            Console.WriteLine("Select the blog post you want to edit:");
            for (int i = 0; i < blogPostList.blogPosts.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {blogPostList.blogPosts[i].BlogTitle}");
            }

            // ask the user to select a blog post
            Console.Write("Enter the number of the post you want to edit: ");
            if (!int.TryParse(Console.ReadLine(), out int postNumber) || postNumber < 1 || postNumber > blogPostList.blogPosts.Count)
            {
                Console.WriteLine("Invalid choice. Please try again.");
                return;
            }

            // get the selected blog post
            BlogPost selectedPost = blogPostList.blogPosts[postNumber - 1];

            // ask the user  what they want to change
            Console.WriteLine("What would you like to edit?");
            Console.WriteLine("[1] Title");
            Console.WriteLine("[2] Date");
            Console.WriteLine("[3] Content");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            // get  user choice and update the blog post
            switch (choice)
            {
                case "1":
                    Console.Write("Enter the new title: ");
                    selectedPost.BlogTitle = Console.ReadLine();
                    break;
                case "2":
                    Console.Write("Enter the new date ( yyyy-mm-dd ): ");
                    if (DateTime.TryParse(Console.ReadLine(), out DateTime newDate))
                    {
                        selectedPost.BlogDate = newDate;
                    }
                    else
                    {
                        Console.WriteLine("Invalid date format.");
                        return;
                    }
                    break;
                case "3":
                    Console.Write("Enter the new content: ");
                    selectedPost.BlogContent = Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Invalid option selected.");
                    break;
            }

            Console.WriteLine("Blog post updated successfully!");
        }
    }
}
