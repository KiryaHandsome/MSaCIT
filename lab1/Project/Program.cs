using System.Diagnostics;

namespace Project
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {   
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}