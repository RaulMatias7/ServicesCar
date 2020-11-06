namespace ServicesCars
{
    partial class frmFuncionarios
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
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.xuiFlatMenuStrip1 = new XanderUI.XUIFlatMenuStrip();
            this.AddFuncionarioTool = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incluirGrupoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionaeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elementosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habilitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desabilitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.pcRefresh = new System.Windows.Forms.PictureBox();
            this.dgvFull = new System.Windows.Forms.DataGridView();
            this.xuiFlatMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFull)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPesquisar.Location = new System.Drawing.Point(18, 63);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(605, 25);
            this.txtPesquisar.TabIndex = 23;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // xuiFlatMenuStrip1
            // 
            this.xuiFlatMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.xuiFlatMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.xuiFlatMenuStrip1.HoverBackColor = System.Drawing.Color.RoyalBlue;
            this.xuiFlatMenuStrip1.HoverTextColor = System.Drawing.Color.White;
            this.xuiFlatMenuStrip1.ItemBackColor = System.Drawing.Color.RoyalBlue;
            this.xuiFlatMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddFuncionarioTool,
            this.grupoToolStripMenuItem,
            this.habilitarToolStripMenuItem,
            this.desabilitarToolStripMenuItem,
            this.editarToolStripMenuItem});
            this.xuiFlatMenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.xuiFlatMenuStrip1.Name = "xuiFlatMenuStrip1";
            this.xuiFlatMenuStrip1.SelectedBackColor = System.Drawing.Color.RoyalBlue;
            this.xuiFlatMenuStrip1.SelectedTextColor = System.Drawing.Color.White;
            this.xuiFlatMenuStrip1.SeperatorColor = System.Drawing.Color.White;
            this.xuiFlatMenuStrip1.Size = new System.Drawing.Size(827, 28);
            this.xuiFlatMenuStrip1.TabIndex = 25;
            this.xuiFlatMenuStrip1.Text = "xuiFlatMenuStrip1";
            this.xuiFlatMenuStrip1.TextColor = System.Drawing.Color.White;
            // 
            // AddFuncionarioTool
            // 
            this.AddFuncionarioTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionárioToolStripMenuItem,
            this.incluirGrupoToolStripMenuItem});
            this.AddFuncionarioTool.ForeColor = System.Drawing.Color.White;
            this.AddFuncionarioTool.Name = "AddFuncionarioTool";
            this.AddFuncionarioTool.Size = new System.Drawing.Size(85, 24);
            this.AddFuncionarioTool.Text = "Adicionar";
            this.AddFuncionarioTool.Click += new System.EventHandler(this.AddFuncionarioTool_Click);
            // 
            // funcionárioToolStripMenuItem
            // 
            this.funcionárioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            this.funcionárioToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.funcionárioToolStripMenuItem.Text = "Funcionário";
            this.funcionárioToolStripMenuItem.Click += new System.EventHandler(this.funcionárioToolStripMenuItem_Click);
            // 
            // incluirGrupoToolStripMenuItem
            // 
            this.incluirGrupoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.incluirGrupoToolStripMenuItem.Name = "incluirGrupoToolStripMenuItem";
            this.incluirGrupoToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.incluirGrupoToolStripMenuItem.Text = "Incluir Grupo";
            this.incluirGrupoToolStripMenuItem.Click += new System.EventHandler(this.incluirGrupoToolStripMenuItem_Click);
            // 
            // grupoToolStripMenuItem
            // 
            this.grupoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionaeToolStripMenuItem,
            this.elementosToolStripMenuItem});
            this.grupoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.grupoToolStripMenuItem.Name = "grupoToolStripMenuItem";
            this.grupoToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.grupoToolStripMenuItem.Text = "Grupo";
            this.grupoToolStripMenuItem.Click += new System.EventHandler(this.grupoToolStripMenuItem_Click);
            // 
            // adicionaeToolStripMenuItem
            // 
            this.adicionaeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.adicionaeToolStripMenuItem.Name = "adicionaeToolStripMenuItem";
            this.adicionaeToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.adicionaeToolStripMenuItem.Text = "Adicionar";
            this.adicionaeToolStripMenuItem.Click += new System.EventHandler(this.adicionaeToolStripMenuItem_Click);
            // 
            // elementosToolStripMenuItem
            // 
            this.elementosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.elementosToolStripMenuItem.Name = "elementosToolStripMenuItem";
            this.elementosToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.elementosToolStripMenuItem.Text = "Elementos";
            this.elementosToolStripMenuItem.Click += new System.EventHandler(this.elementosToolStripMenuItem_Click);
            // 
            // habilitarToolStripMenuItem
            // 
            this.habilitarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.habilitarToolStripMenuItem.Name = "habilitarToolStripMenuItem";
            this.habilitarToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.habilitarToolStripMenuItem.Text = "Habilitar";
            this.habilitarToolStripMenuItem.Click += new System.EventHandler(this.habilitarToolStripMenuItem_Click);
            // 
            // desabilitarToolStripMenuItem
            // 
            this.desabilitarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.desabilitarToolStripMenuItem.Name = "desabilitarToolStripMenuItem";
            this.desabilitarToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.desabilitarToolStripMenuItem.Text = "Desabilitar";
            this.desabilitarToolStripMenuItem.Click += new System.EventHandler(this.desabilitarToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(15, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 50;
            this.label2.Text = "Pesquisar";
            // 
            // pcRefresh
            // 
            this.pcRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcRefresh.Image = global::ServicesCars.Properties.Resources.Refresh_24px;
            this.pcRefresh.Location = new System.Drawing.Point(627, 63);
            this.pcRefresh.Name = "pcRefresh";
            this.pcRefresh.Size = new System.Drawing.Size(24, 24);
            this.pcRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcRefresh.TabIndex = 49;
            this.pcRefresh.TabStop = false;
            this.pcRefresh.Click += new System.EventHandler(this.pcRefresh_Click);
            // 
            // dgvFull
            // 
            this.dgvFull.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFull.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFull.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvFull.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFull.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFull.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFull.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFull.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFull.EnableHeadersVisualStyles = false;
            this.dgvFull.Location = new System.Drawing.Point(18, 94);
            this.dgvFull.Name = "dgvFull";
            this.dgvFull.ReadOnly = true;
            this.dgvFull.Size = new System.Drawing.Size(787, 289);
            this.dgvFull.TabIndex = 53;
            this.dgvFull.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFull_CellClick);
            // 
            // frmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 411);
            this.Controls.Add(this.dgvFull);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pcRefresh);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.xuiFlatMenuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.xuiFlatMenuStrip1;
            this.Name = "frmFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFuncionarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFuncionarios_Load);
            this.xuiFlatMenuStrip1.ResumeLayout(false);
            this.xuiFlatMenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFull)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private XanderUI.XUIFlatMenuStrip xuiFlatMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddFuncionarioTool;
        private System.Windows.Forms.ToolStripMenuItem grupoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desabilitarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        public System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.ToolStripMenuItem funcionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incluirGrupoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pcRefresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem habilitarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionaeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elementosToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvFull;
    }
}