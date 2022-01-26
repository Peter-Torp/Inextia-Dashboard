using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;
using AfsluttendeProjekt.Models;
using Newtonsoft.Json;
using AfsluttendeProjekt.AuthAttribute;
using AfsluttendeProjekt.Service;
using AfsluttendeProjekt.HelperMethods;

namespace AfsluttendeProjekt.ApiController
{
    public class JobController : Controller
    {
        // Make to post and another URL, for more pages. 

        
        [AuthWebPage]
        public PartialViewResult Index()
        {

            var viewObject = JobsHelperMethod.JobsOverdue();


            if (viewObject != null)
            {
                return PartialView(viewObject);
            }

            return PartialView(); // return something else if null
           
        }
    }
}