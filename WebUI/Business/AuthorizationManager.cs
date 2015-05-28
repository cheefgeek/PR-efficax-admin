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
                var hasClaim = context.Principal.IsInRole("PR Admin") || context.Principal.IsInRole("Administrator") || context.Principal.IsInRole("Ministry Admin");

                return hasClaim;
            }

            return false;


        }
    }
}