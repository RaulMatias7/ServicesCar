using System;
using System.Windows.Forms;

namespace ServicesCars
{
    public partial class frmInfoCaixa : Form
    {
        public frmInfoCaixa(int[] valores)
        {
            InitializeComponent();
            lbMontante.Text = valores[0] +" kz";
            lbMulticaixa.Text = valores[1] + " kz";
            lbTotal.Text = valores[2] + " kz";
            lbTotAtendimentos.Text = valores[3].ToString();
        }

        private void pcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInfoCaixa_Load(object sender, EventArgs e)
        {
        }
    }
}
