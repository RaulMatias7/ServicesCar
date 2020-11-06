namespace ServicesCars
{
    partial class frmAddAtendimento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddAtendimento));
            this.label3 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.cbxGrupo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbAmbos = new XanderUI.XUIRadio();
            this.rbMontante = new XanderUI.XUIRadio();
            this.rbMulticaixa = new XanderUI.XUIRadio();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalAtendimento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMulticaixa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMontante = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalPagamento = new System.Windows.Forms.TextBox();
            this.gbxPagamento = new System.Windows.Forms.GroupBox();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnRegistar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvFull = new System.Windows.Forms.DataGridView();
            this.txtIdServico = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pcRefresh = new System.Windows.Forms.PictureBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4.SuspendLayout();
            this.gbxPagamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFull)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcRefresh)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(16, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cliente:";
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCliente.Location = new System.Drawing.Point(16, 41);
            this.txtCliente.MaxLength = 30;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(300, 25);
            this.txtCliente.TabIndex = 11;
            // 
            // cbxGrupo
            // 
            this.cbxGrupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.cbxGrupo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxGrupo.ForeColor = System.Drawing.Color.White;
            this.cbxGrupo.FormattingEnabled = true;
            this.cbxGrupo.Location = new System.Drawing.Point(339, 41);
            this.cbxGrupo.Name = "cbxGrupo";
            this.cbxGrupo.Size = new System.Drawing.Size(300, 25);
            this.cbxGrupo.TabIndex = 15;
            this.cbxGrupo.SelectedIndexChanged += new System.EventHandler(this.cbxGrupo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(342, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Grupo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(16, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Marca Viatura:";
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMarca.Location = new System.Drawing.Point(16, 95);
            this.txtMarca.MaxLength = 20;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(300, 25);
            this.txtMarca.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(342, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Matricula:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMatricula.Location = new System.Drawing.Point(342, 95);
            this.txtMatricula.MaxLength = 20;
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(300, 25);
            this.txtMatricula.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(664, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 19);
            this.label6.TabIndex = 22;
            this.label6.Text = "Identificador de Serviço:";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.rbAmbos);
            this.groupBox4.Controls.Add(this.rbMontante);
            this.groupBox4.Controls.Add(this.rbMulticaixa);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox4.Location = new System.Drawing.Point(18, 490);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(320, 59);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tipo de pagamento";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // rbAmbos
            // 
            this.rbAmbos.Checked = false;
            this.rbAmbos.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.rbAmbos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.rbAmbos.Location = new System.Drawing.Point(234, 26);
            this.rbAmbos.Name = "rbAmbos";
            this.rbAmbos.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.rbAmbos.RadioHoverColor = System.Drawing.Color.RoyalBlue;
            this.rbAmbos.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.rbAmbos.Size = new System.Drawing.Size(80, 18);
            this.rbAmbos.TabIndex = 17;
            this.rbAmbos.Text = "Ambos";
            this.rbAmbos.Click += new System.EventHandler(this.rbAmbos_Click);
            // 
            // rbMontante
            // 
            this.rbMontante.Checked = true;
            this.rbMontante.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.rbMontante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.rbMontante.Location = new System.Drawing.Point(6, 26);
            this.rbMontante.Name = "rbMontante";
            this.rbMontante.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.rbMontante.RadioHoverColor = System.Drawing.Color.RoyalBlue;
            this.rbMontante.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.rbMontante.Size = new System.Drawing.Size(105, 18);
            this.rbMontante.TabIndex = 16;
            this.rbMontante.Text = "Montante";
            this.rbMontante.Click += new System.EventHandler(this.rbMontante_Click);
            // 
            // rbMulticaixa
            // 
            this.rbMulticaixa.Checked = false;
            this.rbMulticaixa.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.rbMulticaixa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.rbMulticaixa.Location = new System.Drawing.Point(120, 26);
            this.rbMulticaixa.Name = "rbMulticaixa";
            this.rbMulticaixa.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.rbMulticaixa.RadioHoverColor = System.Drawing.Color.RoyalBlue;
            this.rbMulticaixa.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.rbMulticaixa.Size = new System.Drawing.Size(105, 18);
            this.rbMulticaixa.TabIndex = 15;
            this.rbMulticaixa.Text = "Multicaixa";
            this.rbMulticaixa.Click += new System.EventHandler(this.rbMulticaixa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(664, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "Total:";
            // 
            // txtTotalAtendimento
            // 
            this.txtTotalAtendimento.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTotalAtendimento.Location = new System.Drawing.Point(664, 95);
            this.txtTotalAtendimento.Name = "txtTotalAtendimento";
            this.txtTotalAtendimento.ReadOnly = true;
            this.txtTotalAtendimento.Size = new System.Drawing.Size(300, 25);
            this.txtTotalAtendimento.TabIndex = 31;
            this.txtTotalAtendimento.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(8, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 19);
            this.label7.TabIndex = 34;
            this.label7.Text = "Multicaixa:";
            // 
            // txtMulticaixa
            // 
            this.txtMulticaixa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMulticaixa.Location = new System.Drawing.Point(9, 41);
            this.txtMulticaixa.MaxLength = 50;
            this.txtMulticaixa.Name = "txtMulticaixa";
            this.txtMulticaixa.Size = new System.Drawing.Size(208, 25);
            this.txtMulticaixa.TabIndex = 33;
            this.txtMulticaixa.Text = "0";
            this.txtMulticaixa.TextChanged += new System.EventHandler(this.txtMulticaixa_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(223, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 19);
            this.label8.TabIndex = 36;
            this.label8.Text = "Montante:";
            // 
            // txtMontante
            // 
            this.txtMontante.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMontante.Location = new System.Drawing.Point(225, 41);
            this.txtMontante.MaxLength = 50;
            this.txtMontante.Name = "txtMontante";
            this.txtMontante.Size = new System.Drawing.Size(208, 25);
            this.txtMontante.TabIndex = 35;
            this.txtMontante.Text = "0";
            this.txtMontante.TextChanged += new System.EventHandler(this.txtMontante_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(436, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 19);
            this.label9.TabIndex = 38;
            this.label9.Text = "Total:";
            // 
            // txtTotalPagamento
            // 
            this.txtTotalPagamento.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTotalPagamento.Location = new System.Drawing.Point(441, 41);
            this.txtTotalPagamento.Name = "txtTotalPagamento";
            this.txtTotalPagamento.ReadOnly = true;
            this.txtTotalPagamento.Size = new System.Drawing.Size(208, 25);
            this.txtTotalPagamento.TabIndex = 37;
            this.txtTotalPagamento.Text = "0";
            // 
            // gbxPagamento
            // 
            this.gbxPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbxPagamento.Controls.Add(this.label9);
            this.gbxPagamento.Controls.Add(this.txtTotalPagamento);
            this.gbxPagamento.Controls.Add(this.label8);
            this.gbxPagamento.Controls.Add(this.txtMontante);
            this.gbxPagamento.Controls.Add(this.label7);
            this.gbxPagamento.Controls.Add(this.txtMulticaixa);
            this.gbxPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.gbxPagamento.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.gbxPagamento.Location = new System.Drawing.Point(344, 471);
            this.gbxPagamento.Name = "gbxPagamento";
            this.gbxPagamento.Size = new System.Drawing.Size(659, 78);
            this.gbxPagamento.TabIndex = 39;
            this.gbxPagamento.TabStop = false;
            this.gbxPagamento.Text = "Pagamento";
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelecionar.BackColor = System.Drawing.SystemColors.Control;
            this.btnSelecionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecionar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.btnSelecionar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.btnSelecionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.btnSelecionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSelecionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.btnSelecionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelecionar.Location = new System.Drawing.Point(19, 573);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(105, 33);
            this.btnSelecionar.TabIndex = 44;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSelecionar.UseVisualStyleBackColor = false;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnRegistar
            // 
            this.btnRegistar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRegistar.BackColor = System.Drawing.SystemColors.Control;
            this.btnRegistar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.btnRegistar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.btnRegistar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.btnRegistar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnRegistar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRegistar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.btnRegistar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistar.Location = new System.Drawing.Point(130, 573);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(105, 33);
            this.btnRegistar.TabIndex = 43;
            this.btnRegistar.Text = "Salvar";
            this.btnRegistar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRegistar.UseVisualStyleBackColor = false;
            this.btnRegistar.Click += new System.EventHandler(this.btnRegistar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.btnCancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(241, 573);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 33);
            this.btnCancelar.TabIndex = 46;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvFull
            // 
            this.dgvFull.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFull.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFull.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFull.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvFull.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFull.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFull.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFull.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFull.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFull.EnableHeadersVisualStyles = false;
            this.dgvFull.Location = new System.Drawing.Point(18, 217);
            this.dgvFull.MultiSelect = false;
            this.dgvFull.Name = "dgvFull";
            this.dgvFull.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFull.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFull.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvFull.Size = new System.Drawing.Size(990, 227);
            this.dgvFull.TabIndex = 48;
            this.dgvFull.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFull_CellClick);
            this.dgvFull.DoubleClick += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // txtIdServico
            // 
            this.txtIdServico.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtIdServico.Location = new System.Drawing.Point(663, 41);
            this.txtIdServico.MaxLength = 100;
            this.txtIdServico.Name = "txtIdServico";
            this.txtIdServico.ReadOnly = true;
            this.txtIdServico.Size = new System.Drawing.Size(300, 25);
            this.txtIdServico.TabIndex = 49;
            this.txtIdServico.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(18, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 17);
            this.label10.TabIndex = 52;
            this.label10.Text = "Pesquisar serviço";
            // 
            // pcRefresh
            // 
            this.pcRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcRefresh.Image = ((System.Drawing.Image)(resources.GetObject("pcRefresh.Image")));
            this.pcRefresh.Location = new System.Drawing.Point(322, 187);
            this.pcRefresh.Name = "pcRefresh";
            this.pcRefresh.Size = new System.Drawing.Size(24, 24);
            this.pcRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcRefresh.TabIndex = 51;
            this.pcRefresh.TabStop = false;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPesquisar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPesquisar.Location = new System.Drawing.Point(18, 186);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(299, 25);
            this.txtPesquisar.TabIndex = 50;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtIdServico);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtTotalAtendimento);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtMatricula);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtMarca);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbxGrupo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtCliente);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox2.Location = new System.Drawing.Point(16, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(983, 133);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Atendimento";
            // 
            // frmAddAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 633);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pcRefresh);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.dgvFull);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.btnRegistar);
            this.Controls.Add(this.gbxPagamento);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddAtendimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddAtendimento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAddAtendimento_Load);
            this.groupBox4.ResumeLayout(false);
            this.gbxPagamento.ResumeLayout(false);
            this.gbxPagamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFull)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcRefresh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.ComboBox cbxGrupo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private XanderUI.XUIRadio rbAmbos;
        private XanderUI.XUIRadio rbMontante;
        private XanderUI.XUIRadio rbMulticaixa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalAtendimento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMulticaixa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMontante;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotalPagamento;
        private System.Windows.Forms.GroupBox gbxPagamento;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnRegistar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvFull;
        private System.Windows.Forms.TextBox txtIdServico;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pcRefresh;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}