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
    public partial class frmRepClienteVuelo : Form
    {
        public frmRepClienteVuelo()
        {
            InitializeComponent();
        }

        private void frmRepClienteVuelo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bddvuelosDataSet.ClienteVuelo' Puede moverla o quitarla según sea necesario.
            this.ClienteVueloTableAdapter.FillClientevuelo(this.bddvuelosDataSet.ClienteVuelo);

            this.reportViewer1.RefreshReport();
        }
    }
}
