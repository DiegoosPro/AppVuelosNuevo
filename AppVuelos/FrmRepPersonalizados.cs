using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppVuelos
{
    public partial class FrmRepPersonalizados : Form
    {
        public FrmRepPersonalizados()
        {
            InitializeComponent();
        }

        private void btnAeropuertoPais_Click(object sender, EventArgs e)
        {
            frmRepAeropuertoPais rep = new frmRepAeropuertoPais();
            rep.ShowDialog();
        }

        private void btnClienteVuelo_Click(object sender, EventArgs e)
        {
            frmRepClienteVuelo rep = new frmRepClienteVuelo();
            rep.ShowDialog();
        }
    }
}
