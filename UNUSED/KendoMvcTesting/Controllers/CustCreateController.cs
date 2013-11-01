using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PlumRunDomain;
using PlumRunModel;

namespace KendoMvcTesting.Controllers
{
    public class CustCreateController : Controller
    {
        private PREntities db = new PREntities();

        //
        // GET: /CustCreate/

        public ActionResult Index()
        {
            var customers = db.Customers.Include(c => c.Price);
            return View(customers.ToList());
        }

        //
        // GET: /CustCreate/Details/5

        public ActionResult Details(int id = 0)
        {
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        //
        // GET: /CustCreate/Create

        public ActionResult Create()
        {
            ViewBag.PriceID = new SelectList(db.Prices, "PriceID", "PriceID");
            return View();
        }

        //
        // POST: /CustCreate/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PriceID = new SelectList(db.Prices, "PriceID", "PriceID", customer.PriceID);
            return View(customer);
        }

        //
        // GET: /CustCreate/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            ViewBag.PriceID = new SelectList(db.Prices, "PriceID", "PriceID", customer.PriceID);
            return View(customer);
        }

        //
        // POST: /CustCreate/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PriceID = new SelectList(db.Prices, "PriceID", "PriceID", customer.PriceID);
            return View(customer);
        }

        //
        // GET: /CustCreate/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        //
        // POST: /CustCreate/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Customer customer = db.Customers.Find(id);
            db.Customers.Remove(customer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}