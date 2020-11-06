using System;
using System.Security.Cryptography;
using System.Windows.Forms;
using ServicesCars.Models;
using ServicesCars.Operations;

namespace ServicesCars
{
    public partial class frmAddAtendimento : Form
    {
        optAtendimentos opt = new optAtendimentos();
        optSubServices optSubService = new optSubServices();

        int IdGrupo;
        string tipoPagameto = "";
        public frmAddAtendimento()
        {
            InitializeComponent();
            dsConfigure.csRestricoes.add_Cmb_HANDELDE(cbxGrupo);
            dsConfigure.csRestricoes.add_text(txtCliente);
            dsConfigure.csRestricoes.add_text(txtMarca);
            dsConfigure.csRestricoes.add_Number(txtMontante);
            dsConfigure.csRestricoes.add_Number(txtMulticaixa);
            dsConfigure.csRestricoes.add_txtUpper(txtMatricula);
            txtMulticaixa.ReadOnly = true;
            txtMulticaixa.Text = "0";
            tipoPagameto = rbMontante.Text;
        }


        private void Calcular()
        {
            try
            {
                //int dd = int.Parse(txtMontante.Text) + int.Parse(txtMontante.Text);
                //MessageBox.Show(dd.ToString());
                txtTotalPagamento.Text = (int.Parse(txtMontante.Text) + int.Parse(txtMulticaixa.Text)).ToString();
            }
            catch (Exception)
            {
                txtTotalPagamento.Text = "0";
            }
        }

        //: DEFINIÇÕES DA DATAGRIDVIEW
        private void DgvSetting()
        {
            try
            {
                dgvFull.Columns["id"].HeaderText = "Identificador";
                dgvFull.Columns["criação"].Visible = false;
                dgvFull.Columns["modificação"].Visible = false;
            }
            catch (Exception)
            {
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmAddAtendimento_Load(object sender, EventArgs e)
        {
            await optGrupos.FullCombol(cbxGrupo);
            await optSubService.Get(dgvFull);
            DgvSetting();
        }

        private void cbxGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.IdGrupo = optGrupos.ListaOperacao[cbxGrupo.SelectedIndex].id;
        }

        private async void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            await optSubService.GetBySearch(dgvFull, txtPesquisar.Text);
            DgvSetting();
        }


        decimal totalAtendimento = 0;
        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            txtIdServico.Text = dgvFull.Rows[dgvFull.CurrentRow.Index].Cells["Id"].Value.ToString();
            totalAtendimento = decimal.Ceiling(decimal.Parse(dgvFull.Rows[dgvFull.CurrentRow.Index].Cells["preço"].Value.ToString()));
            txtTotalAtendimento.Text = totalAtendimento.ToString();

        }

        private async void btnRegistar_Click(object sender, EventArgs e)
        {

            if (await opt.GetMatricula(txtMatricula.Text) == 9)
            {
                Form formAlert = new frmAlertPromocao(txtMatricula.Text);
                csDrag.formMenu.AddOwnedForm(formAlert);
                formAlert.Show();
            }

            if (int.Parse(txtTotalPagamento.Text)< int.Parse(txtTotalAtendimento.Text))
            {
                csDrag.PrintMessenge("Insira o pagamento para concluir a operação", false);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMatricula.Text))
            {
                csDrag.PrintMessenge("Insira o número da matricula para concluir a operação", false);
                return;
            }

            ////: ADICIONAR PAGAMENTO
            if (opt.AddPagamento(new Pagamentos { cliente = txtCliente.Text, montante = decimal.Parse(txtMontante.Text),multicaixa = decimal.Parse(txtMulticaixa.Text), idFuncionario = dsConfigure.csForms.id_user }) != opt.vetor[1])
            {
                csDrag.PrintMessenge(opt.vetor[0], false);
                return;
            }

          
            ////: ADICIONAR ATENDIMENTO
            if (opt.Add(new Atendimento { idPagamento = opt.GetLastPagamentos(), idGrupo = this.IdGrupo, marca = txtMarca.Text, matricula = txtMatricula.Text, tipoPagamento= this.tipoPagameto, idSubServico = int.Parse(txtIdServico.Text), valor = totalAtendimento }) != opt.vetor[1])
            {
                //TODO: implementar o codigo de eliminar o pagamento caso o atendimento não for efectuado
                await opt.DeletePagamento(opt.GetLastPagamentos());
                csDrag.PrintMessenge(opt.vetor[0], false);
                LIMPAR();
                return;
            }

            // SUCESSO
            csDrag.PrintMessenge(opt.vetor[0]);
            LIMPAR();
        }

        private void LIMPAR()
        {
            txtTotalPagamento.Text = "0";
            txtMontante.Text = "0";
            txtMulticaixa.Text = "0";
            rbAmbos.Checked = false;
            rbMontante.Checked = false;
            rbMulticaixa.Checked = false;
            tipoPagameto = null;
        }
        private void rbMulticaixa_Click(object sender, EventArgs e)
        {
            txtMontante.Text = "0";
            txtTotalPagamento.Text = txtTotalAtendimento.Text;
            txtMulticaixa.Text = txtTotalAtendimento.Text;
            gbxPagamento.Enabled = false;
            tipoPagameto = rbMulticaixa.Text;
        }

        private void rbMontante_Click(object sender, EventArgs e)
        {
            gbxPagamento.Enabled = false;
            txtMulticaixa.Text = "0";
            //txtMulticaixa.ReadOnly = true;
            txtTotalPagamento.Text = txtTotalAtendimento.Text;
            txtMontante.Text = txtTotalAtendimento.Text;
            //txtMontante.ReadOnly = true;
            tipoPagameto = rbMontante.Text;
        }

        private void rbAmbos_Click(object sender, EventArgs e)
        {
            gbxPagamento.Enabled = true;
            txtMontante.ReadOnly = false;
            txtMulticaixa.ReadOnly = false;
            tipoPagameto = rbAmbos.Text;

        }

        private void txtMontante_TextChanged(object sender, EventArgs e)
        {
            Calcular();
            //txtTotalPagamento.Text = txtMontante.Text;
        }


        private void txtMulticaixa_TextChanged(object sender, EventArgs e)
        {
            Calcular();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void dgvFull_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtTotalPagamento.Text = txtTotalAtendimento.Text;
                txtMontante.Text = txtTotalAtendimento.Text;
                rbMontante.Checked = true;
            }
            catch (Exception)
            {
            }
        }
    }
}
