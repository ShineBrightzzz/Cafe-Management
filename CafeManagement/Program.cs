using CafeManagement.DAO;
using CafeManagement.Forms;

namespace CafeManagement
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var projectRoot = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            var dotenvPath = Path.Combine(projectRoot, ".env");
            EnvReader.Load(dotenvPath);
            
            CustomerDAO customerDAO = new CustomerDAO();
            customerDAO.AddCustomer(new Entities.Customer("1", "John Doe", "1234567890"));

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormProduct());
            
        }
    }
}
