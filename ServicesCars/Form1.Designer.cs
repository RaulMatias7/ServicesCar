namespace ServicesCars
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pvDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.pvDocument = new System.Drawing.Printing.PrintDocument();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pcLogotipo = new System.Windows.Forms.PictureBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcLogotipo)).BeginInit();
            this.SuspendLayout();
            // 
            // pvDialog
            // 
            this.pvDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.pvDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.pvDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.pvDialog.Enabled = true;
            this.pvDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("pvDialog.Icon")));
            this.pvDialog.Name = "printPreviewDialog1";
            this.pvDialog.Visible = false;
            this.pvDialog.Load += new System.EventHandler(this.pvDialog_Load);
            // 
            // pvDocument
            // 
            this.pvDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(236, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 49);
            this.button2.TabIndex = 3;
            this.button2.Text = "Alterar Logotipo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pcLogotipo
            // 
            this.pcLogotipo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pcLogotipo.Location = new System.Drawing.Point(12, 12);
            this.pcLogotipo.Name = "pcLogotipo";
            this.pcLogotipo.Size = new System.Drawing.Size(131, 133);
            this.pcLogotipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcLogotipo.TabIndex = 2;
            this.pcLogotipo.TabStop = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 151);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(90, 95);
            this.listBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 268);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pcLogotipo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcLogotipo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PrintPreviewDialog pvDialog;
        private System.Drawing.Printing.PrintDocument pvDocument;
        private System.Windows.Forms.PictureBox pcLogotipo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ListBox listBox1;
    }
}