using System.Text;
using System.Text.Json;

namespace CrossFitnessGUI
{
    public partial class Form1 : Form
    {
       
        private HttpClient client;
        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
        }

        private void CreaAccountButton_Click(object sender, EventArgs e)
        {
            Form2 formtwo = new Form2();
            formtwo.Show();
            this.Hide();
        }

        private async void OKbutton_Click(object sender, EventArgs e)
        {
            var values = new Dictionary<string, string>
            {
                { "User:", textBoxLogin.Text },
                { "Password:", textBoxPsw.Text }
            };

            var json = JsonSerializer.Serialize(values);
            string url = "http://localhost:60080/login";
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(url, content);
            if (response.IsSuccessStatusCode)
            {                
                MessageBox.Show("Cliente loggato!");               
                Form4 form4 = new Form4();
                form4.username = textBoxLogin.Text;                
                this.Hide();                
                form4.Show();
                return;
            }
            else if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("Credenziali errate, riprova!");
                return;
            }
        }

        private void buttonEsci_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}