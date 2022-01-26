using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AfsluttendeProjekt.Service;
using AfsluttendeProjekt.Models;
using AfsluttendeProjekt.HelperMethods;

namespace AfsluttendeProjekt.ApiController
{
    public class JobHistoryController : Controller
    {
        // GET: JobHistory
      
        public PartialViewResult RunOnceJob()
        {

            var viewOject = JobHistoryHelperMethod.GetStatisticsForRunOnceJobs();

            if (viewOject != null)
            {
                return PartialView(viewOject);
            }

           return PartialView(); // find something to return if result is null
        }


        
    }

}