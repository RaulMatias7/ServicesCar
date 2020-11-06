using System;
using System.Windows.Forms;

namespace ServicesCars
{
    public partial class frmContinuar : Form
    {
        public static bool x;
        public frmContinuar()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            x = true;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = false;
            this.Close();
        }

        private void frmContinuar_Load(object sender, EventArgs e)
        {
        }
    }
}
