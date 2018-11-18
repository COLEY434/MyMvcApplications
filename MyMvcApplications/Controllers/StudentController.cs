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
            return "This is the return type of the index actions";
        }
    }
}