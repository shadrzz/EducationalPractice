using EducationalPractice.Models;
using EducationalPractice.Utils;

namespace EducationalPractice.Controllers
{
    internal class ServiceController
    {
        private List<Service> services;

        public ServiceController()
        {
            services = DataInitializer.GetServices();
        }

        public List<Service> GetServices() => services;

        public decimal CalculateTotalCost(List<string> selectedServices)
        {
            return services
                .Where(s => selectedServices.Contains(s.Name))
                .Sum(s => s.Cost);
        }
    }
}
