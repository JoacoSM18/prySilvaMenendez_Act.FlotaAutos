namespace prySilvaMenendez_Act.FlotaAutos
{
    partial class frmAgregarChofer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarChofer));
            this.btnAgregarVehiculo = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.mskDNI = new System.Windows.Forms.MaskedTextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblCarnet = new System.Windows.Forms.Label();
            this.mskNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.mskCarnet = new System.Windows.Forms.MaskedTextBox();
            this.lblSeguro = new System.Windows.Forms.Label();
            this.cmbSeguros = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAgregarVehiculo
            // 
            this.btnAgregarVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarVehiculo.Location = new System.Drawing.Point(466, 368);
            this.btnAgregarVehiculo.Name = "btnAgregarVehiculo";
            this.btnAgregarVehiculo.Size = new System.Drawing.Size(266, 49);
            this.btnAgregarVehiculo.TabIndex = 17;
            this.btnAgregarVehiculo.Text = "Agregar Nuevo Vehiculo";
            this.btnAgregarVehiculo.UseVisualStyleBackColor = true;
            this.btnAgregarVehiculo.Click += new System.EventHandler(this.btnAgregarVehiculo_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(530, 29);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(169, 29);
            this.txtNombre.TabIndex = 9;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // mskDNI
            // 
            this.mskDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDNI.Location = new System.Drawing.Point(594, 80);
            this.mskDNI.Mask = "99999";
            this.mskDNI.Name = "mskDNI";
            this.mskDNI.Size = new System.Drawing.Size(104, 29);
            this.mskDNI.TabIndex = 15;
            this.mskDNI.ValidatingType = typeof(int);
            this.mskDNI.Click += new System.EventHandler(this.mskDNI_Click);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(66, 34);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(259, 24);
            this.lbNombre.TabIndex = 16;
            this.lbNombre.Text = "Ingrese el Nombre del Chofer";
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacimiento.Location = new System.Drawing.Point(66, 145);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(370, 24);
            this.lblNacimiento.TabIndex = 14;
            this.lblNacimiento.Text = "Ingrese la Fecha de Nacimiento del Chofer";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(66, 85);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(221, 24);
            this.lblDNI.TabIndex = 12;
            this.lblDNI.Text = "Ingrese el DNI del Chofer";
            // 
            // lblCarnet
            // 
            this.lblCarnet.AutoSize = true;
            this.lblCarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarnet.Location = new System.Drawing.Point(66, 198);
            this.lblCarnet.Name = "lblCarnet";
            this.lblCarnet.Size = new System.Drawing.Size(346, 24);
            this.lblCarnet.TabIndex = 10;
            this.lblCarnet.Text = "Ingrese el Numero de Carnet del Chofer";
            // 
            // mskNacimiento
            // 
            this.mskNacimiento.Location = new System.Drawing.Point(603, 138);
            this.mskNacimiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mskNacimiento.Mask = "00/00/0000";
            this.mskNacimiento.Name = "mskNacimiento";
            this.mskNacimiento.Size = new System.Drawing.Size(96, 26);
            this.mskNacimiento.TabIndex = 19;
            this.mskNacimiento.ValidatingType = typeof(System.DateTime);
            this.mskNacimiento.Click += new System.EventHandler(this.mskNacimiento_Click);
            // 
            // mskCarnet
            // 
            this.mskCarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCarnet.Location = new System.Drawing.Point(636, 189);
            this.mskCarnet.Mask = "99999";
            this.mskCarnet.Name = "mskCarnet";
            this.mskCarnet.Size = new System.Drawing.Size(62, 29);
            this.mskCarnet.TabIndex = 20;
            this.mskCarnet.ValidatingType = typeof(int);
            this.mskCarnet.Click += new System.EventHandler(this.mskCarnet_Click);
            // 
            // lblSeguro
            // 
            this.lblSeguro.AutoSize = true;
            this.lblSeguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeguro.Location = new System.Drawing.Point(66, 257);
            this.lblSeguro.Name = "lblSeguro";
            this.lblSeguro.Size = new System.Drawing.Size(364, 24);
            this.lblSeguro.TabIndex = 21;
            this.lblSeguro.Text = "Seleccione el Seguro que Utiliza el Chofer";
            // 
            // cmbSeguros
            // 
            this.cmbSeguros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeguros.FormattingEnabled = true;
            this.cmbSeguros.Items.AddRange(new object[] {
            "Sancor Seguros",
            "La Caja",
            "San Cristobal",
            "La Segunda"});
            this.cmbSeguros.Location = new System.Drawing.Point(530, 253);
            this.cmbSeguros.Name = "cmbSeguros";
            this.cmbSeguros.Size = new System.Drawing.Size(169, 28);
            this.cmbSeguros.TabIndex = 22;
            // 
            // frmAgregarChofer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.cmbSeguros);
            this.Controls.Add(this.lblSeguro);
            this.Controls.Add(this.mskCarnet);
            this.Controls.Add(this.mskNacimiento);
            this.Controls.Add(this.btnAgregarVehiculo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.mskDNI);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lblNacimiento);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblCarnet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAgregarChofer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar un Chofer";
            this.Load += new System.EventHandler(this.frmAgregarChofer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarVehiculo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.MaskedTextBox mskDNI;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblCarnet;
        private System.Windows.Forms.MaskedTextBox mskNacimiento;
        private System.Windows.Forms.MaskedTextBox mskCarnet;
        private System.Windows.Forms.Label lblSeguro;
        private System.Windows.Forms.ComboBox cmbSeguros;
    }
}