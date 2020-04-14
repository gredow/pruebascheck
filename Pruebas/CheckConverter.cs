using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace Pruebas
{
    public class CheckConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            bool? resultado = null;
            bool algunTrue = false, algunFalse = false;

            foreach (bool isCheked in values){
                if (isCheked){
                    algunTrue = true;
                }
                else
                {
                    algunFalse = true;
                }
            }
            if(algunTrue && !algunFalse)
            {
                resultado = true;
            }else if(algunFalse && !algunTrue)
            {
                resultado = false;
            }
            return resultado;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            object[] estados = new object[] { value, value, value, value, value };
            return estados;
        }
    }
}
