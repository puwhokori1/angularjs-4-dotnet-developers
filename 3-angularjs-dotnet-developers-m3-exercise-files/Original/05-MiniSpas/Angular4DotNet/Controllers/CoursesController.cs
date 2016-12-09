using System.Web.Mvc;
using Angular4DotNetMvc.Models.Registration;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Angular4DotNetMvc.Controllers
{
    public class CoursesController : Controller
    {
        private RegistrationVmBuilder _registrationVmBuilder = new RegistrationVmBuilder();

        public ActionResult Index()
        {
            return View("Index", "", _registrationVmBuilder.GetSerializedCourses());
        }

    }

}
