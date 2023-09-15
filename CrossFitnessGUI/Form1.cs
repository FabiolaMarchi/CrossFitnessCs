
namespace CrossFitnessGUI
{
    public partial class Form1 : Form
    {
        //private HttpClientHandler clientHandler;

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
            return;

        }

        private async void OKbutton_Click(object sender, EventArgs e)
        {
            var values = new Dictionary<string, string>
            {
                { "User", textBoxLogin.Text },
                { "Password:", textBoxPsw.Text }
            };

            //var valore = "ciao";
            //var content = new StringContent(valore, Encoding.UTF8, "text/plain");
            var content = new FormUrlEncodedContent(values);

            //var response = await client.GetAsync("http://localhost:60080/json");
            var response = await client.PostAsync("http://localhost:60080/login", content);
            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                MessageBox.Show("Cliente loggato!");
                Form3 formthree = new Form3();
                formthree.username = textBoxLogin.Text;
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