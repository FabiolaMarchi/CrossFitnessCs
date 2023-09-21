
using System.Text;
using System.Text.Json;

namespace CrossFitnessGUI
{
    public partial class Form1 : Form
    {
        //private HttpClientHandler clientHandler;
        public Dictionary<int, String> lezioniDict = new Dictionary<int, String>();
        private HttpClient client;

        public Form1()
        {
            InitializeComponent();
            // clientHandler = new HttpClientHandler();

            //clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            client = new HttpClient();
            // Pass the handler to httpclient(from you are calling api)
            // HttpClient client = new HttpClient();
        }

        private void CreaAccountButton_Click(object sender, EventArgs e)
        {
            /*var builder = WebApplication.CreateBuilder();
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();

            var app = builder.Build();

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();*/
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
                int i = 1;
                var responseString = await response.Content.ReadAsStringAsync();
                string[] words = responseString.Split('\n');
                foreach (var word in words)
                {
                    
                    lezioniDict.Add(i, word);
                    i++;                    
                }

                MessageBox.Show("Cliente loggato!");
                Form3 formthree = new Form3();

                if (textBoxLogin.Text == "Fabiola")
                {
                    formthree.IDpersone = 1;
                }
                else if (textBoxLogin.Text == "Matteo")
                {
                    formthree.IDpersone = 2;
                }
                this.Hide();
                formthree.username = textBoxLogin.Text;
                formthree.lezioniDict = lezioniDict;
                formthree.Show();
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
    }
}