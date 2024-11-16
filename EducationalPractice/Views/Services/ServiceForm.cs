using EducationalPractice.Controllers;
using EducationalPractice.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationalPractice.Views.Services
{
    public partial class ServiceForm : Form
    {
        private readonly ServiceController serviceController;

        public ServiceForm(ServiceController serviceController)
        {
            InitializeComponent();
            this.serviceController = serviceController;
        }

        private void ServiceForm_Load(object sender, EventArgs e)
        {
            var serviceNames = serviceController.GetServiceNames();
            servicesCheckedListBox.Items.AddRange(serviceNames.ToArray());
        }

        private void servicesCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //string serviceName = servicesCheckedListBox.Items[e.Index].ToString();
            //bool isSelected = e.NewValue == CheckState.Checked;

            //decimal totalCost = serviceController.HandleServiceSelection(serviceName, isSelected);
            //costValue.Text = $"{totalCost} руб.";

            // Получаем выбранный элемент как объект Service
            Service selectedService = serviceController.GetServices()[e.Index];

            MessageBox.Show($"{e.Index}");

            if (selectedService == null)
                return; // Если услуга не найдена, выходим

            int serviceId = selectedService.Id; // Получаем ID услуги
            bool isSelected = e.NewValue == CheckState.Checked;

            // Передаём ID услуги вместо имени
            decimal totalCost = serviceController.HandleServiceSelection(serviceId, isSelected);
            costValue.Text = $"{totalCost} руб.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (serviceController.GetTotalCost() == 0)
            {
                MessageBox.Show($"Выберите хотя бы одну услугу.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show($"Заказ успешно оформлен.\nУслуги: {string.Join(", ", serviceController.GetSelectedServiceNames())}\nСтоимость: {serviceController.GetTotalCost()} руб.\nВремя выполнения: {serviceController.GetTotalTime()}", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
