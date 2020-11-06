using ServicesCars.Models;
using System;
using System.Windows.Forms;

namespace ServicesCars
{
    public partial class frmServicos : Form
    {
        bool vf;
        ServicesCars.Operations.optSubServices opt = new Operations.optSubServices();
        int idServico = 0;
        public frmServicos()
        {
            InitializeComponent();
            dsConfigure.csRestricoes.add_Cmb_HANDELDE(cbxServicos);
            dsConfigure.csRestricoes.add_text(txtModelo);
            dsConfigure.csRestricoes.add_Number(txtPreco);
        }

        //: DEFINIÇÕES DA DATAGRIDVIEW
        private void DgvSetting()
        {
            try
            {
                dgvFull.Columns["id"].HeaderText = "Identificador";
            }
            catch (Exception)
            {
            }
        }
        private void pcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbAddServicos_Click(object sender, EventArgs e)
        {
            dsConfigure.csForms.CallFormDialog(this, new frmServicosAll());
        }

        private async void frmServicos_Load(object sender, EventArgs e)
        {
            csDrag.NomeForm = "SERVIÇOS";
            txtPreco.Text = "0";
            await opt.FullCombol(cbxServicos);
            await opt.Get(dgvFull);
            DgvSetting();
            frmWait.pronto = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            vf = true;
            grbOperacao.Enabled = true;
            grbOperacao.Text = "Adicionar novo Serviço agregado";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            vf = false;
            grbOperacao.Enabled = true;
            grbOperacao.Text = "Editar Serviço agregado";
            //dsConfigure.csForms.PegarLinha(dgvFull);
            txtModelo.Text = dgvFull.Rows[dgvFull.CurrentRow.Index].Cells["modelo"].Value.ToString();
            txtPreco.Text = (decimal.Ceiling(decimal.Parse(dgvFull.Rows[dgvFull.CurrentRow.Index].Cells["preço"].Value.ToString()))).ToString();
            cbxServicos.SelectedItem = dgvFull.Rows[dgvFull.CurrentRow.Index].Cells["serviço"].Value;
            this.idServico = opt.ListaServico[cbxServicos.SelectedIndex].id;
        }

        private void PcConcluir_Click(object sender, EventArgs e)
        {
            if (vf == true)
            {
                txtPreco.Text = (string.IsNullOrWhiteSpace(txtPreco.Text)) ? "0" : txtPreco.Text;

                SubServicoOperation(new Models.SubServicos { idServico = this.idServico, modelo = txtModelo.Text, preco = decimal.Parse(txtPreco.Text) });
            }
            else
            {
                SubServicoOperation(new SubServicos { id=dsConfigure.csForms.id, idServico = this.idServico, modelo = txtModelo.Text, preco = decimal.Parse(txtPreco.Text) },false);
            }
            grbOperacao.Enabled = false;
        }

        private async void PcRefresh_Click(object sender, EventArgs e)
        {
            await opt.Get(dgvFull);
            await opt.FullCombol(cbxServicos);
        }

        private void cbxServicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.idServico = opt.ListaServico[cbxServicos.SelectedIndex].id;
        }

        private async void SubServicoOperation(SubServicos subServicos, bool tipo = true)
        {
            if (tipo)
            {
                dsConfigure.csForms.linha = 0;
                if (opt.Add(subServicos) != opt.vetor[1])
                {
                    csDrag.PrintMessenge(opt.vetor[0], false);
                    return;
                }
                txtPreco.Text = "0";
                txtModelo.Clear();
            }
            else
            {
                if (await opt.Update(subServicos) != opt.vetor[1])
                {
                    csDrag.PrintMessenge(opt.vetor[0], false);
                    return;
                }
            }
            // SUCESSO
            csDrag.PrintMessenge(opt.vetor[0]);
            await opt.Get(dgv: dgvFull);
            dgvFull.Rows[0].Selected = false;
            dgvFull.Rows[dsConfigure.csForms.linha].Selected = true;
        }

        private  void dgvFull_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dsConfigure.csForms.PegarLinha(dgvFull);
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            dsConfigure.csForms.CallFormDialog(this, new frmContinuar());
            if (!frmContinuar.x)
                return;

            if (await opt.Delete(dsConfigure.csForms.id) != opt.vetor[1])
            {
                csDrag.PrintMessenge(opt.vetor[0], false);
                return;
            }

            //// SUCESSO
            csDrag.PrintMessenge(opt.vetor[0]);
            dsConfigure.csForms.id = 0;
            await opt.Get(dgv: dgvFull);
        }

        private async void TxtPesquisar_TextChanged(object sender, EventArgs e)
        {
            await opt.GetBySearch(dgvFull,txtPesquisar.Text);
            DgvSetting();
        }
    }
}
