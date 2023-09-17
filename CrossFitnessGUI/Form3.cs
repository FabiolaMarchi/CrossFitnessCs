using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CrossFitnessGUI
{
    public partial class Form3 : Form
    {
        private HttpClient client;
        public string username;
        public int IDpersone = 0
            ;
        public int IDPrenotazioni = 0;
        public Dictionary<int, String> lezioniDict = new Dictionary<int, String>();
        public List<CheckBox> CheckList = new List<CheckBox> { };
        public List<Prenotazione> PrenotazioneList = new List<Prenotazione>();
        public Prenotazione p;



        public int prenotata(Dictionary<int, String> lezDict, int lezione)
        {
            int flag = 0;
            foreach (var item in lezDict)
            {
                if (item.Key == lezione)
                {
                    flag++;
                }

            }
            return flag;
        }
        public int selezionato(List<CheckBox> CheckList)
        {
            int sel = 0;
            foreach (CheckBox item in CheckList)
            {
                if (item.Checked)
                {
                    sel++;
                }

            }
            return sel;
        }
        public Form3()
        {
            InitializeComponent();
            client = new HttpClient();
        }

        private void buttonEsci_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = username;
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Log Out effettuato con successo!");
            //in caso richiamare lo stesso form2, creo un costruttore gli assegno una variabile e richiamo la variabile.show()
            Form1 formOne = new Form1();
            formOne.Show();
            return;
        }

        private async void buttonprenota_Click(object sender, EventArgs e)
        {
            if (selezionato(CheckList) == 0)
            {
                MessageBox.Show("Devi selezionare almeno una lezione per poter prenotare!");
            }
            else
            {
                string lez = "";
                foreach (var item in lezioniDict)
                {
                    lez = item.Value;

                }

                //p = new Prenotazione(IDPrenotazioni, IDpersone, username, lez);
                //p.setIDPrenotazione(IDPrenotazioni);
                //p.setIDPersona(IDpersone);
                //p.setUsername(username);
                
                foreach (CheckBox item in CheckList)
                {
                    item.CheckState = CheckState.Unchecked;
                }
                Prenotazione p1 = new Prenotazione(IDPrenotazioni, IDpersone, username, lez);
                PrenotazioneList.Add(p1);



                /*
                var myContent = JsonConvert.SerializeObject(p);
                var response = await client.PostAsync("http://localhost:60080/login", content);
                var content = new FormUrlEncodedContent(pren);
                              
                var response = await client.PostAsync("http://localhost:60080/prenotazioni",content);*/

                //var json = p.toJson();
               
                
                //p1.setIDPrenotazione(1);
                //p1.setIDPersona(1);
                //p1.setUsername(username);
                //p1.setLezione("ciao");


                //questo funziona ma si prende solo IDprenotazione
                var json = JsonConvert.SerializeObject(p1);


                
                string url = "http://localhost:60080/prenotazioni";

                // Create a StringContent object with the JSON data
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // Send the POST request with the JSON data
                var response = await client.PostAsync(url, content);



                if (response.IsSuccessStatusCode)
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Prenotazione effettuata con successo!");
                }
                else if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Si e' verificato un errore, riprova!");
                    return;
                }
                
            }
        }

        private void checkBoxLunYoga8_CheckedChanged(object sender, EventArgs e)
        {
            String lez = "Lunedi' " + checkBoxLunYoga8.Text;
            if (checkBoxLunYoga8.Checked)
            {
                CheckList.Add(checkBoxLunYoga8);

                if (prenotata(lezioniDict, 1) == 0)
                {
                    IDPrenotazioni++;
                    lezioniDict.Add(1, lez);
                }
                else
                {
                    checkBoxLunYoga8.CheckState = CheckState.Unchecked;
                    MessageBox.Show("Hai gia' effettuato una prenotazione per questa lezione!");

                }
            }
        }

        private void checkBoxLunCross10_CheckedChanged(object sender, EventArgs e)
        {
            String lez = "Lunedi' " + checkBoxLunCross10.Text;
            if (checkBoxLunCross10.Checked)
            {
                CheckList.Add(checkBoxLunCross10);

                if (prenotata(lezioniDict, 2) == 0)
                {
                    IDPrenotazioni++;
                    lezioniDict.Add(2, lez);
                }
                else
                {
                    checkBoxLunCross10.CheckState = CheckState.Unchecked;
                    MessageBox.Show("Hai gia' effettuato una prenotazione per questa lezione!");

                }
            }
        }

        private void checkBoxLunFunc12_CheckedChanged(object sender, EventArgs e)
        {
            String lez = "Lunedi' " + checkBoxLunFunc12.Text;
            if (checkBoxLunFunc12.Checked)
            {
                CheckList.Add(checkBoxLunFunc12);

                if (prenotata(lezioniDict, 3) == 0)
                {
                    IDPrenotazioni++;
                    lezioniDict.Add(3, lez);
                }
                else
                {
                    checkBoxLunFunc12.CheckState = CheckState.Unchecked;
                    MessageBox.Show("Hai gia' effettuato una prenotazione per questa lezione!");

                }
            }
        }

        private void checkBoxLunYoga14_CheckedChanged(object sender, EventArgs e)
        {
            String lez = "Lunedi' " + checkBoxLunYoga14.Text;
            if (checkBoxLunYoga14.Checked)
            {
                CheckList.Add(checkBoxLunYoga14);

                if (prenotata(lezioniDict, 4) == 0)
                {
                    IDPrenotazioni++;
                    lezioniDict.Add(4, lez);
                }
                else
                {
                    checkBoxLunYoga14.CheckState = CheckState.Unchecked;
                    MessageBox.Show("Hai gia' effettuato una prenotazione per questa lezione!");

                }
            }
        }

        private void checkBoxLunCross16_CheckedChanged(object sender, EventArgs e)
        {
            String lez = "Lunedi' " + checkBoxLunCross16.Text;
            if (checkBoxLunCross16.Checked)
            {
                CheckList.Add(checkBoxLunCross16);

                if (prenotata(lezioniDict, 5) == 0)
                {
                    IDPrenotazioni++;
                    lezioniDict.Add(5, lez);
                }
                else
                {
                    checkBoxLunCross16.CheckState = CheckState.Unchecked;
                    MessageBox.Show("Hai gia' effettuato una prenotazione per questa lezione!");

                }
            }
        }

        private void checkBoxLunFunc18_CheckedChanged(object sender, EventArgs e)
        {
            String lez = "Lunedi' " + checkBoxLunFunc18.Text;
            if (checkBoxLunFunc18.Checked)
            {
                CheckList.Add(checkBoxLunFunc18);

                if (prenotata(lezioniDict, 6) == 0)
                {
                    IDPrenotazioni++;
                    lezioniDict.Add(6, lez);
                }
                else
                {
                    checkBoxLunFunc18.CheckState = CheckState.Unchecked;
                    MessageBox.Show("Hai gia' effettuato una prenotazione per questa lezione!");

                }
            }
        }

        
    }
}
