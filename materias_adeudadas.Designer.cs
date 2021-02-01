namespace ControlEscolar
{
    partial class materias_adeudadas
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
            this.data_materias = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.data_alumnos = new System.Windows.Forms.ComboBox();
            this.matricula = new System.Windows.Forms.Label();
            this.obtener = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_materias)).BeginInit();
            this.SuspendLayout();
            // 
            // data_materias
            // 
            this.data_materias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_materias.Location = new System.Drawing.Point(27, 107);
            this.data_materias.Name = "data_materias";
            this.data_materias.Size = new System.Drawing.Size(240, 150);
            this.data_materias.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Materias adeudadas de:";
            // 
            // data_alumnos
            // 
            this.data_alumnos.FormattingEnabled = true;
            this.data_alumnos.Location = new System.Drawing.Point(38, 49);
            this.data_alumnos.Name = "data_alumnos";
            this.data_alumnos.Size = new System.Drawing.Size(121, 21);
            this.data_alumnos.TabIndex = 2;
            this.data_alumnos.SelectedIndexChanged += new System.EventHandler(this.data_alumnos_SelectedIndexChanged);
            // 
            // matricula
            // 
            this.matricula.AutoSize = true;
            this.matricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matricula.Location = new System.Drawing.Point(35, 73);
            this.matricula.Name = "matricula";
            this.matricula.Size = new System.Drawing.Size(81, 18);
            this.matricula.TabIndex = 3;
            this.matricula.Text = "A00000000";
            // 
            // obtener
            // 
            this.obtener.Location = new System.Drawing.Point(192, 49);
            this.obtener.Name = "obtener";
            this.obtener.Size = new System.Drawing.Size(75, 42);
            this.obtener.TabIndex = 4;
            this.obtener.Text = "Obtener";
            this.obtener.UseVisualStyleBackColor = true;
            this.obtener.Click += new System.EventHandler(this.obtener_Click);
            // 
            // materias_adeudadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 278);
            this.Controls.Add(this.obtener);
            this.Controls.Add(this.matricula);
            this.Controls.Add(this.data_alumnos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_materias);
            this.MaximizeBox = false;
            this.Name = "materias_adeudadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Materias adeudadas";
            this.Load += new System.EventHandler(this.materias_adeudadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_materias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_materias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox data_alumnos;
        private System.Windows.Forms.Label matricula;
        private System.Windows.Forms.Button obtener;
    }
}