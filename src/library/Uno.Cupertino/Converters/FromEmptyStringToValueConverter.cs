﻿using System;
using System.Collections.Generic;
using System.Text;

#if WinUI
using Microsoft.UI.Xaml.Data;
#else
using Windows.UI.Xaml.Data;
#endif

namespace Uno.Cupertino
{
	public class FromEmptyStringToValueConverter : IValueConverter
	{
		public object NullOrEmptyValue { get; set; }

		public object NotNullOrEmptyValue { get; set; }

		public object Convert(object value, Type targetType, object parameter, string language)
		{
			if (!(value is string str) || string.IsNullOrEmpty(str))
			{
				return NullOrEmptyValue;
			}

			return NotNullOrEmptyValue;
		}

		public object ConvertBack(object value, Type targetType, object parameter, string language)
		{
			throw new NotSupportedException();
		}
	}
}
