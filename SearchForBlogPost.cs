using System;
using System.Collections.Generic;
using System.Globalization;

namespace BlogManagerSystem
{
    public class SearchForBlogPost
    {
        public void Search(BlogPostList blogPostList)
        {
            Console.WriteLine("How do you want to search:");
            Console.WriteLine("[1] Keyword in title/content");
            Console.WriteLine("[2] Date");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    SearchByKeyword(blogPostList);
                    break;
                case "2":
                    BubbleSortByDate(blogPostList);
                    SearchByDate(blogPostList);
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }

        private void SearchByKeyword(BlogPostList blogPostList)
        {
            Console.Write("Enter a keyword to search for: ");
            string keyword = Console.ReadLine().ToLower();

            bool found = false;
            foreach (var post in blogPostList.blogPosts)
            {
                if (post.BlogTitle.ToLower().Contains(keyword) || post.BlogContent.ToLower().Contains(keyword))
                {
                    found = true;
                    PrintBlogPost(post);
                }
            }

            if (!found)
            {
                Console.WriteLine("No blog posts found with the given keyword.");
            }
        }

        private void BubbleSortByDate(BlogPostList blogPostList)
        {
            bool swapped;
            do
            {
                swapped = false; // run sort until all is sorted
                for (int i = 0; i < blogPostList.blogPosts.Count - 1; i++)
                {
                    // compare bubbles..
                    if (blogPostList.blogPosts[i].BlogDate > blogPostList.blogPosts[i + 1].BlogDate)
                    {
                        // Swap inside the bubble
                        var temp = blogPostList.blogPosts[i];
                        blogPostList.blogPosts[i] = blogPostList.blogPosts[i + 1];
                        blogPostList.blogPosts[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped); // if no swaps, assume sorted
        }

        private void SearchByDate(BlogPostList blogPostList)
        {
            Console.Write("Enter the date to search for (yyyy-mm-dd): ");
            if (DateTime.TryParseExact(Console.ReadLine(), "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime searchDate))
            {
                bool found = false;
                foreach (var post in blogPostList.blogPosts)
                {
                    if (post.BlogDate.Date == searchDate.Date)
                    {
                        found = true;
                        PrintBlogPost(post);
                    }
                }

                if (!found)
                {
                    Console.WriteLine("No blog posts found with the given date.");
                }
            }
            else
            {
                Console.WriteLine("Invalid date format.");
            }
        }

        private void PrintBlogPost(BlogPost post)
        {
            Console.WriteLine($"Title: {post.BlogTitle}");
            Console.WriteLine($"Date: {post.BlogDate.ToShortDateString()}");
            Console.WriteLine($"Content: {post.BlogContent}");
            Console.WriteLine("-------------");
        }
    }
}
