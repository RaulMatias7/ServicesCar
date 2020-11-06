using System;
using System.Windows.Forms;

namespace ServicesCars
{
    public partial class frmWait : Form
    {
        public static bool pronto = false;

        public frmWait()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            try
            {

                ProgressBar.Value++;
                if (ProgressBar.Value >= 100)
                    ProgressBar.Value = 0;

                if (pronto)
                {
                    pronto = false;
                    this.Close();
                    //csDrag.FrmOpacity.Hide();
                    return;
                }

            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message);
            }
        }

        private void BtnOperacao_Click(object sender, EventArgs e)
        {
            try
            {
                dsConfigure.csForms.FormChamado.Close();
                this.Close();
            }
            catch (Exception)
            {
                this.Close();
            }
        }

        private void FrmWait_FormClosing(object sender, FormClosingEventArgs e)
        {
            //csDrag.FrmOpacity.Hide();
        }
    }
}
