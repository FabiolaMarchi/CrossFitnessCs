namespace CrossFitnessGUI
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            textBoxUserCrea = new TextBox();
            textBoxPswCrea = new TextBox();
            textBoxPswCreaConferma = new TextBox();
            labelnome = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonConferma = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.dumpbell_gym_fitness_icon_179835;
            pictureBox1.Location = new Point(273, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBoxUserCrea
            // 
            textBoxUserCrea.Location = new Point(240, 307);
            textBoxUserCrea.Multiline = true;
            textBoxUserCrea.Name = "textBoxUserCrea";
            textBoxUserCrea.Size = new Size(263, 51);
            textBoxUserCrea.TabIndex = 1;
            // 
            // textBoxPswCrea
            // 
            textBoxPswCrea.Location = new Point(240, 379);
            textBoxPswCrea.Multiline = true;
            textBoxPswCrea.Name = "textBoxPswCrea";
            textBoxPswCrea.PasswordChar = '*';
            textBoxPswCrea.Size = new Size(260, 51);
            textBoxPswCrea.TabIndex = 3;
            // 
            // textBoxPswCreaConferma
            // 
            textBoxPswCreaConferma.Location = new Point(237, 454);
            textBoxPswCreaConferma.Multiline = true;
            textBoxPswCreaConferma.Name = "textBoxPswCreaConferma";
            textBoxPswCreaConferma.PasswordChar = '*';
            textBoxPswCreaConferma.Size = new Size(263, 49);
            textBoxPswCreaConferma.TabIndex = 4;
            // 
            // labelnome
            // 
            labelnome.AutoSize = true;
            labelnome.Font = new Font("Sylfaen", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelnome.ForeColor = Color.Red;
            labelnome.Location = new Point(124, 332);
            labelnome.Name = "labelnome";
            labelnome.Size = new Size(110, 26);
            labelnome.TabIndex = 5;
            labelnome.Text = "Username *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(131, 404);
            label2.Name = "label2";
            label2.Size = new Size(103, 26);
            label2.TabIndex = 7;
            label2.Text = "Password *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sylfaen", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(40, 477);
            label3.Name = "label3";
            label3.Size = new Size(194, 26);
            label3.TabIndex = 8;
            label3.Text = "Conferma Password *";
            // 
            // buttonConferma
            // 
            buttonConferma.BackColor = Color.FromArgb(192, 255, 192);
            buttonConferma.Font = new Font("Sylfaen", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonConferma.Location = new Point(273, 543);
            buttonConferma.Name = "buttonConferma";
            buttonConferma.Size = new Size(189, 53);
            buttonConferma.TabIndex = 9;
            buttonConferma.Text = "Conferma";
            buttonConferma.UseVisualStyleBackColor = false;
            buttonConferma.Click += buttonConferma_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 707);
            Controls.Add(buttonConferma);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(labelnome);
            Controls.Add(textBoxPswCreaConferma);
            Controls.Add(textBoxPswCrea);
            Controls.Add(textBoxUserCrea);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "CrossFitness-Crea Account";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBoxUserCrea;
        private TextBox textBoxPswCrea;
        private TextBox textBoxPswCreaConferma;
        private Label labelnome;
        private Label label2;
        private Label label3;
        private Button buttonConferma;
    }
}