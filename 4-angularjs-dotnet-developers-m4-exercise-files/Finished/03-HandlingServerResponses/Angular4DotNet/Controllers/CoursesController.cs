using System.Web.Mvc;
using Angular4DotNetMvc.Models.Registration;

namespace Angular4DotNetMvc.Controllers
{
    public class CoursesController : JsonController
    {
        private readonly RegistrationVmBuilder _registrationVmBuilder = new RegistrationVmBuilder();

        public ActionResult Index()
        {
            return Json(_registrationVmBuilder.GetCourseVms(), JsonRequestBehavior.AllowGet);
        }
    }
}