using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AfsluttendeProjekt.Models;
using AfsluttendeProjekt.Service;
using AfsluttendeProjekt.HelperMethods;
namespace AfsluttendeProjekt.ApiController
{
    public class ItemController : Controller
    {
        public PartialViewResult LowOnItems()
        {

            var viewObject = ItemHelperMethod.GetLowOnItemsCount();

            if (viewObject != null)
            {
                return PartialView(viewObject);
            }

            return PartialView(); // return something else if null
        }
    }
}