using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using PlumRunDomain;
using System.Threading;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Host.SystemWeb;


namespace WebUI.Helpers
{
    public class AccountHelper
    {
        public static ClaimsPrincipal SetupPrincipal(Person validPerson)
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

            var id = new ClaimsIdentity(claims, DefaultAuthenticationTypes.ApplicationCookie);

            var cp = new ClaimsPrincipal(id);

            return cp;

        }
    }
}