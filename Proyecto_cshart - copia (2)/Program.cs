namespace Proyecto_cshart
{
    internal static class Program
    {
        public static AcademicManager manager = new AcademicManager();
        [STAThread]
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();

            
            manager.LoadData(); // cargar datos

            Application.Run(new Startfrom());
        }
    }
}