namespace AppVuelos
{
    partial class FrmRepPersonalizados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAeropuertoPais = new System.Windows.Forms.Button();
            this.btnClienteVuelo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.bddvuelosDataSet = new AppVuelos.bddvuelosDataSet();
            this.tAB_ROLESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAB_ROLESTableAdapter = new AppVuelos.bddvuelosDataSetTableAdapters.TAB_ROLESTableAdapter();
            this.tableAdapterManager = new AppVuelos.bddvuelosDataSetTableAdapters.TableAdapterManager();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bddvuelosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_ROLESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAeropuertoPais
            // 
            this.btnAeropuertoPais.Location = new System.Drawing.Point(25, 33);
            this.btnAeropuertoPais.Name = "btnAeropuertoPais";
            this.btnAeropuertoPais.Size = new System.Drawing.Size(75, 23);
            this.btnAeropuertoPais.TabIndex = 0;
            this.btnAeropuertoPais.Text = "AeropuertoPais";
            this.btnAeropuertoPais.UseVisualStyleBackColor = true;
            this.btnAeropuertoPais.Click += new System.EventHandler(this.btnAeropuertoPais_Click);
            // 
            // btnClienteVuelo
            // 
            this.btnClienteVuelo.Location = new System.Drawing.Point(25, 71);
            this.btnClienteVuelo.Name = "btnClienteVuelo";
            this.btnClienteVuelo.Size = new System.Drawing.Size(75, 23);
            this.btnClienteVuelo.TabIndex = 1;
            this.btnClienteVuelo.Text = "ClienteVuelo";
            this.btnClienteVuelo.UseVisualStyleBackColor = true;
            this.btnClienteVuelo.Click += new System.EventHandler(this.btnClienteVuelo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAeropuertoPais);
            this.groupBox1.Controls.Add(this.btnClienteVuelo);
            this.groupBox1.Location = new System.Drawing.Point(105, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Referenciados";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGenerar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbRoles);
            this.groupBox2.Location = new System.Drawing.Point(105, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Con Parametros";
            // 
            // cmbRoles
            // 
            this.cmbRoles.DataSource = this.tAB_ROLESBindingSource;
            this.cmbRoles.DisplayMember = "rol";
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(187, 34);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(121, 21);
            this.cmbRoles.TabIndex = 0;
            this.cmbRoles.ValueMember = "id_rol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione el Rol del Usuario";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(337, 31);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "General";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // bddvuelosDataSet
            // 
            this.bddvuelosDataSet.DataSetName = "bddvuelosDataSet";
            this.bddvuelosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tAB_ROLESBindingSource
            // 
            this.tAB_ROLESBindingSource.DataMember = "TAB_ROLES";
            this.tAB_ROLESBindingSource.DataSource = this.bddvuelosDataSet;
            // 
            // tAB_ROLESTableAdapter
            // 
            this.tAB_ROLESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TAB_AEROPUERTOSTableAdapter = null;
            this.tableAdapterManager.TAB_CIUDADESTableAdapter = null;
            this.tableAdapterManager.TAB_CLIENTESTableAdapter = null;
            this.tableAdapterManager.TAB_PAISESTableAdapter = null;
            this.tableAdapterManager.TAB_PLAZASTableAdapter = null;
            this.tableAdapterManager.TAB_RESERVACIONESTableAdapter = null;
            this.tableAdapterManager.TAB_ROLESTableAdapter = this.tAB_ROLESTableAdapter;
            this.tableAdapterManager.TAB_TARJETAS_EMBARQUETableAdapter = null;
            this.tableAdapterManager.TAB_USUARIOSTableAdapter = null;
            this.tableAdapterManager.TAB_VUELOSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AppVuelos.bddvuelosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FrmRepPersonalizados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 378);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRepPersonalizados";
            this.Text = "FrmPersonalizados";
            this.Load += new System.EventHandler(this.FrmRepPersonalizados_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bddvuelosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_ROLESBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAeropuertoPais;
        private System.Windows.Forms.Button btnClienteVuelo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRoles;
        private bddvuelosDataSet bddvuelosDataSet;
        private System.Windows.Forms.BindingSource tAB_ROLESBindingSource;
        private bddvuelosDataSetTableAdapters.TAB_ROLESTableAdapter tAB_ROLESTableAdapter;
        private bddvuelosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}