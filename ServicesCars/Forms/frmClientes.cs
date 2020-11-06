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
    public partial class frmClientes : Form
    {
        optClientes opt = new optClientes();
        public frmClientes()
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

        private async void AddFuncionarioTool_Click(object sender, EventArgs e)
        {
            dsConfigure.csForms.CallFormDialog(this, new frmAddClientes());
            await opt.Get(dgvFull);
        }

        private async void desabilitarToolStripMenuItem_Click(object sender, EventArgs e)
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

        private async void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            await opt.GetBySearch(dgvFull,txtPesquisar.Text);
            DgvSetting();
        }

        private async void frmClientes_Load(object sender, EventArgs e)
        {
            await opt.Get(dgv: dgvFull);
            DgvSetting();
            frmWait.pronto = true;
        }

        private void dgvFull_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dsConfigure.csForms.PegarLinha(dgvFull);
        }
    }
}
