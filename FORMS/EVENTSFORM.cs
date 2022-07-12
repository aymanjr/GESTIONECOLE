using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace GESTIONECOLE.FORMS
{
    public partial class EVENTSFORM : Form
    {
        RESOURCES.SQLRESOURCES r = new RESOURCES.SQLRESOURCES();

        public EVENTSFORM()
        {
            InitializeComponent();
        }

        private void EVENTSFORM_Load(object sender, EventArgs e)
        {
             

            anneshow();
            eventsshow();
            recentevent();
            prochaineevent();
        }

        public void anneshow()
        {

            for (int i = 2018; i < DateTime.Today.Year + 1; i++)
            {
                combo_year.AddItem(i.ToString());
            }

        }

        int count = 0;
        public void eventsshow()
        {


            if (count == 0)
            {
                r.connecter();
                r.adapter = new SqlDataAdapter("select * from EVENTES order by EV_DATE desc  ", r.connection);

                r.adapter.Fill(r.ds, "events");
                dataGridView1.DataSource = r.ds.Tables["events"];
                r.deconnecter();
                count++;
            }
            else
            {
                if (r.ds.Tables["events"].Rows.Count > 0)
                {
                    r.ds.Tables["events"].Clear();
                    r.connecter();
                    r.adapter = new SqlDataAdapter("select * from EVENTES order by EV_DATE desc  ", r.connection);

                    r.adapter.Fill(r.ds, "events");
                    dataGridView1.DataSource = r.ds.Tables["events"];
                    r.deconnecter();
                }
            }




        }

        private void ajouterBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnom.Text) || string.IsNullOrWhiteSpace(txtdescrip.Text))
            {

                MessageBox.Show("Remplir tous les champes ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {

                r.connecter();
                r.command = new SqlCommand("insert into EVENTES values('" + txtnom.Text + "','" + txtdescrip.Text + "','" + datetimepicker1.Value.ToShortDateString().ToString() + "' ) ", r.connection);

                r.command.ExecuteNonQuery();
                if (MessageBox.Show("L'événement a été crée", "terminer", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    txtnom.Text = "Nom";
                    txtdescrip.Text = "";
                    datetimepicker1.Value = DateTime.Today.Date;
                    eventsshow();

                }

                r.deconnecter();

            }


        }

        private void rechercherBTN_Click(object sender, EventArgs e)
        {


            r.ds.Tables["events"].Clear();

            r.connecter();
            r.adapter = new SqlDataAdapter("select * from EVENTES where year(EV_DATE) = '" + combo_year.selectedValue.ToString() + "' order by EV_DATE desc  ", r.connection);

            r.adapter.Fill(r.ds, "events");
            dataGridView1.DataSource = r.ds.Tables["events"];
            r.deconnecter();


        }

        int eventid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            eventid = int.Parse(row.Cells["EV_ID"].Value.ToString());



        }

        private void SupprimerBTN_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Sélectionner une ligne dans la liste ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }
            else
            {
                r.connecter();
                r.command = new SqlCommand(" delete EVENTES where EV_ID  = '" + eventid.ToString() + "'", r.connection);
                r.command.ExecuteNonQuery();
                r.deconnecter();
                if (MessageBox.Show("L'événement a été Supprimer ", "Terminer ", MessageBoxButtons.OK, MessageBoxIcon.Hand) == DialogResult.OK)
                {
                    eventsshow();
                }


            }


        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            eventsshow();
        }

        private void modifierBTN_Click(object sender, EventArgs e)
        {
            r.cmdb = new SqlCommandBuilder(r.adapter);
            r.adapter.Update(r.ds, "events");
            if (MessageBox.Show("L'événement a été modifer ", "Terminer", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                eventsshow();

            }

        }

        public void recentevent()
        {
            r.connecter();
            r.command = new SqlCommand("select top 1  *  from EVENTES where EV_DATE < GETDATE()  order by EV_DATE desc  ", r.connection);
            r.reader = r.command.ExecuteReader();
            r.dt.Load(r.reader);
            nomlabelRecent.Text = r.dt.Rows[0]["EV_nom"].ToString();
            richTextBoxRecent.Text = r.dt.Rows[0]["EV_DESCR"].ToString();

            if (r.dt.Rows[0]["EV_DATE"].ToString().Length == 20)
            {
                datelabelRecent.Text = r.dt.Rows[0]["EV_DATE"].ToString().Substring(0, 9);

            }
            else if (r.dt.Rows[0]["EV_DATE"].ToString().Length == 21)
            {
                datelabelRecent.Text = r.dt.Rows[0]["EV_DATE"].ToString().Substring(0, 10);

            }
            else
            {
                datelabelRecent.Text = r.dt.Rows[0]["EV_DATE"].ToString().Substring(0, 11);
            }




            r.deconnecter();
        }

        public void prochaineevent()
        {


            r.connecter();
            r.command = new SqlCommand("select  top 1 *  from EVENTES where EV_DATE > GETDATE()  order by EV_DATE asc   ", r.connection);
            r.reader = r.command.ExecuteReader();
            r.dt1.Load(r.reader);
               if (r.dt1.Rows.Count == 0 )
            {
                nomlabelProchaine.Text = "Auncun Prochain événement ";
                richTextBoxProchaine.Text = "Auncun Prochain événement";
                datelabelProchaine.Text= "Auncun Prochain événement";
            }
            else
            {

            
            nomlabelProchaine.Text = r.dt1.Rows[0]["EV_nom"].ToString();
            richTextBoxProchaine.Text = r.dt1.Rows[0]["EV_DESCR"].ToString();

            if (r.dt1.Rows[0]["EV_DATE"].ToString().Length == 20)
            {

                datelabelProchaine.Text = r.dt1.Rows[0]["EV_DATE"].ToString().Substring(0, 9);

            }
            else if (r.dt1.Rows[0]["EV_DATE"].ToString().Length == 21)
            {

                datelabelProchaine.Text = r.dt1.Rows[0]["EV_DATE"].ToString().Substring(0, 10);

            }
            else
            {

                datelabelProchaine.Text = r.dt1.Rows[0]["EV_DATE"].ToString().Substring(0, 11);

            }
              }

            r.deconnecter();
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
               THEMAINFORM ee = new THEMAINFORM();

             this.Hide();

              //ee.Closed += (s, args) => this.Close(); 
              // ee.Show();

            // ETUDIANT_FORM ee = new ETUDIANT_FORM();

           // this.Hide();
              ee.ShowDialog();
               this.Close();
        }

        private void txtnom_Enter(object sender, EventArgs e)
        {
            if (txtnom.Text.Trim() != "" || txtnom.Text != null)
            {
                txtnom.Text = "";
            }
        }
    }
}
