namespace ServicesCars
{
    partial class frmPromocoes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPromocoes));
            this.dgvFull = new System.Windows.Forms.DataGridView();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.pnTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pcClose = new System.Windows.Forms.PictureBox();
            this.pcRefresh = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bnDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFull)).BeginInit();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcRefresh)).BeginInit();
            this.SuspendLayout();
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
            this.dgvFull.Location = new System.Drawing.Point(12, 79);
            this.dgvFull.Name = "dgvFull";
            this.dgvFull.ReadOnly = true;
            this.dgvFull.Size = new System.Drawing.Size(673, 247);
            this.dgvFull.TabIndex = 58;
            this.dgvFull.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFull_CellClick);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPesquisar.Location = new System.Drawing.Point(12, 43);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(427, 25);
            this.txtPesquisar.TabIndex = 56;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.pnTop.Controls.Add(this.label1);
            this.pnTop.Controls.Add(this.pcClose);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(697, 24);
            this.pnTop.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Promoções";
            // 
            // pcClose
            // 
            this.pcClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcClose.Image = ((System.Drawing.Image)(resources.GetObject("pcClose.Image")));
            this.pcClose.Location = new System.Drawing.Point(678, 4);
            this.pcClose.Name = "pcClose";
            this.pcClose.Size = new System.Drawing.Size(15, 15);
            this.pcClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcClose.TabIndex = 2;
            this.pcClose.TabStop = false;
            this.pcClose.Click += new System.EventHandler(this.pcClose_Click);
            // 
            // pcRefresh
            // 
            this.pcRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcRefresh.Image = ((System.Drawing.Image)(resources.GetObject("pcRefresh.Image")));
            this.pcRefresh.Location = new System.Drawing.Point(445, 43);
            this.pcRefresh.Name = "pcRefresh";
            this.pcRefresh.Size = new System.Drawing.Size(24, 24);
            this.pcRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcRefresh.TabIndex = 57;
            this.pcRefresh.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.btnEliminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(12, 332);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 33);
            this.btnEliminar.TabIndex = 60;
            this.btnEliminar.Text = "Reiniciar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 383);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(697, 2);
            this.panel2.TabIndex = 61;
            // 
            // bnDragControl
            // 
            this.bnDragControl.Fixed = true;
            this.bnDragControl.Horizontal = true;
            this.bnDragControl.TargetControl = this.pnTop;
            this.bnDragControl.Vertical = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(696, 24);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 359);
            this.panel4.TabIndex = 62;
            // 
            // frmPromocoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 385);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.dgvFull);
            this.Controls.Add(this.pcRefresh);
            this.Controls.Add(this.txtPesquisar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPromocoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPromocoes";
            this.Load += new System.EventHandler(this.frmPromocoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFull)).EndInit();
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvFull;
        private System.Windows.Forms.PictureBox pcRefresh;
        public System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcClose;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel panel2;
        public Bunifu.Framework.UI.BunifuDragControl bnDragControl;
        private System.Windows.Forms.Panel panel4;
    }
}