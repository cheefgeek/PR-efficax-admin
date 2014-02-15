using System;
using System.Linq;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using PlumRunDomain;
using PlumRunModel;
using System.Threading;
using System.IdentityModel.Services;
using System.Security.Permissions;
using WebUI.Business;
using System.Security;

namespace WebUI.Controllers
{
    public class MinistryController : Controller
    {
        //
        // GET: /Ministry/
        public ActionResult Index()
        {
            return View();
        }

        [HandleError(ExceptionType = typeof(SecurityException))]
        [ClaimsPrincipalPermission(SecurityAction.Demand, Operation = "Show", Resource = "Ministry")]
        public ActionResult Read([DataSourceRequest] DataSourceRequest request)
        {
           
           using (PREntities db = new PREntities())
            {
                var userPersonID = System.Security.Claims.ClaimsPrincipal.Current.FindFirst("PersonID").Value;

                //var userGroups = db.GroupMembers          CAN'T GET THIS TO WORK!
                //    .Where(p => p.PersonID == 0)
                //    .Select(x => new Int32
                //    {
                //        GroupID = x.GroupID
                //    });


                var result = db.Groups

                    .Where(g => g.GroupTypeID == 2)
                    .OrderBy(x => x.Name)               // EF requires ordered IQueryable in order to do paging
                    // Use a view model to avoid serializing internal Entity Framework properties as JSON
                    .Select(x => new WebUI.ViewModels.Group.GroupSearch
                    {
                        GroupID = x.GroupID,
                        Name = x.Name,
                        Description = x.Description,
                        Address = x.Address.Address1,
                        City = x.Address.City,
                        State = x.Address.StateProvince.abbreviation
                    })
                    .ToDataSourceResult(request);
                return Json(result);
            }

            
            //SAMPLE LINQ JOIN
            //var query = contacts.AsEnumerable().Join(orders.AsEnumerable(),
            //order => order.Field<Int32>("ContactID"),
            //contact => contact.Field<Int32>("ContactID"),
            //(contact, order) => new
            //{
            //    ContactID = contact.Field<Int32>("ContactID"),
            //    SalesOrderID = order.Field<Int32>("SalesOrderID"),
            //    FirstName = contact.Field<string>("FirstName"),
            //    Lastname = contact.Field<string>("Lastname"),
            //    TotalDue = order.Field<decimal>("TotalDue")
            //})
            //    .GroupBy(record => record.ContactID);





        }

        public ActionResult GroupMembers_Grid(int groupID, [DataSourceRequest] DataSourceRequest request)
        {
            using (PREntities db = new PREntities())
            {
                var result = db.GroupMembers
                    .Where(gm => gm.GroupID == groupID)
                    .OrderBy(gm => gm.Person.FirstName)               // EF requires ordered IQueryable in order to do paging
                    // Use a view model to avoid serializing internal Entity Framework properties as JSON
                    .Select(gm => new WebUI.ViewModels.Group.GroupMember_Grid
                    {
                        GroupID = gm.GroupID,
                        PersonID = gm.PersonID,
                        FirstName = gm.Person.FirstName,
                        LastName = gm.Person.LastName,
                        //CurrentAge = gm.cur,                               // TODO Helpers.MathHelpers.GetAnniversaryCount(gm.Person.Birthday),
                        MemberType = gm.GroupMemberType.Name,
                        HasLogin = gm.Person.UserName                       // TODO Write helper to display "Yes" or "No"
                    })
                    .ToDataSourceResult(request);
                return Json(result);
            }
        }





        //
        // GET: /Ministry/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Ministry/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Ministry/Create
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
        // GET: /Ministry/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Ministry/Edit/5
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
        // GET: /Ministry/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Ministry/Delete/5
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
