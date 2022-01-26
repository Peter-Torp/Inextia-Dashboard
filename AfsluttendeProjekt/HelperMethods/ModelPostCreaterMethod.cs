using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AfsluttendeProjekt.Models;

namespace AfsluttendeProjekt.HelperMethods
{
    public static class ModelPostCreaterMethod
    {

        public static Criteria<string> CriteriaForJson(string _field, string _operator, List<string> _values)
        {
            return new Criteria<string>
            {
                field = _field,
                @operator = _operator,
                values = _values
            };
        }

        // has a different value than the other Criteria
        public static Criteria<bool> CreateCriteria(string _field, string _operator, List<bool> _values) // Create Criteria for post model
        {
            return new Criteria<bool>
            {
                field = _field,
                @operator = _operator,
                values = _values
            };
        }

        public static Sorting CreateSorting(string _field, string _direction) // Create Sorting for post model
        {
            return new Sorting
            {
                field = _field,
                direction = _direction
            };
        }

        public static CompontentModelJson<string> CreateCombinedObject(List<Criteria<string>> _criteria, List<Sorting> _sorting, List<string> _columns )
        {
            return new CompontentModelJson<string>
            {
                criteria = _criteria,
                sorting = _sorting,
                columns =_columns
            };
        }

        public static CompontentModelJson<bool> CreateCombinedObject(List<Criteria<bool>> _criteria, List<Sorting> _sorting, List<string> _columns)
        {
            return new CompontentModelJson<bool>
            {
                criteria = _criteria,
                sorting = _sorting,
                columns = _columns
            };
        }
    }
}