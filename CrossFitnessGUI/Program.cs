using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace CrossFitnessGUI
{
    [DataContract]
    public class Prenotazione
    {
        //[DataMember]
        [JsonProperty("IDPrenotazione:")]
        public int IDPrenotazione { get; set; }
        [JsonProperty("IDPersona:")]
        public int IDPersona { get; set; }
        [JsonProperty("Username:")]
        public String Username { get; set; }

        [JsonProperty("LezioneStr:")]
        public string lez;
        //[JsonProperty("Lezionelist:")]
        //public List<String> LezioneList = new List<string> { };

        // [JsonProperty("Lezione:")]
        //public String lezione {  get; set; }

        //[JsonProperty("LezioneDict:")]

        Dictionary<int, String> lezioniDict = new Dictionary<int, String>();

        


        public Prenotazione(int IDpre, int IDpers, String username, string Lezione)
        {
            
            IDPrenotazione = IDpre;
            IDPersona = IDpers;
            Username = username;
            lez = Lezione;

        }

        public Prenotazione(int IDpre, int IDpers, String username, Dictionary<int, String> lezioniDict)
        {
            IDPrenotazione = IDpre;
            IDPersona = IDpers;
            Username = username;
            this.lezioniDict = lezioniDict;

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
            foreach (var item in lezioniDict)
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
      
        public void setLezioneDict(Dictionary<int, String> dict)
        {
            lezioniDict = dict;
        }
       /* public void setLezione(String lezione)
        {
            LezioneList.Add(lezione);
            //lezioniDict.Add(index, lezione);
        }*/

        public string showPrenotazione()
        {
            String s;
            s = "ID Prenotazione:" + Convert.ToString(getIDPrenotazione()) +
                "ID Persona:" + Convert.ToString(getIDPersona()) + "Username:" + getUsername() + "Prenotazione:" + getLezione();
            return s;
        }
        /*public string toJson()
        {
            return JsonSerializer.Serialize(showPrenotazione());
        }*/
        

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