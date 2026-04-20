namespace prySilvaMenendez_Act.FlotaAutos
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregarChofer = new System.Windows.Forms.Button();
            this.btnAgregarVehiculo = new System.Windows.Forms.Button();
            this.btnAgregarAlquiler = new System.Windows.Forms.Button();
            this.btnVerDatosChoferes = new System.Windows.Forms.Button();
            this.btnVerDatosVehiculos = new System.Windows.Forms.Button();
            this.btnVerAlquileresEnCurso = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarChofer
            // 
            this.btnAgregarChofer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarChofer.Location = new System.Drawing.Point(6, 243);
            this.btnAgregarChofer.Name = "btnAgregarChofer";
            this.btnAgregarChofer.Size = new System.Drawing.Size(336, 40);
            this.btnAgregarChofer.TabIndex = 0;
            this.btnAgregarChofer.Text = "Agregar Chofer";
            this.btnAgregarChofer.UseVisualStyleBackColor = true;
            this.btnAgregarChofer.Click += new System.EventHandler(this.btnAgregarChofer_Click);
            // 
            // btnAgregarVehiculo
            // 
            this.btnAgregarVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarVehiculo.Location = new System.Drawing.Point(6, 146);
            this.btnAgregarVehiculo.Name = "btnAgregarVehiculo";
            this.btnAgregarVehiculo.Size = new System.Drawing.Size(336, 43);
            this.btnAgregarVehiculo.TabIndex = 1;
            this.btnAgregarVehiculo.Text = "Agregar Vehículo";
            this.btnAgregarVehiculo.UseVisualStyleBackColor = true;
            this.btnAgregarVehiculo.Click += new System.EventHandler(this.btnAgregarVehiculo_Click_1);
            // 
            // btnAgregarAlquiler
            // 
            this.btnAgregarAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAlquiler.Location = new System.Drawing.Point(6, 59);
            this.btnAgregarAlquiler.Name = "btnAgregarAlquiler";
            this.btnAgregarAlquiler.Size = new System.Drawing.Size(336, 38);
            this.btnAgregarAlquiler.TabIndex = 2;
            this.btnAgregarAlquiler.Text = "Agregar Nuevo Alquiler";
            this.btnAgregarAlquiler.UseVisualStyleBackColor = true;
            this.btnAgregarAlquiler.Click += new System.EventHandler(this.btnAgregarAlquiler_Click);
            // 
            // btnVerDatosChoferes
            // 
            this.btnVerDatosChoferes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDatosChoferes.Location = new System.Drawing.Point(6, 243);
            this.btnVerDatosChoferes.Name = "btnVerDatosChoferes";
            this.btnVerDatosChoferes.Size = new System.Drawing.Size(336, 40);
            this.btnVerDatosChoferes.TabIndex = 3;
            this.btnVerDatosChoferes.Text = "Ver Datos de Choferes";
            this.btnVerDatosChoferes.UseVisualStyleBackColor = true;
            this.btnVerDatosChoferes.Click += new System.EventHandler(this.btnVerDatosChoferes_Click);
            // 
            // btnVerDatosVehiculos
            // 
            this.btnVerDatosVehiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDatosVehiculos.Location = new System.Drawing.Point(6, 146);
            this.btnVerDatosVehiculos.Name = "btnVerDatosVehiculos";
            this.btnVerDatosVehiculos.Size = new System.Drawing.Size(336, 43);
            this.btnVerDatosVehiculos.TabIndex = 4;
            this.btnVerDatosVehiculos.Text = "Ver Datos de los Vehículos";
            this.btnVerDatosVehiculos.UseVisualStyleBackColor = true;
            this.btnVerDatosVehiculos.Click += new System.EventHandler(this.btnVerDatosVehiculos_Click);
            // 
            // btnVerAlquileresEnCurso
            // 
            this.btnVerAlquileresEnCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerAlquileresEnCurso.Location = new System.Drawing.Point(6, 59);
            this.btnVerAlquileresEnCurso.Name = "btnVerAlquileresEnCurso";
            this.btnVerAlquileresEnCurso.Size = new System.Drawing.Size(336, 38);
            this.btnVerAlquileresEnCurso.TabIndex = 5;
            this.btnVerAlquileresEnCurso.Text = "Ver Alquileres en Curso";
            this.btnVerAlquileresEnCurso.UseVisualStyleBackColor = true;
            this.btnVerAlquileresEnCurso.Click += new System.EventHandler(this.btnVerAlquileresEnCurso_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregarChofer);
            this.groupBox1.Controls.Add(this.btnAgregarVehiculo);
            this.groupBox1.Controls.Add(this.btnAgregarAlquiler);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 320);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Nuevo Elemento";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVerDatosChoferes);
            this.groupBox2.Controls.Add(this.btnVerDatosVehiculos);
            this.groupBox2.Controls.Add(this.btnVerAlquileresEnCurso);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(379, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 320);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ver Datos";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(210, 110);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(362, 22);
            this.lbl1.TabIndex = 8;
            this.lbl1.Text = "Haga Click en la Acción que Desea Realizar";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(144, 40);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(508, 29);
            this.lbl2.TabIndex = 9;
            this.lbl2.Text = "Bienvenido al Sistema de ACDC Vehiculos";
            // 
            // btnSalir
            // 
            this.btnSalir.ForeColor = System.Drawing.Color.Red;
            this.btnSalir.Location = new System.Drawing.Point(630, 489);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 31);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "&SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 535);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACDC - Alquiler de Vehiculos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarChofer;
        private System.Windows.Forms.Button btnAgregarVehiculo;
        private System.Windows.Forms.Button btnAgregarAlquiler;
        private System.Windows.Forms.Button btnVerDatosChoferes;
        private System.Windows.Forms.Button btnVerDatosVehiculos;
        private System.Windows.Forms.Button btnVerAlquileresEnCurso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btnSalir;
    }
}

