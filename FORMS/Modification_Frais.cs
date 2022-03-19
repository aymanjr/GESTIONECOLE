using System;
using System.Windows.Forms;

namespace GESTIONECOLE.FORMS
{
    public partial class Modification_Frais : Form
    {
        public Modification_Frais()
        {
            InitializeComponent();
        }

        private void Modification_Frais_Load(object sender, EventArgs e)
        {
             THEMAINFORM t  = new THEMAINFORM();
            t.Close();


        }

        bool trspshowen = false;
        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
              if (trspshowen == false)
            {
                panel_salaire.Visible = false;
                panel_trsp.Visible = true;
                panel_class.Visible = false;
                trspshowen = true;
                salairehowen = false;
                classhowen = false;
            }
            else if(trspshowen == true)
            {
                 panel_trsp.Visible = false;
                panel_salaire.Visible = false;
                panel_class.Visible = false;
                trspshowen = false;
                classhowen = false;
                salairehowen = false;
            }
             
        }

        bool classhowen = false;
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (classhowen == false)
            {

                panel_trsp.Visible = false;
                panel_salaire.Visible = false;

                panel_class.Visible = true;
                classhowen = true;
                 trspshowen = false;
                salairehowen = false;
            }
            else if(classhowen == true)
            {
              panel_salaire.Visible = false;

                 panel_trsp.Visible = false;
                panel_class.Visible = false;
                classhowen = false;
                 trspshowen = false;
                salairehowen = false;
            }
             
             
        }
         bool salairehowen = false;

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

             if (salairehowen == false)
            {

                panel_trsp.Visible = false;
                panel_class.Visible = false;
                panel_salaire.Visible = true;
                classhowen = false;
                 trspshowen = false;
                salairehowen = true;

            }
            else if(salairehowen == true)
            {

                 panel_trsp.Visible = false;
                panel_class.Visible = false;
                 panel_salaire.Visible = false;

                classhowen = false;
                 trspshowen = false;
                salairehowen = false;
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
          THEMAINFORM ee = new THEMAINFORM();
            this.Hide();
        ee.ShowDialog();
        this.Close();  
        }
    }
}
