using System;
using System.Linq;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using PlumRunModel;
//using System.Collections.Generic;
//using System.Web;


namespace WebUI.Controllers
{
    public class AddressController : Controller
    {

        //
        // GET: /Address/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Read([DataSourceRequest] DataSourceRequest request)
        {
            using (PREntities db = new PREntities())
            {
                var result = db.Addresses
                    .OrderBy(x => x.Address1)
                    .Select(x => new WebUI.ViewModels.Address.AddressSearch
                    {
                        Address1 = x.Address1,
                        AddressID = x.AddressID,
                        City = x.City,
                        StateProvince = x.StateProvince.abbreviation,
                        PostalCode = x.PostalCode
                    })
                    .ToDataSourceResult(request);
                return Json(result);
            }
        }


        public ActionResult AddressMember_Grid (int addressID, [DataSourceRequest] DataSourceRequest request)
        {
            using (PREntities db = new PREntities())
            {
                var result = db.People
                    .Where(p => p.AddressID == addressID)
                    .OrderBy(x => x.FirstName)
                    .Select(am => new WebUI.ViewModels.Person.AddressMember_Grid
                    {
                        AddressID = am.AddressID,
                        PersonID = am.PersonID,
                        Name = am.FirstName + " " + am.LastName,
                        Gender = am.StaticList.Text
                    })
                    .ToDataSourceResult(request);
                return Json(result);
            }
        }



        //
        // GET: /Address/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Address/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Address/Create
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
        // GET: /Address/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Address/Edit/5
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
        // GET: /Address/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Address/Delete/5
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
