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
    public partial class frmCriarFatura : Form
    {
        readonly OptCoorporacao opt = new OptCoorporacao();
        public frmCriarFatura(string numEmpresa,string empresa)
        {
            InitializeComponent();
            txtNumEmpresa.Text = numEmpresa;
            txtEmpresa.Text = empresa;

            dsConfigure.csRestricoes.add_Number(txtNumEncomenda);
            dsConfigure.csRestricoes.add_Number(txtPrecoKilo);
            dsConfigure.csRestricoes.add_Number(txtKilos);
            dsConfigure.csRestricoes.add_text(txtTipo);
        }

        void Calcular()
        {
            try
            {
                txtTotal.Text = (int.Parse(txtKilos.Text) * (int.Parse(txtPrecoKilo.Text))).ToString();
            }
            catch (Exception)
            {
            }
        }

        private void PcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOperacao_Click(object sender, EventArgs e)
        {
            Calcular();
            //: ADICIONAR ATENDIMENTO
            if (opt.AddFacturaEmpresa(new Models.FaturasEmpresa { idEmpresa = dsConfigure.csForms.id, kilos = int.Parse(txtKilos.Text), numEncomenda = int.Parse(txtNumEncomenda.Text), precoKilo = decimal.Parse(txtPrecoKilo.Text), tipo = txtTipo.Text }) != opt.vetor[1])
            {
                csDrag.PrintMessenge(opt.vetor[0], false);
                return;
            }
            // SUCESSO
            csDrag.PrintMessenge(opt.vetor[0]);
        }

        private void TxtPrecoKilo_TextChanged(object sender, EventArgs e)
        {
            Calcular();
        }

        private void TxtKilos_TextChanged(object sender, EventArgs e)
        {
            Calcular();
        }
    }
}
