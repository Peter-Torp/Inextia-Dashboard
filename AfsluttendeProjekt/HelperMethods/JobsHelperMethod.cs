using AfsluttendeProjekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AfsluttendeProjekt.Service;

namespace AfsluttendeProjekt.HelperMethods
{
    public class JobsHelperMethod
    {

        public static JobModelView JobsOverdue()
        {

            var crit = ModelPostCreaterMethod.CreateCriteria("isOverdue", "Equals", new List<bool> { true });
            var sort = ModelPostCreaterMethod.CreateSorting("JobNo","Desc");
            var columns = new List<string> { "JobNo", "isOverdue" };
            var sendingObject = ModelPostCreaterMethod.CreateCombinedObject(new List<Criteria<bool>> { crit }, new List<Sorting> { sort }, columns);

            var result = ServiceCaller.Post<List<JobModelView>>("/Jobs/search", sendingObject).Result;
           

            return new JobModelView
            {
                count = result.Count,
                description = "Overdued Jobs:"
            };
        }


    }
}