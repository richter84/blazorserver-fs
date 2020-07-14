using BlazorServerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorServerLibrary.Helpers
{
    public static class EnumToSelect
    {
        public static List<EnumOption> PopulateOptions<TEnum>() where TEnum : Enum
        {
            List<EnumOption> list = new List<EnumOption>();
            foreach (TEnum item in Enum.GetValues(typeof(TEnum)))
            {
                var text = EnumHelper.GetDisplayName((TEnum)Enum.Parse(typeof(TEnum), item.ToString()));
                list.Add(new EnumOption { Text = text, Value = item.ToString() });
            }

            return list;
        }
    }
}
