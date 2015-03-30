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
    public partial class FrmLoto : Form
    {
        private Loto loto;
        public FrmLoto()
        {
            InitializeComponent();
            loto = new Loto();
        }

        private void btnUplati_Click(object sender, EventArgs e)
        {
            List<string> vrijednosti = new List<string>();
            vrijednosti.Add(txtdobitniBroj1.Text);
            vrijednosti.Add(txtdobitniBroj2.Text);
            vrijednosti.Add(txtdobitniBroj3.Text);
            vrijednosti.Add(txtdobitniBroj4.Text);
            vrijednosti.Add(txtdobitniBroj5.Text);
            vrijednosti.Add(txtdobitniBroj6.Text);
            vrijednosti.Add(txtdobitniBroj7.Text);

            bool ispravnaKombinacija = loto.unesiUplaceneBrojeve(vrijednosti);
            if (ispravnaKombinacija == true)
            {
                btnOdigraj.Enabled = true;
            }
            else
            {
                btnOdigraj.Enabled = false;
                MessageBox.Show("nije ok unos.");
            }
        }

        private void btnOdigraj_Click(object sender, EventArgs e)
        {
            loto.GenerirajDobitnuKombinaciju();

            txtdobitniBroj1.Text = loto.DobitniBrojevi[0].ToString();
            txtUplaceniBroj2.Text = loto.DobitniBrojevi[1].ToString();
            txtUplaceniBroj3.Text = loto.DobitniBrojevi[3].ToString();
            txtUplaceniBroj4.Text = loto.DobitniBrojevi[4].ToString();
            txtUplaceniBroj5.Text = loto.DobitniBrojevi[5].ToString();
            txtUplaceniBroj6.Text = loto.DobitniBrojevi[6].ToString();
            txtUplaceniBroj7.Text = loto.DobitniBrojevi[7].ToString();

            int brojPogodatka = loto.IzracunajBrojPogodaka();
            lblBrojPogodaka.Text = brojPogodatka.ToString();
        }
    }
}
