using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Runtime.Serialization;

namespace CrossFitnessGUI
{
    [DataContract]
    public class Prenotazione
    {
        [DataMember]
        int IDPrenotazione { get; set; }
        int IDPersona { get; set; }
        String Username { get; set; }
        List<String> LezioneList = new List<string> { };

    Dictionary<int, String> lezioniDict = new Dictionary<int, String>();

        int[] IDPrenotazioniArray = new int[30];


        public Prenotazione(int IDpre, int IDpers, String username, List<String> LezioneList)
        {
            IDPrenotazione = IDpre;
            IDPersona = IDpers;
            Username = username;
            this.LezioneList = LezioneList;

        }

        public Prenotazione()
        {

        }
       
        public int getIDPrenotazione()
        {
            return IDPrenotazione;
        }
        public int getIDPersona()
        {
            return IDPersona;
        }
        public String getUsername()
        {
            return Username;
        }
       

        public String getLezione()
        {
            String s = "";
            foreach (String item in LezioneList)
            {
                s += item;
                s += " ";
            }
            return s;
        }

        public void setIDPrenotazione(int IDPren)
        {
            IDPrenotazione = IDPren;
        }

        public void setIDPersona(int IDPers)
        {
            IDPersona = IDPers;
        }

        public void setUsername(String name)
        {
            Username = name;
        }

        

        public void setLezione(String lezione)
        {
            LezioneList.Add(lezione);
            //lezioniDict.Add(index, lezione);
        }

        public string showPrenotazione()
        {
            String s;
            s = "ID Prenotazione : " + Convert.ToString(getIDPrenotazione()) + "\n" +
                "ID Persona : " + Convert.ToString(getIDPersona()) + "\n" + "Username :" + getUsername() +
                 "\n" + "Prenotazione: " + getLezione() + "\n";
            return s;
        }
        public string toJson()
        {
            return JsonSerializer.Serialize(showPrenotazione());
        }
        

    }

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
            Application.Run(new Form1());
            


        }
    }
}