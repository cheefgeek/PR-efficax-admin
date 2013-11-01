using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Mvc;
using Kendo.Mvc.Grid.CRUD.Models;
using PlumRunDomain;
using PlumRunModel;
using WebUI.ViewModels.Customer;
//using Omu;

namespace WebUI.Controllers
{
    public class CustomerController : Controller
    {
        private PREntities db = new PREntities();


        public ActionResult Index()
        {
            ViewBag.SelectedCustomerID = 0;
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
        public ActionResult CustomerCreate(ViewModels.CustomerCreate newCustomer,string button)
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
                customer.ARAddress1 = newCustomer.ARAddress1;
                customer.ARAddress2 = newCustomer.ARAddress2;
                customer.ARAddress3 = newCustomer.ARAddress3;
                customer.ARCity = newCustomer.ARCity;
                customer.AROrgName = newCustomer.AROrgName;
                customer.ARPostalCode = newCustomer.ARPostalCode;
                customer.ARStateProvID = newCustomer.ARStateProvID;
                customer.CountryID = 169;
                customer.CreatedDate = System.DateTime.Now;
                customer.PriceID = 9999999;

                db.Customers.Add(customer);
                db.SaveChanges();
            }                
            return RedirectToAction("Index");
        }


        public ActionResult Destroy(IEnumerable<CustomerSearch> customers)
        {
            {
                //Iterate all destroyed products which are posted by the Kendo Grid
                foreach (var CustomerSearch in customers)
                {
                    // Create a new Product entity and set its properties from productViewModel
                    var customer = new Customer
                    {
                        CustomerID = (int)CustomerSearch.CustomerID,
                    };

                    // Attach the entity
                    db.Customers.Attach(customer);
                    // Delete the entity
                    db.Customers.Remove(customer);
                }

                // Delete the products from the database
                db.SaveChanges();

                //Return emtpy result
                return Json(null);
            }
        }


    //BELOW HERE ARE ORIGINAL ACTION METHODS PRIOR TO GRID
        // GET: /Customer/Details/5
        //public ActionResult Details(int id = 0)
        //{
        //    Customer customer = db.Customers.Find(id);
        //    if (customer == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(customer);
        //}

        // GET: /Customer/Edit/5 
        public ActionResult Edit(int id)
        {
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }

            CustomerEdit editableCustomer = new CustomerEdit();

            editableCustomer.ARAddress1 = customer.ARAddress1;
            editableCustomer.ARAddress2 = customer.ARAddress2;
            editableCustomer.ARAddress3 = customer.ARAddress3;
            editableCustomer.ARCity = customer.ARCity;
            editableCustomer.AROrgName = customer.AROrgName;
            editableCustomer.ARPostalCode = customer.ARPostalCode;

            return View(editableCustomer);
        }

        // POST: /Customer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Read");
            }
            return View(customer);
        }

    }
}





