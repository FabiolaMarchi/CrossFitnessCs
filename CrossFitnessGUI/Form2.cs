using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private async void buttonConferma_Click(object sender, EventArgs e)
        {
            if (textBoxPswCrea.Text == textBoxPswCreaConferma.Text)
            {
                var values = new Dictionary<string, string>
                {
                    { "User", textBoxUserCrea.Text },
                    { "Password:", textBoxPswCrea.Text }
                };
                var content = new FormUrlEncodedContent(values);
                var response = await client.PostAsync("http://localhost:60080/crea_account", content);
                if (response.IsSuccessStatusCode)
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Account Creato");

                    Form3 formthree = new Form3();
                    formthree.username = textBoxUserCrea.Text;
                    formthree.Show();
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
