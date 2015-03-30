using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loto_aplikacija
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            float polumjer = 0, povrsina = 0, opseg = 0;
            float.TryParse(txtPolumjer.Text, out polumjer);

            povrsina = polumjer * polumjer * (float)Math.PI;
            opseg = 2 * polumjer * (float)Math.PI;

            txtPolumjer.Text = polumjer.ToString();
            txtPovrsina.Text = Math.Round(povrsina, 2).ToString();
            txtOpseg.Text = Math.Round(opseg, 2).ToString();

            if (chkSpremi.Checked == true)
            {
                lstRezultati.Items.Add(polumjer);
            }
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            txtPolumjer.Text = "0,00";
            txtPovrsina.Text = "0,00";
            txtOpseg.Text = "0,00";

            lstRezultati.Items.Clear();
        }

        private void lstRezultati_DoubleClick(object sender, EventArgs e)
        {
            float polumjer = 0;
            float.TryParse(lstRezultati.SelectedItem.ToString(), out polumjer);
            txtPolumjer.Text = polumjer.ToString();
            btnIzracunaj_Click(null, null);
        }
    }
}
