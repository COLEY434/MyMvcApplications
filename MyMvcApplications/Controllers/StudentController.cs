using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMvcApplications.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public string Index()
        {
            return "This is an example";
        }

		[ActionName("find")]
		public ActionResult Edit()
		{
			// update student to the database

			return RedirectToAction("Index");
		}
	}
}