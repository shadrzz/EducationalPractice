namespace EducationalPractice.Models;

public partial class Service
{
    public int Id { get; set; }

    public string? ServiceName { get; set; }

    public string? ServiceCode { get; set; }

    public string? ExecutionTime { get; set; }

    public string? AverageDeviation { get; set; }

    public string? Price { get; set; }

    public string? RusCosmeticsPrice { get; set; }

    public Service(int id, string serviceName, string serviceCode, string executionTime, string averageDeviation, string price, string rusCosmeticsPrice)
    {
        Id = id;
        ServiceName = serviceName;
        ServiceCode = serviceCode;
        ExecutionTime = executionTime;
        AverageDeviation = averageDeviation;
        Price = price;
        RusCosmeticsPrice = rusCosmeticsPrice;
    }
}
