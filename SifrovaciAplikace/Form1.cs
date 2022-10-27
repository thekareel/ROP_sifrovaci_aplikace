using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace SifrovaciAplikace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string volbaSifry;
        string volbaAkce;
        Encoding kodovani;

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonROT13.PerformClick();
            buttonUTF8.PerformClick();
            buttonSifrovat.PerformClick();
        }

        private void buttonVybratSoubor_Click(object sender, EventArgs e)
        {
            if (openFileDialogSoubor.ShowDialog() == DialogResult.OK)
            {
                labelNazevVybranehoSouboru.Text = Path.GetFileName(openFileDialogSoubor.FileName);
            }
        }

        private void buttonVybratKlic_Click(object sender, EventArgs e)
        {
            if (openFileDialogKlic.ShowDialog() == DialogResult.OK)
            {
                if (textBoxKlic.Enabled == false)
                {
                    textBoxKlic.Enabled = true;
                }
                textBoxKlic.Text = Path.GetFileName(openFileDialogKlic.FileName);
                textBoxKlic.Select();
                textBoxKlic.Enabled = false;
                buttonVygenerovat.Enabled = false;
                checkBoxVytvoritSoubor.Enabled = false;
                buttonZrusit.Show();
            }
        }

        private void buttonZrusit_Click(object sender, EventArgs e)
        {
            openFileDialogKlic.FileName = "";
            textBoxKlic.Clear();
            buttonZrusit.Hide();
            if (volbaSifry != "Vernam")
            {
                textBoxKlic.Enabled = true;
            }
            buttonVygenerovat.Enabled = true;
            checkBoxVytvoritSoubor.Enabled = true;
        }

        public static int delkaKlice = 4;
        private void buttonVygenerovat_Click(object sender, EventArgs e)
        {
            string klic = "";
            Random random = new Random();

            if (volbaSifry == "Caesar")
            {
                int minus = random.Next(2);
                if (minus == 1) klic += "-";

                int cislo = random.Next(1, 10);
                klic += cislo;
                for (int i = 0; i < delkaKlice - 1; ++i)
                {
                    cislo = random.Next(10);
                    klic += cislo;
                }
            }
            else if (volbaSifry == "Vigen")
            {
                for (int i = 0; i < delkaKlice; ++i)
                {
                    char znak = (char)random.Next('a', 'z' + 1);
                    klic += znak;
                }
            }
            textBoxKlic.Text = klic;
        }

        private void buttonNastaveni_Click(object sender, EventArgs e)
        {
            FormNastaveni formNastaveni = new FormNastaveni();
            formNastaveni.ShowDialog();
        }

        private void buttonSpustit_Click(object sender, EventArgs e)
        {
            if (openFileDialogSoubor.FileName != "")
            {
                if (textBoxNazevNovehoSouboru.Text != "")
                {
                    bool vseVyplneno = true;
                    if (volbaSifry == "Caesar" || volbaSifry == "Vigen" || (volbaSifry == "Vernam" && volbaAkce == "desifrovat"))
                    {
                        if (textBoxKlic.Text == "")
                        {
                            vseVyplneno = false;
                        }
                    }

                    if (vseVyplneno)
                    {
                        try
                        {
                            using (StreamReader sr = new StreamReader(openFileDialogSoubor.FileName, kodovani))
                            {
                                using (StreamWriter sw = new StreamWriter(Path.GetDirectoryName(openFileDialogSoubor.FileName) + @"\" + textBoxNazevNovehoSouboru.Text + Path.GetExtension(openFileDialogSoubor.FileName), false, kodovani))
                                {
                                    try
                                    {
                                        switch (volbaSifry)
                                        {
                                            case "ROT13":
                                                ROT13 sifraROT13 = new ROT13(sr, sw);
                                                if (volbaAkce == "sifrovat")
                                                {
                                                    sifraROT13.Zasifruj();
                                                }
                                                else if (volbaAkce == "desifrovat")
                                                {
                                                    sifraROT13.Desifruj();
                                                }
                                                break;
                                            case "Caesar":
                                                Caesar sifraCaesar = new Caesar(sr, sw);
                                                if (volbaAkce == "sifrovat")
                                                {
                                                    if (openFileDialogKlic.FileName == "" && checkBoxVytvoritSoubor.Checked)
                                                    {
                                                        using (StreamWriter swKlic = new StreamWriter(Path.GetDirectoryName(openFileDialogSoubor.FileName) + @"\klic_" + textBoxNazevNovehoSouboru.Text + ".txt"))
                                                        {
                                                            swKlic.Write(textBoxKlic.Text);
                                                        }
                                                        using (StreamReader srKlic = new StreamReader(Path.GetDirectoryName(openFileDialogSoubor.FileName) + @"\klic_" + textBoxNazevNovehoSouboru.Text + ".txt"))
                                                        {
                                                            sifraCaesar.Zasifruj(srKlic);
                                                        }
                                                    }
                                                    else if (openFileDialogKlic.FileName != "")
                                                    {
                                                        using (StreamReader srKlic = new StreamReader(openFileDialogKlic.FileName))
                                                        {
                                                            sifraCaesar.Zasifruj(srKlic);
                                                        }
                                                    }
                                                    else
                                                    {
                                                        sifraCaesar.Zasifruj(long.Parse(textBoxKlic.Text));
                                                    }
                                                }
                                                else if (volbaAkce == "desifrovat")
                                                {
                                                    if (openFileDialogKlic.FileName != "")
                                                    {
                                                        using (StreamReader srKlic = new StreamReader(openFileDialogKlic.FileName))
                                                        {
                                                            sifraCaesar.Desifruj(srKlic);
                                                        }
                                                    }
                                                    else
                                                    {
                                                        sifraCaesar.Desifruj(long.Parse(textBoxKlic.Text));
                                                    }
                                                }
                                                break;
                                            case "Vigen":
                                                Vigen sifraVigen = new Vigen(sr, sw);
                                                if (volbaAkce == "sifrovat")
                                                {
                                                    if (openFileDialogKlic.FileName == "" && checkBoxVytvoritSoubor.Checked)
                                                    {
                                                        using (StreamWriter swKlic = new StreamWriter(Path.GetDirectoryName(openFileDialogSoubor.FileName) + @"\klic_" + textBoxNazevNovehoSouboru.Text + ".txt"))
                                                        {
                                                            swKlic.Write(textBoxKlic.Text);
                                                        }
                                                        using (StreamReader srKlic = new StreamReader(Path.GetDirectoryName(openFileDialogSoubor.FileName) + @"\klic_" + textBoxNazevNovehoSouboru.Text + ".txt"))
                                                        {
                                                            sifraVigen.Zasifruj(srKlic);
                                                        }
                                                    }
                                                    else if (openFileDialogKlic.FileName != "")
                                                    {
                                                        using (StreamReader srKlic = new StreamReader(openFileDialogKlic.FileName))
                                                        {
                                                            sifraVigen.Zasifruj(srKlic);
                                                        }
                                                    }
                                                    else
                                                    {
                                                        sifraVigen.Zasifruj(textBoxKlic.Text);
                                                    }    
                                                }
                                                else if (volbaAkce == "desifrovat")
                                                {
                                                    if (openFileDialogKlic.FileName != "")
                                                    {
                                                        using (StreamReader srKlic = new StreamReader(openFileDialogKlic.FileName))
                                                        {
                                                            string kontrolniRetezec = srKlic.ReadToEnd();
                                                            if (!Regex.IsMatch(kontrolniRetezec, @"^[a-zA-Z]+$")) throw new FormatException();
                                                            srKlic.BaseStream.Position = 0;
                                                            sifraVigen.Desifruj(srKlic);
                                                        }
                                                    }
                                                    else
                                                    {
                                                        sifraVigen.Desifruj(textBoxKlic.Text);
                                                    }
                                                }
                                                break;
                                            case "Vernam":
                                                Vernam sifraVernam = new Vernam(sr, sw);
                                                if (volbaAkce == "sifrovat")
                                                {
                                                    using (StreamWriter swKlic = new StreamWriter(Path.GetDirectoryName(openFileDialogSoubor.FileName) + @"\klic_" + textBoxNazevNovehoSouboru.Text + ".txt"))
                                                    {
                                                        sifraVernam.Zasifruj(swKlic);
                                                    }
                                                }
                                                else if (volbaAkce == "desifrovat")
                                                {
                                                    using (StreamReader srKlic = new StreamReader(openFileDialogKlic.FileName))
                                                    {
                                                        string kontrolniRetezec = srKlic.ReadToEnd();
                                                        if (!Regex.IsMatch(kontrolniRetezec, @"^[a-zA-Z]+$")) throw new FormatException();
                                                        srKlic.BaseStream.Position = 0;
                                                        sifraVernam.Desifruj(srKlic);
                                                    }
                                                }
                                                break;
                                            case "Atbash":
                                                Atbash sifraAtbash = new Atbash(sr, sw);
                                                if (volbaAkce == "sifrovat")
                                                {
                                                    sifraAtbash.Zasifruj();
                                                }
                                                else if (volbaAkce == "desifrovat")
                                                {
                                                    sifraAtbash.Desifruj();
                                                }
                                                break;
                                        }

                                        if (openFileDialogKlic.FileName != "")
                                        {
                                            openFileDialogKlic.FileName = "";
                                            buttonZrusit.Hide();
                                            textBoxKlic.Clear();
                                            if (volbaSifry != "Vernam") textBoxKlic.Enabled = true;
                                            buttonVygenerovat.Enabled = true;
                                            checkBoxVytvoritSoubor.Enabled = true;
                                        }
                                        openFileDialogSoubor.FileName = "";
                                        textBoxNazevNovehoSouboru.Clear();
                                        labelNazevVybranehoSouboru.Text = "-";

                                        FormDialog formDialog = new FormDialog("Operace proběhla úspěšně.", FormDialog.Typ.Uspech);
                                        formDialog.ShowDialog();
                                    }
                                    catch (FormatException)
                                    {
                                        sw.Close();
                                        File.Delete(Path.GetDirectoryName(openFileDialogSoubor.FileName) + @"\" + textBoxNazevNovehoSouboru.Text + Path.GetExtension(openFileDialogSoubor.FileName));
                                        FormDialog formDialog = new FormDialog("Překontrolujte formát klíče.", FormDialog.Typ.Chyba);
                                        formDialog.ShowDialog();
                                    }
                                    catch (OverflowException)
                                    {
                                        sw.Close();
                                        File.Delete(Path.GetDirectoryName(openFileDialogSoubor.FileName) + @"\" + textBoxNazevNovehoSouboru.Text + Path.GetExtension(openFileDialogSoubor.FileName));
                                        if (openFileDialogKlic.FileName == "" && checkBoxVytvoritSoubor.Checked)
                                        {
                                            File.Delete(Path.GetDirectoryName(openFileDialogSoubor.FileName) + @"\klic_" + textBoxNazevNovehoSouboru.Text + Path.GetExtension(openFileDialogSoubor.FileName));
                                        }
                                        FormDialog formDialog = new FormDialog("Hodnota klíče je mimo rozsah.", FormDialog.Typ.Chyba);
                                        formDialog.ShowDialog();
                                    }
                                    catch (OutOfMemoryException)
                                    {
                                        sw.Close();
                                        File.Delete(Path.GetDirectoryName(openFileDialogSoubor.FileName) + @"\" + textBoxNazevNovehoSouboru.Text + Path.GetExtension(openFileDialogSoubor.FileName));
                                        FormDialog formDialog = new FormDialog("Soubor s klíčem je příliš velký.", FormDialog.Typ.Chyba);
                                        formDialog.ShowDialog();
                                    }
                                }
                            }
                        }
                        catch (PathTooLongException)
                        {
                            FormDialog formDialog = new FormDialog("Neplatný název souboru.", FormDialog.Typ.Chyba);
                            formDialog.ShowDialog();
                            textBoxNazevNovehoSouboru.Focus();
                        }
                    }
                    else
                    {
                        FormDialog formDialog = new FormDialog("Zadejte klíč.", FormDialog.Typ.Upozorneni);
                        formDialog.ShowDialog();
                    }
                }
                else
                {
                    FormDialog formDialog = new FormDialog("Zadejte název souboru.", FormDialog.Typ.Upozorneni);
                    formDialog.ShowDialog();
                    textBoxNazevNovehoSouboru.Focus();
                }
            }
            else
            {
                FormDialog formDialog = new FormDialog("Vyberte soubor.", FormDialog.Typ.Upozorneni);
                formDialog.ShowDialog();
            }
        }

        private void buttonROT13_Click(object sender, EventArgs e)
        {
            volbaSifry = "ROT13";
            labelKlic.Hide();
            textBoxKlic.Hide();
            buttonVygenerovat.Hide();
            buttonNastaveni.Hide();
            checkBoxVytvoritSoubor.Hide();
            buttonVybratKlic.Hide();
            buttonZrusit.Hide();
            foreach (Control tlacitko in panelSifry.Controls)
            {
                if (tlacitko != buttonROT13)
                {
                    tlacitko.Enabled = true;
                    tlacitko.BackColor = Color.MediumPurple;
                }
                else
                {
                    tlacitko.Enabled = false;
                    tlacitko.BackColor = Color.FromArgb(100, 50, 200);
                }
            }
        }

        private void buttonCaesar_Click(object sender, EventArgs e)
        {
            volbaSifry = "Caesar";
            labelKlic.Show();
            textBoxKlic.Show();
            buttonVybratKlic.Show();
            if (openFileDialogKlic.FileName != "")
            {
                buttonZrusit.Show();
            }
            else
            {
                textBoxKlic.Enabled = true;
                textBoxKlic.Clear();
            }
            if (volbaAkce == "sifrovat")
            {
                buttonVygenerovat.Show();
                buttonNastaveni.Show();
                checkBoxVytvoritSoubor.Show();
            }
            foreach (Control tlacitko in panelSifry.Controls)
            {
                if (tlacitko != buttonCaesar)
                {
                    tlacitko.Enabled = true;
                    tlacitko.BackColor = Color.MediumPurple;
                }
                else
                {
                    tlacitko.Enabled = false;
                    tlacitko.BackColor = Color.FromArgb(100, 50, 200);
                }
            }
        }

        private void buttonVigen_Click(object sender, EventArgs e)
        {
            volbaSifry = "Vigen";
            labelKlic.Show();
            textBoxKlic.Show();
            buttonVybratKlic.Show();
            if (openFileDialogKlic.FileName != "")
            {
                buttonZrusit.Show();
            }
            else
            {
                textBoxKlic.Enabled = true;
                textBoxKlic.Clear();
            }
            if (volbaAkce == "sifrovat")
            {
                buttonVygenerovat.Show();
                buttonNastaveni.Show();
                checkBoxVytvoritSoubor.Show();
            }
            foreach (Control tlacitko in panelSifry.Controls)
            {
                if (tlacitko != buttonVigen)
                {
                    tlacitko.Enabled = true;
                    tlacitko.BackColor = Color.MediumPurple;
                }
                else
                {
                    tlacitko.Enabled = false;
                    tlacitko.BackColor = Color.FromArgb(100, 50, 200);
                }
            }
        }

        private void buttonVernam_Click(object sender, EventArgs e)
        {
            volbaSifry = "Vernam";
            if (volbaAkce == "sifrovat")
            {
                labelKlic.Hide();
                textBoxKlic.Hide();
                buttonVygenerovat.Hide();
                buttonNastaveni.Hide();
                checkBoxVytvoritSoubor.Hide();
                buttonVybratKlic.Hide();
                buttonZrusit.Hide();
            }
            else
            {
                labelKlic.Show();
                textBoxKlic.Show();
                buttonVybratKlic.Show();
                if (openFileDialogKlic.FileName != "")
                {
                    buttonZrusit.Show();
                }
                else
                {
                    textBoxKlic.Enabled = false;
                    textBoxKlic.Clear();
                }
            }
            foreach (Control tlacitko in panelSifry.Controls)
            {
                if (tlacitko != buttonVernam)
                {
                    tlacitko.Enabled = true;
                    tlacitko.BackColor = Color.MediumPurple;
                }
                else
                {
                    tlacitko.Enabled = false;
                    tlacitko.BackColor = Color.FromArgb(100, 50, 200);
                }
            }
        }

        private void buttonAtbash_Click(object sender, EventArgs e)
        {
            volbaSifry = "Atbash";
            labelKlic.Hide();
            textBoxKlic.Hide();
            buttonVygenerovat.Hide();
            buttonNastaveni.Hide();
            checkBoxVytvoritSoubor.Hide();
            buttonVybratKlic.Hide();
            buttonZrusit.Hide();
            foreach (Control tlacitko in panelSifry.Controls)
            {
                if (tlacitko != buttonAtbash)
                {
                    tlacitko.Enabled = true;
                    tlacitko.BackColor = Color.MediumPurple;
                }
                else
                {
                    tlacitko.Enabled = false;
                    tlacitko.BackColor = Color.FromArgb(100, 50, 200);
                }
            }
        }

        private void buttonSifrovat_Click(object sender, EventArgs e)
        {
            volbaAkce = "sifrovat";
            if (volbaSifry == "Caesar" || volbaSifry == "Vigen")
            {
                buttonVygenerovat.Show();
                buttonNastaveni.Show();
                checkBoxVytvoritSoubor.Show();
            }
            else if (volbaSifry == "Vernam")
            {
                labelKlic.Hide();
                textBoxKlic.Hide();
                buttonVybratKlic.Hide();
                if (buttonZrusit.Visible == true)
                {
                    buttonZrusit.Hide();
                }
            }
            buttonSifrovat.Enabled = false;
            buttonSifrovat.BackColor = Color.FromArgb(100, 50, 200);
            buttonDesifrovat.Enabled = true;
            buttonDesifrovat.BackColor = Color.MediumPurple;
        }

        private void buttonDesifrovat_Click(object sender, EventArgs e)
        {
            volbaAkce = "desifrovat";
            if (volbaSifry == "Caesar" || volbaSifry == "Vigen")
            {
                buttonVygenerovat.Hide();
                buttonNastaveni.Hide();
                checkBoxVytvoritSoubor.Hide();
            }
            else if (volbaSifry == "Vernam")
            {
                labelKlic.Show();
                textBoxKlic.Show();
                buttonVybratKlic.Show();
                if (openFileDialogKlic.FileName != "")
                {
                    buttonZrusit.Show();
                }
                else
                {
                    textBoxKlic.Enabled = false;
                    textBoxKlic.Clear();
                }
            }
            buttonDesifrovat.Enabled = false;
            buttonDesifrovat.BackColor = Color.FromArgb(100, 50, 200);
            buttonSifrovat.Enabled = true;
            buttonSifrovat.BackColor = Color.MediumPurple;
        }

        private void buttonUTF8_Click(object sender, EventArgs e)
        {
            kodovani = new UTF8Encoding(false);
            foreach (Control tlacitko in panelKodovani.Controls)
            {
                if (tlacitko != buttonUTF8)
                {
                    tlacitko.Enabled = true;
                    tlacitko.BackColor = Color.MediumPurple;
                }
                else
                {
                    tlacitko.Enabled = false;
                    tlacitko.BackColor = Color.FromArgb(100, 50, 200);
                }
            }
        }

        private void buttonUTF8BOM_Click(object sender, EventArgs e)
        {
            kodovani = new UTF8Encoding(true);
            foreach (Control tlacitko in panelKodovani.Controls)
            {
                if (tlacitko != buttonUTF8BOM)
                {
                    tlacitko.Enabled = true;
                    tlacitko.BackColor = Color.MediumPurple;
                }
                else
                {
                    tlacitko.Enabled = false;
                    tlacitko.BackColor = Color.FromArgb(100, 50, 200);
                }
            }
        }

        private void buttonUTF16LE_Click(object sender, EventArgs e)
        {
            kodovani = Encoding.Unicode;
            foreach (Control tlacitko in panelKodovani.Controls)
            {
                if (tlacitko != buttonUTF16LE)
                {
                    tlacitko.Enabled = true;
                    tlacitko.BackColor = Color.MediumPurple;
                }
                else
                {
                    tlacitko.Enabled = false;
                    tlacitko.BackColor = Color.FromArgb(100, 50, 200);
                }
            }
        }

        private void buttonUTF16BE_Click(object sender, EventArgs e)
        {
            kodovani = Encoding.BigEndianUnicode;
            foreach (Control tlacitko in panelKodovani.Controls)
            {
                if (tlacitko != buttonUTF16BE)
                {
                    tlacitko.Enabled = true;
                    tlacitko.BackColor = Color.MediumPurple;
                }
                else
                {
                    tlacitko.Enabled = false;
                    tlacitko.BackColor = Color.FromArgb(100, 50, 200);
                }
            }
        }

        Point pozice;
        private void panelLista_MouseDown(object sender, MouseEventArgs e)
        {
            pozice = new Point(-e.X, -e.Y);
        }

        private void panelLista_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point novaPozice = Control.MousePosition;
                novaPozice.Offset(pozice.X, pozice.Y);
                Location = novaPozice;
            }
        }

        private void buttonZavrit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonZavrit_MouseEnter(object sender, EventArgs e)
        {
            buttonZavrit.BackColor = Color.DarkRed;
        }

        private void buttonZavrit_MouseLeave(object sender, EventArgs e)
        {
            buttonZavrit.BackColor = Color.FromArgb(0);
        }

        private void buttonMinimalizovat_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBoxNazevNovehoSouboru_KeyPress(object sender, KeyPressEventArgs e)
        {
            char znak = e.KeyChar;
            if (znak == '\\' || znak == '/' || znak == ':' || znak == '*' || znak == '?' || znak == '"' || znak == '<' || znak == '>' || znak == '|')
            {
                e.Handled = true;
                toolTip1.Show("Název souboru nesmí obsahovat žádný z následujících znaků: \\ / : * ?  \" < > |", textBoxNazevNovehoSouboru, 0, 35, 3000);
            }
        }

        private void textBoxKlic_KeyPress(object sender, KeyPressEventArgs e)
        {
            char znak = e.KeyChar;
            if (volbaSifry == "Caesar")
            {
                if (!char.IsDigit(znak) && znak != (char)8 && (textBoxKlic.SelectionStart != 0 || znak != '-'))
                {
                    e.Handled = true;
                    toolTip1.Show("Povolené znaky: [-][0-9].", textBoxKlic, 0, 35, 3000);
                }
            }
            else if (volbaSifry == "Vigen")
            {
                if (!((znak >= 'a' && znak <= 'z') || (znak >= 'A' && znak <= 'Z')) && znak != (char)8)
                {
                    e.Handled = true;
                    toolTip1.Show("Povolené znaky: [a-z][A-Z]", textBoxKlic, 0, 35, 3000);
                }
            }
        }
    }
}
