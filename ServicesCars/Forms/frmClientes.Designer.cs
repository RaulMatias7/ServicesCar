namespace ServicesCars
{
    partial class frmClientes
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
            this.xuiFlatMenuStrip1 = new XanderUI.XUIFlatMenuStrip();
            this.AddFuncionarioTool = new System.Windows.Forms.ToolStripMenuItem();
            this.desabilitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvFull = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.PcRefresh = new System.Windows.Forms.PictureBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.xuiFlatMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFull)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcRefresh)).BeginInit();
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
            this.AddFuncionarioTool,
            this.desabilitarToolStripMenuItem});
            this.xuiFlatMenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.xuiFlatMenuStrip1.Name = "xuiFlatMenuStrip1";
            this.xuiFlatMenuStrip1.SelectedBackColor = System.Drawing.Color.RoyalBlue;
            this.xuiFlatMenuStrip1.SelectedTextColor = System.Drawing.Color.White;
            this.xuiFlatMenuStrip1.SeperatorColor = System.Drawing.Color.White;
            this.xuiFlatMenuStrip1.Size = new System.Drawing.Size(813, 28);
            this.xuiFlatMenuStrip1.TabIndex = 26;
            this.xuiFlatMenuStrip1.Text = "xuiFlatMenuStrip1";
            this.xuiFlatMenuStrip1.TextColor = System.Drawing.Color.White;
            // 
            // AddFuncionarioTool
            // 
            this.AddFuncionarioTool.ForeColor = System.Drawing.Color.White;
            this.AddFuncionarioTool.Name = "AddFuncionarioTool";
            this.AddFuncionarioTool.Size = new System.Drawing.Size(85, 24);
            this.AddFuncionarioTool.Text = "Adicionar";
            this.AddFuncionarioTool.Click += new System.EventHandler(this.AddFuncionarioTool_Click);
            // 
            // desabilitarToolStripMenuItem
            // 
            this.desabilitarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.desabilitarToolStripMenuItem.Name = "desabilitarToolStripMenuItem";
            this.desabilitarToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.desabilitarToolStripMenuItem.Text = "Eliminar";
            this.desabilitarToolStripMenuItem.Click += new System.EventHandler(this.desabilitarToolStripMenuItem_Click);
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
            this.dgvFull.Location = new System.Drawing.Point(12, 106);
            this.dgvFull.Name = "dgvFull";
            this.dgvFull.ReadOnly = true;
            this.dgvFull.Size = new System.Drawing.Size(789, 289);
            this.dgvFull.TabIndex = 57;
            this.dgvFull.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFull_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 56;
            this.label2.Text = "Pesquisar";
            // 
            // PcRefresh
            // 
            this.PcRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PcRefresh.Image = global::ServicesCars.Properties.Resources.Refresh_24px;
            this.PcRefresh.Location = new System.Drawing.Point(620, 75);
            this.PcRefresh.Name = "PcRefresh";
            this.PcRefresh.Size = new System.Drawing.Size(24, 24);
            this.PcRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PcRefresh.TabIndex = 55;
            this.PcRefresh.TabStop = false;
            this.PcRefresh.Click += new System.EventHandler(this.frmClientes_Load);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPesquisar.Location = new System.Drawing.Point(11, 75);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(605, 25);
            this.txtPesquisar.TabIndex = 54;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 450);
            this.Controls.Add(this.dgvFull);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PcRefresh);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.xuiFlatMenuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClientes";
            this.Text = "frmClientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.xuiFlatMenuStrip1.ResumeLayout(false);
            this.xuiFlatMenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFull)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUIFlatMenuStrip xuiFlatMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddFuncionarioTool;
        private System.Windows.Forms.ToolStripMenuItem desabilitarToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvFull;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PcRefresh;
        public System.Windows.Forms.TextBox txtPesquisar;
    }
}