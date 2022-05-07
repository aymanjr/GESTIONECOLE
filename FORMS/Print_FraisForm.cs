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
        public Print_FraisForm()
        {
            InitializeComponent();
        }

        private void Printbutton_MouseHover(object sender, EventArgs e)
        {
            ToolTip a = new ToolTip();
            a.SetToolTip(Printbutton, "Print");
        }
    }
}
