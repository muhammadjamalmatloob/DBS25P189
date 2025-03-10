using System.Threading.Tasks;
namespace MidProject
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        
        public static void Main() 
        {
            ApplicationConfiguration.Initialize();
            // Show the Loading form
            Application.Run(new Login());

        }
    }
}