using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            List<string> lista = Admin.Ucitaj();
            int brojac = 0;
            foreach (string linija in lista)
            {
                brojac++;
            }
            statistika.Items.Add("Ukupan broj zivotinja u azilu je "+ brojac);
            List<string> Udomitelj = Admin.UcitajUdomitelje();
            int brojac2 = 0;
            foreach (string linija in Udomitelj)
            {
                brojac2++;
            }
            statistika.Items.Add("Ukupan broj udomljenih je " + brojac2);
            statistika.Items.Add("Broj trenutno prisutnih zivotinja je " + (brojac - brojac2));
            statistika.Items.Add( "Prosjecna dob zivotinja u azilu je " + Admin.ProsjecnaDob());


        }
    }
}
