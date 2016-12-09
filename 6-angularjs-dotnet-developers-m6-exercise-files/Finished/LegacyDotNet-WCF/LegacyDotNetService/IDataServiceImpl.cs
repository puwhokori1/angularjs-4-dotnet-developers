using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LegacyDotNetService
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDataServiceImpl" in both code and config file together.
	[ServiceContract]
	public interface IDataServiceImpl
	{
		[OperationContract]
		[WebGet(ResponseFormat = WebMessageFormat.Json,
			BodyStyle = WebMessageBodyStyle.Bare,
			UriTemplate = "courses/")]
		List<Course> GetCourses();

		[OperationContract]
		[WebGet(ResponseFormat = WebMessageFormat.Json,
			BodyStyle = WebMessageBodyStyle.Bare,
			UriTemplate = "courses/{id}")]
		Course GetCourse(string id);

		[OperationContract]
		[WebInvoke(Method="POST", ResponseFormat = WebMessageFormat.Json,
			BodyStyle = WebMessageBodyStyle.Bare,
			UriTemplate = "courses/{id}")]
		Course UpdateCourse(string id, Course course);
	}
}
