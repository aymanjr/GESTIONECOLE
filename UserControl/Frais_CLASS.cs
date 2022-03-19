using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GESTIONECOLE.FORMS
{
    public partial class Frais_CLASS : UserControl
    {

        RESOURCES.SQLRESOURCES r = new RESOURCES.SQLRESOURCES();

        public Frais_CLASS()
        {
            InitializeComponent();
        }


        public void fill_combo()
        {
            r.connecter();

            r.command = new SqlCommand("select distinct CL_annee_scolaire from CLASS ", r.connection);
            r.reader = r.command.ExecuteReader();
            while (r.reader.Read())
            {
                combo_year.AddItem(r.reader.GetValue(0).ToString());
            }

            r.deconnecter();

        }
        public void showclass()
        {
            r.dt.Clear();
            r.connecter();

            r.command = new SqlCommand(" select c.CL_nom,f.Fr_cl_anneescolaire,f.Fr_cl_montant from CLASS c,FRAIS_MOIS_CLASS f where f.Fr_cl_Class_id# = c.CL_id and   f.Fr_cl_anneescolaire = '" + combo_year.selectedValue.ToString() + "' group by c.CL_nom,f.Fr_cl_anneescolaire,f.Fr_cl_montant  ", r.connection);

            r.reader = r.command.ExecuteReader();
            r.dt.Load(r.reader);
            datagridviewclass.DataSource = r.dt;

            r.deconnecter();
        }

        private void Frais_CLASS_Load(object sender, EventArgs e)
        {
             fill_combo();
        }

        private void combo_year_onItemSelected(object sender, EventArgs e)
        {

            showclass();
        }

        string classname;
        private void datagridviewclass_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = this.datagridviewclass.Rows[e.RowIndex];
            classname = row.Cells["CL_nom"].Value.ToString();
            txt_cost.Text = row.Cells["Fr_cl_montant"].Value.ToString();
            bringid();
        
        }

        int classid;

        public void bringid()
        {
            r.connecter();
            r.command = new SqlCommand(" select CL_id from class where CL_nom = '"+classname+"'  ",r.connection);
            r.reader = r.command.ExecuteReader();

            while (r.reader.Read())
            {
                classid = int.Parse(r.reader.GetValue(0).ToString());
            }

            r.deconnecter();
        }

        private void ModifierBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_cost.Text))
            {
                MessageBox.Show("choisi un class et puis modifier le montant ");
            }
            else
            {
                 r.connecter();

                  r.command = new SqlCommand(" update  FRAIS_MOIS_CLASS  set Fr_cl_montant = '"+txt_cost.Text+"'  where Fr_cl_Class_id# = '"+classid.ToString()+"' ",r.connection);
                  r.command.ExecuteNonQuery();
                   MessageBox.Show(" le frais de cette class a ete bien modifier pour cette annee  ");


            r.deconnecter();
            }
           
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            if (combo_year.selectedValue == null)
            {
                MessageBox.Show("choisi un annee ");
            }
            else
            {
                 showclass();
            }
           
        }
    }
}
