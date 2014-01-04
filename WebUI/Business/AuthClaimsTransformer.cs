using PlumRunModel;
using PlumRunDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Claims;
using System.Web;


namespace WebUI.Business
{
    public class AuthClaimsTransformer : ClaimsAuthenticationManager
    {
        public override ClaimsPrincipal Authenticate(string resourceName, ClaimsPrincipal incomingPrincipal)
        {
            var name = incomingPrincipal.Identity.Name;

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new SecurityException("No user name found");
            }

            return CreatePrincipal(name);
        }

        private ClaimsPrincipal CreatePrincipal(string name)
        {
            using (PREntities db = new PREntities())
            {
                Person person = db.People.Where(u => u.UserName == name).First();

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.GivenName, person.FirstName + " " + person.LastName),
                    new Claim("CustID", person.CustomerID.ToString()),
                    new Claim("PersonID", person.PersonID.ToString()),

                    //TODO: Create ForEach loop for list of roles
                    new Claim(ClaimTypes.Role, "PR Administrator"),
                    new Claim(ClaimTypes.Role, "Cust Admin"),
                };
                return new ClaimsPrincipal(new ClaimsIdentity(claims, "Custom"));

            }
        }
    }
}