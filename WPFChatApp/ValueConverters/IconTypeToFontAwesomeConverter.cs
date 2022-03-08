﻿using System;
using System.Globalization;
using WPFChatApp.Core;

namespace WPFChatApp
{
    /// <summary>
    /// A converter that takes in a <see cref="IconType"/> and returns
    /// the FontAwesome string for that icon
    /// </summary>
    public class IconTypeToFontAwesomeConverter : BaseValueConverter<IconTypeToFontAwesomeConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((IconType)value).ToFontAwesome();
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
