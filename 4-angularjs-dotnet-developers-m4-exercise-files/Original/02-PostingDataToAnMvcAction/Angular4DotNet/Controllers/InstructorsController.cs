using System.Web.Mvc;
using Angular4DotNetMvc.Models.Registration;

namespace Angular4DotNetMvc.Controllers
{
    public class InstructorsController : JsonController
    {
        private readonly RegistrationVmBuilder _registrationVmBuilder = new RegistrationVmBuilder();

        public ActionResult Index()
        {
            return Json(_registrationVmBuilder.GetInstructorsVms(), JsonRequestBehavior.AllowGet);
        }
    }
}