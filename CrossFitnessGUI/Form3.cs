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
        public Prenotazione p1;



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

        private async void buttonCancella_Click(object sender, EventArgs e)
        {
            if (PrenotazioneList.Count != 0)
            {
                PrenotazioneList.Clear();
                lezioniDict.Clear();
                IDPrenotazioni = 0;
                p1 = new Prenotazione(0, IDpersone, username, "");
                var json = JsonConvert.SerializeObject(p1);
                string url = "http://localhost:60080/prenotazioni";
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                
                var response = await client.PostAsync(url, content);
                

                if (response.IsSuccessStatusCode)
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Hai cancellato correttamente la tua prenotazione!");
                }
                else if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Si e' verificato un errore, riprova!");
                    return;
                }

                
            }
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

                foreach (CheckBox item in CheckList)
                {
                    item.CheckState = CheckState.Unchecked;
                }
                p1 = new Prenotazione(IDPrenotazioni, IDpersone, username, lez);
                PrenotazioneList.Add(p1);

                var json = JsonConvert.SerializeObject(p1);
                string url = "http://localhost:60080/prenotazioni";
                var content = new StringContent(json, Encoding.UTF8, "application/json");
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

        private void checkBoxMarAcrYo8_CheckedChanged(object sender, EventArgs e)
        {
            String lez = "Martedi' " + checkBoxMarAcrYo8.Text;
            if (checkBoxMarAcrYo8.Checked)
            {
                CheckList.Add(checkBoxMarAcrYo8);

                if (prenotata(lezioniDict, 7) == 0)
                {
                    IDPrenotazioni++;
                    lezioniDict.Add(7, lez);
                }
                else
                {
                    checkBoxMarAcrYo8.CheckState = CheckState.Unchecked;
                    MessageBox.Show("Hai gia' effettuato una prenotazione per questa lezione!");

                }
            }
        }

        private void checkBoxMarCrossCla10_CheckedChanged(object sender, EventArgs e)
        {
            String lez = "Martedi' " + checkBoxMarCrossCla10.Text;
            if (checkBoxMarCrossCla10.Checked)
            {
                CheckList.Add(checkBoxMarCrossCla10);

                if (prenotata(lezioniDict, 8) == 0)
                {
                    IDPrenotazioni++;
                    lezioniDict.Add(8, lez);
                }
                else
                {
                    checkBoxMarCrossCla10.CheckState = CheckState.Unchecked;
                    MessageBox.Show("Hai gia' effettuato una prenotazione per questa lezione!");

                }
            }
        }

        private void checkBoxMarFuncCla12_CheckedChanged(object sender, EventArgs e)
        {
            String lez = "Martedi' " + checkBoxMarFuncCla12.Text;
            if (checkBoxMarFuncCla12.Checked)
            {
                CheckList.Add(checkBoxMarFuncCla12);

                if (prenotata(lezioniDict, 9) == 0)
                {
                    IDPrenotazioni++;
                    lezioniDict.Add(9, lez);
                }
                else
                {
                    checkBoxMarFuncCla12.CheckState = CheckState.Unchecked;
                    MessageBox.Show("Hai gia' effettuato una prenotazione per questa lezione!");

                }
            }
        }

        private void checkBoxMarAcrYoga14_CheckedChanged(object sender, EventArgs e)
        {
            String lez = "Martedi' " + checkBoxMarAcrYoga14.Text;
            if (checkBoxMarAcrYoga14.Checked)
            {
                CheckList.Add(checkBoxMarAcrYoga14);

                if (prenotata(lezioniDict, 10) == 0)
                {
                    IDPrenotazioni++;
                    lezioniDict.Add(10, lez);
                }
                else
                {
                    checkBoxMarAcrYoga14.CheckState = CheckState.Unchecked;
                    MessageBox.Show("Hai gia' effettuato una prenotazione per questa lezione!");

                }
            }
        }

        private void checkBoxMarCrossCla16_CheckedChanged(object sender, EventArgs e)
        {
            String lez = "Martedi' " + checkBoxMarCrossCla16.Text;
            if (checkBoxMarCrossCla16.Checked)
            {
                CheckList.Add(checkBoxMarCrossCla16);

                if (prenotata(lezioniDict, 11) == 0)
                {
                    IDPrenotazioni++;
                    lezioniDict.Add(11, lez);
                }
                else
                {
                    checkBoxMarCrossCla16.CheckState = CheckState.Unchecked;
                    MessageBox.Show("Hai gia' effettuato una prenotazione per questa lezione!");

                }
            }
        }

        private void checkBoxMarFuncCla18_CheckedChanged(object sender, EventArgs e)
        {
            String lez = "Martedi' " + checkBoxMarFuncCla18.Text;
            if (checkBoxMarFuncCla18.Checked)
            {
                CheckList.Add(checkBoxMarFuncCla18);

                if (prenotata(lezioniDict, 12) == 0)
                {
                    IDPrenotazioni++;
                    lezioniDict.Add(12, lez);
                }
                else
                {
                    checkBoxMarFuncCla18.CheckState = CheckState.Unchecked;
                    MessageBox.Show("Hai gia' effettuato una prenotazione per questa lezione!");

                }
            }
        }

        private void checkBoxMerYoga8_CheckedChanged(object sender, EventArgs e)
        {
            String lez = "Mercoledi' " + checkBoxMerYoga8.Text;
            if (checkBoxMerYoga8.Checked)
            {
                CheckList.Add(checkBoxMerYoga8);

                if (prenotata(lezioniDict, 13) == 0)
                {
                    IDPrenotazioni++;
                    lezioniDict.Add(13, lez);
                }
                else
                {
                    checkBoxMerYoga8.CheckState = CheckState.Unchecked;
                    MessageBox.Show("Hai gia' effettuato una prenotazione per questa lezione!");

                }
            }
        }

        private void checkBoxMerCross10_CheckedChanged(object sender, EventArgs e)
        {
            String lez = "Mercoledi' " + checkBoxMerCross10.Text;
            if (checkBoxMerCross10.Checked)
            {
                CheckList.Add(checkBoxMerCross10);

                if (prenotata(lezioniDict, 14) == 0)
                {
                    IDPrenotazioni++;
                    lezioniDict.Add(14, lez);
                }
                else
                {
                    checkBoxMerCross10.CheckState = CheckState.Unchecked;
                    MessageBox.Show("Hai gia' effettuato una prenotazione per questa lezione!");

                }
            }
        }

        private void checkBoxMerFun12_CheckedChanged(object sender, EventArgs e)
        {
            String lez = "Mercoledi' " + checkBoxMerFun12.Text;
            if (checkBoxMerFun12.Checked)
            {
                CheckList.Add(checkBoxMerFun12);

                if (prenotata(lezioniDict, 15) == 0)
                {
                    IDPrenotazioni++;
                    lezioniDict.Add(15, lez);
                }
                else
                {
                    checkBoxMerFun12.CheckState = CheckState.Unchecked;
                    MessageBox.Show("Hai gia' effettuato una prenotazione per questa lezione!");

                }
            }
        }

        private void checkBoxMerYoga14_CheckedChanged(object sender, EventArgs e)
        {
            String lez = "Mercoledi' " + checkBoxMerYoga14.Text;
            if (checkBoxMerYoga14.Checked)
            {
                CheckList.Add(checkBoxMerYoga14);

                if (prenotata(lezioniDict, 16) == 0)
                {
                    IDPrenotazioni++;
                    lezioniDict.Add(16, lez);
                }
                else
                {
                    checkBoxMerYoga14.CheckState = CheckState.Unchecked;
                    MessageBox.Show("Hai gia' effettuato una prenotazione per questa lezione!");

                }
            }
        }

        private void checkBoxMerCross16_CheckedChanged(object sender, EventArgs e)
        {
            String lez = "Mercoledi' " + checkBoxMerCross16.Text;
            if (checkBoxMerCross16.Checked)
            {
                CheckList.Add(checkBoxMerCross16);

                if (prenotata(lezioniDict, 17) == 0)
                {
                    IDPrenotazioni++;
                    lezioniDict.Add(17, lez);
                }
                else
                {
                    checkBoxMerCross16.CheckState = CheckState.Unchecked;
                    MessageBox.Show("Hai gia' effettuato una prenotazione per questa lezione!");

                }
            }
        }

        private void checkBoxMerFunc18_CheckedChanged(object sender, EventArgs e)
        {
            String lez = "Mercoledi' " + checkBoxMerFunc18.Text;
            if (checkBoxMerFunc18.Checked)
            {
                CheckList.Add(checkBoxMerFunc18);

                if (prenotata(lezioniDict, 18) == 0)
                {
                    IDPrenotazioni++;
                    lezioniDict.Add(18, lez);
                }
                else
                {
                    checkBoxMerFunc18.CheckState = CheckState.Unchecked;
                    MessageBox.Show("Hai gia' effettuato una prenotazione per questa lezione!");

                }
            }
        }

        private void checkBoxGioAcrYoga8_CheckedChanged(object sender, EventArgs e)
        {
            String lez = "Giovedi' " + checkBoxGioAcrYoga8.Text;
            if (checkBoxGioAcrYoga8.Checked)
            {
                CheckList.Add(checkBoxGioAcrYoga8);

                if (prenotata(lezioniDict, 19) == 0)
                {
                    IDPrenotazioni++;
                    lezioniDict.Add(19, lez);
                }
                else
                {
                    checkBoxGioAcrYoga8.CheckState = CheckState.Unchecked;
                    MessageBox.Show("Hai gia' effettuato una prenotazione per questa lezione!");

                }
            }
        }

        private void checkBoxGioCrossCla10_CheckedChanged(object sender, EventArgs e)
        {
            String lez = "Giovedi' " + checkBoxGioCrossCla10.Text;
            if (checkBoxGioCrossCla10.Checked)
            {
                CheckList.Add(checkBoxGioCrossCla10);

                if (prenotata(lezioniDict, 20) == 0)
                {
                    IDPrenotazioni++;
                    lezioniDict.Add(20, lez);
                }
                else
                {
                    checkBoxGioCrossCla10.CheckState = CheckState.Unchecked;
                    MessageBox.Show("Hai gia' effettuato una prenotazione per questa lezione!");

                }
            }
        }

        private void checkBoxGioFunCla12_CheckedChanged(object sender, EventArgs e)
        {
            String lez = "Giovedi' " + checkBoxGioFunCla12.Text;
            if (checkBoxGioFunCla12.Checked)
            {
                CheckList.Add(checkBoxGioFunCla12);

                if (prenotata(lezioniDict, 21) == 0)
                {
                    IDPrenotazioni++;
                    lezioniDict.Add(21, lez);
                }
                else
                {
                    checkBoxGioFunCla12.CheckState = CheckState.Unchecked;
                    MessageBox.Show("Hai gia' effettuato una prenotazione per questa lezione!");

                }
            }
        }

        private void checkBoxGioAcrYoga14_CheckedChanged(object sender, EventArgs e)
        {
            String lez = "Giovedi' " + checkBoxGioAcrYoga14.Text;
            if (checkBoxGioAcrYoga14.Checked)
            {
                CheckList.Add(checkBoxGioAcrYoga14);

                if (prenotata(lezioniDict, 22) == 0)
                {
                    IDPrenotazioni++;
                    lezioniDict.Add(22, lez);
                }
                else
                {
                    checkBoxGioAcrYoga14.CheckState = CheckState.Unchecked;
                    MessageBox.Show("Hai gia' effettuato una prenotazione per questa lezione!");

                }
            }
        }

        private void checkBoxGioCrossCla16_CheckedChanged(object sender, EventArgs e)
        {
            String lez = "Giovedi' " + checkBoxGioCrossCla16.Text;
            if (checkBoxGioCrossCla16.Checked)
            {
                CheckList.Add(checkBoxGioCrossCla16);

                if (prenotata(lezioniDict, 23) == 0)
                {
                    IDPrenotazioni++;
                    lezioniDict.Add(21, lez);
                }
                else
                {
                    checkBoxGioCrossCla16.CheckState = CheckState.Unchecked;
                    MessageBox.Show("Hai gia' effettuato una prenotazione per questa lezione!");

                }
            }
        }

        private void checkBoxGioFuncCla18_CheckedChanged(object sender, EventArgs e)
        {
            String lez = "Giovedi' " + checkBoxGioFuncCla18.Text;
            if (checkBoxGioFuncCla18.Checked)
            {
                CheckList.Add(checkBoxGioFuncCla18);

                if (prenotata(lezioniDict, 24) == 0)
                {
                    IDPrenotazioni++;
                    lezioniDict.Add(24, lez);
                }
                else
                {
                    checkBoxGioFuncCla18.CheckState = CheckState.Unchecked;
                    MessageBox.Show("Hai gia' effettuato una prenotazione per questa lezione!");

                }
            }
        }

        private void checkBoxVenYoga8_CheckedChanged(object sender, EventArgs e)
        {
            String lez = "Venerdi' " + checkBoxVenYoga8.Text;
            if (checkBoxVenYoga8.Checked)
            {
                CheckList.Add(checkBoxVenYoga8);

                if (prenotata(lezioniDict, 25) == 0)
                {
                    IDPrenotazioni++;
                    lezioniDict.Add(25, lez);
                }
                else
                {
                    checkBoxVenYoga8.CheckState = CheckState.Unchecked;
                    MessageBox.Show("Hai gia' effettuato una prenotazione per questa lezione!");

                }
            }
        }

        private void checkBoxVenCross10_CheckedChanged(object sender, EventArgs e)
        {
            String lez = "Venerdi' " + checkBoxVenCross10.Text;
            if (checkBoxVenCross10.Checked)
            {
                CheckList.Add(checkBoxVenCross10);

                if (prenotata(lezioniDict, 26) == 0)
                {
                    IDPrenotazioni++;
                    lezioniDict.Add(26, lez);
                }
                else
                {
                    checkBoxVenCross10.CheckState = CheckState.Unchecked;
                    MessageBox.Show("Hai gia' effettuato una prenotazione per questa lezione!");

                }
            }
        }

        private void checkBoxVenFunc12_CheckedChanged(object sender, EventArgs e)
        {
            String lez = "Venerdi' " + checkBoxVenFunc12.Text;
            if (checkBoxVenFunc12.Checked)
            {
                CheckList.Add(checkBoxVenFunc12);

                if (prenotata(lezioniDict, 27) == 0)
                {
                    IDPrenotazioni++;
                    lezioniDict.Add(27, lez);
                }
                else
                {
                    checkBoxVenFunc12.CheckState = CheckState.Unchecked;
                    MessageBox.Show("Hai gia' effettuato una prenotazione per questa lezione!");

                }
            }
        }

        private void checkBoxVenYoga14_CheckedChanged(object sender, EventArgs e)
        {
            String lez = "Venerdi' " + checkBoxVenYoga14.Text;
            if (checkBoxVenYoga14.Checked)
            {
                CheckList.Add(checkBoxVenYoga14);

                if (prenotata(lezioniDict, 28) == 0)
                {
                    IDPrenotazioni++;
                    lezioniDict.Add(28, lez);
                }
                else
                {
                    checkBoxVenYoga14.CheckState = CheckState.Unchecked;
                    MessageBox.Show("Hai gia' effettuato una prenotazione per questa lezione!");

                }
            }
        }

        private void checkBoxVenCross16_CheckedChanged(object sender, EventArgs e)
        {
            String lez = "Venerdi' " + checkBoxVenCross16.Text;
            if (checkBoxVenCross16.Checked)
            {
                CheckList.Add(checkBoxVenCross16);

                if (prenotata(lezioniDict, 29) == 0)
                {
                    IDPrenotazioni++;
                    lezioniDict.Add(29, lez);
                }
                else
                {
                    checkBoxVenCross16.CheckState = CheckState.Unchecked;
                    MessageBox.Show("Hai gia' effettuato una prenotazione per questa lezione!");

                }
            }
        }

        private void checkBoxVenFunc18_CheckedChanged(object sender, EventArgs e)
        {
            String lez = "Venerdi' " + checkBoxVenFunc18.Text;
            if (checkBoxVenFunc18.Checked)
            {
                CheckList.Add(checkBoxVenFunc18);

                if (prenotata(lezioniDict, 30) == 0)
                {
                    IDPrenotazioni++;
                    lezioniDict.Add(30, lez);
                }
                else
                {
                    checkBoxVenFunc18.CheckState = CheckState.Unchecked;
                    MessageBox.Show("Hai gia' effettuato una prenotazione per questa lezione!");

                }
            }
        }

        private void buttonVisualizza_Click(object sender, EventArgs e)
        {
            if (PrenotazioneList.Count == 0)
            {
                MessageBox.Show("Non ci sono prenotazioni!");
            }
            else
            {
                MessageBox.Show(p1.showPrenotazione());
            }
        }

        
    }
}
