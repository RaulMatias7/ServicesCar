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
    public partial class frmElementosGrupo : Form
    {
        optGrupos opt = new optGrupos();

        public frmElementosGrupo()
        {
            InitializeComponent();
        }

        private async void frmElementosGrupo_Load(object sender, EventArgs e)
        {
            csDrag.NomeForm = "Elementos";
            await opt.GetElementos(dgvFull);
        }

        private async void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            await opt.SearchElementos(dgvFull, txtPesquisar.Text);
        }

        private void pcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            dsConfigure.csForms.PegarLinha(dgvFull);
            dsConfigure.csForms.CallFormDialog(this, new frmContinuar());
            if (!frmContinuar.x)
                return;

            if (await opt.DeleteElemento(dsConfigure.csForms.id) != opt.vetor[1])
            {
                csDrag.PrintMessenge(opt.vetor[0], false);
                return;
            }

            //// SUCESSO
            csDrag.PrintMessenge(opt.vetor[0]);
            dsConfigure.csForms.id = 0;
            await opt.GetElementos(dgvFull);
        }

        private async void btnNovo_Click(object sender, EventArgs e)
        {
            dsConfigure.csForms.CallFormDialog(this, new frmIncluirGrupo());
            await opt.GetElementos(dgvFull);
        }

        private void dgvFull_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dsConfigure.csForms.PegarLinha(dgvFull);
        }
    }
}
