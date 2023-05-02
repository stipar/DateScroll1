using System.Globalization;

namespace MauiApp3.Converters
{
    public class FechaConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DateTime fecha = (DateTime)value;
            return fecha.Date.ToString("dd");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return false;
        }
    }
}
