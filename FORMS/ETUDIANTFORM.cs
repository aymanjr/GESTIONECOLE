using GESTIONECOLE.FORMS;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GESTIONECOLE
{
    public partial class ETUDIANT_FORM : Form
    {

        RESOURCES.SQLRESOURCES r = new RESOURCES.SQLRESOURCES();
        public ETUDIANT_FORM()
        {
            InitializeComponent();
        }

        string defaultannee;
        private void label10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void list_ETUDIANT()
        {
            r.ds.Clear();
            r.connecter();
            r.adapter = new SqlDataAdapter("select * FROM eleve", r.connection);
            r.ds = new System.Data.DataSet();
            r.adapter.Fill(r.ds, "eleve");
            dataGridView1.DataSource = r.ds.Tables["eleve"];

            r.deconnecter();

        }


        private void TECHEAR_ADD_FORM_Load(object sender, EventArgs e)
        {

            list_ETUDIANT();


        }



        string eleveid;

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CREATEETUDIANTFORM ETD = new CREATEETUDIANTFORM();
            ETD.Show();
        }

        public void panelshide()
        {
           
        }
        private void ETUDIANTFORM(object sender, EventArgs e)
        {

          THEMAINFORM t  = new THEMAINFORM();
            t.Close();

            panelshide();

            list_ETUDIANT();
            combo_annescolaire_fill();
           

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

            eleveid = row.Cells["EL_ID"].Value.ToString();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {

            r.connecter();
            r.command = new SqlCommand("delete eleve where EL_ID = '" + eleveid + "'", r.connection);
            r.command.ExecuteNonQuery();
            r.deconnecter();

            if (MessageBox.Show("l'eleve a été supprimé ", "Terminer", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                list_ETUDIANT();

            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {

            r.cmdb = new SqlCommandBuilder(r.adapter);
            r.adapter.Update(r.ds, "eleve");
            if (MessageBox.Show("l'eleve a été Modifié ", "Terminer", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                list_ETUDIANT();

            }
        }
        int i;

        public void combo_annescolaire_fill()
        {

            r.connecter();
            r.command = new SqlCommand(" select distinct CL_annee_scolaire from CLASS ", r.connection);
            r.reader = r.command.ExecuteReader();

            while (r.reader.Read())
            {
                i=0;
                //combo_annescolaire.Items.Add(r.reader.GetValue(0).ToString());
                combo_anneescolaire.Items.Add(r.reader.GetValue(0).ToString());
                if (i==0)
                {
                    defaultannee = r.reader.GetValue(0).ToString();
                    i++;
                }
            }

            r.deconnecter();

        }

        private void btnCreate_Click_1(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    


      


     
        private void combo_annescolaire_onItemSelected(object sender, EventArgs e)
        {



        }

        private void combo_annescolaire_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void combo_annescolaire_SelectedValueChanged(object sender, EventArgs e)
        {
            //classshow();
            // labeltest.Text = comboBox_class.SelectedValue.ToString();
        }
        int count = 0;
        private void comboBox_d_class_SelectedIndexChanged(object sender, EventArgs e)
        {








        }

        public void rechercheleve()
        {
            r.connecter();
            r.adapter = new SqlDataAdapter("select * FROM eleve where el_nom = '" + txt_nomeleve.Text + "' and el_prenom = '" + txtprenom.Text + "' ", r.connection);
            r.ds = new System.Data.DataSet();
            r.adapter.Fill(r.ds, "eleve");
            if (r.ds.Tables["eleve"].Rows.Count == 0)
            {
                MessageBox.Show("Aucun L'eleve avec ce nom et prenom");
                txt_nomeleve.Text = "";
                txtprenom.Text = "";
            }
            else
            {
                dataGridView1.DataSource = r.ds.Tables["eleve"];
            }


            r.deconnecter();
        }

        private void eleverechercherBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_nomeleve.Text) || string.IsNullOrWhiteSpace(txtprenom.Text))
            {
                MessageBox.Show("Entre le nom et le prénom de éleve","Information", MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            else
            {

                if (r.ds.Tables["eleve"].Rows.Count > 0)
                {
                    r.ds.Tables["eleve"].Clear();
                    rechercheleve();
                }
                else
                {
                    rechercheleve();
                }
            }



        }

        private void txt_nomeleve_OnValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < txt_nomeleve.Text.Length; i++)
            {
                if (char.IsDigit(txt_nomeleve.Text[i]))
                {
                    MessageBox.Show("Juste les lettres ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_nomeleve.Text = "";
                }
            }
        }

        private void txt_nomeleve_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            list_ETUDIANT();
        }

        public void filter()
        {







        }

        private void Checkbox_class_OnChange(object sender, EventArgs e)
        {

        }

        private void recherche_btn_Click(object sender, EventArgs e)
        {

            if (r.ds.Tables["eleve"].Rows.Count > 0)
            {
                r.ds.Tables["eleve"].Clear();
                filter();
            }
            else
            {
                filter();
            }


        }

        private void comboBoxde_classss_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            CREATEETUDIANTFORM ef = new CREATEETUDIANTFORM();
            ef.Show();
        }

        private void comboBox_choice_SelectedIndexChanged(object sender, EventArgs e)
        {

            



        }

        bool a = false;
        private void comboBox_choice_Click(object sender, EventArgs e)
        {
            

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

            r.cmdb = new SqlCommandBuilder(r.adapter);
            r.adapter.Update(r.ds,"eleve");
            MessageBox.Show("done");
            list_ETUDIANT();

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
           THEMAINFORM ee = new THEMAINFORM();

            this.Hide();
        ee.ShowDialog();
        this.Close();
        }

        private void combo_filter_onItemSelected(object sender, EventArgs e)
        {
            

            r.ds.Clear();

            r.connecter();
            r.adapter = new SqlDataAdapter("select e.* from eleve e ,class c , INSCRIPTION i where e.EL_ID = i.INS_eleveID# and i.INS_classID# = c.CL_id and c.CL_annee_scolaire = '" + combo_anneescolaire.selectedValue.ToString() + "' ", r.connection);
            r.adapter.Fill(r.ds, "eleve");
            dataGridView1.DataSource = r.ds.Tables["eleve"];

            r.deconnecter();

        }

       
        private void txt_recherche_OnValueChanged(object sender, EventArgs e)
        {

     
             r.ds.Clear();
            r.connecter();
               r.adapter = new SqlDataAdapter("exec   recherch_eleve '"+txt_recherche.Text+"', '" + combo_anneescolaire.selectedValue.ToString()+ "' ", r.connection);
            r.adapter.Fill(r.ds, "eleve");
            dataGridView1.DataSource = r.ds.Tables["eleve"];


            r.deconnecter();
            
        }

      
        private void combo_anneescolaire_Click(object sender, EventArgs e)
        {
            
        }

        private void combo_anneescolaire_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
