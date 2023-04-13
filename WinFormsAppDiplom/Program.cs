namespace WinFormsAppDiplom
{
    internal static class Program
    {
        private const string  ConnectionString= "Server=(localdb)\\mssqllocaldb;Database=ScenarioEditor;Trusted_Connection=True;";
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new AuthForm(ConnectionString));
        }
    }
}