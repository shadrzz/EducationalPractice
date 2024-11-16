using EducationalPractice.Models;
using EducationalPractice.Utils;

namespace EducationalPractice.Controllers
{
    public class ServiceController
    {
        //private List<Service> services;
        //private List<string> selectedServiceNames;

        //public ServiceController()
        //{
        //    services = DataInitializer.GetServices();
        //    selectedServiceNames = new List<string>();
        //}

        //public List<Service> GetServices() => services;

        //public List<string> GetServiceNames()
        //{
        //    return services.Select(s => s.Name).ToList();
        //}

        //public void UpdateSelectedService(string serviceName, bool isSelected)
        //{
        //    if (isSelected)
        //        selectedServiceNames.Add(serviceName);
        //    else
        //        selectedServiceNames.Remove(serviceName);
        //}

        //public string GetSelectedServiceNames()
        //{
        //    // Список с временными значениями выбранных услуг
        //    var selectedNames = services
        //        .Where(s => selectedServiceNames.Contains(s.Name))
        //        .Select(s => s.Name)
        //        .ToList();

        //    return string.Join(", ", selectedNames);
        //}

        //public decimal GetTotalCost()
        //{
        //    return services
        //        .Where(s => selectedServiceNames.Contains(s.Name))
        //        .Sum(s => s.Cost);
        //}

        //public string GetTotalTime()
        //{
        //    // Список с временными значениями выбранных услуг
        //    var selectedTimes = services
        //        .Where(s => selectedServiceNames.Contains(s.Name))
        //        .Select(s => s.ExecutionTime)
        //        .ToList();

        //    return string.Join(", ", selectedTimes);
        //}

        //public decimal HandleServiceSelection(string serviceName, bool isSelected)
        //{
        //    UpdateSelectedService(serviceName, isSelected);
        //    return GetTotalCost();
        //}


        //private List<Service> services;
        //private List<int> selectedServiceIds; // Изменено на список ID услуг

        //public ServiceController()
        //{
        //    services = DataInitializer.GetServices();
        //    selectedServiceIds = new List<int>();
        //}

        //public List<Service> GetServices() => services;

        //public List<string> GetServiceNames()
        //{
        //    return services.Select(s => s.Name).ToList();
        //}

        //public void UpdateSelectedService(int serviceId, bool isSelected) // Используем ID вместо имени
        //{
        //    if (isSelected)
        //    {
        //        if (!selectedServiceIds.Contains(serviceId)) // Исключаем дублирование
        //            selectedServiceIds.Add(serviceId);
        //    }
        //    else
        //    {
        //        selectedServiceIds.Remove(serviceId);
        //    }
        //}

        //public string GetSelectedServiceNames()
        //{
        //    // Список названий выбранных услуг
        //    var selectedNames = services
        //        .Where(s => selectedServiceIds.Contains(s.Id))
        //        .Select(s => s.Name)
        //        .ToList();

        //    return string.Join(", ", selectedNames);
        //}

        //public decimal GetTotalCost()
        //{
        //    return services
        //        .Where(s => selectedServiceIds.Contains(s.Id))
        //        .Sum(s => s.Cost);
        //}

        //public string GetTotalTime()
        //{
        //    // Список временных значений выбранных услуг
        //    var selectedTimes = services
        //        .Where(s => selectedServiceIds.Contains(s.Id))
        //        .Select(s => s.ExecutionTime)
        //        .ToList();

        //    // Преобразование в удобный формат (можно заменить на более сложный расчет, как в предыдущем коде)
        //    return string.Join(", ", selectedTimes);
        //}

        //public decimal HandleServiceSelection(int serviceId, bool isSelected) // Используем ID
        //{
        //    UpdateSelectedService(serviceId, isSelected);
        //    return GetTotalCost();
        //}

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

        public string GetSelectedServiceNames()
        {
            return string.Join(", ", selectedServices.Select(s => s.Name));
        }

        public decimal GetTotalCost()
        {
            return selectedServices.Sum(s => s.Cost);
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