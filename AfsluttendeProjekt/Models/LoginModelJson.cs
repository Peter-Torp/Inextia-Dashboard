using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AfsluttendeProjekt.Models
{
    public class LoginModelJson
    {
        [JsonProperty]
        public string login { set; get; }
        [JsonProperty]
        public string password { set; get; }

    }
}