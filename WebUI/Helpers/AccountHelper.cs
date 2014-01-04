using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using PlumRunDomain;
using System.Threading;

namespace WebUI.Helpers
{
    public class AccountHelper
    {
        public static void SetupPrincipal(Person validPerson)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, validPerson.FirstName + " " + validPerson.LastName),
                new Claim("CustID", validPerson.CustomerID.ToString()),
                new Claim("PersonID", validPerson.PersonID.ToString()),

                //TODO: Create ForEach loop for list of roles
                new Claim(ClaimTypes.Role, "PR Administrator"),
                new Claim(ClaimTypes.Role, "Cust Admin"),
                
            };

            var id = new ClaimsIdentity(claims, "Forms");

            var cp = new ClaimsPrincipal(id);

            Thread.CurrentPrincipal = cp;
            //p = ClaimsPrincipal.Current;
            HttpContext.Current.User = cp;

            


        }
    }
}