using System.Runtime.Serialization;

namespace CrossFitnessGUI
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