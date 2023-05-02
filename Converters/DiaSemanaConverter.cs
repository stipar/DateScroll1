using System.Globalization;

namespace MauiApp3.Converters
{
    public class DiaSemanaConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DateTime fecha = (DateTime)value;

            return fecha.DayOfWeek.ToString()[..3];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return false;
        }
    }
}
