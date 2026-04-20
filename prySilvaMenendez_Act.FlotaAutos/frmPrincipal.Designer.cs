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
            this.btnAgregarAuto = new System.Windows.Forms.Button();
            this.btnAgregarAlquiler = new System.Windows.Forms.Button();
            this.btnVerDatosChoferes = new System.Windows.Forms.Button();
            this.btnVerDatosVehiculos = new System.Windows.Forms.Button();
            this.btnVerAlquileresEnCurso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarChofer
            // 
            this.btnAgregarChofer.Location = new System.Drawing.Point(232, 12);
            this.btnAgregarChofer.Name = "btnAgregarChofer";
            this.btnAgregarChofer.Size = new System.Drawing.Size(336, 40);
            this.btnAgregarChofer.TabIndex = 0;
            this.btnAgregarChofer.Text = "Agregar Chofer";
            this.btnAgregarChofer.UseVisualStyleBackColor = true;
            // 
            // btnAgregarAuto
            // 
            this.btnAgregarAuto.Location = new System.Drawing.Point(232, 77);
            this.btnAgregarAuto.Name = "btnAgregarAuto";
            this.btnAgregarAuto.Size = new System.Drawing.Size(336, 43);
            this.btnAgregarAuto.TabIndex = 1;
            this.btnAgregarAuto.Text = "Agregar Vehículo";
            this.btnAgregarAuto.UseVisualStyleBackColor = true;
            // 
            // btnAgregarAlquiler
            // 
            this.btnAgregarAlquiler.Location = new System.Drawing.Point(232, 150);
            this.btnAgregarAlquiler.Name = "btnAgregarAlquiler";
            this.btnAgregarAlquiler.Size = new System.Drawing.Size(336, 38);
            this.btnAgregarAlquiler.TabIndex = 2;
            this.btnAgregarAlquiler.Text = "Agregar Nuevo Alquiler";
            this.btnAgregarAlquiler.UseVisualStyleBackColor = true;
            // 
            // btnVerDatosChoferes
            // 
            this.btnVerDatosChoferes.Location = new System.Drawing.Point(232, 226);
            this.btnVerDatosChoferes.Name = "btnVerDatosChoferes";
            this.btnVerDatosChoferes.Size = new System.Drawing.Size(336, 29);
            this.btnVerDatosChoferes.TabIndex = 3;
            this.btnVerDatosChoferes.Text = "Ver Datos de Choferes";
            this.btnVerDatosChoferes.UseVisualStyleBackColor = true;
            // 
            // btnVerDatosVehiculos
            // 
            this.btnVerDatosVehiculos.Location = new System.Drawing.Point(232, 285);
            this.btnVerDatosVehiculos.Name = "btnVerDatosVehiculos";
            this.btnVerDatosVehiculos.Size = new System.Drawing.Size(336, 33);
            this.btnVerDatosVehiculos.TabIndex = 4;
            this.btnVerDatosVehiculos.Text = "Ver Datos de los Vehículos";
            this.btnVerDatosVehiculos.UseVisualStyleBackColor = true;
            // 
            // btnVerAlquileresEnCurso
            // 
            this.btnVerAlquileresEnCurso.Location = new System.Drawing.Point(232, 354);
            this.btnVerAlquileresEnCurso.Name = "btnVerAlquileresEnCurso";
            this.btnVerAlquileresEnCurso.Size = new System.Drawing.Size(336, 36);
            this.btnVerAlquileresEnCurso.TabIndex = 5;
            this.btnVerAlquileresEnCurso.Text = "Ver Alquileres en Curso";
            this.btnVerAlquileresEnCurso.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 450);
            this.Controls.Add(this.btnVerAlquileresEnCurso);
            this.Controls.Add(this.btnVerDatosVehiculos);
            this.Controls.Add(this.btnVerDatosChoferes);
            this.Controls.Add(this.btnAgregarAlquiler);
            this.Controls.Add(this.btnAgregarAuto);
            this.Controls.Add(this.btnAgregarChofer);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarChofer;
        private System.Windows.Forms.Button btnAgregarAuto;
        private System.Windows.Forms.Button btnAgregarAlquiler;
        private System.Windows.Forms.Button btnVerDatosChoferes;
        private System.Windows.Forms.Button btnVerDatosVehiculos;
        private System.Windows.Forms.Button btnVerAlquileresEnCurso;
    }
}

