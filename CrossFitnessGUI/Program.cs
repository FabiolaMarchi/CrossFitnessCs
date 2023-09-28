using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace CrossFitnessGUI
{
    [DataContract]
    
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