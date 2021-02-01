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
            ((System.ComponentModel.ISupportInitialize)(this.data_alumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // data_alumnos
            // 
            this.data_alumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_alumnos.Location = new System.Drawing.Point(12, 65);
            this.data_alumnos.Name = "data_alumnos";
            this.data_alumnos.Size = new System.Drawing.Size(455, 374);
            this.data_alumnos.TabIndex = 0;
            // 
            // mostrar_alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 451);
            this.Controls.Add(this.data_alumnos);
            this.Name = "mostrar_alumnos";
            this.Text = "mostrar_alumnos";
            this.Load += new System.EventHandler(this.mostrar_alumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_alumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_alumnos;
    }
}