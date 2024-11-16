﻿using EducationalPractice.Models;
using EducationalPractice.Models.Client;
using EducationalPractice.Utils;
using System.Data.SqlClient;

namespace EducationalPractice.Controllers
{
    public class OrderController
    {
        private List<Order> orders;

        public OrderController()
        {
            orders = DataInitializer.GetOrders();
        }

        public List<Order> GetOrders() => orders;

        public string GetNextOrderNumber()
        {
            var lastOrderNumber = orders.Select(order => ParseOrderNumber(order.OrderNumber)).Max();
            return (lastOrderNumber + 1).ToString();
        }

        private int ParseOrderNumber(string orderNumber)
        {
            if (int.TryParse(orderNumber.Split('/')[0], out int numericPart))
                return numericPart;
            return 0;
        }

        public bool IsUniqueVesselNumber(string vesselNumber)
        {
            return !orders.Any(order => order.OrderNumber.Split('/')[0] == vesselNumber);
        }

        public string ValidateVesselNumber(string vesselNumber)
        {
            if (IsUniqueVesselNumber(vesselNumber))
            {
                return $"Номер сосуда подтвержден: {vesselNumber}";
            }
            else
            {
                return "Этот номер уже существует. Пожалуйста, введите уникальный номер.";
            }
        }

        public string[] GetCustomerTypes()
        {
            return [ "ЮЛ", "ФЛ" ];
        }

        public bool DoesOrderNumberExist(string orderNumber)
        {
            return orders.Any(order => order.OrderNumber == orderNumber);
        }
    }
}
