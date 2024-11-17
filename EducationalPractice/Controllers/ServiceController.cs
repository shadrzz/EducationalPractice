using EducationalPractice.Models;
using EducationalPractice.Utils;

namespace EducationalPractice.Controllers
{
    public class ServiceController
    {
        private List<Service> services;
        private List<Service> selectedServices; // Хранение объектов выбранных услуг

        public ServiceController()
        {
            services = DataInitializer.GetServices();
            selectedServices = new List<Service>();
        }

        public List<Service> GetServices() => services;

        public List<string> GetServiceNames()
        {
            return services.Select(s => s.Name).ToList();
        }

        public void ClearSelectedServices()
        {
            selectedServices.Clear();
        }

        public void UpdateSelectedService(int serviceId, bool isSelected)
        {
            var service = services.FirstOrDefault(s => s.Id == serviceId);
            if (service == null)
                return;

            if (isSelected)
            {
                selectedServices.Add(service);
            }
            else
            {
                // Удаляем только первое совпадение, чтобы учитывать дубли
                selectedServices.Remove(service);
            }
        }

        public int GetSelectedServiceCount()
        {
            return selectedServices.Count;
        }

        public string GetSelectedServiceNames()
        {
            return string.Join(", ", selectedServices.Select(s => s.Name));
        }

        public string GetSelectedServiceIds()
        {
            return string.Join(", ", selectedServices.Select(s => s.Id));
        }

        public decimal GetTotalCost()
        {
            return selectedServices.Sum(s => s.CostForRussianCosmetics);
        }

        public string GetTotalTime()
        {
            var selectedTimes = selectedServices.Select(s => s.ExecutionTime).ToList();

            return string.Join(", ", selectedTimes);
        }

        public decimal HandleServiceSelection(int serviceId, bool isSelected)
        {
            UpdateSelectedService(serviceId, isSelected);
            return GetTotalCost();
        }
    }
}