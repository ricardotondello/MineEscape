using System;
using System.ComponentModel;

namespace Utils
{
    public static class EnumExtensions
    {
        public static string ToDescriptionString(this Enum enumValue)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])enumValue
                .GetType()
                .GetField(enumValue.ToString())
                .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes[0].Description;
        }
    }
}
