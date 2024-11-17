using EducationalPractice.Controllers;
using EducationalPractice.Utils;

namespace EducationalPractice
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            var context = new ApplicationDbContext();

            var orderController = new OrderController();
            var clientController = new ClientController(context);
            var serviceController = new ServiceController();

            ApplicationConfiguration.Initialize();
            Application.Run(new OrderForm(orderController, clientController, serviceController));
        }
    }
}