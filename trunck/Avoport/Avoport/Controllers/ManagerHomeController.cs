using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Avoport.Controllers
{
    public class ManagerHomeController : Controller
    {
        //
        // GET: /ManagerHome/

        public ActionResult ManagerHome()
        {
            return View();
        }

        //
        // GET: /ManagerHome/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /ManagerHome/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ManagerHome/Create

        [HttpPost]
        public ActionResult ManagerHomeModel(Avoport.Models.ManagerHomeModel model)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }

        //
        // GET: /ManagerHome/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /ManagerHome/Edit/5

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

        //
        // GET: /ManagerHome/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /ManagerHome/Delete/5

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
