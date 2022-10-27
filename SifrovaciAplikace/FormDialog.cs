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
    public partial class FormDialog : Form
    {
        public enum Typ
        {
            Uspech, Upozorneni, Chyba
        }
        public FormDialog(string zprava, Typ typ)
        {
            InitializeComponent();

            switch(typ)
            {
                case Typ.Uspech:
                    labelSymbol.Text = "✓";
                    break;
                case Typ.Upozorneni:
                    labelSymbol.Text = "ǃ";
                    break;
                case Typ.Chyba:
                    labelSymbol.Text = "✗";
                    break;
            }
            labelZprava.Text = zprava;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
