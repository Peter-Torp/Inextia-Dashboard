using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AfsluttendeProjekt.Service;
using AfsluttendeProjekt.Models;

namespace AfsluttendeProjekt.HelperMethods
{
    public class ItemHelperMethod
    {

        public static ItemModelView GetLowOnItemsCount()
        {
            //Creating search criterias 
            var criteria = ModelPostCreaterMethod.CreateCriteria("lowOnStock", "Equals", new List<bool> { true });
            var sorting = ModelPostCreaterMethod.CreateSorting("ItemNo", "Asc");
            var columns = new List<string> { "ItemNo", "lowOnStock" };
            var sendingPost = ModelPostCreaterMethod.CreateCombinedObject(new List<Criteria<bool>> { criteria }, new List<Sorting> { sorting }, columns);

            List<ItemModelView> result = ServiceCaller.Post<List<ItemModelView>>("/Items/search", sendingPost).Result;
            
            return new ItemModelView
            {
                count = result.Count,
                description = "Item out of stock:"
            };
        }
    }
}