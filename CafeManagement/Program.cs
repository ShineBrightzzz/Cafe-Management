using CafeManagement.Forms;

namespace CafeManagement
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var projectRoot = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            var dotenvPath = Path.Combine(projectRoot, "DangNhatHuy.env");
            EnvReader.Load(dotenvPath);


            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}
