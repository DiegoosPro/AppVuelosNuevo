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

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            FrmRepUsuariosRoles usu = new FrmRepUsuariosRoles(cmbRoles.Text);
            usu.ShowDialog();
        }

        private void FrmRepPersonalizados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bddvuelosDataSet.TAB_ROLES' Puede moverla o quitarla según sea necesario.
            this.tAB_ROLESTableAdapter.Fill(this.bddvuelosDataSet.TAB_ROLES);

        }
    }
}
