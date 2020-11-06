using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServicesCars
{
    public partial class Teste : Form
    {
        public Teste()
        {
            InitializeComponent();
        }

        private void Teste_Load(object sender, EventArgs e)
        {
            try
            {
                cbxImpressoras.Items.Clear();
                foreach (var impressora in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
                {
                    cbxImpressoras.Items.Add(impressora);
                }
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message);
            }
        }

        string _texto;
        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            _texto = rctxtTexto.Text;
            pvDialog.Document = pvDocument;
            pvDialog.ShowDialog();
        }

        
        private void PvDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            int caracteres = 0, linhas=0;

            var font = new Font("Arial", 14, FontStyle.Regular);
            var brush = new SolidBrush(Color.Black);
            var size = new Size(e.MarginBounds.Width, e.MarginBounds.Height - font.Height + 1);
            
            e.Graphics.MeasureString(_texto, font, size, StringFormat.GenericTypographic, out caracteres,out linhas);

            e.Graphics.DrawString(_texto.Substring(0,caracteres), font, brush, e.MarginBounds);

            _texto = _texto.Substring(caracteres);

            e.HasMorePages = !string.IsNullOrWhiteSpace(_texto);
        }

    }
}
