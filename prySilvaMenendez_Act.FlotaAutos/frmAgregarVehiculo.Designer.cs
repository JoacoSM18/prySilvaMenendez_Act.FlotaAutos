namespace prySilvaMenendez_Act.FlotaAutos
{
    partial class frmAgregarVehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarVehiculo));
            this.lblPatente = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.numAño = new System.Windows.Forms.NumericUpDown();
            this.mskPatente = new System.Windows.Forms.MaskedTextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.btnAgregarVehiculo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numAño)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatente.Location = new System.Drawing.Point(66, 190);
            this.lblPatente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(195, 16);
            this.lblPatente.TabIndex = 0;
            this.lblPatente.Text = "Ingrese la Patente del Vehiculo:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(66, 86);
            this.lblModelo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(195, 16);
            this.lblModelo.TabIndex = 1;
            this.lblModelo.Text = "Ingrese el Modelo del Vehiculo:";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAño.Location = new System.Drawing.Point(66, 139);
            this.lblAño.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(289, 16);
            this.lblAño.TabIndex = 2;
            this.lblAño.Text = "Seleccione el Año de Fabricacion del Vehiculo:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(66, 38);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(187, 16);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Ingrese la Marca del Vehiculo:";
            // 
            // numAño
            // 
            this.numAño.BackColor = System.Drawing.SystemColors.Window;
            this.numAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAño.Location = new System.Drawing.Point(387, 133);
            this.numAño.Margin = new System.Windows.Forms.Padding(2);
            this.numAño.Maximum = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            this.numAño.Minimum = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.numAño.Name = "numAño";
            this.numAño.ReadOnly = true;
            this.numAño.Size = new System.Drawing.Size(59, 22);
            this.numAño.TabIndex = 2;
            this.numAño.Value = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            // 
            // mskPatente
            // 
            this.mskPatente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskPatente.Location = new System.Drawing.Point(375, 184);
            this.mskPatente.Margin = new System.Windows.Forms.Padding(2);
            this.mskPatente.Name = "mskPatente";
            this.mskPatente.Size = new System.Drawing.Size(71, 22);
            this.mskPatente.TabIndex = 3;
            this.mskPatente.Click += new System.EventHandler(this.mskPatente_Click);
            // 
            // txtModelo
            // 
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(333, 80);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(2);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(114, 22);
            this.txtModelo.TabIndex = 1;
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(332, 32);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(2);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(114, 22);
            this.txtMarca.TabIndex = 0;
            // 
            // btnAgregarVehiculo
            // 
            this.btnAgregarVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarVehiculo.Location = new System.Drawing.Point(333, 249);
            this.btnAgregarVehiculo.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarVehiculo.Name = "btnAgregarVehiculo";
            this.btnAgregarVehiculo.Size = new System.Drawing.Size(177, 32);
            this.btnAgregarVehiculo.TabIndex = 8;
            this.btnAgregarVehiculo.Text = "Agregar Nuevo Vehiculo";
            this.btnAgregarVehiculo.UseVisualStyleBackColor = true;
            this.btnAgregarVehiculo.Click += new System.EventHandler(this.btnAgregarVehiculo_Click);
            // 
            // frmAgregarVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.btnAgregarVehiculo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.mskPatente);
            this.Controls.Add(this.numAño);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblPatente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAgregarVehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar un Vehiculo";
            this.Load += new System.EventHandler(this.frmAgregarVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAño)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.NumericUpDown numAño;
        private System.Windows.Forms.MaskedTextBox mskPatente;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Button btnAgregarVehiculo;
    }
}