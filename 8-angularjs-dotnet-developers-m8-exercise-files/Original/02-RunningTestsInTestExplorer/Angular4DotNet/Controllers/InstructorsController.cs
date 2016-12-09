using System.Web.Http;
using System.Web.Mvc;
using Angular4DotNetMvc.Models.Instructors;
using Angular4DotNetMvc.Models.Registration;

namespace Angular4DotNetMvc.Controllers
{
    public class InstructorsController : ApiController
    {
        private readonly RegistrationVmBuilder _registrationVmBuilder = new RegistrationVmBuilder();

        public InstructorVm[] Get()
        {
            return _registrationVmBuilder.GetInstructorsVms();
        }
    }
}