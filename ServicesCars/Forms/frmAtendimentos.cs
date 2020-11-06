using ServicesCars.Models;
using ServicesCars.Operations;
using System;
using System.Windows.Forms;

namespace ServicesCars
{
    public partial class frmAtendimentos : Form
    {
        optAtendimentos opt = new optAtendimentos();
        string tipo = null;

        public frmAtendimentos()
        {
            InitializeComponent();

            toolStripTextBox1.Text = DateTime.Now.Year.ToString();
            toolStripTextBox2.Text = DateTime.Now.Month.ToString();
            toolStripTextBox3.Text = DateTime.Now.Day.ToString();
            dsConfigure.csRestricoes.add_Number(toolStripTextBox1.TextBox);
            dsConfigure.csRestricoes.add_Number(toolStripTextBox2.TextBox);
            dsConfigure.csRestricoes.add_Number(toolStripTextBox3.TextBox);
            tipo=rbHoje.Text;
        }
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

        ///: METODO DE FILTRO
        private void ZERAR()
        {
            if (string.IsNullOrWhiteSpace(toolStripTextBox1.Text))
            {
                toolStripTextBox1.Text = "0";
            }
            if (string.IsNullOrWhiteSpace(toolStripTextBox2.Text))
            {
                toolStripTextBox2.Text = "0";
            }
            if (string.IsNullOrWhiteSpace(toolStripTextBox3.Text))
            {
                toolStripTextBox3.Text = "0";
            }
        }
        private async void Filtro()
        {
            try
            {
                ZERAR();
                this.Cursor = Cursors.WaitCursor;
                
                    await opt.Get(dgvFull, int.Parse(toolStripTextBox1.Text), int.Parse(toolStripTextBox2.Text), int.Parse(toolStripTextBox3.Text),tipo);
               
                dgvFull.Rows[0].Selected = false;
                dgvFull.Rows[dsConfigure.csForms.linha].Selected = true;
                DgvSetting();
            }
            catch (Exception)
            {
                //csDrag.PrintMessenge(ms.Message, false);
            }
            this.Cursor = Cursors.Default;
        }

        ///: ALTERAR O ESTADO DO REGISTO
        private async void Estado(bool x = true)
        {
            dsConfigure.csForms.CallFormDialog(this, new frmContinuar());
            if (!frmContinuar.x)
                return;

            //dsConfigure.csForms.PegarLinha(dgvFull);

            if (x)
            {
                await opt.UpdateState(new Pagamentos { id = dsConfigure.csForms.id, estado = "activo" });
            }
            else
            {
                await opt.UpdateState(new Pagamentos { id = dsConfigure.csForms.id, estado = "cancelado" });
            }
            csDrag.PrintMessenge(opt.vetor[0]);
            Filtro();
        }
        private async void novoTool_Click_1(object sender, EventArgs e)
        {
            dsConfigure.csForms.CallFormInForm(this, new frmAddAtendimento());
            await opt.Get(dgvFull);
        }
        private async void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dsConfigure.csForms.CallFormDialog(this, new frmInfoCaixa(await opt.StateCaixa(dsConfigure.csForms.id_user)));
        }

        private void frmAtendimentos_Load(object sender, EventArgs e)
        {
            csDrag.NomeForm = "Atendimentos";
            //await opt.Get(dgvFull);
            Filtro();
            dsConfigure.csForms.PegarLinha(dgvFull);
            DgvSetting();
            frmWait.pronto = true;
        }
        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            opt.GetBySearch(dgvFull, txtPesquisar.Text.ToLower());
        }
        private void activarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estado();
        }
        private void cancelarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Estado(false);
        }
        private async void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dsConfigure.csForms.CallFormDialog(this, new frmContinuar());
            if (!frmContinuar.x)
                return;

            if (await opt.DeletePagamento(dsConfigure.csForms.id) != opt.vetor[1])
            {
                csDrag.PrintMessenge(opt.vetor[0], false);
                return;
            }

            //// SUCESSO
            dsConfigure.csForms.linha = 0;
            csDrag.PrintMessenge(opt.vetor[0]);
            Filtro();
        }
        private void pcRefresh_Click(object sender, EventArgs e)
        {
            Filtro();
        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Filtro();
            }
        }

        private void toolStripTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Filtro();
            }
        }

        private void toolStripTextBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Filtro();
            }
        }

        private void rbHoje_CheckedChanged(object sender, EventArgs e)
        {
            tipo = rbHoje.Text;
            Filtro();
        }

        private void rbMes_CheckedChanged(object sender, EventArgs e)
        {
            tipo = rbGeral.Text;
            toolStripTextBox3.Text = "0";
            Filtro();
        }

        private void dgvFull_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dsConfigure.csForms.PegarLinha(dgvFull);
        }

        

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}