﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Avoport.Controllers
{
    public class AdminHomeController : Controller
    {
        //
        // GET: /AdminHome/

        public ActionResult AdminHome()
        {
            return View();
        }

        //
        // GET: /AdminHome/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /AdminHome/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /AdminHome/Create

        [HttpPost]
        public ActionResult AdminHome(Avoport.Models.AdminHomeModel model)
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
        // GET: /AdminHome/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /AdminHome/Edit/5

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
        // GET: /AdminHome/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /AdminHome/Delete/5

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
