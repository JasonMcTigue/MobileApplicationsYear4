using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace SavingsAccumulator.Converters
{
    public class BoolVisibilityConverter : IValueConverter
    {
        //This class stops the program from crashing is  bool is not entered.
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is bool) {
                if ((bool)value)
                    return Visibility.Visible;
                else
                    return Visibility.Collapsed;
            }

            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
