namespace AppVuelos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iD_PAISLabel;
            System.Windows.Forms.Label pAISLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tAB_PAISESBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bddvuelosDataSet = new AppVuelos.bddvuelosDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tAB_PAISESBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tAB_PAISESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tAB_PAISESBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_PAISLabel1 = new System.Windows.Forms.Label();
            this.pAISTextBox = new System.Windows.Forms.TextBox();
            this.tAB_PAISESTableAdapter = new AppVuelos.bddvuelosDataSetTableAdapters.TAB_PAISESTableAdapter();
            this.tableAdapterManager = new AppVuelos.bddvuelosDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tAB_CIUDADESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAB_CIUDADESTableAdapter = new AppVuelos.bddvuelosDataSetTableAdapters.TAB_CIUDADESTableAdapter();
            this.tAB_CIUDADESDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iD_PAISLabel = new System.Windows.Forms.Label();
            pAISLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_PAISESBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bddvuelosDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_PAISESBindingNavigator)).BeginInit();
            this.tAB_PAISESBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_PAISESBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CIUDADESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CIUDADESDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_PAISLabel
            // 
            iD_PAISLabel.AutoSize = true;
            iD_PAISLabel.Location = new System.Drawing.Point(133, 60);
            iD_PAISLabel.Name = "iD_PAISLabel";
            iD_PAISLabel.Size = new System.Drawing.Size(48, 13);
            iD_PAISLabel.TabIndex = 0;
            iD_PAISLabel.Text = "ID PAIS:";
            // 
            // pAISLabel
            // 
            pAISLabel.AutoSize = true;
            pAISLabel.Location = new System.Drawing.Point(133, 89);
            pAISLabel.Name = "pAISLabel";
            pAISLabel.Size = new System.Drawing.Size(34, 13);
            pAISLabel.TabIndex = 2;
            pAISLabel.Text = "PAIS:";
            // 
            // tAB_PAISESBindingSource1
            // 
            this.tAB_PAISESBindingSource1.DataMember = "TAB_PAISES";
            this.tAB_PAISESBindingSource1.DataSource = this.bddvuelosDataSet;
            // 
            // bddvuelosDataSet
            // 
            this.bddvuelosDataSet.DataSetName = "bddvuelosDataSet";
            this.bddvuelosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tAB_PAISESBindingNavigator);
            this.groupBox2.Controls.Add(iD_PAISLabel);
            this.groupBox2.Controls.Add(this.iD_PAISLabel1);
            this.groupBox2.Controls.Add(pAISLabel);
            this.groupBox2.Controls.Add(this.pAISTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 122);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Editar";
            // 
            // tAB_PAISESBindingNavigator
            // 
            this.tAB_PAISESBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tAB_PAISESBindingNavigator.BindingSource = this.tAB_PAISESBindingSource;
            this.tAB_PAISESBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tAB_PAISESBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tAB_PAISESBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.tAB_PAISESBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tAB_PAISESBindingNavigatorSaveItem});
            this.tAB_PAISESBindingNavigator.Location = new System.Drawing.Point(46, 16);
            this.tAB_PAISESBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tAB_PAISESBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tAB_PAISESBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tAB_PAISESBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tAB_PAISESBindingNavigator.Name = "tAB_PAISESBindingNavigator";
            this.tAB_PAISESBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tAB_PAISESBindingNavigator.Size = new System.Drawing.Size(280, 25);
            this.tAB_PAISESBindingNavigator.TabIndex = 2;
            this.tAB_PAISESBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // tAB_PAISESBindingSource
            // 
            this.tAB_PAISESBindingSource.DataMember = "TAB_PAISES";
            this.tAB_PAISESBindingSource.DataSource = this.bddvuelosDataSet;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tAB_PAISESBindingNavigatorSaveItem
            // 
            this.tAB_PAISESBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tAB_PAISESBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tAB_PAISESBindingNavigatorSaveItem.Image")));
            this.tAB_PAISESBindingNavigatorSaveItem.Name = "tAB_PAISESBindingNavigatorSaveItem";
            this.tAB_PAISESBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tAB_PAISESBindingNavigatorSaveItem.Text = "Guardar datos";
            this.tAB_PAISESBindingNavigatorSaveItem.Click += new System.EventHandler(this.tAB_PAISESBindingNavigatorSaveItem_Click);
            // 
            // iD_PAISLabel1
            // 
            this.iD_PAISLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_PAISESBindingSource, "ID_PAIS", true));
            this.iD_PAISLabel1.Location = new System.Drawing.Point(187, 60);
            this.iD_PAISLabel1.Name = "iD_PAISLabel1";
            this.iD_PAISLabel1.Size = new System.Drawing.Size(100, 23);
            this.iD_PAISLabel1.TabIndex = 1;
            this.iD_PAISLabel1.Text = "label2";
            // 
            // pAISTextBox
            // 
            this.pAISTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_PAISESBindingSource, "PAIS", true));
            this.pAISTextBox.Location = new System.Drawing.Point(187, 86);
            this.pAISTextBox.Name = "pAISTextBox";
            this.pAISTextBox.Size = new System.Drawing.Size(100, 20);
            this.pAISTextBox.TabIndex = 3;
            // 
            // tAB_PAISESTableAdapter
            // 
            this.tAB_PAISESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TAB_AEROPUERTOSTableAdapter = null;
            this.tableAdapterManager.TAB_CIUDADESTableAdapter = null;
            this.tableAdapterManager.TAB_CLIENTESTableAdapter = null;
            this.tableAdapterManager.TAB_PAISESTableAdapter = this.tAB_PAISESTableAdapter;
            this.tableAdapterManager.TAB_PLAZASTableAdapter = null;
            this.tableAdapterManager.TAB_RESERVACIONESTableAdapter = null;
            this.tableAdapterManager.TAB_ROLESTableAdapter = null;
            this.tableAdapterManager.TAB_TARJETAS_EMBARQUETableAdapter = null;
            this.tableAdapterManager.TAB_USUARIOSTableAdapter = null;
            this.tableAdapterManager.TAB_VUELOSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AppVuelos.bddvuelosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paises";
            // 
            // cmbPais
            // 
            this.cmbPais.DataSource = this.tAB_PAISESBindingSource1;
            this.cmbPais.DisplayMember = "PAIS";
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(95, 37);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(226, 21);
            this.cmbPais.TabIndex = 1;
            this.cmbPais.ValueMember = "ID_PAIS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbPais);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // tAB_CIUDADESBindingSource
            // 
            this.tAB_CIUDADESBindingSource.DataMember = "FK_TAB_CIUD_REFERENCE_TAB_PAIS";
            this.tAB_CIUDADESBindingSource.DataSource = this.tAB_PAISESBindingSource;
            // 
            // tAB_CIUDADESTableAdapter
            // 
            this.tAB_CIUDADESTableAdapter.ClearBeforeFill = true;
            // 
            // tAB_CIUDADESDataGridView
            // 
            this.tAB_CIUDADESDataGridView.AutoGenerateColumns = false;
            this.tAB_CIUDADESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tAB_CIUDADESDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tAB_CIUDADESDataGridView.DataSource = this.tAB_CIUDADESBindingSource;
            this.tAB_CIUDADESDataGridView.Location = new System.Drawing.Point(-1, 275);
            this.tAB_CIUDADESDataGridView.Name = "tAB_CIUDADESDataGridView";
            this.tAB_CIUDADESDataGridView.Size = new System.Drawing.Size(453, 220);
            this.tAB_CIUDADESDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_CIUDAD";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_CIUDAD";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_PAIS";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_PAIS";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CIUDAD";
            this.dataGridViewTextBoxColumn3.HeaderText = "CIUDAD";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 556);
            this.Controls.Add(this.tAB_CIUDADESDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tAB_PAISESBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bddvuelosDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_PAISESBindingNavigator)).EndInit();
            this.tAB_PAISESBindingNavigator.ResumeLayout(false);
            this.tAB_PAISESBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_PAISESBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CIUDADESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CIUDADESDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private bddvuelosDataSet bddvuelosDataSet;
        private System.Windows.Forms.BindingSource tAB_PAISESBindingSource;
        private bddvuelosDataSetTableAdapters.TAB_PAISESTableAdapter tAB_PAISESTableAdapter;
        private bddvuelosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tAB_PAISESBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tAB_PAISESBindingNavigatorSaveItem;
        private System.Windows.Forms.Label iD_PAISLabel1;
        private System.Windows.Forms.TextBox pAISTextBox;
        private System.Windows.Forms.BindingSource tAB_PAISESBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource tAB_CIUDADESBindingSource;
        private bddvuelosDataSetTableAdapters.TAB_CIUDADESTableAdapter tAB_CIUDADESTableAdapter;
        private System.Windows.Forms.DataGridView tAB_CIUDADESDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

    }
}

