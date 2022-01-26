using AfsluttendeProjekt.AuthAttribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AfsluttendeProjekt.WidgetController
{
    public class WidgetController : Controller
    {
       //container page for widgets

        [AuthWebPage]
        public ActionResult Index()
        {
            return View();
        }
    }
}