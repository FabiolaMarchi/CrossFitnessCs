using System.Text;
using System.Text.Json;


namespace CrossFitnessGUI
{
    public partial class Form2 : Form
    {
        private HttpClient client;
        public Form2()
        {
            InitializeComponent();
            client = new HttpClient();
        }

        //POST to send credentials to Server C++ and create an account on http://localhost:60080/crea_account 
        private async void buttonConferma_Click(object sender, EventArgs e)
        {
            if (textBoxPswCrea.Text == textBoxPswCreaConferma.Text)
            {
                var values = new Dictionary<string, string>
                {
                    { "User:", textBoxUserCrea.Text },
                    { "Password:", textBoxPswCrea.Text }
                };
                var json = JsonSerializer.Serialize(values);
                string url = "http://localhost:60080/crea_account";
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    //var responseString = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Account Creato");
                    this.Hide();
                    Form4 form4 = new Form4();
                    form4.username = textBoxUserCrea.Text;
                    form4.Show();
                    return;
                }
                else if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Si e' verificato un errore, riprova!");
                    return;
                }
            }

        }
    }
}
