using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AfsluttendeProjekt.Service;
using AfsluttendeProjekt.Models;
using System.Globalization;

namespace AfsluttendeProjekt.HelperMethods
{
    public static class JobHistoryHelperMethod
    {
        public static JobHistoryDateModelView[] GetStatisticsForRunOnceJobs()
        {

            var criteria = ModelPostCreaterMethod.CriteriaForJson("status", "Equals", new List<string>() { "final"});
            var _criteria = ModelPostCreaterMethod.CriteriaForJson("jobHistoryTriggerType", "Equals", new List<string>() { "RunOnceTrigger" });
            var sorting = ModelPostCreaterMethod.CreateSorting("done", "Desc");
            var columns = new List<string> { "done", "status", "jobhistoryTriggerType" };
            var sendingObject = ModelPostCreaterMethod.CreateCombinedObject(new List<Criteria<string>> { criteria, _criteria }, new List<Sorting> { sorting } , columns);


            var result = ServiceCaller.Post<List<JobHistoryModelView>>("/JobHistories/search?page=1&pageSize=50", sendingObject).Result;
            var dates = new JobHistoryDateModelView[12];


            // Makes sure that 12 objects is created for use
            for (var i = 0; i < 12; i++)
            {
                dates[i] = new JobHistoryDateModelView();
                DateTime time = DateTime.Now;

                if (time.Month > i) { dates[i].year = DateTime.Now.Year; }
                else { dates[i].year = DateTime.Now.Year - 1; }

                dates[i].month = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(i+1);
            }

            // Sets the data from the Api to the created objects. 
            foreach (var item in result)
            {
                var isValueFromCurrentYear = item.done.Year == DateTime.Now.Year;
                var isValueFromLastYear = item.done.Month > DateTime.Now.Month && item.done.Year == DateTime.Now.Year - 1;
                var itemIndex = item.done.Month - 1;

                if (isValueFromCurrentYear || isValueFromLastYear) {dates[itemIndex].value += 1;}
            }

            return dates;
        }
    }
}