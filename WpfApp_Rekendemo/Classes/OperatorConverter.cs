using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_Rekendemo.Classes
{
    public class OperatorConverter : System.Windows.Data.IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            oSom.eOperators op = (oSom.eOperators)value;
            switch (op)
            {
                case oSom.eOperators.add:
                    return "+";
                case oSom.eOperators.subtract:
                    return "-";
                case oSom.eOperators.multiply:
                    return "*";
                case oSom.eOperators.divide:
                    return "/";
                default:
                    return "+";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string sOp = (string)value;
            switch (sOp)
            {
                case "+":
                    return oSom.eOperators.add;
                case "-":
                    return oSom.eOperators.subtract;
                case "*":
                    return oSom.eOperators.multiply;
                case "/":
                    return oSom.eOperators.divide;
                default:
                    return oSom.eOperators.add;
            }
        }
    }
    
}
