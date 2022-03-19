using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace GESTIONECOLE.FORMS
{
    public partial class THEMAINFORM : Form
    {
        RESOURCES.SQLRESOURCES r = new RESOURCES.SQLRESOURCES();

        public THEMAINFORM()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
           
        }

        private void THEMAINFORM_Load(object sender, EventArgs e)
        {
            recent_activ();
            recent_event();
        }

        public void recent_activ()
        {
            r.connecter();
            r.adapter = new SqlDataAdapter("select f.ft_type as Type,f.ft_cout as Cout,f.ft_date as Date,f.ft_description as Description from frais_total f order by f.ft_date desc",r.connection);
            r.adapter.Fill(r.ds,"frais");
            recent_frais_datagrid.DataSource = r.ds.Tables["frais"];

            r.deconnecter();
        }

        public void recent_event()
        {
             r.connecter();
            r.command = new SqlCommand("select  top 1 *  from EVENTES where EV_DATE > GETDATE()  order by EV_DATE asc   ", r.connection);
            r.reader = r.command.ExecuteReader();
            r.dt1.Load(r.reader);
            if (r.dt1.Rows.Count == 0 )
            {
                nomlabelRecent.Text = "Auncun Prochain Events";
                descr_recent_event.Text="Auncun Prochain Events";
                datelabelRecent.Text="Auncun Prochain Events";
            }
            else
            {

            
            nomlabelRecent.Text = r.dt1.Rows[0]["EV_nom"].ToString();
            descr_recent_event.Text = r.dt1.Rows[0]["EV_DESCR"].ToString();

            if (r.dt1.Rows[0]["EV_DATE"].ToString().Length == 20)
            {

                datelabelRecent.Text = r.dt1.Rows[0]["EV_DATE"].ToString().Substring(0, 9);

            }
            else if (r.dt1.Rows[0]["EV_DATE"].ToString().Length == 21)
            {

                datelabelRecent.Text = r.dt1.Rows[0]["EV_DATE"].ToString().Substring(0, 10);

            }
            else
            {

                datelabelRecent.Text = r.dt1.Rows[0]["EV_DATE"].ToString().Substring(0, 11);

            }


            r.deconnecter();
             }
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            
         if (MessageBox.Show("Exit or no?",
                           "GESTION ECOLE",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information) == DialogResult.Yes)
        {
            this.Close();
            Environment.Exit(1);
        }

        }

        private void eleves_btn_Click(object sender, EventArgs e)
        {
              ETUDIANT_FORM ee = new ETUDIANT_FORM();

           
                this.Hide();
                ee.ShowDialog();
                this.Close();
           
           
        }

        private void events_btn_Click(object sender, EventArgs e)
        {
            EVENTSFORM ee = new EVENTSFORM();

            this.Hide();
        ee.ShowDialog();
        this.Close();
             //this.Hide();

             // ee.Closed += (s, args) => this.Close(); 
             //  ee.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
             EMPLOYEEFORM ee = new EMPLOYEEFORM();

            this.Hide();
        ee.ShowDialog();
        this.Close();


        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            TRANSPORTFORM ee = new TRANSPORTFORM();
            this.Hide();
        ee.ShowDialog();
        this.Close();
        }

        private void bunifuFlatButton12_Click(object sender, EventArgs e)
        {
            Frais_Form ee = new Frais_Form();
            this.Hide();
        ee.ShowDialog();
        this.Close();
        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {
            PAYMENT_DE_MOIS_FORM ee = new PAYMENT_DE_MOIS_FORM();
            this.Hide();
        ee.ShowDialog();
        this.Close();
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            TheIn_out_Form ee = new TheIn_out_Form();
            this.Hide();
        ee.ShowDialog();
        this.Close();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Modification_Frais ee = new Modification_Frais();
            this.Hide();
        ee.ShowDialog();
        this.Close();
        }

        private void Inscription_btn_Click(object sender, EventArgs e)
        {
            CREATEINSCRIPTIONFORM ee = new CREATEINSCRIPTIONFORM();
            this.Hide();
        ee.ShowDialog();
        this.Close();
        }
    }
}
