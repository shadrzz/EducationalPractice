using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalPractice.Utils.Extension
{
    public static class OrderExtensions
    {
        /// <summary>
        /// Проверяет, что строка не является пустой или null.
        /// </summary>
        /// <param name="input">Проверяемая строка.</param>
        /// <param name="fieldName">Название поля (для сообщения об ошибке).</param>
        /// <returns>True, если строка валидна; иначе False.</returns>
        public static bool ValidateInput(this string input, string fieldName, out string errorMessage)
        {
            if (string.IsNullOrEmpty(input))
            {
                errorMessage = $"Поле '{fieldName}' пустое.";
                return false;
            }

            errorMessage = null;
            return true;
        }
    }
}
