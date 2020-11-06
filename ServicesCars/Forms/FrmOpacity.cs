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
    public partial class FrmOpacity : Form
    {
        public FrmOpacity()
        {
            InitializeComponent();
        }

        private void FrmOpacity_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmOpacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Hide();
        }
    }
}
