﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ToDoList
{
    class PriorityConverter : System.Windows.Data.IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string rawPriority = ((string)value).ToLower();
            if (rawPriority == "high")
            {
                return "Red";
            }
            else if (rawPriority == "medium")
            {
                return "Orange";
            }
            else
            {
                return "Green";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
}
