using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aplikacija7.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeContext db = new EmployeeContext();

        public ActionResult Index() {



            return View(db.Employees.ToList());

        }
    }
}