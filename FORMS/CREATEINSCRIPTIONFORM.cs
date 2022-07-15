using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GESTIONECOLE.FORMS
{
    public partial class CREATEINSCRIPTIONFORM : Form
    {

        GESTIONECOLE.RESOURCES.SQLRESOURCES r = new GESTIONECOLE.RESOURCES.SQLRESOURCES();

        public int compt = 0;
        public CREATEINSCRIPTIONFORM()
        {
            InitializeComponent();
        }

        private void CREATEINSCRIPTIONFORM_Load(object sender, EventArgs e)
        {
            gridfill();
            niveaushow();
            combo_annescolaire_fill();
            eleveshow();
            showrecents();

        }
        public void combo_annescolaire_fill()
        {

            r.connecter();
            r.command = new SqlCommand(" select distinct CL_annee_scolaire from CLASS ", r.connection);
            r.reader = r.command.ExecuteReader();

            while (r.reader.Read())
            {
                combo_annescolaire.Items.Add(r.reader.GetValue(0).ToString());
            }

            r.deconnecter();

        }

        public void gridfill()
        {
            r.ds.Clear();
            r.connecter();
            r.adapter = new SqlDataAdapter(" select [INS_id] as 'Numero Inscription', (EL_NOM +SPACE(2)+ EL_PRENOM) as Nom_Complet,e.EL_TELETUTEUR as tele,SUBSTRING (c.CL_nom,7,20) as Class,c.CL_annee_scolaire as   Anne_scolaire,i.INS_cout as cout,i.INS_date  as date_Inscription from eleve E , INSCRIPTION I, CLASS c where e.EL_ID = i.INS_eleveID# and c.CL_id=i.INS_classID# order by i.INS_date desc ", r.connection);
            r.adapter.Fill(r.ds, "inscr");
            dataGridView1.DataSource = r.ds.Tables["inscr"];


            r.deconnecter();
        }
        public void niveaushow()
        {
            
            r.connecter();
            r.command = new SqlCommand("select niv_nom from niveau", r.connection);
            r.reader = r.command.ExecuteReader();
            while (r.reader.Read())
            {
                NIVEAUCOMBO.Items.Add(r.reader.GetValue(0).ToString());
            }

            r.deconnecter();

        }
        string id_niveau;
        public void niveauid()
        {
            if (NIVEAUCOMBO.Text == "")
            {
                MessageBox.Show("Veuillez vous selectioner niveau","Information", MessageBoxButtons.OK , MessageBoxIcon.Hand);
                return;
            }
            r.connecter();
            r.command = new SqlCommand("select niv_id from niveau where niv_nom = '" + NIVEAUCOMBO.SelectedItem.ToString() + "'", r.connection);
            r.reader = r.command.ExecuteReader();
            while (r.reader.Read())
            {
                id_niveau = r.reader.GetValue(0).ToString();
            }
            r.deconnecter();

        }

        private void NIVEAUCOMBO_SelectedIndexChanged(object sender, EventArgs e)
        {
            CLASSCOMBO.Items.Clear();
            niveauid();
            r.connecter();

            r.command = new SqlCommand("  exec showclass '" + id_niveau + "' ", r.connection);
            r.reader = r.command.ExecuteReader();
            while (r.reader.Read())
            {

                CLASSCOMBO.Items.Add(r.reader.GetValue(0).ToString());
            }
            r.deconnecter();


        }
        string idclass;
        public void classid()
        {

            if (CLASSCOMBO.Text == "" )
            {
                MessageBox.Show("Veuillez vous selectioner class", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            r.connecter();
            r.command = new SqlCommand("select cl_id from class where cl_nom = '" + CLASSCOMBO.SelectedItem.ToString() + "'", r.connection);
            r.reader = r.command.ExecuteReader();
            while (r.reader.Read())
            {
                idclass = r.reader.GetValue(0).ToString();
            }
            r.deconnecter();

        }

        private void CLASSCOMBO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void eleveshow()
        {
            r.connecter();
            r.command = new SqlCommand("select (EL_NOM+SPACE(4)+EL_PRENOM) from ELEVE e where e.EL_ID not in (select i.INS_eleveID# from INSCRIPTION i )  ", r.connection);

            r.reader = r.command.ExecuteReader();
            while (r.reader.Read())
            {
                elevecombo.Items.Add(r.reader.GetValue(0).ToString());
            }
            r.deconnecter();

        }
        string id_etd;
        public void etd_id()
        {
            if (elevecombo.Text == "")
            {
                MessageBox.Show("Veuillez vous selectioner eleve", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            r.connecter();
            r.command = new SqlCommand("select EL_ID from eleve where (EL_NOM+SPACE(4)+EL_PRENOM)  =  '" + elevecombo.SelectedItem.ToString() + "'", r.connection);
            r.reader = r.command.ExecuteReader();
            while (r.reader.Read())
            {
                id_etd = r.reader.GetValue(0).ToString();
            }
            r.deconnecter();

        }
        string count_etd;
        public void etd_recherche()
        {
            r.connecter();
            r.command = new SqlCommand("select count(*) from INSCRIPTION i   where i.INS_classID# = '" + idclass + "' and i.INS_eleveID# = '" + id_etd + "'  ", r.connection);
            r.reader = r.command.ExecuteReader();

            while (r.reader.Read())
            {
                count_etd = r.reader.GetValue(0).ToString();
            }
            r.deconnecter();

        }

        private void elevecombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AJOUTERBTN_Click(object sender, EventArgs e)
        {



        }

        public void printinscription()
        {
            Print_Inscription print_ = new Print_Inscription(nomcompletLABEL.Text, AnnescolaireLABEL.Text, classnomLABEL.Text,cout);
            print_.ShowDialog();
        }

        private void AJOUTERBTN_Click_1(object sender, EventArgs e)
        {
            classid();
            etd_id();
            etd_recherche();
            if (count_etd == "1")
            {
                    MessageBox.Show("Cette etudiant a ete deja inscrier ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            try
            {
                if (NIVEAUCOMBO.Text == "" && CLASSCOMBO.Text == "" && elevecombo.Text == "")
                            {
                                MessageBox.Show("Veuillez vous saisir", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            else
                            {
                                r.connecter();
                                r.command = new SqlCommand("insert into inscription values('" + idclass + "','" + id_etd + "','" + DateTime.Now.ToShortDateString().ToString() + "','" + TXTCOST.Text + "')", r.connection);
                                r.command.ExecuteNonQuery();


                                MessageBox.Show("Bien ajouter", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                r.deconnecter();
                                TXTCOST.Clear();

                                NIVEAUCOMBO.Text = "";
                                CLASSCOMBO.Text = "";
                                elevecombo.Text = "";

                                gridfill();
                                showrecents();
                            }
            }
            catch
            {
                MessageBox.Show("Veuillez vous saisir", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
        }

        private void print1_Click(object sender, EventArgs e)
        {

        }

        private void CANCELBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void rechercherBTN_Click(object sender, EventArgs e)
        {
            r.ds.Clear();
            r.connecter();

            r.adapter = new SqlDataAdapter(" select [INS_id] as 'Numero Inscription', (EL_NOM +SPACE(2)+ EL_PRENOM) as Nom_Complet,SUBSTRING (c.CL_nom,7,20) as Class,c.CL_annee_scolaire as   Anne_scolaire,i.INS_date  as date_Inscription from eleve E , INSCRIPTION I, CLASS c where e.EL_ID = i.INS_eleveID# and c.CL_id=i.INS_classID# and c.CL_annee_scolaire = '" + combo_annescolaire.selectedValue.ToString() + "' order by i.INS_date desc ", r.connection);
            r.adapter.Fill(r.ds, "inscr");
            dataGridView1.DataSource = r.ds.Tables["inscr"];


            r.deconnecter();

        }


        string cout="";
        public void showrecents()
        {
            r.connecter();
            r.command = new SqlCommand("select (EL_NOM +SPACE(2)+ EL_PRENOM) as Nom_Complet,SUBSTRING (c.CL_nom,7,20) as Class,c.CL_annee_scolaire as Anne_scolaire,i.INS_date  as date_Inscription,e.EL_NOMCOMPLETEPERE,e.EL_TELETUTEUR  ,i.INS_cout from eleve E , INSCRIPTION I, CLASS c where e.EL_ID = i.INS_eleveID# and c.CL_id=i.INS_classID# order by i.INS_date desc", r.connection);
            r.reader = r.command.ExecuteReader();
            r.dt.Load(r.reader);
            nomcompletLABEL.Text = r.dt.Rows[compt]["Nom_Complet"].ToString();
            telelabel.Text = r.dt.Rows[compt]["EL_TELETUTEUR"].ToString();
            classnomLABEL.Text = r.dt.Rows[compt]["Class"].ToString();
            AnnescolaireLABEL.Text = r.dt.Rows[compt]["Anne_scolaire"].ToString();
            dateinscLABEL.Text = r.dt.Rows[compt]["date_Inscription"].ToString();
            cout = r.dt.Rows[compt]["INS_cout"].ToString();

            r.deconnecter();

        }

        private void refreshBTN_Click(object sender, EventArgs e)
        {
            gridfill();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

            if (compt == r.dt.Rows.Count - 1)
            {
                compt = 0;
                showrecents();
            }
            else
            {
                compt++;
                showrecents();
            }


        }

        private void precedentBTN_Click(object sender, EventArgs e)
        {
            if (compt == 0)
            {
                compt = r.dt.Rows.Count - 1;
                showrecents();
            }
            else
            {
                compt--;
                showrecents();
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
              THEMAINFORM ee = new THEMAINFORM();

           
                this.Hide();
                ee.ShowDialog();
                this.Close();
        }

        private void Printbutton_Click(object sender, EventArgs e)
        {
            printinscription();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            nomcompletLABEL.Text = dataGridView1.Rows[e.RowIndex].Cells["Nom_Complet"].Value.ToString();
            telelabel.Text = dataGridView1.Rows[e.RowIndex].Cells["tele"].Value.ToString();
            classnomLABEL.Text = dataGridView1.Rows[e.RowIndex].Cells["Class"].Value.ToString();
            AnnescolaireLABEL.Text = dataGridView1.Rows[e.RowIndex].Cells["Anne_scolaire"].Value.ToString();
            dateinscLABEL.Text = dataGridView1.Rows[e.RowIndex].Cells["date_Inscription"].Value.ToString();
            cout = dataGridView1.Rows[e.RowIndex].Cells["cout"].Value.ToString();
            //AnnescolaireLABEL.Text = r.dt.Rows[compt]["Anne_scolaire"].ToString();
            //dateinscLABEL.Text = r.dt.Rows[compt]["date_Inscription"].ToString();
            //cout = r.dt.Rows[compt]["INS_cout"].ToString();

        }
    }
}
