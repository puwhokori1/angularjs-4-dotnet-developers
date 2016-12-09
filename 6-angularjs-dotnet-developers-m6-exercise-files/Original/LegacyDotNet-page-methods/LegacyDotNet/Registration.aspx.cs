using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LegacyDotNet
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
				new Course { Id= 1, Name= "70's Studies", Credits= 3, InstructorName= "Professor Trelawney", Registered= false },
				new Course { Id= 2, Name= "Aeronautics", Credits= 5, InstructorName= "Professor Hooch", Registered= false },
				new Course { Id= 3, Name= "Care of Ordinary Creatures", Credits= 2, InstructorName= "Professor Grubbly-Plank", Registered= false },
				new Course { Id= 4, Name= "Plagarism in the 21st century", Credits= 4, InstructorName= "Professor Lockhart", Registered= true },
				new Course { Id= 5, Name= "Defense AgaInst the Dim Arts", Credits= 1, InstructorName= "Professor Lupin", Registered= false },
				new Course { Id= 6, Name= "Chemistry", Credits= 5, InstructorName= "Professor Slughorn", Registered= false },
				new Course { Id= 7, Name= "Pharmaceutical Analysis", Credits= 3, InstructorName= "Professor Snape", Registered= true },
				new Course { Id= 8, Name= "Advanced Fertilization Techniques 1", Credits= 5, InstructorName= "Professor Sprout", Registered= false },
			};
	}

	public class Course
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Credits { get; set; }
		public string InstructorName { get; set; }
		public bool Registered { get; set; }
	}
}
