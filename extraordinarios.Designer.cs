﻿namespace ControlEscolar
{
    partial class extraordinarios
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
            this.data_extra = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_extra)).BeginInit();
            this.SuspendLayout();
            // 
            // data_extra
            // 
            this.data_extra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_extra.Location = new System.Drawing.Point(12, 106);
            this.data_extra.Name = "data_extra";
            this.data_extra.ReadOnly = true;
            this.data_extra.Size = new System.Drawing.Size(455, 333);
            this.data_extra.TabIndex = 0;
            this.data_extra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_extra_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Extraordinarios";
            // 
            // extraordinarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 451);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_extra);
            this.MaximizeBox = false;
            this.Name = "extraordinarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extraordinarios";
            this.Load += new System.EventHandler(this.extraordinarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_extra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_extra;
        private System.Windows.Forms.Label label1;
    }
}