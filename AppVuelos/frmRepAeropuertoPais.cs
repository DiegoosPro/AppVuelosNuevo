﻿using System;
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
    public partial class frmRepAeropuertoPais : Form
    {
        public frmRepAeropuertoPais()
        {
            InitializeComponent();
        }

        private void frmRepAeropuertoPais_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bddvuelosDataSet.AeropuertoPais' Puede moverla o quitarla según sea necesario.
            this.AeropuertoPaisTableAdapter.FillAeropuertoPais(this.bddvuelosDataSet.AeropuertoPais);

            this.reportViewer1.RefreshReport();
        }
    }
}
