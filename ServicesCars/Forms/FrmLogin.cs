using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServicesCars.Operations;
namespace ServicesCars
{
    public partial class FrmLogin : Form
    {
        readonly OptLogin opt = new OptLogin();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void CheckSenha()
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;
                lbSms.Hide();

                if (opt.GetSenha(dsConfigure.csCriptografia.Aes_Encrypt(txtSenha.Text)))
                {
                    csDrag.formMenu = new frmMenuPrincipal(OptLogin.TakeUser.FirstOrDefault().nome, OptLogin.TakeUser.FirstOrDefault().acesso);
                    csDrag.formMenu.Show();
                    //csDrag.FrmOpacity.Show();
                    //dsConfigure.csForms.CallFormDialog(this, csDrag.FrmWait);
                    this.Hide();
                }

            }
            catch (Exception ms)
            {
                csDrag.PrintMessenge(ms.Message);
            }
            this.Cursor = Cursors.Default;
        }
        void VerifySenha()
        {
            if (opt.vetor[1] != null)
            {
                lbSms.Visible = false;
                return;
            }

            lbSms.Visible = true;
            lbSms.Text = opt.vetor[0];
        }

        private void Entrar()
        {
            CheckSenha();
            VerifySenha();
        }


        private void PcClose_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text))
            {
                lbSms.Text = "Insira o nome de usuário";
                lbSms.Visible = true;
                return;
            }

             Entrar();
        }
 
        private void TxtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                Entrar();
            }
        }

        private async void txtUser_TextChanged(object sender, EventArgs e)
        {
             await opt.GetUser(txtUser.Text);
             VerifySenha();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            CheckSenha();
        }

    }
}
