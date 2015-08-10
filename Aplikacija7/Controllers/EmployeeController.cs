using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        //  [HttpGet]
        //  public ActionResult Dettails()
        //  {
        //      return View();
        //   }
        //  [HttpPost]

        public ActionResult Details(int? id) {

            //  if (id == null)
            // return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Employee employee = db.Employees.Find(id);
            if (id == null) { 

            return HttpNotFound();
        }
            return View(employee);

        }

        [HttpGet]
        public ActionResult Create() {
            return View();
        }
        [HttpPost]

        public ActionResult Create(Employee employee) {

            if (ModelState.IsValid) {


                db.Employees.Add(employee);
                db.SaveChanges();

                return RedirectToAction("Index");

            }

            return View(employee);
        }



    }
}