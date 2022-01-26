using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AfsluttendeProjekt.Models
{
    
    public class Crit
    {
        public string field { get; set; }
        public string @operator { get; set; }
        public List<string> values { get; set; }
    }

    public class Sort
    {
        public string field { get; set; }
        public string direction { get; set; }
    }

    public class JobHistoryModelJson
    {
        public List<Crit> crit { get; set; }
        public List<Sort> sort { get; set; }
        public List<string> columns { get; set; }

        public JobHistoryModelJson()
        {
            crit = new List<Crit>();
            sort = new List<Sort>();
            columns = new List<string>();

        }

    }


}