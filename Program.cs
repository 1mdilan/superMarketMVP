using superMarketMVP.Model;
using superMarketMVP.Views;
using superMarketMVP.Repositories;
using superMarketMVP.Properties;
using superMarketMVP.Presenters;

namespace superMarketMVP
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
            ApplicationConfiguration.Initialize();
            string sqlConnectionString = Settings.Default.sqlConnection;
            IPayModeView view = new PayModeView();
            IPayModeRepository repository = new PayModeRepository(sqlConnectionString);
            new PayModePresenter (view, repository);
            Application.Run((Form) view);
        }
    }
}