using System.Web.Http;
using System.Web.Mvc;
using Angular4DotNetMvc.Models.Courses;
using Angular4DotNetMvc.Models.Registration;

namespace Angular4DotNetMvc.Controllers
{
    public class CoursesController : ApiController
    {
        private readonly RegistrationVmBuilder _registrationVmBuilder = new RegistrationVmBuilder();

        public CourseVm[] Get()
        {
            return _registrationVmBuilder.GetCourseVms();
        }
    }
}