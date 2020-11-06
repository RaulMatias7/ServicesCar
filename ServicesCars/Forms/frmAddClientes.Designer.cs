namespace ServicesCars
{
    partial class frmAddClientes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddClientes));
            this.pnTop = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pcClose = new System.Windows.Forms.PictureBox();
            this.bnDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mskData = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFeminino = new XanderUI.XUIRadio();
            this.rbMasculino = new XanderUI.XUIRadio();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.grbCredenciais = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNif = new System.Windows.Forms.TextBox();
            this.btnOperacao = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcClose)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbCredenciais.SuspendLayout();
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
            this.pnTop.Size = new System.Drawing.Size(617, 24);
            this.pnTop.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "Clientes";
            // 
            // pcClose
            // 
            this.pcClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcClose.Image = ((System.Drawing.Image)(resources.GetObject("pcClose.Image")));
            this.pcClose.Location = new System.Drawing.Point(595, 3);
            this.pcClose.Name = "pcClose";
            this.pcClose.Size = new System.Drawing.Size(17, 17);
            this.pcClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcClose.TabIndex = 2;
            this.pcClose.TabStop = false;
            this.pcClose.Click += new System.EventHandler(this.pcClose_Click);
            // 
            // bnDragControl
            // 
            this.bnDragControl.Fixed = true;
            this.bnDragControl.Horizontal = true;
            this.bnDragControl.TargetControl = this.pnTop;
            this.bnDragControl.Vertical = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mskData);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Location = new System.Drawing.Point(25, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 243);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações";
            // 
            // mskData
            // 
            this.mskData.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mskData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mskData.Location = new System.Drawing.Point(20, 115);
            this.mskData.Mask = "00/00/0000";
            this.mskData.Name = "mskData";
            this.mskData.Size = new System.Drawing.Size(228, 25);
            this.mskData.TabIndex = 5;
            this.mskData.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskData_MaskInputRejected);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFeminino);
            this.groupBox1.Controls.Add(this.rbMasculino);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Location = new System.Drawing.Point(20, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 47);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // rbFeminino
            // 
            this.rbFeminino.Checked = false;
            this.rbFeminino.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.rbFeminino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.rbFeminino.Location = new System.Drawing.Point(123, 19);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.rbFeminino.RadioHoverColor = System.Drawing.Color.RoyalBlue;
            this.rbFeminino.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.rbFeminino.Size = new System.Drawing.Size(105, 18);
            this.rbFeminino.TabIndex = 7;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.Click += new System.EventHandler(this.rbFeminino_Click);
            // 
            // rbMasculino
            // 
            this.rbMasculino.Checked = true;
            this.rbMasculino.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.rbMasculino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.rbMasculino.Location = new System.Drawing.Point(12, 19);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.rbMasculino.RadioHoverColor = System.Drawing.Color.RoyalBlue;
            this.rbMasculino.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.rbMasculino.Size = new System.Drawing.Size(105, 18);
            this.rbMasculino.TabIndex = 6;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.Click += new System.EventHandler(this.rbMasculino_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(20, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Data Nascimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(20, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nome completo:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNome.Location = new System.Drawing.Point(20, 45);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(228, 25);
            this.txtNome.TabIndex = 3;
            // 
            // grbCredenciais
            // 
            this.grbCredenciais.Controls.Add(this.label6);
            this.grbCredenciais.Controls.Add(this.txtEmail);
            this.grbCredenciais.Controls.Add(this.label5);
            this.grbCredenciais.Controls.Add(this.txtContacto);
            this.grbCredenciais.Controls.Add(this.label1);
            this.grbCredenciais.Controls.Add(this.txtNif);
            this.grbCredenciais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.grbCredenciais.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.grbCredenciais.Location = new System.Drawing.Point(320, 67);
            this.grbCredenciais.Name = "grbCredenciais";
            this.grbCredenciais.Size = new System.Drawing.Size(262, 243);
            this.grbCredenciais.TabIndex = 31;
            this.grbCredenciais.TabStop = false;
            this.grbCredenciais.Text = "Credenciáis";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(11, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 21);
            this.label6.TabIndex = 24;
            this.label6.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.Location = new System.Drawing.Point(11, 174);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(238, 25);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtConfirmar_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(11, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = "Contacto:";
            // 
            // txtContacto
            // 
            this.txtContacto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtContacto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtContacto.Location = new System.Drawing.Point(11, 115);
            this.txtContacto.MaxLength = 15;
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(238, 25);
            this.txtContacto.TabIndex = 9;
            this.txtContacto.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(11, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "NIF:";
            // 
            // txtNif
            // 
            this.txtNif.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNif.Location = new System.Drawing.Point(11, 45);
            this.txtNif.MaxLength = 20;
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(238, 25);
            this.txtNif.TabIndex = 8;
            this.txtNif.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
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
            this.btnOperacao.Location = new System.Drawing.Point(25, 325);
            this.btnOperacao.Name = "btnOperacao";
            this.btnOperacao.Size = new System.Drawing.Size(137, 33);
            this.btnOperacao.TabIndex = 32;
            this.btnOperacao.Text = "Adicionar";
            this.btnOperacao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOperacao.UseVisualStyleBackColor = false;
            this.btnOperacao.Click += new System.EventHandler(this.btnOperacao_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 377);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(617, 2);
            this.panel2.TabIndex = 33;
            // 
            // frmAddClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 379);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnOperacao);
            this.Controls.Add(this.grbCredenciais);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddClientes";
            this.Load += new System.EventHandler(this.frmAddClientes_Load);
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcClose)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.grbCredenciais.ResumeLayout(false);
            this.grbCredenciais.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pcClose;
        public Bunifu.Framework.UI.BunifuDragControl bnDragControl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox mskData;
        private System.Windows.Forms.GroupBox groupBox1;
        private XanderUI.XUIRadio rbFeminino;
        private XanderUI.XUIRadio rbMasculino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox grbCredenciais;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNif;
        private System.Windows.Forms.Button btnOperacao;
        private System.Windows.Forms.Panel panel2;
    }
}