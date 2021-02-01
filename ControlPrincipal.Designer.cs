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
            this.helper_title = new System.Windows.Forms.Label();
            this.helper_content = new System.Windows.Forms.Label();
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
            this.alumnos_existentes.Click += new System.EventHandler(this.alumnos_existentes_Click);
            this.alumnos_existentes.MouseHover += new System.EventHandler(this.alumnos_existentes_MouseHover);
            // 
            // materias_existentes
            // 
            this.materias_existentes.Location = new System.Drawing.Point(12, 90);
            this.materias_existentes.Name = "materias_existentes";
            this.materias_existentes.Size = new System.Drawing.Size(130, 45);
            this.materias_existentes.TabIndex = 2;
            this.materias_existentes.Text = "Materias existentes";
            this.materias_existentes.UseVisualStyleBackColor = true;
            this.materias_existentes.Click += new System.EventHandler(this.materias_existentes_Click);
            // 
            // alta_alumnos
            // 
            this.alta_alumnos.Location = new System.Drawing.Point(12, 141);
            this.alta_alumnos.Name = "alta_alumnos";
            this.alta_alumnos.Size = new System.Drawing.Size(130, 45);
            this.alta_alumnos.TabIndex = 3;
            this.alta_alumnos.Text = "Alta de alumnos";
            this.alta_alumnos.UseVisualStyleBackColor = true;
            this.alta_alumnos.Click += new System.EventHandler(this.alta_alumnos_Click);
            // 
            // modificar_calificaciones
            // 
            this.modificar_calificaciones.Location = new System.Drawing.Point(12, 192);
            this.modificar_calificaciones.Name = "modificar_calificaciones";
            this.modificar_calificaciones.Size = new System.Drawing.Size(130, 45);
            this.modificar_calificaciones.TabIndex = 4;
            this.modificar_calificaciones.Text = "Modificar calificaciones";
            this.modificar_calificaciones.UseVisualStyleBackColor = true;
            this.modificar_calificaciones.Click += new System.EventHandler(this.modificar_calificaciones_Click);
            // 
            // promedio_total
            // 
            this.promedio_total.Location = new System.Drawing.Point(12, 243);
            this.promedio_total.Name = "promedio_total";
            this.promedio_total.Size = new System.Drawing.Size(130, 45);
            this.promedio_total.TabIndex = 5;
            this.promedio_total.Text = "Promedio total de alumnos";
            this.promedio_total.UseVisualStyleBackColor = true;
            this.promedio_total.Click += new System.EventHandler(this.promedio_total_Click);
            // 
            // promedio_parcial
            // 
            this.promedio_parcial.Location = new System.Drawing.Point(12, 294);
            this.promedio_parcial.Name = "promedio_parcial";
            this.promedio_parcial.Size = new System.Drawing.Size(130, 45);
            this.promedio_parcial.TabIndex = 6;
            this.promedio_parcial.Text = "Promedio parical de alumnos";
            this.promedio_parcial.UseVisualStyleBackColor = true;
            this.promedio_parcial.Click += new System.EventHandler(this.promedio_parcial_Click);
            // 
            // materias_adeudadas
            // 
            this.materias_adeudadas.Location = new System.Drawing.Point(12, 345);
            this.materias_adeudadas.Name = "materias_adeudadas";
            this.materias_adeudadas.Size = new System.Drawing.Size(130, 45);
            this.materias_adeudadas.TabIndex = 7;
            this.materias_adeudadas.Text = "Materias adeudadas";
            this.materias_adeudadas.UseVisualStyleBackColor = true;
            this.materias_adeudadas.Click += new System.EventHandler(this.materias_adeudadas_Click);
            // 
            // extraordinarios
            // 
            this.extraordinarios.Location = new System.Drawing.Point(12, 396);
            this.extraordinarios.Name = "extraordinarios";
            this.extraordinarios.Size = new System.Drawing.Size(130, 45);
            this.extraordinarios.TabIndex = 8;
            this.extraordinarios.Text = "Extraordinarios";
            this.extraordinarios.UseVisualStyleBackColor = true;
            this.extraordinarios.Click += new System.EventHandler(this.extraordinarios_Click);
            // 
            // helper_title
            // 
            this.helper_title.AutoSize = true;
            this.helper_title.Font = new System.Drawing.Font("Monotxt_IV25", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helper_title.Location = new System.Drawing.Point(187, 48);
            this.helper_title.Name = "helper_title";
            this.helper_title.Size = new System.Drawing.Size(252, 26);
            this.helper_title.TabIndex = 9;
            this.helper_title.Text = "Control escolar";
            // 
            // helper_content
            // 
            this.helper_content.AutoSize = true;
            this.helper_content.Font = new System.Drawing.Font("Monotxt_IV25", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helper_content.Location = new System.Drawing.Point(189, 90);
            this.helper_content.Name = "helper_content";
            this.helper_content.Size = new System.Drawing.Size(153, 20);
            this.helper_content.TabIndex = 10;
            this.helper_content.Text = "Esta funcion";
            // 
            // ControlPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 451);
            this.Controls.Add(this.helper_content);
            this.Controls.Add(this.helper_title);
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
            this.PerformLayout();

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
        private System.Windows.Forms.Label helper_title;
        private System.Windows.Forms.Label helper_content;
    }
}

