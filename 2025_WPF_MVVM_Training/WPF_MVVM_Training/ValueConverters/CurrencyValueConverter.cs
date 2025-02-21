using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WPF_MVVM_Training.ValueConverters
{
    public class CurrencyValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            decimal val = (decimal)value;

            string currency = (string)parameter;

            if (currency is null)
            {
                currency = "€";
            }

            return val.ToString("0.00") + currency;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string val = (string)value;

            val = val.Replace((string)parameter, "").Trim();

            decimal res = decimal.Parse(val);

            return res;
            
        }
    }
}
