using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class HouseholdController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Household/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Household/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Household/Create
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

        //
        // GET: /Household/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Household/Edit/5
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
        // GET: /Household/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Household/Delete/5
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
