using System.Diagnostics;

namespace Project
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            string code = File.ReadAllText(@"E:\labs_4sem\MSISIT\lab1\Project\File.cpp");
            foreach (var pair in HolstedMetrics.FindOperators(code))
            {
                Debug.WriteLine(pair.ToString());
            }
            
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}