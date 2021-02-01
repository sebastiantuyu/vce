namespace ControlEscolar
{
    partial class mostrar_alumnos
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
            this.data_alumnos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_alumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // data_alumnos
            // 
            this.data_alumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_alumnos.Location = new System.Drawing.Point(12, 65);
            this.data_alumnos.Name = "data_alumnos";
            this.data_alumnos.ReadOnly = true;
            this.data_alumnos.Size = new System.Drawing.Size(455, 374);
            this.data_alumnos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alumnos registrados actualmente";
            // 
            // mostrar_alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 451);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_alumnos);
            this.Name = "mostrar_alumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mostrar_alumnos";
            this.Load += new System.EventHandler(this.mostrar_alumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_alumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_alumnos;
        private System.Windows.Forms.Label label1;
    }
}