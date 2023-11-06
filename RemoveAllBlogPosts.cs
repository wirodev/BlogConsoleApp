using System;
using System.Collections.Generic;

namespace BlogManagerSystem
{
	public class RemoveALLBlogPosts
	{
		public void DeleteDatabase(BlogPostList blogPostList)
		{
			Console.WriteLine("Warning: This task will delete your database and is irreversible.");
			Console.Write("Are you sure you want to continue? ( y / n ): ");
			string confirmation = Console.ReadLine().ToLower();

			if (confirmation == "y")
			{
				blogPostList.blogPosts.Clear();
				Console.WriteLine("All posts have been deleted.");
			}
			else
			{
				Console.WriteLine("Aborted. No posts were removed.");
			}
			
		}
	}
}
