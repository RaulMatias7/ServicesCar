using System;
using System.Windows.Forms;
using ServicesCars.Operations;
using ServicesCars.Models;
using System.Drawing;
using System.Collections.Generic;

namespace ServicesCars
{
    public partial class frmAddFuncionario : Form
    {
        optFuncionarios opt = new optFuncionarios();
        string sexo, acesso;
        //public static DataGridView _dataGrid = new DataGridView();
        public frmAddFuncionario(string tipo= "Adicionar")
        {
            InitializeComponent();
            btnOperacao.Text = tipo;
            sexo = rbMasculino.Text;
            acesso = rbNenhum.Text;
            rbNenhum.Checked = true;
            dsConfigure.csRestricoes.add_Nome(txtNome);

            if (tipo!="Adicionar")
            {
                rbNenhum.Checked = false;
                txtNome.Text = dsConfigure.csForms.listObject[1].ToString();
                txtUserName.Text = dsConfigure.csForms.listObject[2].ToString();

                if (dsConfigure.csForms.listObject[3].ToString() == "Masculino")
                    rbMasculino.Checked = true;
                else
                    rbFeminino.Checked = true;

                if (dsConfigure.csForms.listObject[7].ToString() == "Admin")
                    rbAdmin.Checked = true;
                else if (dsConfigure.csForms.listObject[7].ToString() == "Gerente")
                    rbGerente.Checked = true;
                else
                    rbNenhum.Checked = true;

                mskData.Text = dsConfigure.csForms.listObject[4].ToString();
                txtSenha.Text = dsConfigure.csCriptografia.Aes_Decrypt(dsConfigure.csForms.listObject[5].ToString());
                txtConfirmar.Text = txtSenha.Text;
                grbCredenciais.Enabled = false;
            }
        }

        private void pcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmAddFuncionario_Load(object sender, EventArgs e)
        {
            csDrag.NomeForm = "FUNCIONÁRIOS";
        }

        private void btnOperacao_Click(object sender, EventArgs e)
        {
            if (btnOperacao.Text== "Adicionar")
            {
                FuncionariosOperation(new Funcionarios { nome= txtNome.Text, sexo= this.sexo, username= txtUserName.Text, acesso= this.acesso, dataN= DateTime.Parse(mskData.Text), senha= dsConfigure.csCriptografia.Aes_Encrypt(txtSenha.Text)});
            }
            else
            {
                FuncionariosOperation(new Funcionarios { id=dsConfigure.csForms.id, nome = txtNome.Text, sexo = this.sexo, acesso = this.acesso, dataN = DateTime.Parse(mskData.Text) },false);
            }
            // SUCESSO
            txtNome.Focus();
        }

        private async void FuncionariosOperation(Funcionarios funcionarios, bool tipo = true)
        {
            
            if (tipo)
            {
                dsConfigure.csForms.linha = 0;
                if (opt.Add(funcionarios) != opt.vetor[1])
                {
                    csDrag.PrintMessenge(opt.vetor[0], false);
                    return;
                }
            }
            else
            {
                if (await opt.Update(funcionarios) != opt.vetor[1])
                {
                    csDrag.PrintMessenge(opt.vetor[0], false);
                    return;
                }
            }
            // SUCESSO
            csDrag.PrintMessenge(opt.vetor[0]);
        }

        private void rbMasculino_Click(object sender, EventArgs e)
        {
            sexo = rbMasculino.Text;
        }

        private void rbAdmin_Click(object sender, EventArgs e)
        {
            acesso = rbAdmin.Text;
        }

        private void rbGerente_Click(object sender, EventArgs e)
        {
            acesso = rbGerente.Text;
        }

        private void rbNenhum_Click(object sender, EventArgs e)
        {
            acesso = rbNenhum.Text;
        }

        private void txtConfirmar_TextChanged(object sender, EventArgs e)
        {
            if (txtSenha.Text != txtConfirmar.Text)
            {
                lbSenhaCompact.Visible = true;
                lbSenhaCompact.ForeColor = Color.Red;
            }
            else
            {
                lbSenhaCompact.Visible = false;
            }
        }


        private void rbFeminino_Click(object sender, EventArgs e)
        {
            sexo = rbFeminino.Text;
        }
    }
}
