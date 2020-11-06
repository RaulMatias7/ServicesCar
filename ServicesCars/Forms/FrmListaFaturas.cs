using ServicesCars.Operations;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServicesCars
{
    public partial class FrmListaFaturas : Form
    {
        readonly OptCoorporacao opt = new OptCoorporacao();
        public FrmListaFaturas()
        {
            InitializeComponent();
            toolStripTextBox1.Text = DateTime.Now.Year.ToString();
            toolStripTextBox2.Text = DateTime.Now.Month.ToString();
            dsConfigure.csRestricoes.add_Number(toolStripTextBox1.TextBox);
            dsConfigure.csRestricoes.add_Number(toolStripTextBox2.TextBox);
        }

        private async Task Filtro()
        {
            try
            {
                ZERAR();
                this.Cursor = Cursors.WaitCursor;

                await opt.GetFacturas(dgvFull, int.Parse(toolStripTextBox1.Text), int.Parse(toolStripTextBox2.Text));

                dgvFull.Rows[0].Selected = false;
                dgvFull.Rows[dsConfigure.csForms.linha].Selected = true;
                Calcular();
                DgvSetting();
            }
            catch (Exception)
            {
            }
            this.Cursor = Cursors.Default;
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

        private void DgvSetting()
        {
            try
            {
                dgvFull.Columns["id"].HeaderText = "Identificador";
                dgvFull.Columns["nome"].HeaderText = "Empresa";
                dgvFull.Columns["numEncomenda"].HeaderText = "Nº Encomenda";
                dgvFull.Columns["tipo"].HeaderText = "Tipo de Peixe";
                dgvFull.Columns["idEmpresa"].HeaderText = "Nº Empresa";
                dgvFull.Columns["precoKilo"].HeaderText = "Preço/Kilo";
                dgvFull.Columns["data_criacao"].HeaderText = "Criação";
            }
            catch (Exception)
            {
            }
        }
        private void Calcular()
        {
            try
            {
                decimal total = 0;
                for (int i = 0; i < dgvFull.Rows.Count; i++)
                {
                    total += decimal.Ceiling((decimal)dgvFull.Rows[i].Cells["Total"].Value);
                }
                lbTotal.Text = "Total: " + total + ",00 AOA";
            }
            catch (Exception)
            {
            }
        }


        private async void FrmListaFaturas_Load(object sender, EventArgs e)
        {
            csDrag.NomeForm = "Lista de facturas";
            await Filtro();
            DgvSetting();
            frmWait.pronto = true;
        }

        private void pcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            opt.GetBySearchFacturas(dgvFull, txtPesquisar.Text.ToLower());
            Calcular();
        }

        private async void pcRefresh_Click(object sender, EventArgs e)
        {
            txtPesquisar.Clear();
            await Filtro();
        }

        private async void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await Filtro();
            }
        }

        private async void toolStripTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await Filtro();
            }
        }
    }
}
