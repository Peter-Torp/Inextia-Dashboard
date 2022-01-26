using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AfsluttendeProjekt.Models
{
   
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        
        public class BudgetCostEstimate
        {
          
            public double value { get; set; }
            public string currencyNo { get; set; }
        }

        public class EstimatedCosts
        {
            public double value { get; set; }
            public string currencyNo { get; set; }
        }

        public class Link
        {
            public string key { get; set; }
            public string url { get; set; }
        }

        public class JobModelJson
        {
            public string jobNo { get; set; }
            public string name { get; set; }
            public string text { get; set; }
            public string componentNo { get; set; }
            public string componentName { get; set; }
            public string classification { get; set; }
            public bool criticalEquipment { get; set; }
            public int maxExceedingDays { get; set; }
            public bool classRelated { get; set; }
            public bool technicalFile { get; set; }
            public BudgetCostEstimate budgetCostEstimate { get; set; }
            public bool isActivated { get; set; }
            public bool isIdle { get; set; }
            public bool isPostponed { get; set; }
            public bool isOverdue { get; set; }
            public double estimatedHours { get; set; }
            public EstimatedCosts estimatedCosts { get; set; }
            public string standardCurrency { get; set; }
            public string componentNoStructure { get; set; }
            public string componentNameStructure { get; set; }
            public string formTemplatesAsString { get; set; }
            public string formTemplateNamesAsString { get; set; }
            public bool isMainJob { get; set; }
            public int jobOrder { get; set; }
            public string updateUserNo { get; set; }
            public string updateUserName { get; set; }
            public DateTime updateDate { get; set; }
            public string createUserNo { get; set; }
            public string createUserName { get; set; }
            public DateTime createDate { get; set; }
            public string guid { get; set; }
            public string unitGuid { get; set; }
            public string latestHistoryGuid { get; set; }
            public List<Link> links { get; set; }
            
        }


}