using EducationalPractice.Models;
using EducationalPractice.Models.Client;
using EducationalPractice.Utils;
using System.Data.SqlClient;

namespace EducationalPractice.Controllers
{
    public class OrderController
    {
        private List<Order> orders;

        public OrderController()
        {
            orders = DataInitializer.GetOrders();
        }

        public List<Order> GetOrders() => orders;

        public string GetNextOrderNumber()
        {
            var lastOrderNumber = orders.Select(order => order.OrderNumber).Max();

            if (!string.IsNullOrEmpty(lastOrderNumber))
            {
                var parts = lastOrderNumber.Split('/');
                if (parts.Length == 2 && int.TryParse(parts[1], out int lastNumber))
                {
                    // Увеличиваем второй элемент
                    return $"{parts[0]}/{lastNumber + 1}";
                }
            }

            return "00000000/0000000";
        }

        private int ParseOrderNumber(string orderNumber)
        {
            if (int.TryParse(orderNumber.Split('/')[0], out int numericPart))
                return numericPart;
            return 0;
        }

        public bool IsUniqueVesselNumber(string vesselNumber)
        {
            return !orders.Any(order => order.OrderNumber.Split('/')[0] == vesselNumber);
        }

        public string ValidateVesselNumber(string vesselNumber)
        {
            if (IsUniqueVesselNumber(vesselNumber))
            {
                return $"Номер сосуда подтвержден: {vesselNumber}";
            }
            else
            {
                return "Этот номер уже существует. Пожалуйста, введите уникальный номер.";
            }
        }

        public string[] GetCustomerTypes()
        {
            return [ "ЮЛ", "ФЛ" ];
        }

        public bool DoesOrderNumberExist(string orderNumber)
        {
            return orders.Any(order => order.OrderNumber == orderNumber);
        }

        public void AddOrder(Order order)
        {
            orders.Add(order);
        }

        public int GetNextOrderId()
        {
            return orders.Select(order => order.Id).Max() + 1;
        }
    }
}
