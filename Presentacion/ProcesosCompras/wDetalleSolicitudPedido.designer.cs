﻿namespace Presentacion.ProcesosCompras
{
    partial class wDetalleSolicitudPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && (components != null) )
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtDesExi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodExi = new System.Windows.Forms.TextBox();
            this.txtGloMovDet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtCantMovDet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNUniMed = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCUniMed = new System.Windows.Forms.TextBox();
            this.txtCodPar = new System.Windows.Forms.TextBox();
            this.txtDesPar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStoAntExi = new System.Windows.Forms.TextBox();
            this.txtPreAntExi = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btnLote = new System.Windows.Forms.Button();
            this.txtCodTip = new System.Windows.Forms.TextBox();
            this.txtCEsLot = new System.Windows.Forms.TextBox();
            this.txtCanCon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCEsUniCon = new System.Windows.Forms.TextBox();
            this.txtFacCon = new System.Windows.Forms.TextBox();
            this.txtCodAre = new System.Windows.Forms.TextBox();
            this.txtDesAre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(418, 290);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 25);
            this.btnCancelar.TabIndex = 40;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtDesExi
            // 
            this.txtDesExi.Location = new System.Drawing.Point(294, 55);
            this.txtDesExi.Name = "txtDesExi";
            this.txtDesExi.ReadOnly = true;
            this.txtDesExi.Size = new System.Drawing.Size(228, 22);
            this.txtDesExi.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 14);
            this.label2.TabIndex = 41;
            this.label2.Text = "Existencia";
            // 
            // txtCodExi
            // 
            this.txtCodExi.Location = new System.Drawing.Point(191, 55);
            this.txtCodExi.MaxLength = 15;
            this.txtCodExi.Name = "txtCodExi";
            this.txtCodExi.Size = new System.Drawing.Size(102, 22);
            this.txtCodExi.TabIndex = 43;
            this.txtCodExi.DoubleClick += new System.EventHandler(this.txtCodExi_DoubleClick);
            this.txtCodExi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodExi_KeyDown);
            this.txtCodExi.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodExi_Validating);
            // 
            // txtGloMovDet
            // 
            this.txtGloMovDet.Location = new System.Drawing.Point(191, 223);
            this.txtGloMovDet.MaxLength = 250;
            this.txtGloMovDet.Multiline = true;
            this.txtGloMovDet.Name = "txtGloMovDet";
            this.txtGloMovDet.Size = new System.Drawing.Size(331, 55);
            this.txtGloMovDet.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 14);
            this.label4.TabIndex = 46;
            this.label4.Text = "Glosa";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(308, 290);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(104, 25);
            this.btnAceptar.TabIndex = 48;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtCantMovDet
            // 
            this.txtCantMovDet.Location = new System.Drawing.Point(191, 139);
            this.txtCantMovDet.MaxLength = 7;
            this.txtCantMovDet.Name = "txtCantMovDet";
            this.txtCantMovDet.Size = new System.Drawing.Size(102, 22);
            this.txtCantMovDet.TabIndex = 52;
            this.txtCantMovDet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantMovDet.Validated += new System.EventHandler(this.txtCant_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 14);
            this.label6.TabIndex = 51;
            this.label6.Text = "Cantidad";
            // 
            // txtNUniMed
            // 
            this.txtNUniMed.Location = new System.Drawing.Point(191, 83);
            this.txtNUniMed.Name = "txtNUniMed";
            this.txtNUniMed.ReadOnly = true;
            this.txtNUniMed.Size = new System.Drawing.Size(102, 22);
            this.txtNUniMed.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 14);
            this.label9.TabIndex = 63;
            this.label9.Text = "Unidad Medida";
            // 
            // txtCUniMed
            // 
            this.txtCUniMed.Location = new System.Drawing.Point(294, 83);
            this.txtCUniMed.Name = "txtCUniMed";
            this.txtCUniMed.ReadOnly = true;
            this.txtCUniMed.Size = new System.Drawing.Size(10, 22);
            this.txtCUniMed.TabIndex = 65;
            this.txtCUniMed.Visible = false;
            // 
            // txtCodPar
            // 
            this.txtCodPar.Location = new System.Drawing.Point(191, 194);
            this.txtCodPar.MaxLength = 15;
            this.txtCodPar.Name = "txtCodPar";
            this.txtCodPar.Size = new System.Drawing.Size(65, 22);
            this.txtCodPar.TabIndex = 68;
            this.txtCodPar.DoubleClick += new System.EventHandler(this.txtCodPar_DoubleClick);
            this.txtCodPar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodPar_KeyDown);
            this.txtCodPar.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodPar_Validating);
            // 
            // txtDesPar
            // 
            this.txtDesPar.Location = new System.Drawing.Point(257, 195);
            this.txtDesPar.Name = "txtDesPar";
            this.txtDesPar.ReadOnly = true;
            this.txtDesPar.Size = new System.Drawing.Size(265, 22);
            this.txtDesPar.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 14);
            this.label3.TabIndex = 66;
            this.label3.Text = "Partida";
            // 
            // txtStoAntExi
            // 
            this.txtStoAntExi.Location = new System.Drawing.Point(305, 83);
            this.txtStoAntExi.Name = "txtStoAntExi";
            this.txtStoAntExi.ReadOnly = true;
            this.txtStoAntExi.Size = new System.Drawing.Size(10, 22);
            this.txtStoAntExi.TabIndex = 69;
            this.txtStoAntExi.Visible = false;
            // 
            // txtPreAntExi
            // 
            this.txtPreAntExi.Location = new System.Drawing.Point(316, 83);
            this.txtPreAntExi.Name = "txtPreAntExi";
            this.txtPreAntExi.ReadOnly = true;
            this.txtPreAntExi.Size = new System.Drawing.Size(10, 22);
            this.txtPreAntExi.TabIndex = 70;
            this.txtPreAntExi.Visible = false;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.DarkGray;
            this.label21.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(32, 32);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(490, 14);
            this.label21.TabIndex = 357;
            this.label21.Text = "Datos Generales";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLote
            // 
            this.btnLote.Location = new System.Drawing.Point(294, 139);
            this.btnLote.Name = "btnLote";
            this.btnLote.Size = new System.Drawing.Size(55, 22);
            this.btnLote.TabIndex = 358;
            this.btnLote.Text = "Lote";
            this.btnLote.UseVisualStyleBackColor = true;
            this.btnLote.Click += new System.EventHandler(this.btnLote_Click);
            // 
            // txtCodTip
            // 
            this.txtCodTip.Location = new System.Drawing.Point(327, 83);
            this.txtCodTip.Name = "txtCodTip";
            this.txtCodTip.ReadOnly = true;
            this.txtCodTip.Size = new System.Drawing.Size(10, 22);
            this.txtCodTip.TabIndex = 359;
            this.txtCodTip.Visible = false;
            // 
            // txtCEsLot
            // 
            this.txtCEsLot.Location = new System.Drawing.Point(338, 83);
            this.txtCEsLot.Name = "txtCEsLot";
            this.txtCEsLot.ReadOnly = true;
            this.txtCEsLot.Size = new System.Drawing.Size(10, 22);
            this.txtCEsLot.TabIndex = 360;
            this.txtCEsLot.Visible = false;
            // 
            // txtCanCon
            // 
            this.txtCanCon.Location = new System.Drawing.Point(191, 111);
            this.txtCanCon.MaxLength = 7;
            this.txtCanCon.Name = "txtCanCon";
            this.txtCanCon.ReadOnly = true;
            this.txtCanCon.Size = new System.Drawing.Size(102, 22);
            this.txtCanCon.TabIndex = 364;
            this.txtCanCon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCanCon.Validated += new System.EventHandler(this.txtCanCon_Validated);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 14);
            this.label8.TabIndex = 363;
            this.label8.Text = "Cantidad Conversion";
            // 
            // txtCEsUniCon
            // 
            this.txtCEsUniCon.Location = new System.Drawing.Point(349, 83);
            this.txtCEsUniCon.Name = "txtCEsUniCon";
            this.txtCEsUniCon.ReadOnly = true;
            this.txtCEsUniCon.Size = new System.Drawing.Size(10, 22);
            this.txtCEsUniCon.TabIndex = 365;
            this.txtCEsUniCon.Visible = false;
            // 
            // txtFacCon
            // 
            this.txtFacCon.Location = new System.Drawing.Point(360, 83);
            this.txtFacCon.Name = "txtFacCon";
            this.txtFacCon.ReadOnly = true;
            this.txtFacCon.Size = new System.Drawing.Size(10, 22);
            this.txtFacCon.TabIndex = 366;
            this.txtFacCon.Visible = false;
            // 
            // txtCodAre
            // 
            this.txtCodAre.Location = new System.Drawing.Point(191, 167);
            this.txtCodAre.MaxLength = 15;
            this.txtCodAre.Name = "txtCodAre";
            this.txtCodAre.Size = new System.Drawing.Size(65, 22);
            this.txtCodAre.TabIndex = 370;
            this.txtCodAre.DoubleClick += new System.EventHandler(this.txtCodAre_DoubleClick);
            this.txtCodAre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodAre_KeyDown);
            this.txtCodAre.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodAre_Validating);
            // 
            // txtDesAre
            // 
            this.txtDesAre.Location = new System.Drawing.Point(257, 167);
            this.txtDesAre.Name = "txtDesAre";
            this.txtDesAre.ReadOnly = true;
            this.txtDesAre.Size = new System.Drawing.Size(265, 22);
            this.txtDesAre.TabIndex = 369;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 14);
            this.label10.TabIndex = 368;
            this.label10.Text = "Area";
            // 
            // wDetalleSolicitudPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(553, 336);
            this.ControlBox = false;
            this.Controls.Add(this.txtCodAre);
            this.Controls.Add(this.txtDesAre);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtFacCon);
            this.Controls.Add(this.txtCEsUniCon);
            this.Controls.Add(this.txtCanCon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCEsLot);
            this.Controls.Add(this.txtCodTip);
            this.Controls.Add(this.btnLote);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtPreAntExi);
            this.Controls.Add(this.txtStoAntExi);
            this.Controls.Add(this.txtCodPar);
            this.Controls.Add(this.txtDesPar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCUniMed);
            this.Controls.Add(this.txtNUniMed);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCantMovDet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtGloMovDet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCodExi);
            this.Controls.Add(this.txtDesExi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wDetalleSolicitudPedido";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.wDetalleSolicitudPedido_FormClosing);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtDesExi, 0);
            this.Controls.SetChildIndex(this.txtCodExi, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtGloMovDet, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtCantMovDet, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.txtNUniMed, 0);
            this.Controls.SetChildIndex(this.txtCUniMed, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtDesPar, 0);
            this.Controls.SetChildIndex(this.txtCodPar, 0);
            this.Controls.SetChildIndex(this.txtStoAntExi, 0);
            this.Controls.SetChildIndex(this.txtPreAntExi, 0);
            this.Controls.SetChildIndex(this.label21, 0);
            this.Controls.SetChildIndex(this.btnLote, 0);
            this.Controls.SetChildIndex(this.txtCodTip, 0);
            this.Controls.SetChildIndex(this.txtCEsLot, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtCanCon, 0);
            this.Controls.SetChildIndex(this.txtCEsUniCon, 0);
            this.Controls.SetChildIndex(this.txtFacCon, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.txtDesAre, 0);
            this.Controls.SetChildIndex(this.txtCodAre, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGloMovDet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNUniMed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCUniMed;
        private System.Windows.Forms.TextBox txtCodPar;
        private System.Windows.Forms.TextBox txtDesPar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStoAntExi;
        private System.Windows.Forms.TextBox txtPreAntExi;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnLote;
        internal System.Windows.Forms.TextBox txtDesExi;
        internal System.Windows.Forms.TextBox txtCodExi;
        internal System.Windows.Forms.TextBox txtCantMovDet;
        private System.Windows.Forms.TextBox txtCodTip;
        private System.Windows.Forms.TextBox txtCEsLot;
        internal System.Windows.Forms.TextBox txtCanCon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCEsUniCon;
        internal System.Windows.Forms.TextBox txtFacCon;
        private System.Windows.Forms.TextBox txtCodAre;
        private System.Windows.Forms.TextBox txtDesAre;
        private System.Windows.Forms.Label label10;
    }
}