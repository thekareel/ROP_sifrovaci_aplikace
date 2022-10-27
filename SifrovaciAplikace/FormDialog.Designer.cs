
namespace SifrovaciAplikace
{
    partial class FormDialog
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
            this.labelSymbol = new System.Windows.Forms.Label();
            this.labelZprava = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.panelLista = new System.Windows.Forms.Panel();
            this.panelOkraj.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOkraj
            // 
            this.panelOkraj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOkraj.Controls.Add(this.labelSymbol);
            this.panelOkraj.Controls.Add(this.labelZprava);
            this.panelOkraj.Controls.Add(this.buttonOK);
            this.panelOkraj.Controls.Add(this.panelLista);
            this.panelOkraj.Location = new System.Drawing.Point(0, 0);
            this.panelOkraj.Name = "panelOkraj";
            this.panelOkraj.Size = new System.Drawing.Size(500, 200);
            this.panelOkraj.TabIndex = 0;
            // 
            // labelSymbol
            // 
            this.labelSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.labelSymbol.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelSymbol.Location = new System.Drawing.Point(10, 50);
            this.labelSymbol.Name = "labelSymbol";
            this.labelSymbol.Size = new System.Drawing.Size(100, 100);
            this.labelSymbol.TabIndex = 3;
            this.labelSymbol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelZprava
            // 
            this.labelZprava.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelZprava.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelZprava.Location = new System.Drawing.Point(124, 67);
            this.labelZprava.Name = "labelZprava";
            this.labelZprava.Size = new System.Drawing.Size(250, 65);
            this.labelZprava.TabIndex = 2;
            this.labelZprava.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonOK.FlatAppearance.BorderSize = 0;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonOK.Location = new System.Drawing.Point(199, 140);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 50);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // panelLista
            // 
            this.panelLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.panelLista.Location = new System.Drawing.Point(0, 0);
            this.panelLista.Name = "panelLista";
            this.panelLista.Size = new System.Drawing.Size(500, 40);
            this.panelLista.TabIndex = 0;
            // 
            // FormDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(500, 200);
            this.Controls.Add(this.panelOkraj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelOkraj.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOkraj;
        private System.Windows.Forms.Label labelSymbol;
        private System.Windows.Forms.Label labelZprava;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Panel panelLista;
    }
}