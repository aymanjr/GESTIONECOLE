using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GESTIONECOLE.FORMS
{
    public partial class Frais_Transport : UserControl
    {

        RESOURCES.SQLRESOURCES r = new RESOURCES.SQLRESOURCES();

        public Frais_Transport()
        {
            InitializeComponent();
        }

        public void trspshow()
        {
            r.ds.Clear();
            r.connecter();
            r.adapter = new SqlDataAdapter(" select *  from FRAIS_MOIS_TRSP  ", r.connection);
            r.adapter.Fill(r.ds, "trsp");
            datagridviewTRSP.DataSource = r.ds.Tables["trsp"];

            r.deconnecter();
        }

        private void Frais_Transport_Load(object sender, EventArgs e)
        {
            trspshow();
        }

        private void txt_cost_OnValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < txt_cost.Text.Length; i++)
            {
                if (char.IsLetter(txt_cost.Text[i]))
                {
                    MessageBox.Show("just les nombers ");
                    txt_cost.Text = "";

                }
            }
        }

        private void ajouterBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_type.Text) || string.IsNullOrWhiteSpace(txt_cost.Text))
            {
                MessageBox.Show("enter tout les information", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                r.connecter();

                r.command = new SqlCommand("insert into FRAIS_MOIS_TRSP values('" + txt_type.Text + "','" + txt_cost.Text + "') ", r.connection);
                r.command.ExecuteNonQuery();
                r.deconnecter();
                if (MessageBox.Show("Un nouvelle type a ete ajouter ", "DONE", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    trspshow();
                    txt_cost.Text = "";
                    txt_type.Text = "";

                }


            }
        }

        int fr_id;
        private void datagridviewTRSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ModifierBtn_Click(object sender, EventArgs e)
        {
            r.cmdb = new SqlCommandBuilder(r.adapter);
            r.adapter.Update(r.ds, "trsp");
            if (MessageBox.Show("EMPLOYEE is updated ", "DONE", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                trspshow();

            }
        }

        private void SupprimerBtn_Click(object sender, EventArgs e)
        {
            if (datagridviewTRSP.AreAllCellsSelected(true))
            {

                MessageBox.Show("selectioner just une row ", "Selected Cells");

            }
            else
            {
                r.connecter();
                r.command = new SqlCommand("delete from FRAIS_MOIS_TRSP where  frtrsp_id =  '" + fr_id + "'", r.
                    connection);
                r.command.ExecuteNonQuery();
                r.deconnecter();

                if (MessageBox.Show("Type a ete Supprimer", "DONE", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    trspshow();
                }

            }


        }

        private void datagridviewTRSP_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            DataGridViewRow row = this.datagridviewTRSP.Rows[e.RowIndex];
            fr_id = int.Parse(row.Cells["FRTRSP_id"].Value.ToString());

        }
    }
}
