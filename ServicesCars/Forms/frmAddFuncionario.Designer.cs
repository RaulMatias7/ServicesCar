namespace ServicesCars
{
    partial class frmAddFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddFuncionario));
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbMasculino = new XanderUI.XUIRadio();
            this.rbFeminino = new XanderUI.XUIRadio();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskData = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.btnOperacao = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grbCredenciais = new System.Windows.Forms.GroupBox();
            this.lbSenhaCompact = new System.Windows.Forms.Label();
            this.pnTop = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pcClose = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbNenhum = new XanderUI.XUIRadio();
            this.rbGerente = new XanderUI.XUIRadio();
            this.rbAdmin = new XanderUI.XUIRadio();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bnDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grbCredenciais.SuspendLayout();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcClose)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(20, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nome completo:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNome.Location = new System.Drawing.Point(20, 48);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(228, 25);
            this.txtNome.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(11, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome de usuário:";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserName.Location = new System.Drawing.Point(11, 48);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(202, 25);
            this.txtUserName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(20, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Data Nascimento:";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFeminino);
            this.groupBox1.Controls.Add(this.rbMasculino);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Location = new System.Drawing.Point(20, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 47);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
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
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(11, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSenha.Location = new System.Drawing.Point(11, 111);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(202, 25);
            this.txtSenha.TabIndex = 9;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(11, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 21);
            this.label6.TabIndex = 24;
            this.label6.Text = "Confirmar:";
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtConfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConfirmar.Location = new System.Drawing.Point(11, 177);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.Size = new System.Drawing.Size(202, 25);
            this.txtConfirmar.TabIndex = 10;
            this.txtConfirmar.UseSystemPasswordChar = true;
            this.txtConfirmar.TextChanged += new System.EventHandler(this.txtConfirmar_TextChanged);
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
            this.btnOperacao.Location = new System.Drawing.Point(34, 374);
            this.btnOperacao.Name = "btnOperacao";
            this.btnOperacao.Size = new System.Drawing.Size(137, 33);
            this.btnOperacao.TabIndex = 11;
            this.btnOperacao.Text = "Adicionar";
            this.btnOperacao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOperacao.UseVisualStyleBackColor = false;
            this.btnOperacao.Click += new System.EventHandler(this.btnOperacao_Click);
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
            this.groupBox2.Location = new System.Drawing.Point(34, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 248);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações";
            // 
            // grbCredenciais
            // 
            this.grbCredenciais.Controls.Add(this.lbSenhaCompact);
            this.grbCredenciais.Controls.Add(this.label6);
            this.grbCredenciais.Controls.Add(this.txtConfirmar);
            this.grbCredenciais.Controls.Add(this.label5);
            this.grbCredenciais.Controls.Add(this.txtSenha);
            this.grbCredenciais.Controls.Add(this.label1);
            this.grbCredenciais.Controls.Add(this.txtUserName);
            this.grbCredenciais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.grbCredenciais.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.grbCredenciais.Location = new System.Drawing.Point(328, 117);
            this.grbCredenciais.Name = "grbCredenciais";
            this.grbCredenciais.Size = new System.Drawing.Size(226, 245);
            this.grbCredenciais.TabIndex = 27;
            this.grbCredenciais.TabStop = false;
            this.grbCredenciais.Text = "Credenciáis";
            // 
            // lbSenhaCompact
            // 
            this.lbSenhaCompact.AutoSize = true;
            this.lbSenhaCompact.BackColor = System.Drawing.Color.Transparent;
            this.lbSenhaCompact.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenhaCompact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbSenhaCompact.Location = new System.Drawing.Point(11, 213);
            this.lbSenhaCompact.Name = "lbSenhaCompact";
            this.lbSenhaCompact.Size = new System.Drawing.Size(163, 23);
            this.lbSenhaCompact.TabIndex = 25;
            this.lbSenhaCompact.Text = "Senhas incompactíveis...";
            this.lbSenhaCompact.Visible = false;
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.pnTop.Controls.Add(this.label8);
            this.pnTop.Controls.Add(this.pcClose);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(611, 24);
            this.pnTop.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "Funcionários";
            // 
            // pcClose
            // 
            this.pcClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcClose.Image = ((System.Drawing.Image)(resources.GetObject("pcClose.Image")));
            this.pcClose.Location = new System.Drawing.Point(589, 3);
            this.pcClose.Name = "pcClose";
            this.pcClose.Size = new System.Drawing.Size(17, 17);
            this.pcClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcClose.TabIndex = 2;
            this.pcClose.TabStop = false;
            this.pcClose.Click += new System.EventHandler(this.pcClose_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbNenhum);
            this.groupBox4.Controls.Add(this.rbGerente);
            this.groupBox4.Controls.Add(this.rbAdmin);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox4.Location = new System.Drawing.Point(34, 41);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(337, 47);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Acesso";
            // 
            // rbNenhum
            // 
            this.rbNenhum.Checked = false;
            this.rbNenhum.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.rbNenhum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.rbNenhum.Location = new System.Drawing.Point(234, 19);
            this.rbNenhum.Name = "rbNenhum";
            this.rbNenhum.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.rbNenhum.RadioHoverColor = System.Drawing.Color.RoyalBlue;
            this.rbNenhum.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.rbNenhum.Size = new System.Drawing.Size(97, 18);
            this.rbNenhum.TabIndex = 2;
            this.rbNenhum.Text = "Nenhum";
            this.rbNenhum.Click += new System.EventHandler(this.rbNenhum_Click);
            // 
            // rbGerente
            // 
            this.rbGerente.Checked = false;
            this.rbGerente.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.rbGerente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.rbGerente.Location = new System.Drawing.Point(123, 19);
            this.rbGerente.Name = "rbGerente";
            this.rbGerente.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.rbGerente.RadioHoverColor = System.Drawing.Color.RoyalBlue;
            this.rbGerente.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.rbGerente.Size = new System.Drawing.Size(105, 18);
            this.rbGerente.TabIndex = 1;
            this.rbGerente.Text = "Gerente";
            this.rbGerente.Click += new System.EventHandler(this.rbGerente_Click);
            // 
            // rbAdmin
            // 
            this.rbAdmin.Checked = false;
            this.rbAdmin.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.rbAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.rbAdmin.Location = new System.Drawing.Point(12, 19);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.rbAdmin.RadioHoverColor = System.Drawing.Color.RoyalBlue;
            this.rbAdmin.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.rbAdmin.Size = new System.Drawing.Size(105, 18);
            this.rbAdmin.TabIndex = 0;
            this.rbAdmin.Text = "Admin";
            this.rbAdmin.Click += new System.EventHandler(this.rbAdmin_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 395);
            this.panel3.TabIndex = 30;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(610, 24);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 395);
            this.panel4.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(1, 417);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(609, 2);
            this.panel2.TabIndex = 32;
            // 
            // bnDragControl
            // 
            this.bnDragControl.Fixed = true;
            this.bnDragControl.Horizontal = true;
            this.bnDragControl.TargetControl = this.pnTop;
            this.bnDragControl.Vertical = true;
            // 
            // frmAddFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 419);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.btnOperacao);
            this.Controls.Add(this.grbCredenciais);
            this.Controls.Add(this.groupBox2);
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddFuncionario";
            this.Load += new System.EventHandler(this.frmAddFuncionario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grbCredenciais.ResumeLayout(false);
            this.grbCredenciais.PerformLayout();
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcClose)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private XanderUI.XUIRadio rbMasculino;
        private XanderUI.XUIRadio rbFeminino;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mskData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.Button btnOperacao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grbCredenciais;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pcClose;
        private System.Windows.Forms.GroupBox groupBox4;
        private XanderUI.XUIRadio rbNenhum;
        private XanderUI.XUIRadio rbGerente;
        private XanderUI.XUIRadio rbAdmin;
        private System.Windows.Forms.Label lbSenhaCompact;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        public Bunifu.Framework.UI.BunifuDragControl bnDragControl;
        public System.Windows.Forms.TextBox txtNome;
    }
}