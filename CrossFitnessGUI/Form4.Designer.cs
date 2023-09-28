namespace CrossFitnessGUI
{
    partial class Form4
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
            buttonCancella = new Button();
            buttonVisualizza = new Button();
            buttonLogOut = new Button();
            buttonEsci = new Button();
            SuspendLayout();
            // 
            // buttonCancella
            // 
            buttonCancella.AllowDrop = true;
            buttonCancella.BackColor = Color.IndianRed;
            buttonCancella.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            buttonCancella.Font = new Font("Sylfaen", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancella.ForeColor = SystemColors.ActiveCaptionText;
            buttonCancella.Location = new Point(1468, 498);
            buttonCancella.Name = "buttonCancella";
            buttonCancella.Size = new Size(245, 144);
            buttonCancella.TabIndex = 0;
            buttonCancella.Text = "Cancella Prenotazioni";
            buttonCancella.UseVisualStyleBackColor = false;
            buttonCancella.Click += buttonCancella_Click;
            // 
            // buttonVisualizza
            // 
            buttonVisualizza.BackColor = Color.FromArgb(0, 192, 192);
            buttonVisualizza.Font = new Font("Sylfaen", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonVisualizza.Location = new Point(1168, 498);
            buttonVisualizza.Name = "buttonVisualizza";
            buttonVisualizza.Size = new Size(267, 135);
            buttonVisualizza.TabIndex = 1;
            buttonVisualizza.Text = "Visualizza Prenotazioni";
            buttonVisualizza.UseVisualStyleBackColor = false;
            buttonVisualizza.Click += buttonVisualizza_Click;
            // 
            // buttonLogOut
            // 
            buttonLogOut.Font = new Font("Sylfaen", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogOut.ForeColor = Color.Red;
            buttonLogOut.Location = new Point(337, 498);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(256, 129);
            buttonLogOut.TabIndex = 2;
            buttonLogOut.Text = "Log Out";
            buttonLogOut.UseVisualStyleBackColor = true;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // buttonEsci
            // 
            buttonEsci.Font = new Font("Sylfaen", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEsci.ForeColor = Color.Red;
            buttonEsci.Location = new Point(81, 498);
            buttonEsci.Name = "buttonEsci";
            buttonEsci.Size = new Size(235, 129);
            buttonEsci.TabIndex = 3;
            buttonEsci.Text = "Chiudi Applicazione";
            buttonEsci.UseVisualStyleBackColor = true;
            buttonEsci.Click += buttonEsci_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1743, 677);
            Controls.Add(buttonEsci);
            Controls.Add(buttonLogOut);
            Controls.Add(buttonVisualizza);
            Controls.Add(buttonCancella);
            Name = "Form4";
            Text = "CrossFitness";
            Load += Form4_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCancella;
        private Button buttonVisualizza;
        private Button buttonLogOut;
        private Button buttonEsci;
    }
}