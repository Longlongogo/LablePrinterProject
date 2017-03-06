using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace LablePrintProject.Domain
{
    public class DigitalOnlyValidationRule : System.Windows.Controls.ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {

            bool isDigital = false;
            string a = (value ?? "").ToString();
            if (!string.IsNullOrWhiteSpace(a))
            {
                try
                {
                    Convert.ToDouble(a);
                    isDigital = true;
                }
                catch
                {
                    isDigital = false;
                }
            }
            else
            {
                isDigital = true;
            }
            ValidationResult result;
            result = isDigital
                ? ValidationResult.ValidResult
                : new ValidationResult(false, null);
            return result;
        }
    }
}
