using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AfsluttendeProjekt.Models
{
    public class JobModelView
    {

        public string jobNo { get; set; }
        public bool isOverDue { get; set; }

        public string description { get; set; }
        public int count { get; set; }
    }

   
}