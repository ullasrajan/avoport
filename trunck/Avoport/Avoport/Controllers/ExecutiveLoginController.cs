using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using DotNetOpenAuth.AspNet;
using Microsoft.Web.WebPages.OAuth;
using WebMatrix.WebData;
using Avoport.Filters;
using Avoport.Models;

namespace Avoport.Controllers
{
    public class ExecutiveLoginController : Controller
    {
        //
        // GET: /ExecutiveLogin/

        public ActionResult ExecutiveLogin()
        {
            return View();
        }

        //
        // GET: /ExecutiveLogin/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /ExecutiveLogin/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ExecutiveLogin/Create

        [HttpPost]
        public ActionResult ExecutiveLogin(Avoport.Models.ExecutiveLoginModel model)
        {

            if (ModelState.IsValid)
            {

                if (model.IsValid(model.Username, model.Password))
                {
                    FormsAuthentication.SetAuthCookie(model.Username, model.RememberMe);
                    return RedirectToAction("index", "Home");

                }
                else
                {


                    ModelState.AddModelError("", "The User Name or Password provided is incorrect !");

                }


            }
            return View(model);
        }

        //
        // GET: /ExecutiveLogin/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /ExecutiveLogin/Edit/5

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
        // GET: /ExecutiveLogin/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /ExecutiveLogin/Delete/5

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
