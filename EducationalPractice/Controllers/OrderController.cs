using EducationalPractice.Utils;

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
            return ["Юридическое лицо (ЮЛ)", "Физическое лицо (ФЛ)"];
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
                   .AsEnumerable()
                   .Select(order => order.Id)
                   .DefaultIfEmpty(0)
                   .Max() + 1;
        }
    }
}
