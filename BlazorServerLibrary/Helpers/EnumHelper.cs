using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace BlazorServerLibrary.Helpers
{
    public static class EnumHelper
    {
        public static string GetDisplayName(this Enum enumType)
        {
            var displayName = enumType.GetType().GetMember(enumType.ToString())
                           .First()
                           .GetCustomAttribute<DisplayAttribute>();

            if(displayName == null)
            {
                return enumType.ToString();
            }

            return displayName.Name;
        }
    }
}
