using System.Windows.Forms;

namespace ServicesCars
{
    public static class csDrag
    {
        public static frmMenuPrincipal formMenu;
        //public static frmWait FrmWait = new frmWait(); 
        //public static FrmOpacity FrmOpacity = new FrmOpacity();
        public static string NomeForm = ""; 

        public static void PrintMessenge(string msg, bool x=true)
        {
            if (x)
                MessageBox.Show(msg, csDrag.NomeForm, MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(msg, csDrag.NomeForm, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
