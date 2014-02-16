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
                var personRoles = person.Roles.Select(x => x.Name);

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, name),
                    new Claim(ClaimTypes.GivenName, person.FirstName + " " + person.LastName),
                    new Claim("CustID", person.CustomerID.ToString()),
                    new Claim("PersonID", person.PersonID.ToString()),
                };
                
                foreach (string role in personRoles)
                    {
                        claims.Add(new Claim(ClaimTypes.Role, role));
                    }

                return new ClaimsPrincipal(new ClaimsIdentity(claims, "Custom"));

            }
        }
    }
}




