using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GESTIONECOLE.FORMS
{
    public partial class CREATETRANSPORTFORM : Form
    {
        RESOURCES.SQLRESOURCES r = new RESOURCES.SQLRESOURCES();
        public CREATETRANSPORTFORM()
        {
            InitializeComponent();
        }

        private void CREATETRANSPORTFORM_Load(object sender, EventArgs e)
        {
            chauffeurshow();
            accompshow();
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
        }

        private void chauffeurshow()
        {
            r.connecter();
            r.command = new SqlCommand("select (Emp_nom + SPACE(3) + Emp_prenom) as emp_namecomplet,Emp_id from EMPLOYEE where Emp_post = 'chauffeur' ", r.connection);
            r.reader = r.command.ExecuteReader();
            r.dt.Load(r.reader);
            chauffeurcombo.DataSource = r.dt;
            chauffeurcombo.DisplayMember = "emp_namecomplet";
            chauffeurcombo.ValueMember = "Emp_id";

            r.deconnecter();
        }

        private void accompshow()
        {
            r.connecter();
            r.command = new SqlCommand("select (Emp_nom + SPACE(3) + Emp_prenom) as emp_namecomplet,Emp_id from EMPLOYEE where Emp_post = 'ACCOMPAGNEMENT'", r.connection);
            r.reader = r.command.ExecuteReader();
            DataTable dt1 = new DataTable();
            dt1.Load(r.reader);
            accompcombo.DataSource = dt1;
            accompcombo.DisplayMember = "emp_namecomplet";
            accompcombo.ValueMember = "Emp_id";

            r.deconnecter();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("TU VEUX EXIT ? ", "ALERT", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                TRANSPORTFORM ee = new TRANSPORTFORM();
                this.Hide();
                 ee.ShowDialog();
                  this.Close();
            }
            else
            {

            }
        }

        private void AjouterBtn_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtmatricule.Text) || string.IsNullOrEmpty(txtcapaciter.Text) || string.IsNullOrEmpty(txtmodule.Text) || string.IsNullOrEmpty(txtstaut.Text) || chauffeurcombo.SelectedItem == null || accompcombo.SelectedItem == null)
            {
                MessageBox.Show("");
            }
            else
            {
                r.connecter();
                r.command = new SqlCommand(" INSERT INTO TRANSPORT VALUES('" + txtmatricule.Text + "','" + txtmodule.Text + "','" + txtcapaciter.Text + "','" + chauffeurcombo.SelectedValue.ToString() + "','" + accompcombo.SelectedValue.ToString() + "','" + txtstaut.Text + "')", r.connection);

                MessageBox.Show("TRANSPORT A ETE CRIER");
                r.command.ExecuteNonQuery();
                r.deconnecter();

                      TRANSPORTFORM ee = new TRANSPORTFORM();
                    this.Hide();
                   ee.ShowDialog();
                  this.Close();
             }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
              TRANSPORTFORM ee = new TRANSPORTFORM();

           
                this.Hide();
                ee.ShowDialog();
                this.Close();
        }
    }
}
