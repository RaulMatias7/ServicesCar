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
    public partial class frmPromocoes : Form
    {
        ServicesCars.Operations.optPromocoes opt = new Operations.optPromocoes();
        public frmPromocoes()
        {
            InitializeComponent();
        }

        private async void frmPromocoes_Load(object sender, EventArgs e)
        {
            csDrag.NomeForm = "Promoções";
            await opt.Get(dgvFull);
        }

        private async void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            await opt.GetBySearch(dgvFull, txtPesquisar.Text.ToLower());
        }

        private void dgvFull_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dsConfigure.csForms.PegarLinha(dgvFull);
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((int)dgvFull.Rows[dgvFull.CurrentRow.Index].Cells["contagem"].Value != 10)
                {
                    csDrag.PrintMessenge("Não é possível reiniciar porque a contagem de promoção ainda não atingiu o limite. ", false);
                    return;
                }

                dsConfigure.csForms.CallFormDialog(this, new frmContinuar());
                if (!frmContinuar.x)
                    return;

                if (await opt.Reiniciar(dsConfigure.csForms.id) != opt.vetor[1])
                {
                    csDrag.PrintMessenge(opt.vetor[0], false);
                    return;
                }

                //// SUCESSO
                csDrag.PrintMessenge(opt.vetor[0]);
                await opt.Get(dgv: dgvFull);

            }
            catch (Exception ms)
            {
                csDrag.PrintMessenge(ms.Message, false);
            }
        }

        private void pcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
