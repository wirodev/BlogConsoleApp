using System;

namespace BlogManagerSystem
{
	public class BlogPost
	{
		private string blogTitle; // field
		private DateTime blogDate; // field
		private string blogContent; // field
		
		public string BlogTitle // property
		{
			get{ return blogTitle; }
			set{ blogTitle = value; }
		}
		
		public DateTime BlogDate // property
		{
			get { return blogDate; }
			set { blogDate = value; }
		}
		
		public string BlogContent // property
		{
			get { return blogContent; }
			set { blogContent = value; }
		}
		
		// Note: It's simpler to use shorthand and automatic properties here with {get; set;} since fields are private by default (introduced in C# 3.0)
		
		public BlogPost(string blogTitle, DateTime blogDate, string blogContent)
		{
			BlogTitle = blogTitle;
			BlogDate = blogDate;
			BlogContent = blogContent;
		}
	}
}
