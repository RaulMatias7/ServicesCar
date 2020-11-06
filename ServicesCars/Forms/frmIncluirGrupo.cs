using System;
using System.Windows.Forms;

namespace ServicesCars
{
    public partial class frmIncluirGrupo : Form
    {
        int IdGrupo=0;
        ServicesCars.Operations.optGrupos opt = new Operations.optGrupos();
        public frmIncluirGrupo(int idfuncionario=0)
        {
            InitializeComponent();
            dsConfigure.csRestricoes.add_Cmb_HANDELDE(cbxGrupo);
            dsConfigure.csRestricoes.add_Number(txtId);
            txtId.Text = dsConfigure.csForms.id.ToString();
        }

        private void pcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmIncluirGrupo_Load(object sender, EventArgs e)
        {
            await ServicesCars.Operations.optGrupos.FullCombol(cbxGrupo);
            txtNome.Text = await opt.SearchById(int.Parse(txtId.Text));
        }

        private async void pcPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                txtNome.Text= await opt.SearchById(int.Parse(txtId.Text));
            }
            catch (Exception ms)
            {
                csDrag.PrintMessenge(ms.Message, false);
            }
        }

        private void btnOperacao_Click(object sender, EventArgs e)
        {
            if (opt.IncluirGrupo(new Models.FuncGroup { idFuncionario= int.Parse(txtId.Text), idGrupo= this.IdGrupo }) != opt.vetor[1])
            {
                csDrag.PrintMessenge(opt.vetor[0], false);
                return;
            }
            csDrag.PrintMessenge(opt.vetor[0]);
        }

        private void cbxGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.IdGrupo = ServicesCars.Operations.optGrupos.ListaOperacao[cbxGrupo.SelectedIndex].id;
        }

        private async void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtNome.Text = await opt.SearchById(int.Parse(txtId.Text));
                }
            }
            catch (Exception ms)
            {
                csDrag.PrintMessenge(ms.Message, false);
            }
        }
    }
}
