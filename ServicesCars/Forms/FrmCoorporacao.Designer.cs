namespace ServicesCars
{
    partial class FrmCoorporacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCoorporacao));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.xuiFlatMenuStrip1 = new XanderUI.XUIFlatMenuStrip();
            this.empresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.FacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CrriarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeFaturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pcClose = new System.Windows.Forms.PictureBox();
            this.dgvFull = new System.Windows.Forms.DataGridView();
            this.pcRefresh = new System.Windows.Forms.PictureBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.xuiFlatMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFull)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcRefresh)).BeginInit();
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
            this.empresasToolStripMenuItem,
            this.FacturasToolStripMenuItem});
            this.xuiFlatMenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.xuiFlatMenuStrip1.Name = "xuiFlatMenuStrip1";
            this.xuiFlatMenuStrip1.SelectedBackColor = System.Drawing.Color.RoyalBlue;
            this.xuiFlatMenuStrip1.SelectedTextColor = System.Drawing.Color.White;
            this.xuiFlatMenuStrip1.SeperatorColor = System.Drawing.Color.White;
            this.xuiFlatMenuStrip1.Size = new System.Drawing.Size(781, 28);
            this.xuiFlatMenuStrip1.TabIndex = 27;
            this.xuiFlatMenuStrip1.Text = "xuiFlatMenuStrip1";
            this.xuiFlatMenuStrip1.TextColor = System.Drawing.Color.White;
            // 
            // empresasToolStripMenuItem
            // 
            this.empresasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem,
            this.editarToolStripMenuItem1});
            this.empresasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.empresasToolStripMenuItem.Name = "empresasToolStripMenuItem";
            this.empresasToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.empresasToolStripMenuItem.Text = "Empresas";
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.adicionarToolStripMenuItem.Text = "Adicionar";
            this.adicionarToolStripMenuItem.Click += new System.EventHandler(this.AdicionarToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem1
            // 
            this.editarToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.editarToolStripMenuItem1.Name = "editarToolStripMenuItem1";
            this.editarToolStripMenuItem1.Size = new System.Drawing.Size(180, 24);
            this.editarToolStripMenuItem1.Text = "Editar";
            this.editarToolStripMenuItem1.Click += new System.EventHandler(this.EditarToolStripMenuItem1_Click);
            // 
            // FacturasToolStripMenuItem
            // 
            this.FacturasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CrriarToolStripMenuItem,
            this.listaDeFaturasToolStripMenuItem});
            this.FacturasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.FacturasToolStripMenuItem.Name = "FacturasToolStripMenuItem";
            this.FacturasToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.FacturasToolStripMenuItem.Text = "Facturas";
            this.FacturasToolStripMenuItem.Click += new System.EventHandler(this.FacturasToolStripMenuItem_Click);
            // 
            // CrriarToolStripMenuItem
            // 
            this.CrriarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.CrriarToolStripMenuItem.Name = "CrriarToolStripMenuItem";
            this.CrriarToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.CrriarToolStripMenuItem.Text = "Criar";
            this.CrriarToolStripMenuItem.Click += new System.EventHandler(this.CrriarToolStripMenuItem_Click);
            // 
            // listaDeFaturasToolStripMenuItem
            // 
            this.listaDeFaturasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.listaDeFaturasToolStripMenuItem.Name = "listaDeFaturasToolStripMenuItem";
            this.listaDeFaturasToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.listaDeFaturasToolStripMenuItem.Text = "Lista de faturas";
            this.listaDeFaturasToolStripMenuItem.Click += new System.EventHandler(this.ListaDeFaturasToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 442);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(781, 8);
            this.panel2.TabIndex = 56;
            // 
            // pcClose
            // 
            this.pcClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.pcClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcClose.Image = ((System.Drawing.Image)(resources.GetObject("pcClose.Image")));
            this.pcClose.Location = new System.Drawing.Point(757, 6);
            this.pcClose.Name = "pcClose";
            this.pcClose.Size = new System.Drawing.Size(15, 15);
            this.pcClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcClose.TabIndex = 28;
            this.pcClose.TabStop = false;
            this.pcClose.Click += new System.EventHandler(this.PcClose_Click);
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
            this.dgvFull.Location = new System.Drawing.Point(12, 73);
            this.dgvFull.Name = "dgvFull";
            this.dgvFull.ReadOnly = true;
            this.dgvFull.Size = new System.Drawing.Size(757, 337);
            this.dgvFull.TabIndex = 61;
            this.dgvFull.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFull_CellClick);
            this.dgvFull.DoubleClick += new System.EventHandler(this.DgvFull_DoubleClick);
            // 
            // pcRefresh
            // 
            this.pcRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcRefresh.Image = ((System.Drawing.Image)(resources.GetObject("pcRefresh.Image")));
            this.pcRefresh.Location = new System.Drawing.Point(632, 40);
            this.pcRefresh.Name = "pcRefresh";
            this.pcRefresh.Size = new System.Drawing.Size(24, 24);
            this.pcRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcRefresh.TabIndex = 60;
            this.pcRefresh.TabStop = false;
            this.pcRefresh.Click += new System.EventHandler(this.FrmCoorporacao_Load);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPesquisar.Location = new System.Drawing.Point(12, 40);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(614, 25);
            this.txtPesquisar.TabIndex = 59;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.TxtPesquisar_TextChanged);
            // 
            // FrmCoorporacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 450);
            this.Controls.Add(this.dgvFull);
            this.Controls.Add(this.pcRefresh);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pcClose);
            this.Controls.Add(this.xuiFlatMenuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCoorporacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCoorporacao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCoorporacao_Load);
            this.xuiFlatMenuStrip1.ResumeLayout(false);
            this.xuiFlatMenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFull)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUIFlatMenuStrip xuiFlatMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FacturasToolStripMenuItem;
        private System.Windows.Forms.PictureBox pcClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem CrriarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeFaturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dgvFull;
        private System.Windows.Forms.PictureBox pcRefresh;
        public System.Windows.Forms.TextBox txtPesquisar;
    }
}