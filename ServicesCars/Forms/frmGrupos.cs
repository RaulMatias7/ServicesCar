using ServicesCars.Models;
using ServicesCars.Operations;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServicesCars
{
    public partial class frmGrupos : Form
    {
        optGrupos opt = new optGrupos();
        public frmGrupos()
        {
            InitializeComponent();
            dsConfigure.csRestricoes.add_text(txtGrupo);
        }

        private void pcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmGrupos_Load(object sender, EventArgs e)
        {
             csDrag.NomeForm = "Grupos";
            await opt.Get(dgv: dgvFull);
        }

        private void lblimpar_Click(object sender, EventArgs e)
        {
            txtGrupo.Clear();
        }

        private void dgvFull_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dsConfigure.csForms.PegarLinha(dgv: dgvFull);
        }

        private void dgvFull_DoubleClick(object sender, EventArgs e)
        {
            btnEditar.Enabled = true;
            dsConfigure.csForms.PegarLinha(dgv: dgvFull);
            txtGrupo.Focus();
            txtGrupo.SelectAll();
            txtGrupo.Text = dgvFull.Rows[dgvFull.CurrentRow.Index].Cells["grupo"].Value.ToString();
        }

        private async void btnNovo_Click(object sender, EventArgs e)
        {
            if (opt.Add(new Grupos { grupo = txtGrupo.Text }) != opt.vetor[1])
            {
                csDrag.PrintMessenge(opt.vetor[0], false);
                return;
            }

            // SUCESSO
            csDrag.PrintMessenge(opt.vetor[0]);
            txtGrupo.Clear();
            await opt.Get(dgv: dgvFull);
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            if (await opt.Update(new Grupos { id= dsConfigure.csForms.id, grupo= txtGrupo.Text }) != opt.vetor[1])
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
            txtGrupo.Clear();
            dsConfigure.csForms.id = 0;
            await opt.Get(dgv: dgvFull);
        }

        private void txtGrupo_KeyDown(object sender, KeyEventArgs e)
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
    }
}
