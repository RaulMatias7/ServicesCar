namespace ServicesCars
{
    partial class Teste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teste));
            this.pvDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.pvDocument = new System.Drawing.Printing.PrintDocument();
            this.cbxImpressoras = new System.Windows.Forms.ComboBox();
            this.rctxtTexto = new System.Windows.Forms.RichTextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            // 
            // pvDocument
            // 
            this.pvDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PvDocument_PrintPage);
            // 
            // cbxImpressoras
            // 
            this.cbxImpressoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbxImpressoras.FormattingEnabled = true;
            this.cbxImpressoras.Location = new System.Drawing.Point(22, 37);
            this.cbxImpressoras.Name = "cbxImpressoras";
            this.cbxImpressoras.Size = new System.Drawing.Size(247, 24);
            this.cbxImpressoras.TabIndex = 0;
            // 
            // rctxtTexto
            // 
            this.rctxtTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rctxtTexto.Location = new System.Drawing.Point(22, 76);
            this.rctxtTexto.Name = "rctxtTexto";
            this.rctxtTexto.Size = new System.Drawing.Size(565, 308);
            this.rctxtTexto.TabIndex = 1;
            this.rctxtTexto.Text = resources.GetString("rctxtTexto.Text");
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(275, 32);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 33);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(425, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // teste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 396);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.rctxtTexto);
            this.Controls.Add(this.cbxImpressoras);
            this.Name = "teste";
            this.Text = "teste";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Teste_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PrintPreviewDialog pvDialog;
        private System.Drawing.Printing.PrintDocument pvDocument;
        private System.Windows.Forms.ComboBox cbxImpressoras;
        private System.Windows.Forms.RichTextBox rctxtTexto;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button button1;

    }
}