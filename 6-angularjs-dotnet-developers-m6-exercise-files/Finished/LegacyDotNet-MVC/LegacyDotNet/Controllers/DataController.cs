using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LegacyDotNet.Controllers
{
	public class DataController : Controller
	{
		public JsonResult GetCatalog()
		{
			return Json(Data.CourseList, JsonRequestBehavior.AllowGet);
		}
	}
}