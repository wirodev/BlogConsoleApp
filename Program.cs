using System;

namespace BlogManagerSystem
{
	class Program
	{
		enum MenuOption
		{
			AddBlogPost = 1, // enums are strongly typed constants, enums start at 0, need to set to 1
			SearchForBlogPost, // automatically given index 2
			EditBlogPosts, // index 3
			PrintAllBlogPosts, // index 4
			RemoveBlogPost, // index 5
			RemoveALLBlogPosts, // index 6
			ExitProgram // index 7
		}

		static void Main(string[] args)
		{
			// Instantiate list here
			BlogPostList blogPostList = new BlogPostList();
			
			BlogDatabase.DatabaseOfPosts(blogPostList); // add entries to list
			
			ShowMenu(blogPostList); // call the menu for the first time
		}

		static void ShowMenu(BlogPostList blogPostList) // encapsulate menu as its own static method to call later
		{
			while (true)
			{
				Console.WriteLine("\nMenu");
				Console.WriteLine("[1] Add Blog Post");
				Console.WriteLine("[2] Search For Blog Post");
				Console.WriteLine("[3] Edit Blog Posts");
				Console.WriteLine("[4] Print All Blog Posts");
				Console.WriteLine("[5] Remove Blog Post");
				Console.WriteLine("[6] Remove ALL Blog Posts");
				Console.WriteLine("[7] Exit Program");

				Console.Write("Select an option: ");
				if (int.TryParse(Console.ReadLine(), out int menuOption) && Enum.IsDefined(typeof(MenuOption), menuOption))
				{
					switch ((MenuOption)menuOption) // Switch with enum makes the menu easier to read and maintain
					{
						case MenuOption.AddBlogPost:
							AddBlogPost addPost = new AddBlogPost();
							addPost.AddPost(blogPostList);
							break;
						case MenuOption.SearchForBlogPost:
							SearchForBlogPost searchPost = new SearchForBlogPost();
   	 						searchPost.Search(blogPostList);
							break;
						case MenuOption.EditBlogPosts:
							EditBlogPosts editPost = new EditBlogPosts();
							editPost.EditPost(blogPostList);
							break;
						case MenuOption.PrintAllBlogPosts:
							PrintAllBlogPosts printPost = new PrintAllBlogPosts();
							printPost.PrintBlogPosts(blogPostList);
							break;
						case MenuOption.RemoveBlogPost:
							RemoveBlogPost removeBlogPost = new RemoveBlogPost();
							removeBlogPost.RemoveSinglePost(blogPostList);
							break;
						case MenuOption.RemoveALLBlogPosts:
							RemoveALLBlogPosts removeALLBlogPosts = new RemoveALLBlogPosts();
							removeALLBlogPosts.DeleteDatabase(blogPostList);
							break;
						case MenuOption.ExitProgram:
							Console.WriteLine("Exiting Program...");
							return;
						default:
							throw new ArgumentOutOfRangeException(); // if Enum.IsDefined is not in 1-6 range, throw error and print else-statement
					}
				}
				else
				{
					Console.WriteLine("You must select an integer between 1 and 6.");
				}
			}
		}
	}
}
