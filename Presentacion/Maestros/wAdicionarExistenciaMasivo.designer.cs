﻿namespace Presentacion.Maestros
{
    partial class wAdicionarExistenciaMasivo
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblTit = new System.Windows.Forms.Label();
            this.DgvExi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodAlm1 = new System.Windows.Forms.TextBox();
            this.txtDesAlm1 = new System.Windows.Forms.TextBox();
            this.btnFiltrarExistencia = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodAlm2 = new System.Windows.Forms.TextBox();
            this.txtDesAlm2 = new System.Windows.Forms.TextBox();
            this.btnMarcarTodas = new System.Windows.Forms.Button();
            this.btnDesmarcarTodas = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvExi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(471, 464);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 25);
            this.btnCancelar.TabIndex = 71;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(356, 464);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(109, 25);
            this.btnAceptar.TabIndex = 72;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblTit
            // 
            this.lblTit.BackColor = System.Drawing.Color.DarkGray;
            this.lblTit.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTit.ForeColor = System.Drawing.Color.White;
            this.lblTit.Location = new System.Drawing.Point(23, 134);
            this.lblTit.Name = "lblTit";
            this.lblTit.Size = new System.Drawing.Size(557, 14);
            this.lblTit.TabIndex = 74;
            this.lblTit.Text = "Existencias a seleccionar";
            this.lblTit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DgvExi
            // 
            this.DgvExi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvExi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvExi.GridColor = System.Drawing.Color.Silver;
            this.DgvExi.Location = new System.Drawing.Point(23, 184);
            this.DgvExi.Name = "DgvExi";
            this.DgvExi.Size = new System.Drawing.Size(557, 274);
            this.DgvExi.TabIndex = 96;
            this.DgvExi.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvExi_CellValueChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 14);
            this.label1.TabIndex = 97;
            this.label1.Text = "Almacen de donde quiere copiar las existencias";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 14);
            this.label2.TabIndex = 414;
            this.label2.Text = "Almacen";
            // 
            // txtCodAlm1
            // 
            this.txtCodAlm1.Location = new System.Drawing.Point(107, 55);
            this.txtCodAlm1.Name = "txtCodAlm1";
            this.txtCodAlm1.Size = new System.Drawing.Size(28, 22);
            this.txtCodAlm1.TabIndex = 412;
            this.txtCodAlm1.DoubleClick += new System.EventHandler(this.txtCodAlm1_DoubleClick);
            this.txtCodAlm1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodAlm1_KeyDown);
            this.txtCodAlm1.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodAlm1_Validating);
            // 
            // txtDesAlm1
            // 
            this.txtDesAlm1.Location = new System.Drawing.Point(136, 55);
            this.txtDesAlm1.Name = "txtDesAlm1";
            this.txtDesAlm1.ReadOnly = true;
            this.txtDesAlm1.Size = new System.Drawing.Size(214, 22);
            this.txtDesAlm1.TabIndex = 413;
            // 
            // btnFiltrarExistencia
            // 
            this.btnFiltrarExistencia.Location = new System.Drawing.Point(356, 104);
            this.btnFiltrarExistencia.Name = "btnFiltrarExistencia";
            this.btnFiltrarExistencia.Size = new System.Drawing.Size(224, 25);
            this.btnFiltrarExistencia.TabIndex = 415;
            this.btnFiltrarExistencia.Text = "Filtrar";
            this.btnFiltrarExistencia.UseVisualStyleBackColor = true;
            this.btnFiltrarExistencia.Click += new System.EventHandler(this.btnFiltrarExistencia_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 14);
            this.label3.TabIndex = 419;
            this.label3.Text = "Almacen";
            // 
            // txtCodAlm2
            // 
            this.txtCodAlm2.Location = new System.Drawing.Point(107, 105);
            this.txtCodAlm2.Name = "txtCodAlm2";
            this.txtCodAlm2.Size = new System.Drawing.Size(28, 22);
            this.txtCodAlm2.TabIndex = 417;
            this.txtCodAlm2.DoubleClick += new System.EventHandler(this.txtCodAlm2_DoubleClick);
            this.txtCodAlm2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodAlm2_KeyDown);
            this.txtCodAlm2.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodAlm2_Validating);
            // 
            // txtDesAlm2
            // 
            this.txtDesAlm2.Location = new System.Drawing.Point(136, 105);
            this.txtDesAlm2.Name = "txtDesAlm2";
            this.txtDesAlm2.ReadOnly = true;
            this.txtDesAlm2.Size = new System.Drawing.Size(214, 22);
            this.txtDesAlm2.TabIndex = 418;
            // 
            // btnMarcarTodas
            // 
            this.btnMarcarTodas.Location = new System.Drawing.Point(23, 153);
            this.btnMarcarTodas.Name = "btnMarcarTodas";
            this.btnMarcarTodas.Size = new System.Drawing.Size(130, 25);
            this.btnMarcarTodas.TabIndex = 420;
            this.btnMarcarTodas.Text = "Marcar Todas";
            this.btnMarcarTodas.UseVisualStyleBackColor = true;
            this.btnMarcarTodas.Click += new System.EventHandler(this.btnMarcarTodas_Click);
            // 
            // btnDesmarcarTodas
            // 
            this.btnDesmarcarTodas.Location = new System.Drawing.Point(159, 153);
            this.btnDesmarcarTodas.Name = "btnDesmarcarTodas";
            this.btnDesmarcarTodas.Size = new System.Drawing.Size(130, 25);
            this.btnDesmarcarTodas.TabIndex = 421;
            this.btnDesmarcarTodas.Text = "Desmarcar Todas";
            this.btnDesmarcarTodas.UseVisualStyleBackColor = true;
            this.btnDesmarcarTodas.Click += new System.EventHandler(this.btnDesmarcarTodas_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DarkGray;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(23, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(327, 14);
            this.label6.TabIndex = 422;
            this.label6.Text = "Almacen a donde se quiere copiar estas existencias";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wAdicionarExistenciaMasivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.ClientSize = new System.Drawing.Size(606, 507);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDesmarcarTodas);
            this.Controls.Add(this.btnMarcarTodas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodAlm2);
            this.Controls.Add(this.txtDesAlm2);
            this.Controls.Add(this.btnFiltrarExistencia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodAlm1);
            this.Controls.Add(this.txtDesAlm1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvExi);
            this.Controls.Add(this.lblTit);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Font = new System.Drawing.Font("Calibri", 8.75F);
            this.Name = "wAdicionarExistenciaMasivo";
            this.Text = "Adicionar Existencias";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.wAdicionarExistenciaMasivo_FormClosing);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.lblTit, 0);
            this.Controls.SetChildIndex(this.DgvExi, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtDesAlm1, 0);
            this.Controls.SetChildIndex(this.txtCodAlm1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btnFiltrarExistencia, 0);
            this.Controls.SetChildIndex(this.txtDesAlm2, 0);
            this.Controls.SetChildIndex(this.txtCodAlm2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btnMarcarTodas, 0);
            this.Controls.SetChildIndex(this.btnDesmarcarTodas, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DgvExi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblTit;
        private System.Windows.Forms.DataGridView DgvExi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtCodAlm1;
        internal System.Windows.Forms.TextBox txtDesAlm1;
        private System.Windows.Forms.Button btnFiltrarExistencia;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtCodAlm2;
        internal System.Windows.Forms.TextBox txtDesAlm2;
        private System.Windows.Forms.Button btnMarcarTodas;
        private System.Windows.Forms.Button btnDesmarcarTodas;
        private System.Windows.Forms.Label label6;
    }
}
