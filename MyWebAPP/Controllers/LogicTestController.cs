using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebAPP.Controllers
{
    public class LogicTestController : Controller
    {
        // GET: LogicTest
        public ActionResult Index()
        {
            return View();
        }

        // GET: LogicTest/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LogicTest/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LogicTest/Create
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

        // GET: LogicTest/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LogicTest/Edit/5
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

        // GET: LogicTest/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LogicTest/Delete/5
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
