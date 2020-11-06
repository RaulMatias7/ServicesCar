namespace ServicesCars
{
    partial class frmCriarFatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCriarFatura));
            this.pnTop = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pcClose = new System.Windows.Forms.PictureBox();
            this.grbKilos = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKilos = new System.Windows.Forms.TextBox();
            this.txtPrecoKilo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumEncomenda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumEmpresa = new System.Windows.Forms.TextBox();
            this.btnOperacao = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcClose)).BeginInit();
            this.grbKilos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.pnTop.Controls.Add(this.label8);
            this.pnTop.Controls.Add(this.pcClose);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(768, 24);
            this.pnTop.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "Criar Factura";
            // 
            // pcClose
            // 
            this.pcClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcClose.Image = ((System.Drawing.Image)(resources.GetObject("pcClose.Image")));
            this.pcClose.Location = new System.Drawing.Point(746, 3);
            this.pcClose.Name = "pcClose";
            this.pcClose.Size = new System.Drawing.Size(17, 17);
            this.pcClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcClose.TabIndex = 2;
            this.pcClose.TabStop = false;
            this.pcClose.Click += new System.EventHandler(this.PcClose_Click);
            // 
            // grbKilos
            // 
            this.grbKilos.Controls.Add(this.label6);
            this.grbKilos.Controls.Add(this.label7);
            this.grbKilos.Controls.Add(this.txtTotal);
            this.grbKilos.Controls.Add(this.label5);
            this.grbKilos.Controls.Add(this.txtKilos);
            this.grbKilos.Controls.Add(this.txtPrecoKilo);
            this.grbKilos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.grbKilos.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.grbKilos.Location = new System.Drawing.Point(401, 55);
            this.grbKilos.Name = "grbKilos";
            this.grbKilos.Size = new System.Drawing.Size(355, 343);
            this.grbKilos.TabIndex = 35;
            this.grbKilos.TabStop = false;
            this.grbKilos.Text = "Kilos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(8, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 21);
            this.label6.TabIndex = 24;
            this.label6.Text = "Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(8, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "Kilos:";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotal.Location = new System.Drawing.Point(8, 195);
            this.txtTotal.MaxLength = 50;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(340, 25);
            this.txtTotal.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(8, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = "Preço por kilo:";
            // 
            // txtKilos
            // 
            this.txtKilos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtKilos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtKilos.Location = new System.Drawing.Point(8, 57);
            this.txtKilos.MaxLength = 60;
            this.txtKilos.Name = "txtKilos";
            this.txtKilos.Size = new System.Drawing.Size(340, 25);
            this.txtKilos.TabIndex = 2;
            this.txtKilos.TextChanged += new System.EventHandler(this.TxtKilos_TextChanged);
            // 
            // txtPrecoKilo
            // 
            this.txtPrecoKilo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPrecoKilo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrecoKilo.Location = new System.Drawing.Point(8, 122);
            this.txtPrecoKilo.MaxLength = 15;
            this.txtPrecoKilo.Name = "txtPrecoKilo";
            this.txtPrecoKilo.Size = new System.Drawing.Size(340, 25);
            this.txtPrecoKilo.TabIndex = 3;
            this.txtPrecoKilo.TextChanged += new System.EventHandler(this.TxtPrecoKilo_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(9, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 21);
            this.label10.TabIndex = 30;
            this.label10.Text = "Empresa:";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmpresa.Location = new System.Drawing.Point(9, 122);
            this.txtEmpresa.MaxLength = 20;
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.ReadOnly = true;
            this.txtEmpresa.Size = new System.Drawing.Size(337, 25);
            this.txtEmpresa.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtEmpresa);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTipo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtNumEncomenda);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtNumEmpresa);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Location = new System.Drawing.Point(9, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 343);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(9, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tipo de peixe:";
            // 
            // txtTipo
            // 
            this.txtTipo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTipo.Location = new System.Drawing.Point(9, 271);
            this.txtTipo.MaxLength = 60;
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(337, 25);
            this.txtTipo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(9, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nº Encomenda:";
            // 
            // txtNumEncomenda
            // 
            this.txtNumEncomenda.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNumEncomenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNumEncomenda.Location = new System.Drawing.Point(9, 195);
            this.txtNumEncomenda.MaxLength = 20;
            this.txtNumEncomenda.Name = "txtNumEncomenda";
            this.txtNumEncomenda.Size = new System.Drawing.Size(337, 25);
            this.txtNumEncomenda.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(9, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nº Empresa:";
            // 
            // txtNumEmpresa
            // 
            this.txtNumEmpresa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNumEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNumEmpresa.Location = new System.Drawing.Point(9, 57);
            this.txtNumEmpresa.MaxLength = 50;
            this.txtNumEmpresa.Name = "txtNumEmpresa";
            this.txtNumEmpresa.ReadOnly = true;
            this.txtNumEmpresa.Size = new System.Drawing.Size(337, 25);
            this.txtNumEmpresa.TabIndex = 5;
            // 
            // btnOperacao
            // 
            this.btnOperacao.BackColor = System.Drawing.SystemColors.Control;
            this.btnOperacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOperacao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.btnOperacao.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.btnOperacao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.btnOperacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnOperacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOperacao.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnOperacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.btnOperacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOperacao.Location = new System.Drawing.Point(23, 420);
            this.btnOperacao.Name = "btnOperacao";
            this.btnOperacao.Size = new System.Drawing.Size(137, 33);
            this.btnOperacao.TabIndex = 4;
            this.btnOperacao.Text = "Adicionar";
            this.btnOperacao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOperacao.UseVisualStyleBackColor = false;
            this.btnOperacao.Click += new System.EventHandler(this.BtnOperacao_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 480);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(768, 2);
            this.panel2.TabIndex = 41;
            // 
            // frmCriarFatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 482);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnOperacao);
            this.Controls.Add(this.grbKilos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCriarFatura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCriarFatura";
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcClose)).EndInit();
            this.grbKilos.ResumeLayout(false);
            this.grbKilos.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pcClose;
        private System.Windows.Forms.GroupBox grbKilos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecoKilo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKilos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumEncomenda;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtNumEmpresa;
        private System.Windows.Forms.Button btnOperacao;
        private System.Windows.Forms.Panel panel2;
    }
}