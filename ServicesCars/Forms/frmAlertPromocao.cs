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
    public partial class frmAlertPromocao : Form
    {
        public frmAlertPromocao(string matricula)
        {
            InitializeComponent();
            lbMensagem.Text = "   O veículo com a matricula " + matricula + " acabou de receber \n" +
    "uma promoção por ter completado o número estimado de aquisição \n" +
    "de serviços.";
        }

        int c = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            c++;
            if (c==15)
            {
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("X: "+Location.X + "--- Y: " + Location.Y);
        }

        private void frmAlertPromocao_Load(object sender, EventArgs e)
        {
            int width = Screen.PrimaryScreen.Bounds.Width;
            int height = Screen.PrimaryScreen.Bounds.Height;
            SetDesktopLocation(width - 506, height - 150);
        }

        private void pcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbVerMais_Click(object sender, EventArgs e)
        {
            dsConfigure.csForms.CallFormDialog(this, new frmPromocoes());
        }
    }
}
