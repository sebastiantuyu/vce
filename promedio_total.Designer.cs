﻿namespace ControlEscolar
{
    partial class promedio_total
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
            this.data_promedio = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_promedio)).BeginInit();
            this.SuspendLayout();
            // 
            // data_promedio
            // 
            this.data_promedio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_promedio.Location = new System.Drawing.Point(12, 85);
            this.data_promedio.Name = "data_promedio";
            this.data_promedio.ReadOnly = true;
            this.data_promedio.Size = new System.Drawing.Size(450, 359);
            this.data_promedio.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Promedio total de alumnos";
            // 
            // promedio_total
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 456);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_promedio);
            this.MaximizeBox = false;
            this.Name = "promedio_total";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promedio total";
            this.Load += new System.EventHandler(this.promedio_total_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_promedio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_promedio;
        private System.Windows.Forms.Label label1;
    }
}