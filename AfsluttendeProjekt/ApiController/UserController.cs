using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using AfsluttendeProjekt.Models;
using Newtonsoft.Json;
using AfsluttendeProjekt.ApiController;
using System.Text;
using AfsluttendeProjekt.Service;

namespace AfsluttendeProjekt.ApiController
{
    [HandleError]
    public class UserController : Controller 
    {
        public ActionResult Index() // login view From is from [HttpPost] Login
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string userN, string pWord) // method login  
        {
            // Creating a model to post a login informations
            LoginModelJson login = new LoginModelJson
            {
                login = userN,
                password = pWord
            };

            if (!string.IsNullOrWhiteSpace(login.login) && !string.IsNullOrWhiteSpace(login.password))
            {
                var response = ServiceCaller.Post<LoginTokenModelJson>("/Auth", login).Result; // Service caller for post



                if (response?.accessToken != null)
                {
                    Session["access"] = response.accessToken;

                    return RedirectToAction("Index", "widget");
                }
            }

            ViewBag.Message = "Sorry, we couldn't log you in."; // return a error login message
            return View("index"); 

        }
    }
}