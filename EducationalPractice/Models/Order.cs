using System.ComponentModel.DataAnnotations;

namespace EducationalPractice.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public string CreationDate { get; set; }
        public string ClientId { get; set; }
        public string Services { get; set; }
        public string Status { get; set; }
        public string? ClosingDate { get; set; }
        public string EmployeeId { get; set; }
        public string ExecutionTime { get; set; }

        public Order(int id, string orderNumber, string creationDate, string clientId, string services,
                     string status, string? closingDate, string employeeId, string executionTime)
        {
            Id = id;
            OrderNumber = orderNumber;
            CreationDate = creationDate;
            ClientId = clientId;
            Services = services;
            Status = status;
            ClosingDate = closingDate;
            EmployeeId = employeeId;
            ExecutionTime = executionTime;
        }
    }
}
