using System.ComponentModel.DataAnnotations;

namespace EducationalPractice.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ServiceCode { get; set; }
        public string ExecutionTime { get; set; }
        public string AverageDeviation { get; set; }
        public decimal Cost { get; set; }
        public decimal CostForRussianCosmetics { get; set; }

        public Service(int id, string name, string serviceCode, string executionTime, string averageDeviation, decimal cost, decimal costForRussianCosmetics)
        {
            Id = id;
            Name = name;
            ServiceCode = serviceCode;
            ExecutionTime = executionTime;
            AverageDeviation = averageDeviation;
            Cost = cost;
            CostForRussianCosmetics = costForRussianCosmetics;
        }
    }
}
