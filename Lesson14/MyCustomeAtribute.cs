using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lesson14
{
    public class MyCustomeAtribute: ValidationAttribute
    {
        public string Regex { get; set; }

        public override bool IsValid(object value)
        {
            
            Regex regex = new Regex(Regex);
            MatchCollection matches = regex.Matches(value.ToString());
            if (matches.Count > 0)
            {
                return true;
            }
            else
            {
                this.ErrorMessage = "Неверный формат имени";
            }
            return false;
        }
    }
}
