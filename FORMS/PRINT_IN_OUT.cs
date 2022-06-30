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
    public partial class PRINT_IN_OUT : Form
    {
        public string type, count, date, description, annesclr;
        private Bitmap memorying;


        public PRINT_IN_OUT()
        {
            InitializeComponent();
            date = DateTime.Now.ToString("M/d/yyyy");
        }

        
        
        
        private void Printbutton_MouseHover(object sender, EventArgs e)
        {
            ToolTip a = new ToolTip();
            a.SetToolTip(Printbutton, "Print");
        }



        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memorying, (pagearea.Height / 2) - (this.panelprint.Width / 2), this.panelprint.Location.Y);
        }

        private void getprintarea(Panel p1)
        {
            memorying = new Bitmap(p1.Width, p1.Height);
            p1.DrawToBitmap(memorying, new Rectangle(0, 0, p1.Width, p1.Height));

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



        private void Printbutton_Click(object sender, EventArgs e)
        {
            print(this.panelprint);
        }

        private void PRINT_IN_OUT_Load(object sender, EventArgs e)
        {

            datetimelabel.Text = date;



            typelabel.Text = "";
            anneescolaire.Text = "";
            datefraislabel.Text = "";
            costlabel.Text = "";
            descriptionlabel.Text = "";
        }
    }
}
