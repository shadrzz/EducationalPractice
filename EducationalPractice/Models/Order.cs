namespace EducationalPractice.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public string CreationDate { get; set; }
        public string ClientCode { get; set; }
        public List<int> Services { get; set; }
        public string Status { get; set; }
        public string? ClosingDate { get; set; }
        public string EmployeeCode { get; set; }
        public string ExecutionTime { get; set; }

        public Order(int id, string orderNumber, string creationDate, string clientCode, List<int> services,
                     string status, string? closingDate, string employeeCode, string executionTime)
        {
            Id = id;
            OrderNumber = orderNumber;
            CreationDate = creationDate;
            ClientCode = clientCode;
            Services = services;
            Status = status;
            ClosingDate = closingDate;
            EmployeeCode = employeeCode;
            ExecutionTime = executionTime;
        }
    }
}
