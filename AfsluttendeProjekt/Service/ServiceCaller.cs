using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using AfsluttendeProjekt.Models;
using System.Text;
using System.Net.Http.Headers;
using AfsluttendeProjekt.ApiController;
using System.Media;
using System.Net;
using System.Threading;
using System.Web.Caching;


namespace AfsluttendeProjekt.Service
{
    public static class ServiceCaller
    {
        [HttpGet]
        public static async Task<T> Get<T>(string url) // Gets the data from url 
        {
            T result = default(T);

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Current.Session["access"].ToString()); // Token is req to get. 
                client.BaseAddress = new Uri("https://development.inextia.dk/api" + url); // Added the rest of the wanted url start with "/ "

                var response = await client.GetStringAsync(client.BaseAddress).ConfigureAwait(false);

                if (!string.IsNullOrWhiteSpace(response))
                {
                    result = JsonConvert.DeserializeObject<T>(response);
                }
            }

            return result;
        }

        [HttpPost]
        public static async Task<T> Post<T>(string url, object postObject)   // Post to the url and taking in a object to serz and send. 
        {
            T result = default(T);

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://development.inextia.dk/api" + url); // Added the rest of the wanted url start with "/ "

                //When loggin in no access token exist. When logged in the acces token is set as authen.
                if (!string.IsNullOrEmpty(HttpContext.Current.Session["access"]?.ToString()))
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Current.Session["access"]?.ToString());
                }

                var ops = await client.PostAsJsonAsync(client.BaseAddress, postObject).ConfigureAwait(false); // check up on what Configure does. 

                if (ops.IsSuccessStatusCode)
                {
                   var message = ops.Content.ReadAsStringAsync();
                   result = JsonConvert.DeserializeObject<T>(message.Result);
                }
               
            }

            return result;
        }
    }

}
