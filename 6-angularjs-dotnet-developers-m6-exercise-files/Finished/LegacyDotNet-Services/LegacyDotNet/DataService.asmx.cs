using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace LegacyDotNet
{
	[System.Web.Script.Services.ScriptService]
	public class DataService : System.Web.Services.WebService
	{

		[WebMethod]
		[ScriptMethod(ResponseFormat = ResponseFormat.Json)]
		public List<Course> GetCourses()
		{
			return Data.CourseList;
		}

		[WebMethod]
		[ScriptMethod(ResponseFormat = ResponseFormat.Json)]
		public Course UpdateCourse(int id, bool registered)
		{
			Data.CourseList.Single(c => c.id == id).registered = registered;
			return Data.CourseList.Single(c => c.id == id);
		}
	}
}
