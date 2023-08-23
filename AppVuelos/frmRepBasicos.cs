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
    public partial class frmRepBasicos : Form
    {
        public frmRepBasicos()
        {
            InitializeComponent();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            frmRepPaises rep = new frmRepPaises();
            rep.ShowDialog();
        }
    }
}
