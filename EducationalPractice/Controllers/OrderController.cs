//using EducationalPractice.Utils;

//namespace EducationalPractice.Controllers
//{
//    public class OrderController
//    {
//        private List<Order> orders;

//        public OrderController()
//        {
//            orders = DataInitializer.GetOrders();
//        }

//        public string GetNextOrderNumber()
//        {
//            var lastOrderNumber = orders.Select(order => order.OrderNumber).Max();

//            if (!string.IsNullOrEmpty(lastOrderNumber))
//            {
//                var parts = lastOrderNumber.Split('/');
//                if (parts.Length == 2 && int.TryParse(parts[1], out int lastNumber))
//                {
//                    // Увеличиваем второй элемент
//                    return $"{parts[0]}/{lastNumber + 1}";
//                }
//            }

//            return "00000000/0000000";
//        }

//        public string[] GetCustomerTypes()
//        {
//            return ["Юридическое лицо (ЮЛ)", "Физическое лицо (ФЛ)"];
//        }

//        public bool DoesOrderNumberExist(string orderNumber)
//        {
//            return orders.Any(order => order.OrderNumber == orderNumber);
//        }

//        public void AddOrder(Order order)
//        {
//            orders.Add(order);
//        }

//        public int GetNextOrderId()
//        {
//            return orders.Select(order => order.Id).Max() + 1;
//        }
//    }
//}

using EducationalPractice.Models;
using EducationalPractice.Utils;
using System.Collections.Generic;
using System.Linq;

namespace EducationalPractice.Controllers
{
    public class OrderController
    {
        private readonly ApplicationDbContext _context;

        public OrderController(ApplicationDbContext context)
        {
            _context = context;
        }

        public string GetNextOrderNumber()
        {
            var lastOrderNumber = _context.Orders
                .OrderByDescending(o => o.Id)
                .Select(o => o.OrderNumber)
                .FirstOrDefault();

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

        public string[] GetCustomerTypes()
        {
            return new[] { "Юридическое лицо (ЮЛ)", "Физическое лицо (ФЛ)" };
        }

        public bool DoesOrderNumberExist(string orderNumber)
        {
            return _context.Orders.Any(order => order.OrderNumber == orderNumber);
        }

        public void AddOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public int GetNextOrderId()
        {
            return _context.Orders
                   .AsEnumerable() // Переключаемся на обработку данных на стороне клиента
                   .Select(order => order.Id)
                   .DefaultIfEmpty(0) // Обработка случая, когда таблица пуста
                   .Max() + 1;        // Получаем следующий Id
        }
    }
}
