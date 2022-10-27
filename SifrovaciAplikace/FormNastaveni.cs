using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SifrovaciAplikace
{
    public partial class FormNastaveni : Form
    {
        private int delkaKlice;
        public FormNastaveni()
        {
            InitializeComponent();
        }

        private void FormNastaveni_Load(object sender, EventArgs e)
        {
            delkaKlice = Form1.delkaKlice;
            trackBarDelkaKlice.Value = delkaKlice;
            labelDelkaKlice.Text = delkaKlice.ToString();
        }

        private void trackBarDelkaKlice_Scroll(object sender, EventArgs e)
        {
            delkaKlice = trackBarDelkaKlice.Value;
            labelDelkaKlice.Text = delkaKlice.ToString();
        }

        private void buttonUlozit_Click(object sender, EventArgs e)
        {
            Form1.delkaKlice = delkaKlice;
            this.Close();
        }
    }
}
