using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ServicesCars.Operations;

namespace ServicesCars
{

    public partial class frmFuncionarios : Form
    {
        optFuncionarios opt = new optFuncionarios();
        public frmFuncionarios()
        {
            InitializeComponent();
            this.Hide();
        }

        private void DgvSetting()
        {
            try
            {
                dgvFull.Columns["id"].HeaderText = "Identificador";
                dgvFull.Columns["nome"].HeaderText = "nome completo";
                dgvFull.Columns["username"].Visible = false;
                dgvFull.Columns["senha"].Visible = false;
            }
            catch (Exception)
            {
            }
        }

        private async void frmFuncionarios_Load(object sender, EventArgs e)
        {
            //frmWait.pronto = false;
            csDrag.NomeForm = "Funcionários";
            await opt.Get(dgvFull);
            DgvSetting();
            frmWait.pronto = true;

            //this.Hide();
            //frmWait.pronto = true;
            //this.Show();
        }

        private async void pcRefresh_Click(object sender, EventArgs e)
        {
            await opt.Get(dgvFull);
            DgvSetting();
        }

        private void AddFuncionarioTool_Click(object sender, EventArgs e)
        {
            //dsConfigure.csForms.CallFormDialog(this, new frmAddFuncionario());
            //frmAddFuncionario fr = new frmAddFuncionario();
            //fr.FormBorderStyle = FormBorderStyle.None;
            //fr.TopLevel = false;
            ////fr.Dock = DockStyle.Fill;
            //fr.StartPosition = FormStartPosition.CenterScreen;
            //fr.Location = new Point(377, 209);
            //this.Controls.Add(fr);
            //this.Tag = fr;
            //fr.BringToFront();
            //fr.Show();
        }

        private void grupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private async void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dsConfigure.csForms.CallFormDialog(this, new frmAddFuncionario());
            await opt.Get(dgvFull);
        }

        private void incluirGrupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dsConfigure.csForms.PegarLinha(dgvFull);
            dsConfigure.csForms.CallFormDialog(this, new frmIncluirGrupo());
        }

        private async void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            await opt.GetBySearch(dgvFull, txtPesquisar.Text);
        }

        private void dgvFull_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dsConfigure.csForms.PegarLinha(dgvFull);
        }

        private async void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dsConfigure.csForms.PegarLinha(dgvFull);
                dsConfigure.csForms.listObject = new List<object>();
                for (int i = 0; i < dgvFull.ColumnCount-1; i++)
                    dsConfigure.csForms.listObject.Add(dgvFull.Rows[dsConfigure.csForms.linha].Cells[i].Value);
                dsConfigure.csForms.CallFormDialog(this, new frmAddFuncionario("Editar"));
                await opt.Get(dgvFull);
                dgvFull.Rows[0].Selected = false;
                dgvFull.Rows[dsConfigure.csForms.linha].Selected = true;
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message);
            }
        }

        private void desabilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estado(false);
        }

        private void habilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estado();
        }

        private async void Estado(bool x = true)
        {
            if (x)
            {
                await opt.UpdateState(new Models.Funcionarios { id = dsConfigure.csForms.id, estado = "Habilitado" });
            }
            else
            {
                await opt.UpdateState(new Models.Funcionarios { id = dsConfigure.csForms.id, estado = "Desabilitado" });
            }
            await opt.Get(dgvFull);
            dgvFull.Rows[0].Selected = false;
            dgvFull.Rows[dsConfigure.csForms.linha].Selected = true;
        }

        private void adicionaeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dsConfigure.csForms.CallFormDialog(this, new frmGrupos());
        }

        private void elementosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dsConfigure.csForms.CallFormDialog(this, new frmElementosGrupo());
        }
    }
}
