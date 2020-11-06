using ServicesCars.Operations;
using System;
using System.Windows.Forms;

namespace ServicesCars
{
    public partial class FrmCoorporacao : Form
    {
        readonly OptCoorporacao opt = new OptCoorporacao();
        string empresa, numempresa;
        public FrmCoorporacao()
        {
            InitializeComponent();
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

        private async void FrmCoorporacao_Load(object sender, EventArgs e)
        {
            await opt.Get(dgvFull);
            DgvSetting();
            frmWait.pronto = true;
        }

        private void TxtPesquisar_TextChanged(object sender, EventArgs e)
        {
             opt.GetBySearch(dgvFull, txtPesquisar.Text);
            DgvSetting();
        }

        private void PcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //dsConfigure.csForms.CallFormInForm(this, new frmFacturas());
        }

        private void CrriarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
              empresa = dgvFull.Rows[dgvFull.CurrentRow.Index].Cells["nome"].Value.ToString();
              numempresa = dgvFull.Rows[dgvFull.CurrentRow.Index].Cells["id"].Value.ToString();
              dsConfigure.csForms.CallFormDialog(this, new frmCriarFatura(numempresa, empresa));
            }
            catch (Exception)
            {
            }
        }

        private async void AdicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dsConfigure.csForms.CallFormDialog(this, new FrmAddEmpresa());
            await opt.Get(dgv: dgvFull);
        }

        private async void EditarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           dsConfigure.csForms.CallFormDialog(this, new FrmAddEmpresa(dsConfigure.csForms.id, "Editar"));
            await opt.Get(dgv: dgvFull);
        }

        private void DgvFull_DoubleClick(object sender, EventArgs e)
        {
            dsConfigure.csForms.PegarLinha(dgvFull);
        }

        private void DgvFull_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dsConfigure.csForms.PegarLinha(dgvFull);
        }

        private void ListaDeFaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dsConfigure.csForms.CallFormInForm(this, new FrmListaFaturas());
                //csDrag.FrmOpacity.Show();
                //dsConfigure.csForms.CallFormDialog(this, csDrag.FrmWait);
            }
            catch (Exception)
            {
            }
            this.Cursor = Cursors.Default;
        }
    }
}
