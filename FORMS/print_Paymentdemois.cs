using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTIONECOLE.FORMS
{
    public partial class print_Paymentdemois : Form
    {


        private void print_Paymentdemois_Load(object sender, EventArgs e)
        {



        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memorying, (pagearea.Height / 2) - (this.panelprint.Width / 2), this.panelprint.Location.Y);
        }
        private void print(Panel p1)
        {
            PrinterSettings printer = new PrinterSettings();
            panelprint = p1;
            getprintarea(p1);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();

        }
        private Bitmap memorying;

        private void getprintarea(Panel p1)
        {
            memorying = new Bitmap(p1.Width, p1.Height);
            p1.DrawToBitmap(memorying, new Rectangle(0, 0, p1.Width, p1.Height));

        }

        public print_Paymentdemois(string nomcomplet, string montant, string classl,string mois,string trsp,string annee,string datepayment)
        {
            InitializeComponent();
            string Date = DateTime.Now.ToString("M/d/yyyy");
            nomcompletlabel.Text = nomcomplet;
            costlabel.Text = montant;
            classlabel.Text = classl;
            moislabel.Text = mois;
            transporttypelabel.Text = trsp;
            anneescolairelabel.Text = annee;
            datepaymentlabel.Text = datepayment;
            datetimelabel.Text = Date;

        }

        private void Printbutton_Click(object sender, EventArgs e)
        {
            print(this.panelprint);

        }


    }
}
