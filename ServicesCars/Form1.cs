using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace ServicesCars
{
    public partial class Form1 : Form
    {
        string caminhoA, caminhoB, logoName, valor;
        public Form1()
        {
            InitializeComponent();
            logoName = @"\logotipo.png";
            caminhoB = Environment.CurrentDirectory + @"\Logotipo";

            valor = "The query specifies what information to retrieve from the data source or sources.";
        }

        private void Button2_Click(object sender, System.EventArgs e)
        {
            try
            {
                caminhoA = dsConfigure.csFoto.TakeFoto(pcLogotipo);

                if (!Directory.Exists(caminhoB))
                    Directory.CreateDirectory(caminhoB);
                
                File.Copy(caminhoA, caminhoB+logoName,true);
            }
            catch (Exception ms)
            {
                csDrag.PrintMessenge(ms.Message, false);
            }
        }

        int largura, altura, y, num_frases;
        Font font;
        Brush brush ;
        Size size;

        private void pvDialog_Load(object sender, EventArgs e)
        {

        }

        Image img;
        private void button1_Click(object sender, EventArgs e)
        {
            pvDialog.Document = pvDocument;

            y = 230;
            num_frases = 1;
            largura = pvDocument.DefaultPageSettings.Bounds.Width;
            altura = pvDocument.DefaultPageSettings.Bounds.Height;

            listBox1.Items.Add("Largura: {largura}");
            listBox1.Items.Add("Altura: {altura}");

            font = new Font("Times New Roman", 14, FontStyle.Regular);
            brush = new SolidBrush(Color.Black);
            size = new Size(largura, altura - font.Height + 1);

            //Rectangle rect = new Rectangle(0, 100, largura, 30);

            Bitmap btm = new Bitmap(caminhoB + logoName);
            img = btm;


            pvDialog.ShowDialog();
        }


        //int alturaRestante = 0;
        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            if (num_frases<=1)
            {
                e.Graphics.DrawImage(img, 15, 25, 232, 181);
            }

            while (num_frases<=100)
            {
                e.Graphics.DrawString("{valor} : {num_frases}", new Font("Arial", 14, FontStyle.Regular),
               Brushes.Black, new Point(50,y));
                y += 30;
                num_frases++;

                if (y>=altura-50)
                {
                    y = 50;
                    e.HasMorePages = true;
                    break;
                }
            }

            if (!e.HasMorePages)
            {
                e.Graphics.DrawString("CLEIFATIMA PESCAS, LDA",
new Font("Times New Roman", 20, FontStyle.Bold),
brush, new Point(img.Width + 50, y + 20));
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            pvDocument.Print();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //printDialog1.ShowDialog();
      

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //pvDialog.Document = pvDocument;
            ////pvDialog.Width = Screen.PrimaryScreen.Bounds.Width;
            ////pvDialog.Height = Screen.PrimaryScreen.Bounds.Height;
            //pvDialog.ShowDialog();
            //this.Close();
        }

      }
}
