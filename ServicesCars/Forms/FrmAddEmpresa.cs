using ServicesCars.Operations;
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
    public partial class FrmAddEmpresa : Form
    {
        readonly OptCoorporacao opt = new OptCoorporacao();
        public FrmAddEmpresa(int id=0,string tipo = "Adicionar")
        {
            InitializeComponent();
            btnOperacao.Text = tipo;
            try
            {
                if (tipo != "Adicionar")
                {
                    btnOperacao.Text = "Editar";

                    //// Pesquisar a empresa
                     opt.GetListEmpresaById(id);

                    //// Preencher as textBox
                    txtEmpresa.Text = opt.TakeEmpresas[0].nome;
                    txtLocalizacao.Text = opt.TakeEmpresas[0].localizacao;
                    txtNIF.Text = opt.TakeEmpresas[0].NIF;
                    txtEmail.Text = opt.TakeEmpresas[0].email;
                    txtDescricao.Text = opt.TakeEmpresas[0].descricao;
                    txtBanco.Text = opt.TakeEmpresas[0].banco;
                    txtConta.Text = opt.TakeEmpresas[0].num_conta;
                    txtIBAN.Text = opt.TakeEmpresas[0].IBAN;
                    txtContacto.Text = opt.TakeEmpresas[0].contacto;
                }
            }
            catch (Exception)
            {
            }
        }

        private void PcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddEmpresa_Load(object sender, EventArgs e)
        {
            csDrag.NomeForm = "EMPRESAS";
        }

        private async void BtnOperacao_Click(object sender, EventArgs e)
        {

            if (btnOperacao.Text == "Adicionar")
            {
                ////: ADICIONAR ATENDIMENTO
                if (opt.AddEmpresa(new Models.Empresas { nome = txtEmpresa.Text, banco = txtBanco.Text, contacto = txtContacto.Text, descricao = txtDescricao.Text, email = txtEmail.Text, IBAN = txtIBAN.Text, localizacao = txtLocalizacao.Text, NIF = txtNIF.Text, num_conta = txtConta.Text }) != opt.vetor[1])
                {
                    csDrag.PrintMessenge(opt.vetor[0], false);
                    return;
                }

            }
            else
            {
                if (await opt.Update(new Models.Empresas { id = dsConfigure.csForms.id, nome = txtEmpresa.Text, banco = txtBanco.Text, contacto = txtContacto.Text, descricao = txtDescricao.Text, email = txtEmail.Text, IBAN = txtIBAN.Text, localizacao = txtLocalizacao.Text, NIF = txtNIF.Text, num_conta = txtConta.Text }) != opt.vetor[1])
                {
                    csDrag.PrintMessenge(opt.vetor[0], false);
                    return;
                }
            }

            // SUCESSO
            csDrag.PrintMessenge(opt.vetor[0]);

        }

     }
}
