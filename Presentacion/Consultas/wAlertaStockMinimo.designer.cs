﻿namespace Presentacion.Consultas
{
    partial class wAlertaStockMinimo
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTit = new System.Windows.Forms.Label();
            this.dgvMovDet = new System.Windows.Forms.DataGridView();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovDet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTit
            // 
            this.lblTit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTit.BackColor = System.Drawing.Color.DarkGray;
            this.lblTit.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTit.ForeColor = System.Drawing.Color.White;
            this.lblTit.Location = new System.Drawing.Point(17, 29);
            this.lblTit.Name = "lblTit";
            this.lblTit.Size = new System.Drawing.Size(1012, 14);
            this.lblTit.TabIndex = 418;
            this.lblTit.Text = "Filtros";
            this.lblTit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvMovDet
            // 
            this.dgvMovDet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMovDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovDet.Location = new System.Drawing.Point(18, 46);
            this.dgvMovDet.Name = "dgvMovDet";
            this.dgvMovDet.Size = new System.Drawing.Size(1010, 502);
            this.dgvMovDet.TabIndex = 431;
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportar.Location = new System.Drawing.Point(805, 554);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(109, 25);
            this.btnExportar.TabIndex = 432;
            this.btnExportar.Text = "Exportar Excel";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(920, 554);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(109, 25);
            this.btnSalir.TabIndex = 433;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // wAlertaStockMinimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.ClientSize = new System.Drawing.Size(1048, 595);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.dgvMovDet);
            this.Controls.Add(this.lblTit);
            this.Name = "wAlertaStockMinimo";
            this.Text = "Alerta Stock Minimo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.wAlertaStockMinimo_FormClosing);
            this.Controls.SetChildIndex(this.lblTit, 0);
            this.Controls.SetChildIndex(this.dgvMovDet, 0);
            this.Controls.SetChildIndex(this.btnExportar, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovDet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTit;
        internal System.Windows.Forms.DataGridView dgvMovDet;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnSalir;
    }
}
