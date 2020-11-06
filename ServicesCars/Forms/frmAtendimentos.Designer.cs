namespace ServicesCars
{
    partial class frmAtendimentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAtendimentos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.xuiFlatMenuStrip1 = new XanderUI.XUIFlatMenuStrip();
            this.novoTool = new System.Windows.Forms.ToolStripMenuItem();
            this.filtroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.mêsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.diaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.desabilitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.pcRefresh = new System.Windows.Forms.PictureBox();
            this.dgvFull = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.rbHoje = new System.Windows.Forms.RadioButton();
            this.rbGeral = new System.Windows.Forms.RadioButton();
            this.xuiFlatMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFull)).BeginInit();
            this.SuspendLayout();
            // 
            // xuiFlatMenuStrip1
            // 
            this.xuiFlatMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.xuiFlatMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.xuiFlatMenuStrip1.HoverBackColor = System.Drawing.Color.RoyalBlue;
            this.xuiFlatMenuStrip1.HoverTextColor = System.Drawing.Color.White;
            this.xuiFlatMenuStrip1.ItemBackColor = System.Drawing.Color.RoyalBlue;
            this.xuiFlatMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoTool,
            this.filtroToolStripMenuItem,
            this.desabilitarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.xuiFlatMenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.xuiFlatMenuStrip1.Name = "xuiFlatMenuStrip1";
            this.xuiFlatMenuStrip1.SelectedBackColor = System.Drawing.Color.RoyalBlue;
            this.xuiFlatMenuStrip1.SelectedTextColor = System.Drawing.Color.White;
            this.xuiFlatMenuStrip1.SeperatorColor = System.Drawing.Color.White;
            this.xuiFlatMenuStrip1.Size = new System.Drawing.Size(950, 28);
            this.xuiFlatMenuStrip1.TabIndex = 26;
            this.xuiFlatMenuStrip1.Text = "xuiFlatMenuStrip1";
            this.xuiFlatMenuStrip1.TextColor = System.Drawing.Color.White;
            // 
            // novoTool
            // 
            this.novoTool.ForeColor = System.Drawing.Color.White;
            this.novoTool.Name = "novoTool";
            this.novoTool.Size = new System.Drawing.Size(57, 24);
            this.novoTool.Text = "Novo";
            this.novoTool.Click += new System.EventHandler(this.novoTool_Click_1);
            // 
            // filtroToolStripMenuItem
            // 
            this.filtroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anoToolStripMenuItem,
            this.mêsToolStripMenuItem,
            this.diaToolStripMenuItem});
            this.filtroToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.filtroToolStripMenuItem.Name = "filtroToolStripMenuItem";
            this.filtroToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.filtroToolStripMenuItem.Text = "Filtro";
            // 
            // anoToolStripMenuItem
            // 
            this.anoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.anoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.anoToolStripMenuItem.Name = "anoToolStripMenuItem";
            this.anoToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.anoToolStripMenuItem.Text = "Ano";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // mêsToolStripMenuItem
            // 
            this.mêsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox2});
            this.mêsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.mêsToolStripMenuItem.Name = "mêsToolStripMenuItem";
            this.mêsToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.mêsToolStripMenuItem.Text = "Mês";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox2_KeyDown);
            // 
            // diaToolStripMenuItem
            // 
            this.diaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox3});
            this.diaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.diaToolStripMenuItem.Name = "diaToolStripMenuItem";
            this.diaToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.diaToolStripMenuItem.Text = "Dia";
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox3_KeyDown);
            // 
            // desabilitarToolStripMenuItem
            // 
            this.desabilitarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.fecharToolStripMenuItem});
            this.desabilitarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.desabilitarToolStripMenuItem.Name = "desabilitarToolStripMenuItem";
            this.desabilitarToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.desabilitarToolStripMenuItem.Text = "Caixa";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activarToolStripMenuItem,
            this.cancelarToolStripMenuItem1,
            this.eliminarToolStripMenuItem1,
            this.imprimirToolStripMenuItem});
            this.eliminarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.eliminarToolStripMenuItem.Text = "Operação";
            // 
            // activarToolStripMenuItem
            // 
            this.activarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.activarToolStripMenuItem.Name = "activarToolStripMenuItem";
            this.activarToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.activarToolStripMenuItem.Text = "Activar";
            this.activarToolStripMenuItem.Click += new System.EventHandler(this.activarToolStripMenuItem_Click);
            // 
            // cancelarToolStripMenuItem1
            // 
            this.cancelarToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.cancelarToolStripMenuItem1.Name = "cancelarToolStripMenuItem1";
            this.cancelarToolStripMenuItem1.Size = new System.Drawing.Size(135, 24);
            this.cancelarToolStripMenuItem1.Text = "Cancelar";
            this.cancelarToolStripMenuItem1.Click += new System.EventHandler(this.cancelarToolStripMenuItem1_Click);
            // 
            // eliminarToolStripMenuItem1
            // 
            this.eliminarToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1";
            this.eliminarToolStripMenuItem1.Size = new System.Drawing.Size(135, 24);
            this.eliminarToolStripMenuItem1.Text = "Eliminar";
            this.eliminarToolStripMenuItem1.Click += new System.EventHandler(this.eliminarToolStripMenuItem1_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPesquisar.Location = new System.Drawing.Point(16, 55);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(699, 25);
            this.txtPesquisar.TabIndex = 28;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // pcRefresh
            // 
            this.pcRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcRefresh.Image = ((System.Drawing.Image)(resources.GetObject("pcRefresh.Image")));
            this.pcRefresh.Location = new System.Drawing.Point(720, 55);
            this.pcRefresh.Name = "pcRefresh";
            this.pcRefresh.Size = new System.Drawing.Size(24, 24);
            this.pcRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcRefresh.TabIndex = 50;
            this.pcRefresh.TabStop = false;
            this.pcRefresh.Click += new System.EventHandler(this.pcRefresh_Click);
            // 
            // dgvFull
            // 
            this.dgvFull.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFull.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvFull.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFull.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFull.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFull.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFull.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFull.EnableHeadersVisualStyles = false;
            this.dgvFull.Location = new System.Drawing.Point(16, 88);
            this.dgvFull.Name = "dgvFull";
            this.dgvFull.ReadOnly = true;
            this.dgvFull.Size = new System.Drawing.Size(916, 289);
            this.dgvFull.TabIndex = 52;
            this.dgvFull.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFull_CellClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(766, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 56;
            this.label1.Text = "Dados:";
            // 
            // rbHoje
            // 
            this.rbHoje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbHoje.AutoSize = true;
            this.rbHoje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.rbHoje.Checked = true;
            this.rbHoje.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.rbHoje.ForeColor = System.Drawing.Color.White;
            this.rbHoje.Location = new System.Drawing.Point(824, 2);
            this.rbHoje.Name = "rbHoje";
            this.rbHoje.Size = new System.Drawing.Size(59, 24);
            this.rbHoje.TabIndex = 58;
            this.rbHoje.TabStop = true;
            this.rbHoje.Text = "Hoje";
            this.rbHoje.UseVisualStyleBackColor = false;
            this.rbHoje.CheckedChanged += new System.EventHandler(this.rbHoje_CheckedChanged);
            // 
            // rbGeral
            // 
            this.rbGeral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbGeral.AutoSize = true;
            this.rbGeral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.rbGeral.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.rbGeral.ForeColor = System.Drawing.Color.White;
            this.rbGeral.Location = new System.Drawing.Point(887, 2);
            this.rbGeral.Name = "rbGeral";
            this.rbGeral.Size = new System.Drawing.Size(62, 24);
            this.rbGeral.TabIndex = 59;
            this.rbGeral.Text = "Geral";
            this.rbGeral.UseVisualStyleBackColor = false;
            this.rbGeral.CheckedChanged += new System.EventHandler(this.rbMes_CheckedChanged);
            // 
            // frmAtendimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 411);
            this.Controls.Add(this.rbGeral);
            this.Controls.Add(this.rbHoje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFull);
            this.Controls.Add(this.pcRefresh);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.xuiFlatMenuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAtendimentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAtendimentos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAtendimentos_Load);
            this.xuiFlatMenuStrip1.ResumeLayout(false);
            this.xuiFlatMenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFull)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUIFlatMenuStrip xuiFlatMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novoTool;
        private System.Windows.Forms.ToolStripMenuItem desabilitarToolStripMenuItem;
        public System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.PictureBox pcRefresh;
        private System.Windows.Forms.DataGridView dgvFull;
        private System.Windows.Forms.ToolStripMenuItem activarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anoToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem mêsToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem diaToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.RadioButton rbHoje;
        private System.Windows.Forms.RadioButton rbGeral;
    }
}