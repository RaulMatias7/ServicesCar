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
    public partial class FrmFacturas : Form
    {
        int largura,altura,alturaLess, y, num_pages;
        readonly string caminhoA, caminhoB, logoName;
        Font font;
        Brush brush;
        Size size;

        private void FrmFacturas_Load(object sender, EventArgs e)
        {
           // reportViewer1.Dock = DockStyle.Fill;
        }

        Image img;
        Color cor;
        readonly Dictionary<string, Rectangle> listRectangles;
        public FrmFacturas()
        {
            InitializeComponent();
            logoName = @"\logotipo.png";
            caminhoB = Environment.CurrentDirectory + @"\Logotipo";
            listRectangles = new Dictionary<string, Rectangle>
            {
                { "código", new Rectangle(12, 375, 100, 30) },
                { "descrição", new Rectangle(112, 375, 200, 30) },
                { "Qt.", new Rectangle(312, 375, 100, 30) },
                { "preço", new Rectangle(412, 375, 130, 30) },
                { "IVA", new Rectangle(542, 375, 80, 30) },
                { "desc", new Rectangle(622, 375, 80, 30) },
                { "total", new Rectangle(702, 375, 115, 30) }
            };
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            PrintPreviewDialog printDialog = new PrintPreviewDialog
            {
                Document = pvDocument,
            };

            y = 230;
            num_pages = 1;
            largura = pvDocument.DefaultPageSettings.Bounds.Width;
            altura = pvDocument.DefaultPageSettings.Bounds.Height;
            alturaLess = altura;

            listBox1.Items.Add("Largura: {largura}");
            listBox1.Items.Add("Altura: {altura}");

            font = new Font("Arial", 13, FontStyle.Regular);
            brush = new SolidBrush(Color.Black);
            size = new Size(largura, altura - font.Height + 1);
            cor = Color.FromArgb(227, 227, 227);
            //Rectangle rect = new Rectangle(0, 100, largura, 30);

            Bitmap btm = new Bitmap(caminhoB + logoName);
            img = btm;

            printDialog.ShowDialog();
        }

        private void PvDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int yA = 40;
            int xL = 160;
            string localizacao = "Centralidade do Kilamba Ed. C22 Aptº 23";
            Rectangle rectHead = new Rectangle(10, 0, largura-20, 200);
            alturaLess -= 200;

            StringFormat formato = new StringFormat { Alignment = StringAlignment.Far, LineAlignment = StringAlignment.Far };

            //e.Graphics.DrawRectangle(new Pen(Color.Red,2), rectHead);

            e.Graphics.DrawImage(img, 15, 25, 160, 150);


            #region (HEADER INFORMATION)
            //// nome da empresa
            e.Graphics.DrawString("CLEIFATIMA PESCAS, LDA",
                new Font("Times New Roman", 13, FontStyle.Bold),
                brush, new Point(xL + 30, yA));
            //// Localização
            List<string> newLocalizacao = new List<string>();
            if (localizacao.Length > 40)
            {
                newLocalizacao.Add(localizacao.Substring(0, 40));

                if (localizacao.Substring(40).Length < 7)
                    newLocalizacao[0] += " " + localizacao.Substring(40);

                if (localizacao.Substring(40).Length >= 7)
                {
                    newLocalizacao.Add(localizacao.Substring(40));
                }

                for (int i = 0; i < newLocalizacao.Count; i++)
                {
                    e.Graphics.DrawString(newLocalizacao[i], font, brush, new Point(xL + 30, yA += 20));
                }
            }
            else
            {
                e.Graphics.DrawString(localizacao, font, brush, new Point(xL + 30, yA += 20));
            }
            //// NIF
            e.Graphics.DrawString("NIF: 003242324293",
               font, brush, new Point(xL + 30, yA += 20));
            ////// Contactos
            e.Graphics.DrawString("Tlf: +244 948 092 980 / +244 990 092 980",
               font, brush, new Point(xL + 30, yA += 20));
            //// Email
            e.Graphics.DrawString("Email: derciosinione@gmail.com",
               font, brush, new Point(xL + 30, yA += 20));
            #endregion (HEADER END)

            yA = 40;
            //// Informacoes da factura
            e.Graphics.DrawString("FACTURA",new Font("Times New Roman", 13,FontStyle.Bold), brush, new Rectangle(460, yA, 350, 30), formato);
            e.Graphics.DrawString("FT V2020/58", new Font("Times New Roman", 13, FontStyle.Bold), brush, new Rectangle(460, yA+=20, 350, 30), formato);

            e.Graphics.DrawString("ORGINAL",font, brush, new Rectangle(460, yA += 50, 350, 30), formato);
            e.Graphics.DrawString("Página 1 de 1", font, brush, new Rectangle(460, yA += 20, 350, 30), formato);
            e.Graphics.DrawString("DATA: {DateTime.Now}", font, brush, new Rectangle(460, yA += 20, 350, 30), formato);
            e.Graphics.DrawString("DATA VENCIMENTO: {DateTime.Now.ToShortDateString()}", font, brush, new Rectangle(460, yA += 20, 350, 30), formato);

            //// Dezenhar uma linha
            e.Graphics.DrawLine(new Pen(cor), 12, yA + 35, largura - 22, yA + 35);

            Rectangle rectCliente = new Rectangle(455, 220, 350, 100);
            e.Graphics.DrawRectangle(new Pen(cor, 1), rectCliente);

            formato.LineAlignment = StringAlignment.Near;
            formato.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("Cliente:", font, brush, new Rectangle(460, 230, 350, 30), formato);
            e.Graphics.DrawString("Dercio Sinione Derone",new Font("Arial", 13, FontStyle.Bold), brush, new Rectangle(460, 250, 355, 30), formato);

            e.Graphics.DrawString("NIF: CONSUMIDOR FINAL", font, brush, new Rectangle(460, 290, 350, 30), formato);

            //// OPERADOR
            formato.Alignment = StringAlignment.Far;
            formato.LineAlignment = StringAlignment.Far;
            e.Graphics.DrawString("Utilizador: Raul Matias Mambu", font, brush, new Rectangle(440, 340, 360, 30), formato);

            //// Dezenhar uma linha
            //e.Graphics.DrawLine(new Pen(cor), 12, 410, largura - 22, 410);


            //// CRIAR A TABELA
            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;
            
            foreach (var item in listRectangles)
            {
                e.Graphics.DrawRectangle(new Pen(cor), item.Value);
                e.Graphics.DrawString(item.Key.ToUpper(),new Font("Arial",13,FontStyle.Bold), brush, item.Value, formato);
            }
            //// Dezenhar uma linha
            e.Graphics.DrawLine(new Pen(Color.Black), 12, 375, largura-10, 375);

            xL = 0;
            yA = 400;
            formato.Alignment = StringAlignment.Near;
            formato.LineAlignment = StringAlignment.Near;

            int c = 0;

            while (c<=4)
            {
                yA += 30;

                e.Graphics.DrawString("12324",font ,brush, new Rectangle(listRectangles["código"].X, yA-10, 115, 30), formato);
                e.Graphics.DrawString("Computador", font, brush, new Rectangle(listRectangles["descrição"].X, yA - 10, 115, 30), formato);
                e.Graphics.DrawString("2", font, brush, new Rectangle(listRectangles["Qt."].X, yA - 10, 115, 30), formato);
                e.Graphics.DrawString("274.000,00", font, brush, new Rectangle(listRectangles["preço"].X, yA - 10, 115, 30), formato);
                e.Graphics.DrawString("14%", font, brush, new Rectangle(listRectangles["IVA"].X, yA - 10, 115, 30), formato);
                e.Graphics.DrawString("0%", font, brush, new Rectangle(listRectangles["desc"].X, yA - 10, 115, 30), formato);
                e.Graphics.DrawString("548.000,00", font, brush, new Rectangle(listRectangles["total"].X, yA - 10, 115, 30), formato);

                c++;
            }

        }
    }
}
