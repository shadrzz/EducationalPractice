using EducationalPractice.Models;
using EducationalPractice.Utils;

namespace EducationalPractice.Controllers
{
    public class ServiceController
    {
        private List<Service> services;
        private List<string> selectedServiceNames;

        public ServiceController()
        {
            services = DataInitializer.GetServices();
            selectedServiceNames = new List<string>();
        }

        public List<Service> GetServices() => services;

        public List<string> GetServiceNames()
        {
            return services.Select(s => s.Name).ToList();
        }

        public void UpdateSelectedService(string serviceName, bool isSelected)
        {
            if (isSelected)
                selectedServiceNames.Add(serviceName);
            else
                selectedServiceNames.Remove(serviceName);
        }

        public decimal GetTotalCost()
        {
            return services
                .Where(s => selectedServiceNames.Contains(s.Name))
                .Sum(s => s.Cost);
        }

        public decimal HandleServiceSelection(string serviceName, bool isSelected)
        {
            UpdateSelectedService(serviceName, isSelected);
            return GetTotalCost();
        }
    }
}
