﻿using EducationalPractice.Models;
using EducationalPractice.Utils;

namespace EducationalPractice.Controllers
{
    public class ServiceController
    {
        private readonly ApplicationDbContext _context; // Контекст базы данных
        private List<Service> selectedServices; // Хранение объектов выбранных услуг

        public ServiceController(ApplicationDbContext context)
        {
            _context = context;
            selectedServices = new List<Service>();
        }

        public List<Service> GetServices()
        {
            return _context.Services.ToList();
        }

        public List<string> GetServiceNames()
        {
            return _context.Services.Select(s => s.ServiceName).ToList();
        }

        public void ClearSelectedServices()
        {
            selectedServices.Clear();
        }

        public void UpdateSelectedService(int serviceId, bool isSelected)
        {
            var service = _context.Services.FirstOrDefault(s => s.Id == serviceId);
            if (service == null)
                return;

            if (isSelected)
            {
                selectedServices.Add(service);
            }
            else
            {
                selectedServices.Remove(service);
            }
        }

        public int GetSelectedServiceCount()
        {
            return selectedServices.Count;
        }

        public string GetSelectedServiceNames()
        {
            return string.Join(", ", selectedServices.Select(s => s.ServiceName));
        }

        public string GetSelectedServiceIds()
        {
            return string.Join(", ", selectedServices.Select(s => s.Id));
        }

        public decimal GetTotalCost()
        {
            return selectedServices.Sum(s => decimal.Parse(s.RusCosmeticsPrice));
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
