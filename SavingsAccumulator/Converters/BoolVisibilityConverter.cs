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
        //If object is false when program is ran add page should be collapsed
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is bool) {
                if ((bool)value)
                    return Visibility.Visible;//when add button is pressed this method is triggered and update page is visible
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
