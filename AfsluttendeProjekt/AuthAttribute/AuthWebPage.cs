using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Threading;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;
using AfsluttendeProjekt.Models;
using Newtonsoft.Json;


namespace AfsluttendeProjekt.AuthAttribute
{
    
    public class AuthWebPage : ActionFilterAttribute
    {
        

        public override void OnActionExecuting(ActionExecutingContext filterContext) 
        {
            try
            {
                if (string.IsNullOrWhiteSpace(HttpContext.Current.Session["access"]?.ToString())) // needs another check
                {
                    filterContext.Result = new RedirectResult("User/Index");
                }
            }
            catch (Exception)
            {

                throw;

            }

           
        }
    }
}