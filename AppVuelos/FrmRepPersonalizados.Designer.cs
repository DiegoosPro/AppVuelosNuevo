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
            this.btnAeropuertoPais = new System.Windows.Forms.Button();
            this.btnClienteVuelo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAeropuertoPais
            // 
            this.btnAeropuertoPais.Location = new System.Drawing.Point(123, 85);
            this.btnAeropuertoPais.Name = "btnAeropuertoPais";
            this.btnAeropuertoPais.Size = new System.Drawing.Size(75, 23);
            this.btnAeropuertoPais.TabIndex = 0;
            this.btnAeropuertoPais.Text = "AeropuertoPais";
            this.btnAeropuertoPais.UseVisualStyleBackColor = true;
            this.btnAeropuertoPais.Click += new System.EventHandler(this.btnAeropuertoPais_Click);
            // 
            // btnClienteVuelo
            // 
            this.btnClienteVuelo.Location = new System.Drawing.Point(134, 155);
            this.btnClienteVuelo.Name = "btnClienteVuelo";
            this.btnClienteVuelo.Size = new System.Drawing.Size(75, 23);
            this.btnClienteVuelo.TabIndex = 1;
            this.btnClienteVuelo.Text = "ClienteVuelo";
            this.btnClienteVuelo.UseVisualStyleBackColor = true;
            this.btnClienteVuelo.Click += new System.EventHandler(this.btnClienteVuelo_Click);
            // 
            // FrmRepPersonalizados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 378);
            this.Controls.Add(this.btnClienteVuelo);
            this.Controls.Add(this.btnAeropuertoPais);
            this.Name = "FrmRepPersonalizados";
            this.Text = "FrmPersonalizados";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAeropuertoPais;
        private System.Windows.Forms.Button btnClienteVuelo;
    }
}