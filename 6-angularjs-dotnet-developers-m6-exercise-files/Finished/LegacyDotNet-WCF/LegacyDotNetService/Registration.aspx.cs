using System;
using System.Collections.Generic;

namespace LegacyDotNetService
{
	public partial class Registration : System.Web.UI.Page
	{
		public User CurrentUser;
		protected void Page_Load(object sender, EventArgs e)
		{
			CurrentUser = new User {Id = 3, Name = "Aaron Skonnard"};
		}
	}

	public class User
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}

	public static class Data
	{
		public static List<Course> CourseList = new List<Course>()
			{
				new Course { id= 1, name= "70's Studies", credits= 3, instructorName= "Professor Trelawney", registered= false },
				new Course { id= 2, name= "Aeronautics", credits= 5, instructorName= "Professor Hooch", registered= false },
				new Course { id= 3, name= "Care of Ordinary Creatures", credits= 2, instructorName= "Professor Grubbly-Plank", registered= false },
				new Course { id= 4, name= "Plagarism in the 21st century", credits= 4, instructorName= "Professor Lockhart", registered= true },
				new Course { id= 5, name= "Defense AgaInst the Dim Arts", credits= 1, instructorName= "Professor Lupin", registered= false },
				new Course { id= 6, name= "Chemistry", credits= 5, instructorName= "Professor Slughorn", registered= false },
				new Course { id= 7, name= "Pharmaceutical Analysis", credits= 3, instructorName= "Professor Snape", registered= true },
				new Course { id= 8, name= "Advanced Fertilization Techniques 1", credits= 5, instructorName= "Professor Sprout", registered= false },
			};
	}

	public class Course
	{
		public int id { get; set; }
		public string name { get; set; }
		public int credits { get; set; }
		public string instructorName { get; set; }
		public bool registered { get; set; }
	}
}
