
namespace SifrovaciAplikace
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelLista = new System.Windows.Forms.Panel();
            this.buttonMinimalizovat = new System.Windows.Forms.Button();
            this.buttonZavrit = new System.Windows.Forms.Button();
            this.panelSifry = new System.Windows.Forms.Panel();
            this.buttonAtbash = new System.Windows.Forms.Button();
            this.buttonVernam = new System.Windows.Forms.Button();
            this.buttonVigen = new System.Windows.Forms.Button();
            this.buttonCaesar = new System.Windows.Forms.Button();
            this.buttonROT13 = new System.Windows.Forms.Button();
            this.panelKodovani = new System.Windows.Forms.Panel();
            this.buttonUTF16BE = new System.Windows.Forms.Button();
            this.buttonUTF16LE = new System.Windows.Forms.Button();
            this.buttonUTF8BOM = new System.Windows.Forms.Button();
            this.buttonUTF8 = new System.Windows.Forms.Button();
            this.buttonVybratSoubor = new System.Windows.Forms.Button();
            this.buttonSifrovat = new System.Windows.Forms.Button();
            this.buttonDesifrovat = new System.Windows.Forms.Button();
            this.textBoxNazevNovehoSouboru = new System.Windows.Forms.TextBox();
            this.textBoxKlic = new System.Windows.Forms.TextBox();
            this.buttonVygenerovat = new System.Windows.Forms.Button();
            this.buttonNastaveni = new System.Windows.Forms.Button();
            this.checkBoxVytvoritSoubor = new System.Windows.Forms.CheckBox();
            this.buttonSpustit = new System.Windows.Forms.Button();
            this.buttonVybratKlic = new System.Windows.Forms.Button();
            this.buttonZrusit = new System.Windows.Forms.Button();
            this.labelSlozka = new System.Windows.Forms.Label();
            this.labelNazevVybranehoSouboru = new System.Windows.Forms.Label();
            this.labelKodovani = new System.Windows.Forms.Label();
            this.labelNazevNovehoSouboru = new System.Windows.Forms.Label();
            this.labelKlic = new System.Windows.Forms.Label();
            this.openFileDialogSoubor = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogKlic = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelLista.SuspendLayout();
            this.panelSifry.SuspendLayout();
            this.panelKodovani.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLista
            // 
            this.panelLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.panelLista.Controls.Add(this.buttonMinimalizovat);
            this.panelLista.Controls.Add(this.buttonZavrit);
            this.panelLista.Location = new System.Drawing.Point(0, 0);
            this.panelLista.Name = "panelLista";
            this.panelLista.Size = new System.Drawing.Size(950, 40);
            this.panelLista.TabIndex = 13;
            this.panelLista.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLista_MouseDown);
            this.panelLista.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelLista_MouseMove);
            // 
            // buttonMinimalizovat
            // 
            this.buttonMinimalizovat.FlatAppearance.BorderSize = 0;
            this.buttonMinimalizovat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimalizovat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMinimalizovat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonMinimalizovat.Location = new System.Drawing.Point(870, 0);
            this.buttonMinimalizovat.Name = "buttonMinimalizovat";
            this.buttonMinimalizovat.Size = new System.Drawing.Size(40, 40);
            this.buttonMinimalizovat.TabIndex = 0;
            this.buttonMinimalizovat.Text = "_";
            this.buttonMinimalizovat.UseVisualStyleBackColor = true;
            this.buttonMinimalizovat.Click += new System.EventHandler(this.buttonMinimalizovat_Click);
            // 
            // buttonZavrit
            // 
            this.buttonZavrit.FlatAppearance.BorderSize = 0;
            this.buttonZavrit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZavrit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZavrit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonZavrit.Location = new System.Drawing.Point(910, 0);
            this.buttonZavrit.Name = "buttonZavrit";
            this.buttonZavrit.Size = new System.Drawing.Size(40, 40);
            this.buttonZavrit.TabIndex = 1;
            this.buttonZavrit.Text = "X";
            this.buttonZavrit.UseVisualStyleBackColor = true;
            this.buttonZavrit.Click += new System.EventHandler(this.buttonZavrit_Click);
            this.buttonZavrit.MouseEnter += new System.EventHandler(this.buttonZavrit_MouseEnter);
            this.buttonZavrit.MouseLeave += new System.EventHandler(this.buttonZavrit_MouseLeave);
            // 
            // panelSifry
            // 
            this.panelSifry.Controls.Add(this.buttonAtbash);
            this.panelSifry.Controls.Add(this.buttonVernam);
            this.panelSifry.Controls.Add(this.buttonVigen);
            this.panelSifry.Controls.Add(this.buttonCaesar);
            this.panelSifry.Controls.Add(this.buttonROT13);
            this.panelSifry.Location = new System.Drawing.Point(0, 40);
            this.panelSifry.Name = "panelSifry";
            this.panelSifry.Size = new System.Drawing.Size(950, 90);
            this.panelSifry.TabIndex = 0;
            // 
            // buttonAtbash
            // 
            this.buttonAtbash.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonAtbash.FlatAppearance.BorderSize = 0;
            this.buttonAtbash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAtbash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAtbash.Location = new System.Drawing.Point(760, 0);
            this.buttonAtbash.Name = "buttonAtbash";
            this.buttonAtbash.Size = new System.Drawing.Size(190, 90);
            this.buttonAtbash.TabIndex = 4;
            this.buttonAtbash.Text = "Atbaš";
            this.buttonAtbash.UseVisualStyleBackColor = false;
            this.buttonAtbash.Click += new System.EventHandler(this.buttonAtbash_Click);
            // 
            // buttonVernam
            // 
            this.buttonVernam.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonVernam.FlatAppearance.BorderSize = 0;
            this.buttonVernam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVernam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonVernam.Location = new System.Drawing.Point(570, 0);
            this.buttonVernam.Name = "buttonVernam";
            this.buttonVernam.Size = new System.Drawing.Size(190, 90);
            this.buttonVernam.TabIndex = 3;
            this.buttonVernam.Text = "Vernamova šifra";
            this.buttonVernam.UseVisualStyleBackColor = false;
            this.buttonVernam.Click += new System.EventHandler(this.buttonVernam_Click);
            // 
            // buttonVigen
            // 
            this.buttonVigen.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonVigen.FlatAppearance.BorderSize = 0;
            this.buttonVigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonVigen.Location = new System.Drawing.Point(380, 0);
            this.buttonVigen.Name = "buttonVigen";
            this.buttonVigen.Size = new System.Drawing.Size(190, 90);
            this.buttonVigen.TabIndex = 2;
            this.buttonVigen.Text = "Vigenèrova šifra";
            this.buttonVigen.UseVisualStyleBackColor = false;
            this.buttonVigen.Click += new System.EventHandler(this.buttonVigen_Click);
            // 
            // buttonCaesar
            // 
            this.buttonCaesar.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonCaesar.FlatAppearance.BorderSize = 0;
            this.buttonCaesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCaesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCaesar.Location = new System.Drawing.Point(190, 0);
            this.buttonCaesar.Name = "buttonCaesar";
            this.buttonCaesar.Size = new System.Drawing.Size(190, 90);
            this.buttonCaesar.TabIndex = 1;
            this.buttonCaesar.Text = "Caesarova šifra";
            this.buttonCaesar.UseVisualStyleBackColor = false;
            this.buttonCaesar.Click += new System.EventHandler(this.buttonCaesar_Click);
            // 
            // buttonROT13
            // 
            this.buttonROT13.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonROT13.FlatAppearance.BorderSize = 0;
            this.buttonROT13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonROT13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonROT13.Location = new System.Drawing.Point(0, 0);
            this.buttonROT13.Name = "buttonROT13";
            this.buttonROT13.Size = new System.Drawing.Size(190, 90);
            this.buttonROT13.TabIndex = 0;
            this.buttonROT13.Text = "ROT13";
            this.buttonROT13.UseVisualStyleBackColor = false;
            this.buttonROT13.Click += new System.EventHandler(this.buttonROT13_Click);
            // 
            // panelKodovani
            // 
            this.panelKodovani.Controls.Add(this.buttonUTF16BE);
            this.panelKodovani.Controls.Add(this.buttonUTF16LE);
            this.panelKodovani.Controls.Add(this.buttonUTF8BOM);
            this.panelKodovani.Controls.Add(this.buttonUTF8);
            this.panelKodovani.Location = new System.Drawing.Point(555, 180);
            this.panelKodovani.Name = "panelKodovani";
            this.panelKodovani.Size = new System.Drawing.Size(200, 90);
            this.panelKodovani.TabIndex = 2;
            // 
            // buttonUTF16BE
            // 
            this.buttonUTF16BE.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonUTF16BE.FlatAppearance.BorderSize = 0;
            this.buttonUTF16BE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUTF16BE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonUTF16BE.Location = new System.Drawing.Point(100, 45);
            this.buttonUTF16BE.Name = "buttonUTF16BE";
            this.buttonUTF16BE.Size = new System.Drawing.Size(100, 45);
            this.buttonUTF16BE.TabIndex = 3;
            this.buttonUTF16BE.Text = "UTF-16 BE";
            this.buttonUTF16BE.UseVisualStyleBackColor = false;
            this.buttonUTF16BE.Click += new System.EventHandler(this.buttonUTF16BE_Click);
            // 
            // buttonUTF16LE
            // 
            this.buttonUTF16LE.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonUTF16LE.FlatAppearance.BorderSize = 0;
            this.buttonUTF16LE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUTF16LE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonUTF16LE.Location = new System.Drawing.Point(0, 45);
            this.buttonUTF16LE.Name = "buttonUTF16LE";
            this.buttonUTF16LE.Size = new System.Drawing.Size(100, 45);
            this.buttonUTF16LE.TabIndex = 2;
            this.buttonUTF16LE.Text = "UTF-16 LE";
            this.buttonUTF16LE.UseVisualStyleBackColor = false;
            this.buttonUTF16LE.Click += new System.EventHandler(this.buttonUTF16LE_Click);
            // 
            // buttonUTF8BOM
            // 
            this.buttonUTF8BOM.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonUTF8BOM.FlatAppearance.BorderSize = 0;
            this.buttonUTF8BOM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUTF8BOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonUTF8BOM.Location = new System.Drawing.Point(100, 0);
            this.buttonUTF8BOM.Name = "buttonUTF8BOM";
            this.buttonUTF8BOM.Size = new System.Drawing.Size(100, 45);
            this.buttonUTF8BOM.TabIndex = 1;
            this.buttonUTF8BOM.Text = "UTF-8 BOM";
            this.buttonUTF8BOM.UseVisualStyleBackColor = false;
            this.buttonUTF8BOM.Click += new System.EventHandler(this.buttonUTF8BOM_Click);
            // 
            // buttonUTF8
            // 
            this.buttonUTF8.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonUTF8.FlatAppearance.BorderSize = 0;
            this.buttonUTF8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUTF8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonUTF8.Location = new System.Drawing.Point(0, 0);
            this.buttonUTF8.Name = "buttonUTF8";
            this.buttonUTF8.Size = new System.Drawing.Size(100, 45);
            this.buttonUTF8.TabIndex = 0;
            this.buttonUTF8.Text = "UTF-8";
            this.buttonUTF8.UseVisualStyleBackColor = false;
            this.buttonUTF8.Click += new System.EventHandler(this.buttonUTF8_Click);
            // 
            // buttonVybratSoubor
            // 
            this.buttonVybratSoubor.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonVybratSoubor.FlatAppearance.BorderSize = 0;
            this.buttonVybratSoubor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVybratSoubor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonVybratSoubor.Location = new System.Drawing.Point(100, 180);
            this.buttonVybratSoubor.Name = "buttonVybratSoubor";
            this.buttonVybratSoubor.Size = new System.Drawing.Size(450, 90);
            this.buttonVybratSoubor.TabIndex = 1;
            this.buttonVybratSoubor.Text = "VYBRAT SOUBOR";
            this.buttonVybratSoubor.UseVisualStyleBackColor = false;
            this.buttonVybratSoubor.Click += new System.EventHandler(this.buttonVybratSoubor_Click);
            // 
            // buttonSifrovat
            // 
            this.buttonSifrovat.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonSifrovat.FlatAppearance.BorderSize = 0;
            this.buttonSifrovat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSifrovat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonSifrovat.Location = new System.Drawing.Point(100, 275);
            this.buttonSifrovat.Name = "buttonSifrovat";
            this.buttonSifrovat.Size = new System.Drawing.Size(225, 60);
            this.buttonSifrovat.TabIndex = 3;
            this.buttonSifrovat.Text = "ŠIFROVAT";
            this.buttonSifrovat.UseVisualStyleBackColor = false;
            this.buttonSifrovat.Click += new System.EventHandler(this.buttonSifrovat_Click);
            // 
            // buttonDesifrovat
            // 
            this.buttonDesifrovat.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonDesifrovat.FlatAppearance.BorderSize = 0;
            this.buttonDesifrovat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDesifrovat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonDesifrovat.Location = new System.Drawing.Point(325, 275);
            this.buttonDesifrovat.Name = "buttonDesifrovat";
            this.buttonDesifrovat.Size = new System.Drawing.Size(225, 60);
            this.buttonDesifrovat.TabIndex = 4;
            this.buttonDesifrovat.Text = "DEŠIFROVAT";
            this.buttonDesifrovat.UseVisualStyleBackColor = false;
            this.buttonDesifrovat.Click += new System.EventHandler(this.buttonDesifrovat_Click);
            // 
            // textBoxNazevNovehoSouboru
            // 
            this.textBoxNazevNovehoSouboru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxNazevNovehoSouboru.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNazevNovehoSouboru.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textBoxNazevNovehoSouboru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxNazevNovehoSouboru.Location = new System.Drawing.Point(600, 350);
            this.textBoxNazevNovehoSouboru.Name = "textBoxNazevNovehoSouboru";
            this.textBoxNazevNovehoSouboru.Size = new System.Drawing.Size(250, 35);
            this.textBoxNazevNovehoSouboru.TabIndex = 11;
            this.textBoxNazevNovehoSouboru.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNazevNovehoSouboru_KeyPress);
            // 
            // textBoxKlic
            // 
            this.textBoxKlic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxKlic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxKlic.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textBoxKlic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxKlic.Location = new System.Drawing.Point(150, 350);
            this.textBoxKlic.Name = "textBoxKlic";
            this.textBoxKlic.Size = new System.Drawing.Size(245, 35);
            this.textBoxKlic.TabIndex = 5;
            this.textBoxKlic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKlic_KeyPress);
            // 
            // buttonVygenerovat
            // 
            this.buttonVygenerovat.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonVygenerovat.FlatAppearance.BorderSize = 0;
            this.buttonVygenerovat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVygenerovat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.buttonVygenerovat.Location = new System.Drawing.Point(395, 350);
            this.buttonVygenerovat.Name = "buttonVygenerovat";
            this.buttonVygenerovat.Size = new System.Drawing.Size(120, 35);
            this.buttonVygenerovat.TabIndex = 6;
            this.buttonVygenerovat.Text = "vygenerovat";
            this.buttonVygenerovat.UseVisualStyleBackColor = false;
            this.buttonVygenerovat.Click += new System.EventHandler(this.buttonVygenerovat_Click);
            // 
            // buttonNastaveni
            // 
            this.buttonNastaveni.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.buttonNastaveni.FlatAppearance.BorderSize = 2;
            this.buttonNastaveni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNastaveni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.buttonNastaveni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonNastaveni.Location = new System.Drawing.Point(515, 350);
            this.buttonNastaveni.Name = "buttonNastaveni";
            this.buttonNastaveni.Size = new System.Drawing.Size(35, 35);
            this.buttonNastaveni.TabIndex = 7;
            this.buttonNastaveni.Text = "⚙";
            this.buttonNastaveni.UseVisualStyleBackColor = false;
            this.buttonNastaveni.Click += new System.EventHandler(this.buttonNastaveni_Click);
            // 
            // checkBoxVytvoritSoubor
            // 
            this.checkBoxVytvoritSoubor.AutoSize = true;
            this.checkBoxVytvoritSoubor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxVytvoritSoubor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.checkBoxVytvoritSoubor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkBoxVytvoritSoubor.Location = new System.Drawing.Point(150, 385);
            this.checkBoxVytvoritSoubor.Name = "checkBoxVytvoritSoubor";
            this.checkBoxVytvoritSoubor.Size = new System.Drawing.Size(126, 20);
            this.checkBoxVytvoritSoubor.TabIndex = 8;
            this.checkBoxVytvoritSoubor.Text = "vytvořit soubor";
            this.checkBoxVytvoritSoubor.UseVisualStyleBackColor = true;
            // 
            // buttonSpustit
            // 
            this.buttonSpustit.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonSpustit.FlatAppearance.BorderSize = 0;
            this.buttonSpustit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSpustit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.buttonSpustit.Location = new System.Drawing.Point(600, 392);
            this.buttonSpustit.Name = "buttonSpustit";
            this.buttonSpustit.Size = new System.Drawing.Size(250, 80);
            this.buttonSpustit.TabIndex = 12;
            this.buttonSpustit.Text = "SPUSTIT";
            this.buttonSpustit.UseVisualStyleBackColor = false;
            this.buttonSpustit.Click += new System.EventHandler(this.buttonSpustit_Click);
            // 
            // buttonVybratKlic
            // 
            this.buttonVybratKlic.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonVybratKlic.FlatAppearance.BorderSize = 0;
            this.buttonVybratKlic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVybratKlic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonVybratKlic.Location = new System.Drawing.Point(150, 412);
            this.buttonVybratKlic.Name = "buttonVybratKlic";
            this.buttonVybratKlic.Size = new System.Drawing.Size(200, 60);
            this.buttonVybratKlic.TabIndex = 9;
            this.buttonVybratKlic.Text = "VYBRAT KLÍČ";
            this.buttonVybratKlic.UseVisualStyleBackColor = false;
            this.buttonVybratKlic.Click += new System.EventHandler(this.buttonVybratKlic_Click);
            // 
            // buttonZrusit
            // 
            this.buttonZrusit.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.buttonZrusit.FlatAppearance.BorderSize = 2;
            this.buttonZrusit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZrusit.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.buttonZrusit.ForeColor = System.Drawing.Color.MediumPurple;
            this.buttonZrusit.Location = new System.Drawing.Point(350, 412);
            this.buttonZrusit.Name = "buttonZrusit";
            this.buttonZrusit.Size = new System.Drawing.Size(60, 60);
            this.buttonZrusit.TabIndex = 10;
            this.buttonZrusit.Text = "❌";
            this.buttonZrusit.UseVisualStyleBackColor = false;
            this.buttonZrusit.Click += new System.EventHandler(this.buttonZrusit_Click);
            // 
            // labelSlozka
            // 
            this.labelSlozka.AutoSize = true;
            this.labelSlozka.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.labelSlozka.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelSlozka.Location = new System.Drawing.Point(93, 140);
            this.labelSlozka.Name = "labelSlozka";
            this.labelSlozka.Size = new System.Drawing.Size(53, 37);
            this.labelSlozka.TabIndex = 14;
            this.labelSlozka.Text = "📁";
            // 
            // labelNazevVybranehoSouboru
            // 
            this.labelNazevVybranehoSouboru.AutoEllipsis = true;
            this.labelNazevVybranehoSouboru.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelNazevVybranehoSouboru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelNazevVybranehoSouboru.Location = new System.Drawing.Point(150, 150);
            this.labelNazevVybranehoSouboru.Name = "labelNazevVybranehoSouboru";
            this.labelNazevVybranehoSouboru.Size = new System.Drawing.Size(400, 24);
            this.labelNazevVybranehoSouboru.TabIndex = 15;
            this.labelNazevVybranehoSouboru.Text = "-";
            // 
            // labelKodovani
            // 
            this.labelKodovani.AutoSize = true;
            this.labelKodovani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelKodovani.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelKodovani.Location = new System.Drawing.Point(552, 161);
            this.labelKodovani.Name = "labelKodovani";
            this.labelKodovani.Size = new System.Drawing.Size(77, 16);
            this.labelKodovani.TabIndex = 16;
            this.labelKodovani.Text = "Kódování:";
            // 
            // labelNazevNovehoSouboru
            // 
            this.labelNazevNovehoSouboru.AutoSize = true;
            this.labelNazevNovehoSouboru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelNazevNovehoSouboru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelNazevNovehoSouboru.Location = new System.Drawing.Point(597, 332);
            this.labelNazevNovehoSouboru.Name = "labelNazevNovehoSouboru";
            this.labelNazevNovehoSouboru.Size = new System.Drawing.Size(171, 16);
            this.labelNazevNovehoSouboru.TabIndex = 18;
            this.labelNazevNovehoSouboru.Text = "Název nového souboru:";
            // 
            // labelKlic
            // 
            this.labelKlic.AutoSize = true;
            this.labelKlic.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.labelKlic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelKlic.Location = new System.Drawing.Point(94, 350);
            this.labelKlic.Name = "labelKlic";
            this.labelKlic.Size = new System.Drawing.Size(46, 31);
            this.labelKlic.TabIndex = 17;
            this.labelKlic.Text = "🔑";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(950, 500);
            this.Controls.Add(this.labelKlic);
            this.Controls.Add(this.labelNazevNovehoSouboru);
            this.Controls.Add(this.labelKodovani);
            this.Controls.Add(this.labelNazevVybranehoSouboru);
            this.Controls.Add(this.labelSlozka);
            this.Controls.Add(this.buttonZrusit);
            this.Controls.Add(this.buttonVybratKlic);
            this.Controls.Add(this.buttonSpustit);
            this.Controls.Add(this.checkBoxVytvoritSoubor);
            this.Controls.Add(this.buttonNastaveni);
            this.Controls.Add(this.buttonVygenerovat);
            this.Controls.Add(this.textBoxKlic);
            this.Controls.Add(this.textBoxNazevNovehoSouboru);
            this.Controls.Add(this.buttonDesifrovat);
            this.Controls.Add(this.buttonSifrovat);
            this.Controls.Add(this.buttonVybratSoubor);
            this.Controls.Add(this.panelKodovani);
            this.Controls.Add(this.panelSifry);
            this.Controls.Add(this.panelLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLista.ResumeLayout(false);
            this.panelSifry.ResumeLayout(false);
            this.panelKodovani.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLista;
        private System.Windows.Forms.Button buttonMinimalizovat;
        private System.Windows.Forms.Button buttonZavrit;
        private System.Windows.Forms.Panel panelSifry;
        private System.Windows.Forms.Button buttonAtbash;
        private System.Windows.Forms.Button buttonVernam;
        private System.Windows.Forms.Button buttonVigen;
        private System.Windows.Forms.Button buttonCaesar;
        private System.Windows.Forms.Button buttonROT13;
        private System.Windows.Forms.Panel panelKodovani;
        private System.Windows.Forms.Button buttonUTF16BE;
        private System.Windows.Forms.Button buttonUTF16LE;
        private System.Windows.Forms.Button buttonUTF8BOM;
        private System.Windows.Forms.Button buttonUTF8;
        private System.Windows.Forms.Button buttonVybratSoubor;
        private System.Windows.Forms.Button buttonSifrovat;
        private System.Windows.Forms.Button buttonDesifrovat;
        private System.Windows.Forms.TextBox textBoxNazevNovehoSouboru;
        private System.Windows.Forms.TextBox textBoxKlic;
        private System.Windows.Forms.Button buttonVygenerovat;
        private System.Windows.Forms.Button buttonNastaveni;
        private System.Windows.Forms.CheckBox checkBoxVytvoritSoubor;
        private System.Windows.Forms.Button buttonSpustit;
        private System.Windows.Forms.Button buttonVybratKlic;
        private System.Windows.Forms.Button buttonZrusit;
        private System.Windows.Forms.Label labelSlozka;
        private System.Windows.Forms.Label labelNazevVybranehoSouboru;
        private System.Windows.Forms.Label labelKodovani;
        private System.Windows.Forms.Label labelNazevNovehoSouboru;
        private System.Windows.Forms.Label labelKlic;
        private System.Windows.Forms.OpenFileDialog openFileDialogSoubor;
        private System.Windows.Forms.OpenFileDialog openFileDialogKlic;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

