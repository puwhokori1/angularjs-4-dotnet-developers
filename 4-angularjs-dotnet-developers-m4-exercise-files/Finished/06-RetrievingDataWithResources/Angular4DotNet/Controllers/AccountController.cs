﻿using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace Angular4DotNetMvc.Controllers
{
    public class AccountController : ApiController
    {
        public HttpResponseMessage Post(StudentVm student)
        {
            //_studentRegistrationService.Register(student);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

    }
}
