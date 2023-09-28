
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
                checkboxListLez = new List<String> { };
                int lenght = checkboxListLez.Count;
                string[] words = responseString.Split('\n');

                foreach (var word in words)
                {
                    checkboxListLez.Add(word);

                }
                CheckBox[] boxes = new CheckBox[checkboxListLez.Count];

                for (int i = 0; i < checkboxListLez.Count; i = i + 6)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        CheckBox box = new CheckBox();
                        box.Tag = i.ToString();
                        box.AutoSize = true;
                        box.Font = new Font("Sylfaen", 10F, FontStyle.Regular, GraphicsUnit.Point);
                        box.Location = new Point((i * 60) + 20, (j * 45) + 20);                        
                        int n = i / 6;

                        if (n <= 4)
                        {
                            int prova2 = j + (6 * n);

                            box.Text = checkboxListLez[prova2];
                            this.Controls.Add(box);

                            boxes[i] = box;
                        }

                        box.CheckStateChanged += new EventHandler(checkbox_Checked);
                    }
                }
            }
            else
                MessageBox.Show("Errore del server");
        }
        async void checkbox_Checked(object sender, EventArgs e)
        {
            CheckBox box = sender as CheckBox;
            CheckList.Add(box);
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
            Application.Exit();
        }
    }
}