namespace ControlEscolar
{
    partial class ControlPrincipal
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
            this.exit = new System.Windows.Forms.Button();
            this.alumnos_existentes = new System.Windows.Forms.Button();
            this.materias_existentes = new System.Windows.Forms.Button();
            this.alta_alumnos = new System.Windows.Forms.Button();
            this.modificar_calificaciones = new System.Windows.Forms.Button();
            this.promedio_total = new System.Windows.Forms.Button();
            this.promedio_parcial = new System.Windows.Forms.Button();
            this.materias_adeudadas = new System.Windows.Forms.Button();
            this.extraordinarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(391, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 0;
            this.exit.Text = "Salir";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // alumnos_existentes
            // 
            this.alumnos_existentes.Location = new System.Drawing.Point(12, 39);
            this.alumnos_existentes.Name = "alumnos_existentes";
            this.alumnos_existentes.Size = new System.Drawing.Size(130, 45);
            this.alumnos_existentes.TabIndex = 1;
            this.alumnos_existentes.Text = "Alumnos existentes";
            this.alumnos_existentes.UseVisualStyleBackColor = true;
            // 
            // materias_existentes
            // 
            this.materias_existentes.Location = new System.Drawing.Point(12, 90);
            this.materias_existentes.Name = "materias_existentes";
            this.materias_existentes.Size = new System.Drawing.Size(130, 45);
            this.materias_existentes.TabIndex = 2;
            this.materias_existentes.Text = "Materias existentes";
            this.materias_existentes.UseVisualStyleBackColor = true;
            // 
            // alta_alumnos
            // 
            this.alta_alumnos.Location = new System.Drawing.Point(12, 141);
            this.alta_alumnos.Name = "alta_alumnos";
            this.alta_alumnos.Size = new System.Drawing.Size(130, 45);
            this.alta_alumnos.TabIndex = 3;
            this.alta_alumnos.Text = "Alta de alumnos";
            this.alta_alumnos.UseVisualStyleBackColor = true;
            // 
            // modificar_calificaciones
            // 
            this.modificar_calificaciones.Location = new System.Drawing.Point(12, 192);
            this.modificar_calificaciones.Name = "modificar_calificaciones";
            this.modificar_calificaciones.Size = new System.Drawing.Size(130, 45);
            this.modificar_calificaciones.TabIndex = 4;
            this.modificar_calificaciones.Text = "Modificar calificaciones";
            this.modificar_calificaciones.UseVisualStyleBackColor = true;
            // 
            // promedio_total
            // 
            this.promedio_total.Location = new System.Drawing.Point(12, 243);
            this.promedio_total.Name = "promedio_total";
            this.promedio_total.Size = new System.Drawing.Size(130, 45);
            this.promedio_total.TabIndex = 5;
            this.promedio_total.Text = "Promedio total de alumnos";
            this.promedio_total.UseVisualStyleBackColor = true;
            // 
            // promedio_parcial
            // 
            this.promedio_parcial.Location = new System.Drawing.Point(12, 294);
            this.promedio_parcial.Name = "promedio_parcial";
            this.promedio_parcial.Size = new System.Drawing.Size(130, 45);
            this.promedio_parcial.TabIndex = 6;
            this.promedio_parcial.Text = "Promedio parical de alumnos";
            this.promedio_parcial.UseVisualStyleBackColor = true;
            // 
            // materias_adeudadas
            // 
            this.materias_adeudadas.Location = new System.Drawing.Point(12, 345);
            this.materias_adeudadas.Name = "materias_adeudadas";
            this.materias_adeudadas.Size = new System.Drawing.Size(130, 45);
            this.materias_adeudadas.TabIndex = 7;
            this.materias_adeudadas.Text = "Materias adeudadas";
            this.materias_adeudadas.UseVisualStyleBackColor = true;
            // 
            // extraordinarios
            // 
            this.extraordinarios.Location = new System.Drawing.Point(12, 396);
            this.extraordinarios.Name = "extraordinarios";
            this.extraordinarios.Size = new System.Drawing.Size(130, 45);
            this.extraordinarios.TabIndex = 8;
            this.extraordinarios.Text = "Extraordinarios";
            this.extraordinarios.UseVisualStyleBackColor = true;
            // 
            // ControlPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 450);
            this.Controls.Add(this.extraordinarios);
            this.Controls.Add(this.materias_adeudadas);
            this.Controls.Add(this.promedio_parcial);
            this.Controls.Add(this.promedio_total);
            this.Controls.Add(this.modificar_calificaciones);
            this.Controls.Add(this.alta_alumnos);
            this.Controls.Add(this.materias_existentes);
            this.Controls.Add(this.alumnos_existentes);
            this.Controls.Add(this.exit);
            this.MaximizeBox = false;
            this.Name = "ControlPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Escolar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button alumnos_existentes;
        private System.Windows.Forms.Button materias_existentes;
        private System.Windows.Forms.Button alta_alumnos;
        private System.Windows.Forms.Button modificar_calificaciones;
        private System.Windows.Forms.Button promedio_total;
        private System.Windows.Forms.Button promedio_parcial;
        private System.Windows.Forms.Button materias_adeudadas;
        private System.Windows.Forms.Button extraordinarios;
    }
}

