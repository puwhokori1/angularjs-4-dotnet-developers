using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Angular4DotNetMvc.Models.Registration;

namespace Angular4DotNetMvc.Controllers
{
    public class InstructorsController : Controller
    {
        private readonly RegistrationVmBuilder _registrationVmBuilder = new RegistrationVmBuilder();

        public ActionResult Index()
        {
            return View("Index", "", _registrationVmBuilder.GetSerializedInstructors());
        }
    }
}
