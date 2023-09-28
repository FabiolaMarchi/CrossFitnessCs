namespace CrossFitnessGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CreaAccountButton = new Button();
            OKbutton = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBoxLogin = new TextBox();
            pictureBox2 = new PictureBox();
            textBoxPsw = new TextBox();
            pictureBox3 = new PictureBox();
            buttonEsci = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // CreaAccountButton
            // 
            CreaAccountButton.BackColor = Color.FromArgb(255, 255, 192);
            CreaAccountButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CreaAccountButton.Location = new Point(217, 704);
            CreaAccountButton.Name = "CreaAccountButton";
            CreaAccountButton.Size = new Size(299, 54);
            CreaAccountButton.TabIndex = 0;
            CreaAccountButton.Text = "Crea Account";
            CreaAccountButton.UseVisualStyleBackColor = false;
            CreaAccountButton.Click += CreaAccountButton_Click;
            // 
            // OKbutton
            // 
            OKbutton.BackColor = Color.FromArgb(192, 255, 192);
            OKbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            OKbutton.Location = new Point(217, 620);
            OKbutton.Name = "OKbutton";
            OKbutton.Size = new Size(299, 65);
            OKbutton.TabIndex = 1;
            OKbutton.Text = "OK";
            OKbutton.UseVisualStyleBackColor = false;
            OKbutton.Click += OKbutton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.dumpbell_gym_fitness_icon_179835;
            pictureBox1.Location = new Point(307, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Historic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(226, 262);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(290, 107);
            textBox1.TabIndex = 3;
            textBox1.Text = "Effettua il LogIn per prenotare lezioni";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(226, 427);
            textBoxLogin.Multiline = true;
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(290, 58);
            textBoxLogin.TabIndex = 4;
            textBoxLogin.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.userIco;
            pictureBox2.Location = new Point(150, 427);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 59);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // textBoxPsw
            // 
            textBoxPsw.Location = new Point(226, 514);
            textBoxPsw.Multiline = true;
            textBoxPsw.Name = "textBoxPsw";
            textBoxPsw.PasswordChar = '*';
            textBoxPsw.Size = new Size(290, 57);
            textBoxPsw.TabIndex = 6;
            textBoxPsw.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.pswIco;
            pictureBox3.Location = new Point(150, 514);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(65, 57);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // buttonEsci
            // 
            buttonEsci.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEsci.Location = new Point(217, 776);
            buttonEsci.Name = "buttonEsci";
            buttonEsci.Size = new Size(299, 40);
            buttonEsci.TabIndex = 8;
            buttonEsci.Text = "Esci";
            buttonEsci.UseVisualStyleBackColor = true;
            buttonEsci.Click += buttonEsci_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 887);
            Controls.Add(buttonEsci);
            Controls.Add(pictureBox3);
            Controls.Add(textBoxPsw);
            Controls.Add(pictureBox2);
            Controls.Add(textBoxLogin);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(OKbutton);
            Controls.Add(CreaAccountButton);
            Name = "Form1";
            Text = "CrossFitness - Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CreaAccountButton;
        private Button OKbutton;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBoxLogin;
        private PictureBox pictureBox2;
        private TextBox textBoxPsw;
        private PictureBox pictureBox3;
        private Button buttonEsci;
    }
}