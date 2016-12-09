using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LegacyDotNet
{
	public partial class Registration : System.Web.UI.Page
	{
		public User CurrentUser;
		protected void Page_Load(object sender, EventArgs e)
		{
			CurrentUser = new User() {Id = 3, Name = "Aaron Skonnard"};

			var FollowedInstructors = new List<FollowedInstructor>
			{
				new FollowedInstructor() {Id = 1, Name = "Professor Snape"},
				new FollowedInstructor() {Id = 2, Name = "Professor McGonagall"},
				new FollowedInstructor() {Id = 3, Name = "Professor Dumbledore"}
			};

//			rptFollowedInstructors.DataSource = FollowedInstructors;
//			rptFollowedInstructors.DataBind();

			var fiString = "var followedInstructorsList = [";
			FollowedInstructors.ForEach(f => fiString += "{id:" + f.Id + ", name:\"" + f.Name + "\"},");
			fiString += "];";
			litFollowedInstructors.Text = fiString;
		}
	}

	public class User
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}


	public class FollowedInstructor
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}
}
