using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DiagnosticoWeb.Model.Helpers;

namespace DiagnosticoWeb.Helpers
{
    public static class EnumExtensions
    {
        public static IEnumerable<SelectListItem> ToSelectList(this Enum enumValue)
        {
            return from Enum e in Enum.GetValues(enumValue.GetType())
                select new SelectListItem
                {
                    Selected = e.Equals(enumValue),
                    Text = EnumHelpers.GetEnumDescription(e),
                    Value = e.ToString()
                };
        }
    }
}