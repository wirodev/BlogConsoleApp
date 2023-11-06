using System;

namespace BlogManagerSystem
{
	public static class BlogDatabase
	{
		public static void DatabaseOfPosts(BlogPostList blogPostList)
		{
			blogPostList.AddBlogPost(new BlogPost("Exploring the Oceans", new DateTime(2023, 11, 08), "The ocean is a vast and mysterious place. It covers 71% of the Earth's surface and is home to a rich diversity of life."));
			blogPostList.AddBlogPost(new BlogPost("The Wonders of Space Travel", new DateTime(2023, 11, 09), "Space travel opens up new horizons for humanity. Exploring the cosmos allows us to understand our place in the universe."));
			blogPostList.AddBlogPost(new BlogPost("Gardening for Beginners", new DateTime(2023, 11, 10), "Gardening can be a relaxing and rewarding hobby. This guide will help you get started with the basics."));
			blogPostList.AddBlogPost(new BlogPost("The History of Computing", new DateTime(2023, 11, 11), "Computers have revolutionized the way we live and work. Let's take a look at how they've evolved over the years."));
			blogPostList.AddBlogPost(new BlogPost("Healthy Eating on a Budget", new DateTime(2023, 11, 12), "Eating healthily doesn't have to be expensive. Here are some tips for maintaining a balanced diet without breaking the bank."));
		}
	}
}