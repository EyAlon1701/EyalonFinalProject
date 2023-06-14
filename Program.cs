namespace EyalonFinalProject
{
    internal static class Program
    {
        //Roles
        public const string STUDENT_ROLE = "0";
        public const string LECTURER_ROLE = "1";
        public const string ADMIN_ROLE = "2";

        public const int MAX_STUDENTS_PER_PAGE = 2;

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