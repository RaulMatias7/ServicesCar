using ServicesCars.Operations;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ServicesCars
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal(string user, string acesso)
        {
            InitializeComponent();
            try
            {
                dsConfigure.csForms.frmSelected = new frmHome();
                dsConfigure.csForms.CallFormInPanel(pnContainer, new frmHome());
                lbtime.Text = DateTime.Now.ToLongDateString();

                lbUsuario.Text = user;
                lbAcesso.Text = "User: " + acesso;
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message);
            }
        }


        void ShowForm(Panel pnChamar, Form form, string texto)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                lbMenu.Text = texto;
                dsConfigure.csForms.CallFormInPanel(pnChamar, form);
                //AddOwnedForm(csDrag.FrmOpacity);
                //csDrag.FrmOpacity.Show();
                //dsConfigure.csForms.CallFormDialog(this, csDrag.FrmWait);
            }
            catch (Exception)
            {
            }
            this.Cursor = Cursors.Default;
        }
        private void PcMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PcMenu_Click(object sender, EventArgs e)
        {
            pnMenuLateral.Width = (pnMenuLateral.Width == 46) ? 196 : 46;
            dsConfigure.csForms.CallFormInPanel(this.pnContainer, dsConfigure.csForms.frmSelected);
        }


        private void BtnInicio_Click(object sender, EventArgs e)
        {
            dsConfigure.csForms.CallFormInPanel(this.pnContainer, new frmHome());
        }
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            dsConfigure.csForms.CallFormInPanel(pnContainer, new frmAddAtendimento());
            lbMenu.Text = "Novo atendimento";
        }

        private void BtnServicos_Click(object sender, EventArgs e)
        {
            ShowForm(this.pnContainer, new frmServicos(), btnServicos.Text);
        }

        private void BtnFuncionarios_Click(object sender, EventArgs e)
        {
            ShowForm(this.pnContainer, new frmFuncionarios(), btnFuncionarios.Text);
        }

        private void BtnAtendimento_Click(object sender, EventArgs e)
        {
            ShowForm(this.pnContainer, new frmAtendimentos(), btnAtendimento.Text);
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            dsConfigure.csForms.CallFormInPanel(this.pnContainer, new frmHome());
            csDrag.formMenu = this;
            frmWait.pronto = true;
            //csDrag.FrmWait.Hide();
        }

        private void BtnCaixa_Click(object sender, EventArgs e)
        {
            ShowForm(this.pnContainer, new frmCaixa(), btnCaixa.Text);
        }


        private void BtnPromocoes_Click(object sender, EventArgs e)
        {
            dsConfigure.csForms.CallFormDialog(this, new frmPromocoes());
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            ShowForm(this.pnContainer, new frmClientes(),btnClientes.Text);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            dsConfigure.csForms.CallForm(this, new frmAlertPromocao("LD-12-15-DS"));
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            lbMenu.Text = btnDashboard.Text;
        }

        private void PcClose_Click(object sender, EventArgs e)
        {
            dsConfigure.csForms.CallFormDialog(this, new frmContinuar());
            if (frmContinuar.x)
                Application.ExitThread();
        }

        private void frmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void BtnCoorporacao_Click(object sender, EventArgs e)
        {
            try
            {
                dsConfigure.csForms.CallFormInForm(this, new FrmCoorporacao());
                //csDrag.FrmOpacity.Show();
                //dsConfigure.csForms.CallFormDialog(this, csDrag.FrmWait);
            }
            catch (Exception)
            {
            }
        }
    }
}
