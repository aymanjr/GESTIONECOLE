using GESTIONECOLE.FORMS;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace GESTIONECOLE
{
    public partial class EMPLOYEEFORM : Form
    {
        RESOURCES.SQLRESOURCES r = new RESOURCES.SQLRESOURCES();


        public static int theid;
        public EMPLOYEEFORM()
        {
            InitializeComponent();

        }

        private void TEACHERSFORM_ADMIN_ACCESS_Load(object sender, EventArgs e)
        {
              THEMAINFORM t  = new THEMAINFORM();
            t.Close();

            list_teachers();
            showville();

            showpost();
        }
        private void list_teachers()
        {

            r.ds.Clear();
            r.connecter();
            r.adapter = new SqlDataAdapter("select * FROM EMPLOYEE ", r.connection);


            r.adapter.Fill(r.ds, "EMPLOYEE");
            dataGridView1.DataSource = r.ds.Tables[0];

            r.deconnecter();


        }


        private void btnTeachEdit_Click(object sender, EventArgs e)
        {


        }

        private void btnTeachDelete_Click(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {


        }
        int empid;

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTeachCreate_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void ajouterBTN_Click(object sender, EventArgs e)
        {
            CreateEmployeeFORM fORM = new CreateEmployeeFORM();
            fORM.Show();
        }

        private void ModifierBtn_Click(object sender, EventArgs e)
        {

            r.cmdb = new SqlCommandBuilder(r.adapter);
            r.adapter.Update(r.ds, "EMPLOYEE");
            if (MessageBox.Show("Le Employee est bien modifer ", "Terminer", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                list_teachers();

            }

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

            empid = int.Parse(row.Cells["EMP_ID"].Value.ToString());

        }

        private void SupprimerBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.AreAllCellsSelected(true))
            {

                MessageBox.Show("sélectionner juste une row ", "Cellules sélectionnées", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {

            }
            r.connecter();
            SqlCommand command = new SqlCommand("exec delete_emp '" + empid + "'", r.connection);
            command.ExecuteNonQuery();
            r.deconnecter();

            if (MessageBox.Show("Employee est bien supprimé ", "Terminer", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                list_teachers();

            }

        }

        private void rechercherBTN_Click(object sender, EventArgs e)
        {
            r.ds.Clear();
            r.connecter();
            r.adapter = new SqlDataAdapter("select * FROM EMPLOYEE where emp_nom = '" + txt_nom.Text + "' and emp_prenom = '" + txtprenom.Text + "' ", r.connection);


            r.adapter.Fill(r.ds, "EMPLOYEE");
            dataGridView1.DataSource = r.ds.Tables[0];
            r.deconnecter();
            if (dataGridView1.RowCount < 1)
            {
                MessageBox.Show("Ancun trouver ", "Aucun",  MessageBoxButtons.OK, MessageBoxIcon.Error);
                list_teachers();

            }

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            list_teachers();
        }

        public void showpost()
        {
            r.connecter();

            r.command = new SqlCommand("SELECT distinct Emp_post from EMPLOYEE",r.connection);
            r.reader = r.command.ExecuteReader();
            while (r.reader.Read())
            {
                combo_post.AddItem(r.reader.GetValue(0).ToString());
            }

            r.deconnecter();

        }

        public void showville()
        {
             r.connecter();

            r.command = new SqlCommand("SELECT distinct Emp_Ville from EMPLOYEE",r.connection);
            r.reader = r.command.ExecuteReader();
            while (r.reader.Read())
            {
                combo_ville.AddItem(r.reader.GetValue(0).ToString());
            }

            r.deconnecter();
        }
            
        private void combo_filter_onItemSelected(object sender, EventArgs e)
        {
            if (combo_filter.selectedValue == "Post")
            {
                panel_sex.Visible = false;
                panel_ville.Visible = false;
                panel_post.Visible = true;
            }
            else if (combo_filter.selectedValue == "Ville")
            {
                panel_sex.Visible = false;
                  panel_post.Visible = false;

                panel_ville.Visible = true;
            }
            else if (combo_filter.selectedValue == "Genre")
            {
                panel_post.Visible = false;
                  panel_ville.Visible = false;
                panel_sex.Visible = true;
            }
            else
            {
                                panel_post.Visible = false;
                                panel_ville.Visible = false;
                                panel_sex.Visible = false;

            }
        }

        private void combo_post_onItemSelected(object sender, EventArgs e)
        {
          

               r.ds.Clear();
            r.connecter();
            r.adapter = new SqlDataAdapter("SELECT *  from EMPLOYEE where Emp_post = '"+combo_post.selectedValue.ToString()+"' ", r.connection);


            r.adapter.Fill(r.ds, "EMPLOYEE");
            dataGridView1.DataSource = r.ds.Tables[0];

            r.deconnecter();
        }

        private void combo_ville_onItemSelected(object sender, EventArgs e)
        {
              r.ds.Clear();
            r.connecter();
            r.adapter = new SqlDataAdapter("SELECT *  from EMPLOYEE where Emp_ville = '"+combo_ville.selectedValue.ToString()+"' ", r.connection);


            r.adapter.Fill(r.ds, "EMPLOYEE");
            dataGridView1.DataSource = r.ds.Tables[0];

            r.deconnecter();
        }

        private void combo_sex_onItemSelected(object sender, EventArgs e)
        {
             r.ds.Clear();
            r.connecter();
            r.adapter = new SqlDataAdapter("SELECT *  from EMPLOYEE where Emp_sex = '"+combo_sex.selectedValue.ToString()+"' ", r.connection);


            r.adapter.Fill(r.ds, "EMPLOYEE");
            dataGridView1.DataSource = r.ds.Tables[0];

            r.deconnecter();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
             THEMAINFORM ee = new THEMAINFORM();

            this.Hide();
        ee.ShowDialog();
        this.Close();

        }

        private void panel_ville_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_nom_Enter(object sender, EventArgs e)
        {
            if (txt_nom.Text.Trim() != "" || txt_nom.Text != null)
            {
                txt_nom.Text = "";
            }
        }

        private void txtprenom_Enter(object sender, EventArgs e)
        {
            if (txtprenom.Text.Trim() != "" || txtprenom.Text != null)
            {
                txtprenom.Text = "";
            }
        }
    }
}
