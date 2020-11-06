namespace ServicesCars
{
    partial class frmWait
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnOperacao = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ProgressBar = new Bunifu.Framework.UI.BunifuProgressBar();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
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
            this.btnOperacao.Location = new System.Drawing.Point(165, 127);
            this.btnOperacao.Name = "btnOperacao";
            this.btnOperacao.Size = new System.Drawing.Size(103, 31);
            this.btnOperacao.TabIndex = 47;
            this.btnOperacao.Text = "Cancelar";
            this.btnOperacao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOperacao.UseVisualStyleBackColor = false;
            this.btnOperacao.Click += new System.EventHandler(this.BtnOperacao_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 15.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(145, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 50;
            this.label1.Text = "Esperando...";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBar.BackColor = System.Drawing.Color.White;
            this.ProgressBar.BorderRadius = 5;
            this.ProgressBar.Location = new System.Drawing.Point(11, 96);
            this.ProgressBar.MaximumValue = 100;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.ProgressColor = System.Drawing.Color.RoyalBlue;
            this.ProgressBar.Size = new System.Drawing.Size(411, 10);
            this.ProgressBar.TabIndex = 49;
            this.ProgressBar.Value = 0;
            // 
            // frmWait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(440, 185);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.btnOperacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmWait";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmWait";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmWait_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button btnOperacao;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuProgressBar ProgressBar;
    }
}