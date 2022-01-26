using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AfsluttendeProjekt.Models
{
    public class ItemModelView
    {
        public string itemNo { get; set; }
        public bool lowOnStock { get; set; }

        public int count { get; set; }

        public string description { get; set; }

    }
}