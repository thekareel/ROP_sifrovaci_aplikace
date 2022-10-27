
namespace SifrovaciAplikace
{
    partial class FormNastaveni
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
            this.panelOkraj = new System.Windows.Forms.Panel();
            this.panelLista = new System.Windows.Forms.Panel();
            this.labelPopisNastaveni = new System.Windows.Forms.Label();
            this.trackBarDelkaKlice = new System.Windows.Forms.TrackBar();
            this.labelDelkaKlice = new System.Windows.Forms.Label();
            this.buttonUlozit = new System.Windows.Forms.Button();
            this.panelOkraj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDelkaKlice)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOkraj
            // 
            this.panelOkraj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOkraj.Controls.Add(this.buttonUlozit);
            this.panelOkraj.Controls.Add(this.labelDelkaKlice);
            this.panelOkraj.Controls.Add(this.trackBarDelkaKlice);
            this.panelOkraj.Controls.Add(this.labelPopisNastaveni);
            this.panelOkraj.Controls.Add(this.panelLista);
            this.panelOkraj.Location = new System.Drawing.Point(0, 0);
            this.panelOkraj.Name = "panelOkraj";
            this.panelOkraj.Size = new System.Drawing.Size(500, 275);
            this.panelOkraj.TabIndex = 0;
            // 
            // panelLista
            // 
            this.panelLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.panelLista.Location = new System.Drawing.Point(0, 0);
            this.panelLista.Name = "panelLista";
            this.panelLista.Size = new System.Drawing.Size(500, 40);
            this.panelLista.TabIndex = 4;
            // 
            // labelPopisNastaveni
            // 
            this.labelPopisNastaveni.AutoSize = true;
            this.labelPopisNastaveni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelPopisNastaveni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelPopisNastaveni.Location = new System.Drawing.Point(173, 70);
            this.labelPopisNastaveni.Name = "labelPopisNastaveni";
            this.labelPopisNastaveni.Size = new System.Drawing.Size(152, 20);
            this.labelPopisNastaveni.TabIndex = 2;
            this.labelPopisNastaveni.Text = "Zvolte délku klíče:";
            // 
            // trackBarDelkaKlice
            // 
            this.trackBarDelkaKlice.LargeChange = 1;
            this.trackBarDelkaKlice.Location = new System.Drawing.Point(49, 115);
            this.trackBarDelkaKlice.Maximum = 15;
            this.trackBarDelkaKlice.Minimum = 1;
            this.trackBarDelkaKlice.Name = "trackBarDelkaKlice";
            this.trackBarDelkaKlice.Size = new System.Drawing.Size(400, 45);
            this.trackBarDelkaKlice.TabIndex = 0;
            this.trackBarDelkaKlice.Value = 4;
            this.trackBarDelkaKlice.Scroll += new System.EventHandler(this.trackBarDelkaKlice_Scroll);
            // 
            // labelDelkaKlice
            // 
            this.labelDelkaKlice.AutoSize = true;
            this.labelDelkaKlice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelDelkaKlice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelDelkaKlice.Location = new System.Drawing.Point(235, 165);
            this.labelDelkaKlice.Name = "labelDelkaKlice";
            this.labelDelkaKlice.Size = new System.Drawing.Size(0, 20);
            this.labelDelkaKlice.TabIndex = 3;
            // 
            // buttonUlozit
            // 
            this.buttonUlozit.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonUlozit.FlatAppearance.BorderSize = 0;
            this.buttonUlozit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUlozit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonUlozit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonUlozit.Location = new System.Drawing.Point(199, 215);
            this.buttonUlozit.Name = "buttonUlozit";
            this.buttonUlozit.Size = new System.Drawing.Size(100, 50);
            this.buttonUlozit.TabIndex = 1;
            this.buttonUlozit.Text = "ULOŽIT";
            this.buttonUlozit.UseVisualStyleBackColor = false;
            this.buttonUlozit.Click += new System.EventHandler(this.buttonUlozit_Click);
            // 
            // FormNastaveni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(500, 275);
            this.Controls.Add(this.panelOkraj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNastaveni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormNastaveni";
            this.Load += new System.EventHandler(this.FormNastaveni_Load);
            this.panelOkraj.ResumeLayout(false);
            this.panelOkraj.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDelkaKlice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOkraj;
        private System.Windows.Forms.Button buttonUlozit;
        private System.Windows.Forms.Label labelDelkaKlice;
        private System.Windows.Forms.TrackBar trackBarDelkaKlice;
        private System.Windows.Forms.Label labelPopisNastaveni;
        private System.Windows.Forms.Panel panelLista;
    }
}