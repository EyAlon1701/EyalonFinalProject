namespace EyalonFinalProject
{
    internal static class Program
    {
        public const string studentRole = "0";
        public const string lecturerRole = "1";
        public const string adminRole = "2";

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new HomeForm());
        }
    }
}