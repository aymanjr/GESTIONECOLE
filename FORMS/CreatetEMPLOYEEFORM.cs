using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GESTIONECOLE.FORMS
{
    public partial class CreateEmployeeFORM : Form
    {
        RESOURCES.SQLRESOURCES r = new RESOURCES.SQLRESOURCES();
        public CreateEmployeeFORM()
        {
            InitializeComponent();
        }

        string a;
        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void CANCELBTN_Click(object sender, EventArgs e)
        {

        }

        private void createbtn_Click(object sender, EventArgs e)
        {
            if (checkBoxCNSS_OUI.Checked)
            {
                a = "TRUE";
            }
            else if (checkBoxCNSS_NON.Checked)
            {
                a = "FALSE";
            }
            if (string.IsNullOrEmpty(txtFirstname.Text) || string.IsNullOrEmpty(txtLastname.Text) || string.IsNullOrEmpty(TXTCIN.Text) ||
                POSTcombo.SelectedItem == null ||
                string.IsNullOrEmpty(txtadress.Text) ||
                string.IsNullOrEmpty(textVille.Text) ||
                string.IsNullOrEmpty(txtemail.Text) ||
                string.IsNullOrEmpty(txttele.Text) ||
                string.IsNullOrEmpty(textEducation.Text) ||
                SEXcombo.SelectedItem == null ||
                (!checkBoxCNSS_OUI.Checked && !checkBoxCNSS_NON.Checked))
            {
                MessageBox.Show("DES COLUMNS EST VIDE");
            }
            else
            {


                r.connecter();
                r.command = new SqlCommand("insert into EMPLOYEE values( '" + txtFirstname.Text + "','" + txtLastname.Text + "','" + datofbirth.Value.ToShortDateString() + "','" + TXTCIN.Text + "','" + a + "','" + POSTcombo.SelectedItem.ToString() + "','" + txtadress.Text + "','" + txttele.Text + "','" + textVille.Text + "', '" + txtemail.Text + "','" + SEXcombo.SelectedItem.ToString() + "', '" + textEducation.Text + "') ", r.connection);

                r.command.ExecuteNonQuery();
                r.deconnecter();

                MessageBox.Show("EMPLOYEE A ETE CREE ");

                EMPLOYEEFORM ee = new EMPLOYEEFORM();
               this.Hide();
               ee.ShowDialog();
                 this.Close();


            }
        }

        private void CANCELBTN_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("TU VEUX EXIT ? ", "ALERT", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                 EMPLOYEEFORM ee = new EMPLOYEEFORM();

           
                this.Hide();
                ee.ShowDialog();
                this.Close();
            }
            else
            {

            }
        }
    }
}
