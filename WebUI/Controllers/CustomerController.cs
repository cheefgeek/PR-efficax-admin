using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Mvc;
using Kendo.Mvc.Grid.CRUD.Models;
using PlumRunDomain;
using PlumRunModel;
using WebUI.ViewModels.Customer;
using System.Net;
using System.Data.Entity;
//using Omu;

namespace WebUI.Controllers
{
    public class CustomerController : Controller
    {
        private PREntities db = new PREntities();

        public ActionResult Index()
        {
            //ViewBag.SelectedCustomerID = 0;
            return View();
        }

        public ActionResult Read(int take, int skip, IEnumerable<Sort> sort, Kendo.Mvc.Grid.CRUD.Models.Filter filter)
        {
            {
                var result = db.Customers
                    .OrderBy(c => c.CustomerID) // EF requires ordered IQueryable in order to do paging
                    // Use a view model to avoid serializing internal Entity Framework properties as JSON
                    .Select(c => new CustomerSearch
                    {
                        CustomerID = c.CustomerID,
                        AROrgName = c.AROrgName,
                        ARCity = c.ARCity,
                        ARStateProvID = c.ARStateProvID,
                        CreatedDate = c.CreatedDate ,
                        State = c.StateProvince.name
                    })
                    .ToDataSourceResult(take, skip, sort, filter);
                return Json(result);
            }
        }

        public ActionResult CustomerCreate()
        {
            ViewBag.ARStateProvID = new SelectList(db.StateProvinces, "id", "name");
            ViewBag.CountryID = new SelectList(db.Countries, "CountryID", "Country1");
            //INSTANTIATE VIEWMODEL OBJECT
            ViewModels.CustomerCreateVM vm = new ViewModels.CustomerCreateVM();
            return View(vm);
        }


        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult CustomerCreate(ViewModels.CustomerCreateVM newCustomer,string button)
        {
            if (button == "clear")
            {
                return RedirectToAction("CustomerCreate");
            }
            else if (button == "cancel")
            {
                return RedirectToAction("Index");
            }
            else if (button == "add")
            {
                return RedirectToAction("CustomerCreate");
            }
            else if (ModelState.IsValid)
            {
                Customer customer = new Customer();
                customer.ActiveDate = System.DateTime.Now;
                customer.ARAddress1 = newCustomer.CustomerCreate.ARAddress1;
                customer.ARAddress2 = newCustomer.CustomerCreate.ARAddress2;
                customer.ARAddress3 = newCustomer.CustomerCreate.ARAddress3;
                customer.ARCity = newCustomer.CustomerCreate.ARCity;
                customer.AROrgName = newCustomer.CustomerCreate.AROrgName;
                customer.ARPostalCode = newCustomer.CustomerCreate.ARPostalCode;
                customer.ARStateProvID = newCustomer.stateDropDown.SelectedID;
                customer.CountryID = 169;                                       //TODO Get CountryID from model
                customer.CreatedDate = System.DateTime.Now;
                customer.PriceID = newCustomer.pricesDropDown.SelectedID;

                db.Customers.Add(customer);
                db.SaveChanges();
            }                
            return RedirectToAction("Index");
        }


        // GET: /Customer/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: /Customer/Delete/5
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
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }


        // GET: /Customer/Edit/5 
        public ActionResult Edit(int id)
        {
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            CustomerEditVM VM = new CustomerEditVM(customer.PriceID, customer.ARStateProvID, customer.CountryID);

            VM.customerEdit.ARAddress1 = customer.ARAddress1;
            VM.customerEdit.ARAddress2 = customer.ARAddress2;
            VM.customerEdit.ARAddress3 = customer.ARAddress3;
            VM.customerEdit.ARCity = customer.ARCity;
            VM.customerEdit.ARStateProvID = customer.ARStateProvID;
            VM.customerEdit.AROrgName = customer.AROrgName;
            VM.customerEdit.ARPostalCode = customer.ARPostalCode;
            VM.customerEdit.CountryID = customer.CountryID;
            VM.customerEdit.CustomerID = customer.CustomerID;
            VM.customerEdit.PriceID = customer.PriceID;
            VM.customerEdit.ActiveDate = customer.ActiveDate;
            VM.customerEdit.InactiveDate = customer.InactiveDate;
            VM.customerEdit.ModifiedByPersonID = 0;                //TODO Get PersonID from code
            return View(VM);
        }

        // POST: /Customer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit (
            int id,
            CustomerEdit customerEdit,
            ViewModels.DropDownLists.StateDropDown stateDropDown,
            ViewModels.DropDownLists.CountryDropDown countryDropDown,
            ViewModels.DropDownLists.PricesDropDown pricesDropDown,
            string button)
        {
            if (button == "cancel")
            {
                return RedirectToAction("Index");
            }

            else if (button == "delete")
            {
                return RedirectToAction("Delete", new { id = id });
            }

            if (ModelState.IsValid)
            {
                Customer updatedCustomer = db.Customers.Find(id);

                updatedCustomer.ModifiedDate = System.DateTime.Now;
                updatedCustomer.ARStateProvID = stateDropDown.SelectedID;
                updatedCustomer.CountryID = countryDropDown.SelectedID;
                updatedCustomer.PriceID = pricesDropDown.SelectedID;
                updatedCustomer.AROrgName = customerEdit.AROrgName;
                updatedCustomer.ARAddress1 = customerEdit.ARAddress1;
                updatedCustomer.ARAddress2 = customerEdit.ARAddress2;
                updatedCustomer.ARAddress3 = customerEdit.ARAddress3;
                updatedCustomer.ARCity = customerEdit.ARCity;
                updatedCustomer.ARPostalCode = customerEdit.ARPostalCode;
                db.Entry(updatedCustomer).State = EntityState.Modified;
                // TODO Populate ModifiedByPersonID in code
               db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}