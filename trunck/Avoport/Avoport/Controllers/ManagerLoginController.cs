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
    public class ManagerLoginController : Controller
    {
        //
        // GET: /ManagerLogin/

        public ActionResult ManagerLogin()
        {
            return View();
        }

        //
        // GET: /ManagerLogin/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /ManagerLogin/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ManagerLogin/Create

        [HttpPost]
        public ActionResult ManagerLogin(Avoport.Models.ManagerLoginModel model)
        {
           
                if (ModelState.IsValid)
                {

                    if (model.IsValid(model.Username, model.Password))
                    {
                        FormsAuthentication.SetAuthCookie(model.Username, model.RememberMe);
                        return RedirectToAction("ManagerHome", "ManagerHome");

                    }
                    else
                    {


                        ModelState.AddModelError("", "The User Name or Password provided is incorrect !");

                    }


                }
            return View(model);
        }

        //
        // GET: /ManagerLogin/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /ManagerLogin/Edit/5

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
        // GET: /ManagerLogin/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /ManagerLogin/Delete/5

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
