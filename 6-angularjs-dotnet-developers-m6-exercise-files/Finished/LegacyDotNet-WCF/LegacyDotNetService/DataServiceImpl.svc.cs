using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LegacyDotNetService
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DataServiceImpl" in code, svc and config file together.
	public class DataServiceImpl : IDataServiceImpl
	{
		public List<Course> GetCourses()
		{
			return Data.CourseList;
		}

		public Course GetCourse(string id)
		{
			return Data.CourseList.Single(c => c.id == int.Parse(id));
		}

		public Course UpdateCourse(string id, Course course)
		{
			var courseToUpdate = Data.CourseList.Single(c => c.id == course.id);
			courseToUpdate.registered = course.registered;
			return courseToUpdate;
		}
	}
}
