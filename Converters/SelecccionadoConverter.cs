using System.Globalization;

namespace MauiApp3.Converters
{
    public class SelecccionadoConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool result = (bool)value;
            return result ? Colors.Green : Colors.White;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return false;
        }
    }
}
