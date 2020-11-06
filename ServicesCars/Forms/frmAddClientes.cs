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
    public partial class frmAddClientes : Form
    {
        optClientes opt = new optClientes();
        string sexo;
        public frmAddClientes()
        {
            InitializeComponent();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmar_TextChanged(object sender, EventArgs e)
        {

        }

        private void mskData_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void pcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOperacao_Click(object sender, EventArgs e)
        {
            if (opt.Add(new Models.Clientes { nome=txtNome.Text, sexo=this.sexo, email=txtEmail.Text, contacto= txtContacto.Text, dataN= DateTime.Parse(mskData.Text), NIF=txtNif.Text }) != opt.vetor[1])
            {
                csDrag.PrintMessenge(opt.vetor[0], false);
                return;
            }
            // SUCESSO
            csDrag.PrintMessenge(opt.vetor[0]);
        }

        private void frmAddClientes_Load(object sender, EventArgs e)
        {

        }

        private void rbMasculino_Click(object sender, EventArgs e)
        {
            sexo = rbMasculino.Text;
        }

        private void rbFeminino_Click(object sender, EventArgs e)
        {
            sexo = rbFeminino.Text;
        }
    }
}
