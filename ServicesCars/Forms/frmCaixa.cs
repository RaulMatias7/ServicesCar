using ServicesCars.Operations;
using System;
using System.Windows.Forms;

namespace ServicesCars
{
    public partial class frmCaixa : Form
    {
        readonly optAtendimentos opt = new optAtendimentos();
        public frmCaixa()
        {
            InitializeComponent();
            toolStripTextBox1.Text = DateTime.Now.Year.ToString();
            toolStripTextBox2.Text = DateTime.Now.Month.ToString();
           dsConfigure.csRestricoes.add_Number(toolStripTextBox1.TextBox);
            dsConfigure.csRestricoes.add_Number(toolStripTextBox2.TextBox);
        }

        private void DgvSetting()
        {
            try
            {
                dgvFull.Columns["id"].HeaderText = "Identificador";
                dgvFull.Columns["referência"].Visible=false;
            }
            catch (Exception)
            {
            }
        }

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
            
        }

        private async void Filtro()
        {
            try
            {
                ZERAR();
                this.Cursor = Cursors.WaitCursor;

                await opt.GetCaixa(dgvFull, int.Parse(toolStripTextBox1.Text), int.Parse(toolStripTextBox2.Text));

                dgvFull.Rows[0].Selected = false;
                dgvFull.Rows[dsConfigure.csForms.linha].Selected = true;
                Calcular();
                DgvSetting();
            }
            catch (Exception)
            {
                //csDrag.PrintMessenge(ms.Message, false);
            }
            this.Cursor = Cursors.Default;
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


        private void frmCaixa_Load(object sender, EventArgs e)
        {
            csDrag.NomeForm = "Caixa";
            Filtro();
            dsConfigure.csForms.PegarLinha(dgvFull);
            DgvSetting();
            frmWait.pronto = true;
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            opt.GetBySearchCaixa(dgvFull, txtPesquisar.Text.ToLower());
            Calcular();
        }

        private void pcRefresh_Click(object sender, EventArgs e)
        {
            Filtro();
        }

        private void dgvFull_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dsConfigure.csForms.PegarLinha(dgvFull);
        }

        private void Calcular()
        {
            try
            {
                decimal montante = 0, multicaixa = 0;
                for (int i = 0; i < dgvFull.Rows.Count ; i++)
                {
                    montante += decimal.Ceiling((decimal)dgvFull.Rows[i].Cells["montante"].Value);
                    multicaixa += decimal.Ceiling((decimal)dgvFull.Rows[i].Cells["multicaixa"].Value);
                }
                lbMontante.Text = "Montante: " + montante + ",00 AOA";
                lbMulticaixa.Text = "Multicaixa: " + multicaixa + ",00 AOA";
                lbTotal.Text = "Total: " + (montante+multicaixa) + ",00 AOA";
            }
            catch (Exception)
            {
            }
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
