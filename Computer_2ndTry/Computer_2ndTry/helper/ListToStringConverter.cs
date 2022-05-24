using Computer_2ndTry.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Computer_2ndTry.helper
{
    public class ListToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var parts = value as ICollection<ComputerPart>;
            string result = "";
            foreach (var part in parts)
            {
                result += "Identiifier" + part.Id + "\t" + part.Brand + "\t" + part.Price + "\t" + part.Category+"\n";
            }
            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }
}
