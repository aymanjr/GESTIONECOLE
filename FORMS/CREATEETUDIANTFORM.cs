using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GESTIONECOLE.FORMS
{
    public partial class CREATEETUDIANTFORM : Form
    {

        RESOURCES.SQLRESOURCES r = new RESOURCES.SQLRESOURCES();


        string pere;
        string mere;
        string tuteur;
        int sport;


        public CREATEETUDIANTFORM()
        {
            InitializeComponent();
        }

        private void createbtn_Click(object sender, EventArgs e)
        {
        }



        private void CREATEETUDIANTFORM_Load(object sender, EventArgs e)
        {


        }



        private void CANCELBTN_Click(object sender, EventArgs e)
        {


        }

        private void NIVEAUcombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void createbtn_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtFirstname.Text) || string.IsNullOrEmpty(txtLastname.Text) || string.IsNullOrEmpty(txtadress.Text) || string.IsNullOrEmpty(txtnomcompletTUTEUR.Text) || string.IsNullOrEmpty(txttele.Text) || string.IsNullOrEmpty(txtemail.Text) ||
                (!checkBoxOUI.Checked && !checkBoxNON.Checked) || string.IsNullOrEmpty(txtnationaliter.Text) || sex.SelectedItem == null)
            {
                MessageBox.Show("Uue column est vide", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkBoxOUI.Checked)
                {
                    sport = 1;
                }
                else if (checkBoxNON.Checked)
                {
                    sport = 0;
                }


                if (string.IsNullOrEmpty(txtnomcompletPERE.Text) && string.IsNullOrEmpty(txtnomcompletMERE.Text))
                {
                    tuteur = txtnomcompletTUTEUR.Text;
                    mere = "NULL";
                    pere = "NULL";

                }
                else if (!string.IsNullOrEmpty(txtnomcompletPERE.Text) && !string.IsNullOrEmpty(txtnomcompletMERE.Text))
                {
                    tuteur = txtnomcompletTUTEUR.Text;
                    mere = txtnomcompletMERE.Text;
                    pere = txtnomcompletPERE.Text;
                }



                r.connecter();

                r.command = new SqlCommand("insert into eleve values('" + txtFirstname.Text + "','" + txtLastname.Text + "','" + datofbirth.Value.ToShortDateString() + "','" + pere + "','" + mere + "','" + tuteur + "','" + txttele.Text + "','" + txtadress.Text + "','" + sport + "','" + sex.SelectedItem.ToString() + "','" + txtnationaliter.Text + "')", r.connection);

                MessageBox.Show("l'éleve a été crée", "Information", MessageBoxButtons.OK , MessageBoxIcon.Information) ;


                r.command.ExecuteNonQuery();


                r.deconnecter();

                if (MessageBox.Show("Tu veux faire Une inscription de cette éleve", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CREATEINSCRIPTIONFORM ee = new CREATEINSCRIPTIONFORM();
                     this.Hide();
                       ee.ShowDialog();
                    this.Close();
                }
                else
                {
                    ETUDIANT_FORM ee = new ETUDIANT_FORM();
                     this.Hide();
                       ee.ShowDialog();
                    this.Close();
                }
            }
        }

        private void CANCELBTN_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("est ce que tu veux sortir ? ", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                    ETUDIANT_FORM ee = new ETUDIANT_FORM();
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
