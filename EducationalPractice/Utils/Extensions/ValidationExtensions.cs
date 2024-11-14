using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalPractice.Utils.Extensions
{
    public static class ValidationExtensions
    {
        public static bool ValidateTextBoxNotEmpty(TextBox textBox)
        {
            return !string.IsNullOrWhiteSpace(textBox.Text);
        }
    }
}
