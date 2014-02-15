using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace WebUI.Business
{
    public class AuthorizationManager : ClaimsAuthorizationManager
    {
        public override bool CheckAccess(AuthorizationContext context)
        {
            //THIS IS A SAMPLE CHECK ACCESS IF STATEMENT
            var resource = context.Resource.First().Value;
            var action = context.Action.First().Value;

            if (action == "Show" && resource == "Ministry")
            {
                //Check for required claim...
                var hasClaim = context.Principal.IsInRole("PR Administrator");

                return hasClaim;
            }

            return false;

            //try
            //{
            //    if (action == "Show" && resource == "Ministry")
            //    {
            //        //Check for required claim...
            //        var hasClaim = context.Principal.IsInRole("PR Administrator");

            //        return hasClaim;
            //    }

            //    return false;
            //}
            //catch (System.Security.SecurityException e)
            //{
            //    var exception = e;
                
            //}

            //return false;
        }
    }
}