using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace pr7_wpf_converts_Trembach.Converters
{
    public class LowStockConverter : IValueConverter
    {
        //кол красное если меньше остатка
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool isLow && isLow)
            {
                return Brushes.Red;
            }
            return Brushes.Black;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();
    }
}
