using System;
using System.Globalization;
using System.Windows.Controls;

namespace LablePrintProject.Domain
{
    public class NotEmptyValidationRule : System.Windows.Controls.ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            ValidationResult result;
            result =  string.IsNullOrWhiteSpace((value ?? "").ToString())
                ? new ValidationResult(false, "不能为空！")
                : ValidationResult.ValidResult;
            return result;
        }
    }

}