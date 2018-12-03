using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Lapis
{
	class JobIDConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			for (uint i = 0; i < Info.Instance().Jobs.Count; i++)
			{
				if(Info.Instance().Jobs[(int)i].Value == (uint)value)
				{
					return i;
				}
			}

			return -1;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return Info.Instance().Jobs[(int)value].Value;
		}
	}
}
