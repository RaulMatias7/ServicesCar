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
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            xuiCircleProgressBar1.Percentage++;
            xuiCircleProgressBar1.AnimationSpeed++;
            if (xuiCircleProgressBar1.percentage >= 100)
            {
                timer1.Stop();
                dsConfigure.csForms.CallForm(this, new FrmLogin());
                this.Hide();
            }
        }
    }
}
