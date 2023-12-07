


namespace ReflectionExample
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        ///  Explain how Reflection works in C# and create a small program to demonstrate the concept.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}