﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aplikacija7.Controllers
{
    public class Employee1Controller : Controller
    {
        // GET: Employee1
        public ActionResult Index()
        {
            return View();
        }

        // GET: Employee1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employee1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee1/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employee1/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee1/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
