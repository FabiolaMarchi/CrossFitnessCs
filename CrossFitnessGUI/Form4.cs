
using System.Text;
using System.Text.Json;

namespace CrossFitnessGUI
{
    public partial class Form4 : Form
    {
        public List<CheckBox> CheckList = new List<CheckBox> { };
        public List<String> checkboxListLez;
        private HttpClient client;
        public string username;
        public Form4()
        {
            InitializeComponent();
            client = new HttpClient();
        }

        private async void Form4_Load(object sender, EventArgs e)
        {
            string url = "http://localhost:60080/lezioni";
            var response = await client.GetAsync(url);
            var responseString = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                //checkboxListLez = new List<String> { };
                //int lenght = checkboxListLez.Count;
                string[] lezioni = responseString.Split('\n');
                string[] giorni = { "Lunedi'", "Martedi'", "Mercoledi'", "Giovedi'", "Venerdi'", "Sabato", "Domenica" };
                int columns = 0;
                int rows = 0;

                /*foreach (var lezione in lezioni)
                {
                    checkboxListLez.Add(lezione);

                }*/
                foreach (String day in giorni)
                {
                    if (responseString.Contains(day))
                    {
                        columns += 1;
                    }
                }

                rows = lezioni.Length / columns;
                //CheckBox[] boxes = new CheckBox[checkboxListLez.Count];

                for (int col = 0; col < columns; col++)
                {
                    int j = col * rows;
                    for (int row = 0; row < rows; row++)
                    {
                        int i = row + j;
                        CheckBox box = new CheckBox();
                        box.Tag = "ciao2";
                        box.AutoSize = true;
                        box.Font = new Font("Sylfaen", 10F, FontStyle.Regular, GraphicsUnit.Point);
                        box.Location = new Point((col * 350) + 30, (row * 50) + 20);
                        box.Text = lezioni[i];
                        this.Controls.Add(box);
                        box.Click += new EventHandler(checkbox_Checked);


                    }

                }
            }
            else
                MessageBox.Show("Errore del server");
        }
        async void checkbox_Checked(object sender, EventArgs e)
        {
            CheckBox box = sender as CheckBox;
            //CheckList.Add(box);
            var values = new Dictionary<string, string>
            {
                { "Username:", username },
                { "Lezione:", box.Text }
            };
            var json = JsonSerializer.Serialize(values);
            string url = "http://localhost:60080/prenotazioni";
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(url, content);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Prenotata effettuata con successo!");               
                
            }
            else
                MessageBox.Show("Hai già una prenotazione per questa lezione, non è possibile prenotarla nuovamente!");
            box.CheckState = CheckState.Unchecked;
        }
        private async void buttonCancella_Click(object sender, EventArgs e)
        {

            var values = new Dictionary<string, string>
            {
                { "Username:", username },
                { "Lezione:", "" }
            };

            var json = JsonSerializer.Serialize(values);
            string url = "http://localhost:60080/prenotazioni";
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(url, content);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Cancellazione Effettuata con successo!");
            }
            else
                MessageBox.Show("Errore del server!");

        }

        private async void buttonVisualizza_Click(object sender, EventArgs e)
        {
            var json = JsonSerializer.Serialize(username);
            string url = "http://localhost:60080/user";
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(url, content);
            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                MessageBox.Show(responseString);
            }
            else
                MessageBox.Show("Non hai effettuato alcuna prenotazione!");
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Log Out effettuato con successo!");
            this.Hide();
            Form1 formOne = new Form1();
            formOne.Show();
            return;
        }

        private void buttonEsci_Click(object sender, EventArgs e)
        {
            client.Dispose();
            Application.Exit();
        }
    }
}