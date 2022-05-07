using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTIONECOLE.FORMS
{
    public partial class Print_FraisForm : Form
    {
        public  string Date,type,description,cost,datefrais;
        public Print_FraisForm()
        {
            InitializeComponent();
            Date = DateTime.Now.ToString("M/d/yyyy");
        }

        private void Printbutton_MouseHover(object sender, EventArgs e)
        {
            ToolTip a = new ToolTip();
            a.SetToolTip(Printbutton, "Print");
        }

        private void print(Panel p1)
        {

        }

        private void Print_FraisForm_Load(object sender, EventArgs e)
        {
            datetimelabel.Text = Date;
            typelabel.Text = type;
            descriptionlabel.Text = description;
            costlabel.Text = cost;
            datefraislabel.Text = datefrais;
        }
    }
}
