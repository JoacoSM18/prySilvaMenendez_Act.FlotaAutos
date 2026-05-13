namespace prySilvaMenendez_Act.FlotaAutos
{
    partial class frmAgregarAlquiler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarAlquiler));
            this.cmbVehiculos = new System.Windows.Forms.ComboBox();
            this.lblSeguro = new System.Windows.Forms.Label();
            this.btnAgregarVehiculo = new System.Windows.Forms.Button();
            this.lblApp = new System.Windows.Forms.Label();
            this.btnCabify = new System.Windows.Forms.RadioButton();
            this.btnDidi = new System.Windows.Forms.RadioButton();
            this.btnUber = new System.Windows.Forms.RadioButton();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbVehiculos
            // 
            this.cmbVehiculos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehiculos.FormattingEnabled = true;
            this.cmbVehiculos.Location = new System.Drawing.Point(464, 126);
            this.cmbVehiculos.Name = "cmbVehiculos";
            this.cmbVehiculos.Size = new System.Drawing.Size(240, 28);
            this.cmbVehiculos.TabIndex = 33;
            // 
            // lblSeguro
            // 
            this.lblSeguro.AutoSize = true;
            this.lblSeguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeguro.Location = new System.Drawing.Point(48, 130);
            this.lblSeguro.Name = "lblSeguro";
            this.lblSeguro.Size = new System.Drawing.Size(393, 24);
            this.lblSeguro.TabIndex = 32;
            this.lblSeguro.Text = "Seleccione el Vehiculo que Utilizara el Chofer";
            // 
            // btnAgregarVehiculo
            // 
            this.btnAgregarVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarVehiculo.Location = new System.Drawing.Point(438, 509);
            this.btnAgregarVehiculo.Name = "btnAgregarVehiculo";
            this.btnAgregarVehiculo.Size = new System.Drawing.Size(266, 49);
            this.btnAgregarVehiculo.TabIndex = 29;
            this.btnAgregarVehiculo.Text = "Agregar Nuevo Vehiculo";
            this.btnAgregarVehiculo.UseVisualStyleBackColor = true;
            this.btnAgregarVehiculo.Click += new System.EventHandler(this.btnAgregarVehiculo_Click);
            // 
            // lblApp
            // 
            this.lblApp.AutoSize = true;
            this.lblApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApp.Location = new System.Drawing.Point(48, 40);
            this.lblApp.Name = "lblApp";
            this.lblApp.Size = new System.Drawing.Size(405, 24);
            this.lblApp.TabIndex = 28;
            this.lblApp.Text = "Seleccione la Aplicacion que Utilizara el Chofer";
            // 
            // btnCabify
            // 
            this.btnCabify.AutoSize = true;
            this.btnCabify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCabify.Location = new System.Drawing.Point(273, 83);
            this.btnCabify.Name = "btnCabify";
            this.btnCabify.Size = new System.Drawing.Size(86, 28);
            this.btnCabify.TabIndex = 34;
            this.btnCabify.TabStop = true;
            this.btnCabify.Text = "Cabify";
            this.btnCabify.UseVisualStyleBackColor = true;
            // 
            // btnDidi
            // 
            this.btnDidi.AutoSize = true;
            this.btnDidi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDidi.Location = new System.Drawing.Point(166, 83);
            this.btnDidi.Name = "btnDidi";
            this.btnDidi.Size = new System.Drawing.Size(67, 28);
            this.btnDidi.TabIndex = 35;
            this.btnDidi.TabStop = true;
            this.btnDidi.Text = "Didi";
            this.btnDidi.UseVisualStyleBackColor = true;
            // 
            // btnUber
            // 
            this.btnUber.AutoSize = true;
            this.btnUber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUber.Location = new System.Drawing.Point(54, 83);
            this.btnUber.Name = "btnUber";
            this.btnUber.Size = new System.Drawing.Size(76, 28);
            this.btnUber.TabIndex = 36;
            this.btnUber.TabStop = true;
            this.btnUber.Text = "Uber";
            this.btnUber.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(122, 231);
            this.monthCalendar1.MaxDate = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 24);
            this.label1.TabIndex = 38;
            this.label1.Text = "Seleccione la Fecha del Inicio y del Fin del Alquiler";
            // 
            // frmAgregarAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(726, 587);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btnUber);
            this.Controls.Add(this.btnDidi);
            this.Controls.Add(this.btnCabify);
            this.Controls.Add(this.cmbVehiculos);
            this.Controls.Add(this.lblSeguro);
            this.Controls.Add(this.btnAgregarVehiculo);
            this.Controls.Add(this.lblApp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAgregarAlquiler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Alquiler";
            this.Load += new System.EventHandler(this.frmAgregarAlquiler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbVehiculos;
        private System.Windows.Forms.Label lblSeguro;
        private System.Windows.Forms.Button btnAgregarVehiculo;
        private System.Windows.Forms.Label lblApp;
        private System.Windows.Forms.RadioButton btnCabify;
        private System.Windows.Forms.RadioButton btnDidi;
        private System.Windows.Forms.RadioButton btnUber;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
    }
}