using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GESTIONECOLE.FORMS
{
    public partial class TRANSPORTFORM : Form
    {
        RESOURCES.SQLRESOURCES r = new RESOURCES.SQLRESOURCES();

        public TRANSPORTFORM()
        {
            InitializeComponent();
        }

        private void TRANSPORTFORM_Load(object sender, EventArgs e)
        {
            listtransport();

        }

        private void listtransport()
        {
            r.connecter();
            r.adapter = new SqlDataAdapter("select t.TRSP_id as Num_trsp ,t.TRSP_matricule as Matricule,t.TRSP_module as Module,t.TRSP_statut as Statut from transport t  ", r.connection);
            r.ds = new System.Data.DataSet();
            r.adapter.Fill(r.ds, "TRANSPORT");

            dataGridView1.DataSource = r.ds.Tables[0];

            r.deconnecter();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


        }

        int theid;
        private void TRANSPORTGRIDVIEW_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }

        private void BTNREPARATION_Click(object sender, EventArgs e)
        {

        }

        private void ajouterBTN_Click(object sender, EventArgs e)
        {
            CREATETRANSPORTFORM TR = new CREATETRANSPORTFORM();
            TR.Show();
        }

        private void ModifierBtn_Click(object sender, EventArgs e)
        {
            r.cmdb = new SqlCommandBuilder(r.adapter);
            r.adapter.Update(r.ds, "TRANSPORT");
            if (MessageBox.Show("TRANSPORT is updated ", "DONE", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                listtransport();

            }
        }

        private void SupprimerBtn_Click(object sender, EventArgs e)
        {

            r.connecter();
            SqlCommand command = new SqlCommand("delete TRANSPORT where TRSP_ID = '" + theid + "'", r.connection);
            command.ExecuteNonQuery();
            r.deconnecter();
            if (MessageBox.Show("TRANSPORT is deleted ", "DONE", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                listtransport();

            }

        }

        public void erasedetail()
        {
            mtriculeLABEL.Text = "";
            moduleLABEL.Text = "";
            capaciterLABEL.Text = "";
            CHAUFEURNOMLABEL.Text = "";
            accompLABEL.Text = "";
            TRSPstatutlabel.Text = "";


        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            erasedetail();
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

            theid = int.Parse(row.Cells["Num_trsp"].Value.ToString());
            showdetailschauffer();
            showdetailsaccomp();
            showdetail();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            listtransport();
        }

        public void showdetail()
        {
            r.connecter();
            r.command = new SqlCommand("select TRSP_matricule,TRSP_module,TRSP_capaciter,TRSP_statut from TRANSPORT where TRSP_id = '" + theid + "' ", r.connection);
            r.reader = r.command.ExecuteReader();
            while (r.reader.Read())
            {
                mtriculeLABEL.Text = r.reader.GetValue(0).ToString();
                moduleLABEL.Text = r.reader.GetValue(1).ToString();
                capaciterLABEL.Text = r.reader.GetValue(2).ToString();
                TRSPstatutlabel.Text = r.reader.GetValue(3).ToString();

            }

            r.deconnecter();
        }

        public void showdetailschauffer()
        {
            r.connecter();
            r.command = new SqlCommand(" exec detailtrsp '" + theid + "' ", r.connection);

            r.reader = r.command.ExecuteReader();
            while (r.reader.Read())
            {

                CHAUFEURNOMLABEL.Text = r.reader.GetValue(0).ToString();

            }
            r.deconnecter();

        }
        public void showdetailsaccomp()
        {
            r.connecter();
            r.command = new SqlCommand(" exec detailaccomp '" + theid + "' ", r.connection);

            r.reader = r.command.ExecuteReader();
            while (r.reader.Read())
            {

                accompLABEL.Text = r.reader.GetValue(0).ToString();
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
        ee.ShowDialog();
        this.Close();
        }
    }
}
