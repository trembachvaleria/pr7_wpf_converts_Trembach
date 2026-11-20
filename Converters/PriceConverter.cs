using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace pr7_wpf_converts_Trembach.Converters
{
    public class PriceConverter : IValueConverter
    {
        //рубли в копейки
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is float f)
            {
                return (int)(f * 100);
            }
            return 0;
        }

        //комейки в рубли
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (float.TryParse(value?.ToString(), NumberStyles.Float, culture, out float kopecks))
            {
                return kopecks / 100f;
            }
            return 0f;
        }
    }

}
