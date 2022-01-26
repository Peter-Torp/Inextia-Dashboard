using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

namespace AfsluttendeProjekt.Models
{
    // Should be renamed to PostJsonModel

    public class Criteria<T>
    {
        public string field { get; set; }
        public string @operator { get; set; }
        public List<T> values { get; set; }
    }

    public class Sorting
    {
        public string field { get; set; }
        public string direction { get; set; }
    }

    public class CompontentModelJson<T>
    {

        public List<Criteria<T>> criteria { get; set; }
        public List<Sorting> sorting { get; set; }
        public List<string> columns { get; set; }

        public CompontentModelJson()
        {
            criteria = new List<Criteria<T>>();
            sorting = new List<Sorting>();
            columns = new List<string>();

        }

       
    }

   



}