using System;
using System.Windows.Forms;
using ServicesCars.Models;
using ServicesCars.Operations;

namespace ServicesCars
{
    public partial class frmServicosAll : Form
    {
        optServices opt = new optServices();
        public frmServicosAll()
        {
            InitializeComponent();
            dsConfigure.csRestricoes.add_text(txtService);
        }

        ////: DEFINIÇÕES DA DATAGRIDVIEW
        private void DgvSetting()
        {
            try
            {
                dgvFull.Columns["id"].HeaderText = "Identificador";
                dgvFull.Columns["data_criacao"].HeaderText = "criação";
                dgvFull.Columns["data_modificacao"].HeaderText = "modificação";
            }
            catch (Exception)
            {
            }
        }
        private void pcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ////: LEITURA DO FORMULARIO
        private async void frmServicosAll_Load(object sender, EventArgs e)
        {
            csDrag.NomeForm = "SERVIÇOS";
            await opt.Get(dgv: dgvFull);
            DgvSetting();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

        ////: ADICIONAR NOVO ELEMENTO
        private async void btnNovo_Click(object sender, EventArgs e)
        {

            if (opt.Add(new Servicos { nome = txtService.Text }) != opt.vetor[1])
            {
                csDrag.PrintMessenge(opt.vetor[0], false);
                return;
            }

            // SUCESSO
            csDrag.PrintMessenge(opt.vetor[0]);
            txtService.Clear();
            await opt.Get(dgv: dgvFull);
        }

        ////: ELIMINAR ELEMENTO
        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            dsConfigure.csForms.PegarLinha(dgvFull);
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
            txtService.Clear();
            dsConfigure.csForms.id = 0;
            await opt.Get(dgv: dgvFull);
        }

        ////: EDITAR ELEMENTO
        private async void btnEditar_Click(object sender, EventArgs e)
        {
            if (await opt.Update(dsConfigure.csForms.id, new Servicos { nome = txtService.Text }) != opt.vetor[1])
            {
                csDrag.PrintMessenge(opt.vetor[0], false);
                return;
            }

            // SUCESSO
            csDrag.PrintMessenge(opt.vetor[0]);
            await opt.Get(dgv: dgvFull);
            dgvFull.Rows[0].Selected = false;
            dgvFull.Rows[dsConfigure.csForms.linha].Selected = true;
        }

       

        ////: Pegar o Id selecionado quando clicar em uma linha
        private void dgvFull_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dsConfigure.csForms.PegarLinha(dgv: dgvFull);
        }

        private void dgvFull_DoubleClick(object sender, EventArgs e)
        {
            btnEditar.Enabled = true;
            dsConfigure.csForms.PegarLinha(dgv: dgvFull);
            txtService.Focus();
            txtService.Text = dgvFull.Rows[dgvFull.CurrentRow.Index].Cells["Nome"].Value.ToString();
        }

        ////: Limpar a textbox
        private void lblimpar_Click_1(object sender, EventArgs e)
        {
            txtService.Clear();
        }

        private void txtService_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (dsConfigure.csForms.id == 0)
                    btnNovo_Click(sender, e);
                else
                    btnEditar_Click(sender, e);

                dsConfigure.csForms.id = 0;
            }
        }

        private void txtService_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
