using System.Web.Mvc;
using Angular4DotNetMvc.Models.Registration;

namespace Angular4DotNetMvc.Controllers
{
    public class RegistrationController : Controller
    {
        private RegistrationVmBuilder _registrationVmBuilder = new RegistrationVmBuilder();

        public ActionResult Index()
        {
            return View(_registrationVmBuilder.BuildRegistrationVm());
        }

    }
}
