using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GESTIONECOLE.FORMS
{
    public partial class Frais_Form : Form
    {
        RESOURCES.SQLRESOURCES r = new RESOURCES.SQLRESOURCES();
        DataTable ddt = new DataTable();
        public Frais_Form()
        {
            InitializeComponent();
        }


        float annecost;
        public void frais_cette_annee()
        {
            r.connecter();
            r.command = new SqlCommand("select *  from Extra_frais   where YEAR(ef_date) = year(getdate())", r.connection);
            r.reader = r.command.ExecuteReader();
            r.dt.Load(r.reader);
            for (int i = 0; i < r.dt.Rows.Count; i++)
            {

                dataGridViewcetteANNEE.Rows.Add(r.dt.Rows[i]["ef_type"].ToString(), r.dt.Rows[i]["ef_cost"].ToString(), r.dt.Rows[i]["ef_date"].ToString());

                annecost = annecost + float.Parse(r.dt.Rows[i]["ef_cost"].ToString());
            }

            totalanneeLabel.Text = annecost.ToString() + " DH ";
            r.deconnecter();
        }


        float costrech;
        bool deja = false;
        public void frais_recherch()
        {
            if (deja == true)
            {
                r.ds.Tables["ef"].Clear();
                costrech = 0;

            }

            deja = true;


            r.connecter();
            r.adapter = new SqlDataAdapter("select f.EF_type,f.EF_description,f.EF_date,f.EF_cost from Extra_Frais f order by f.EF_date desc", r.connection);
            r.adapter.Fill(r.ds, "ef");

            datagrid_Recherche.DataSource = r.ds.Tables["ef"];

            for (int i = 0; i < r.ds.Tables["ef"].Rows.Count; i++)
            {
                costrech = costrech + float.Parse(r.ds.Tables["ef"].Rows[i]["EF_cost"].ToString());
            }
            totalrecherchLABEL.Text = costrech.ToString();
            r.deconnecter();
        }

        float moistotal;
        public void frais_cette_mois()
        {
            r.connecter();
            r.command = new SqlCommand("select * from Extra_frais   where YEAR(ef_date) = year(getdate()) and MONTH(ef_date) = MONTH(GETDATE())", r.connection);
            r.reader = r.command.ExecuteReader();
            r.dt1.Load(r.reader);
            for (int i = 0; i < r.dt1.Rows.Count; i++)
            {

                datagridviewCETTEMOIS.Rows.Add(r.dt1.Rows[i]["ef_type"].ToString(), r.dt1.Rows[i]["ef_cost"].ToString(), r.dt1.Rows[i]["ef_date"].ToString());

                moistotal = moistotal + float.Parse(r.dt1.Rows[i]["ef_cost"].ToString());
            }

            Totalmoislabel.Text = moistotal.ToString() + " DH ";
            r.deconnecter();
        }


        public void gridrows()
        {


            dataGridViewcetteANNEE.Columns.Add("Type", "Type_frais");
            dataGridViewcetteANNEE.Columns.Add("Cost", "Cost_frais");
            dataGridViewcetteANNEE.Columns.Add("Date", "Date_frais");


            datagridviewCETTEMOIS.Columns.Add("Type", "Type_frais");
            datagridviewCETTEMOIS.Columns.Add("Cost", "Cost_frais");
            datagridviewCETTEMOIS.Columns.Add("Date", "Date_frais");


        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frais_Form_Load(object sender, EventArgs e)
        {

            THEMAINFORM t  = new THEMAINFORM();
           
            t.Close();

            gridrows();
            frais_cette_annee();
            frais_cette_mois();
            frais_recherch();
            fill_combo_type();
         
        }
        public void fill_combo_type()
        {
            r.connecter();
            r.command = new SqlCommand("select DISTINCT f.EF_type from Extra_Frais f ", r.connection);
            r.reader = r.command.ExecuteReader();
            while (r.reader.Read())
            {
                combobox_type.AddItem(r.reader.GetValue(0).ToString());

            }


            r.deconnecter();
        }

        public void show_cost_desc()
        {

            r.ds.Tables["ef"].Clear();
            costrech = 0;
            r.connecter();
            r.adapter = new SqlDataAdapter("select f.EF_type,f.EF_description,f.EF_date,f.EF_cost from Extra_Frais f order by f.EF_cost desc", r.connection);
            r.adapter.Fill(r.ds, "ef");

            datagrid_Recherche.DataSource = r.ds.Tables["ef"];

            for (int i = 0; i < r.ds.Tables["ef"].Rows.Count; i++)
            {
                costrech = costrech + float.Parse(r.ds.Tables["ef"].Rows[i]["EF_cost"].ToString());
            }
            totalrecherchLABEL.Text = costrech.ToString();

            r.deconnecter();

        }
        public void show_cost_Asc()
        {

            r.ds.Tables["ef"].Clear();
            costrech = 0;
            r.connecter();
            r.adapter = new SqlDataAdapter("select f.EF_type,f.EF_description,f.EF_date,f.EF_cost from Extra_Frais f order by f.EF_cost asc", r.connection);
            r.adapter.Fill(r.ds, "ef");

            datagrid_Recherche.DataSource = r.ds.Tables["ef"];

            for (int i = 0; i < r.ds.Tables["ef"].Rows.Count; i++)
            {

                costrech = costrech + float.Parse(r.ds.Tables["ef"].Rows[i]["EF_cost"].ToString());

            }
            totalrecherchLABEL.Text = costrech.ToString();

            r.deconnecter();

        }
        private void combo_choice_onItemSelected(object sender, EventArgs e)
        {
            if (combo_choice.selectedValue.ToString() == "Type")
            {
                panel_date.Hide();
                Panel_Type.Show();




            }
            else if (combo_choice.selectedValue.ToString() == "Date")
            {
                Panel_Type.Hide();
                panel_date.Show();
            }
            else if (combo_choice.selectedValue.ToString() == "Cost la plus haut")
            {
                panel_date.Hide();
                Panel_Type.Hide();
                show_cost_desc();
            }
            else if (combo_choice.selectedValue.ToString() == "Cost la plus pas")
            {
                panel_date.Hide();
                Panel_Type.Hide();
                show_cost_Asc();

            }
            else
            {
                panel_date.Hide();
                Panel_Type.Hide();
            }
        }

        private void combobox_type_onItemSelected(object sender, EventArgs e)
        {

        }

        private void rechercheBTN_type_Click(object sender, EventArgs e)
        {
            if (combobox_type.selectedValue == null)
            {
                MessageBox.Show("entrer un type ");
            }
            else
            {

                r.ds.Tables["ef"].Clear();
                costrech = 0;
                r.connecter();
                r.adapter = new SqlDataAdapter("select f.EF_type,f.EF_description,f.EF_date,f.EF_cost from Extra_Frais f where f.EF_type = '" + combobox_type.selectedValue.ToString() + "'", r.connection);
                r.adapter.Fill(r.ds, "ef");

                datagrid_Recherche.DataSource = r.ds.Tables["ef"];

                for (int i = 0; i < r.ds.Tables["ef"].Rows.Count; i++)
                {
                    costrech = costrech + float.Parse(r.ds.Tables["ef"].Rows[i]["EF_cost"].ToString());
                }
                totalrecherchLABEL.Text = costrech.ToString();

                r.deconnecter();
            }
        }

        private void refreshBTN_Click(object sender, EventArgs e)
        {
            frais_recherch();

        }

        private void recherchbtn_date_Click(object sender, EventArgs e)
        {
            r.ds.Tables["ef"].Clear();
            costrech = 0;
            r.connecter();
            r.adapter = new SqlDataAdapter("select f.EF_type,f.EF_description,f.EF_date,f.EF_cost from Extra_Frais f where f.EF_date between '" + datetimepicker_from.Value.ToShortDateString() + "' and '" + datetimepicker_TO.Value.ToShortDateString() + "' ", r.connection);
            r.adapter.Fill(r.ds, "ef");

            datagrid_Recherche.DataSource = r.ds.Tables["ef"];

            for (int i = 0; i < r.ds.Tables["ef"].Rows.Count; i++)
            {
                costrech = costrech + float.Parse(r.ds.Tables["ef"].Rows[i]["EF_cost"].ToString());
            }
            totalrecherchLABEL.Text = costrech.ToString();

            r.deconnecter();

        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            THEMAINFORM ee = new THEMAINFORM();
            this.Hide();
        ee.ShowDialog();
        this.Close();
        }

        private void extras_frais_btn_Click(object sender, EventArgs e)
        {
             CreateExtra_Frais ee = new CreateExtra_Frais();
            this.Hide();
        ee.ShowDialog();
        this.Close();
        }

        private void datagrid_Recherche_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = this.datagrid_Recherche.Rows[e.RowIndex];
            //    Type_label.Text = row.Cells["ef_type"].ToString();
            //    description_richtext.Text = row.Cells["EF_description"].ToString();
            //    cost_label.Text = row.Cells["EF_cost"].ToString();
            //    dateLABEL.Text = row.Cells["EF_date"].ToString();
            //}
        }

        private void datagrid_Recherche_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Printbutton.Visible = true;
        }

        private void datagrid_Recherche_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            datagrid_Recherche.CurrentRow.Selected = true;
            Type_label.Text = datagrid_Recherche.Rows[e.RowIndex].Cells["ef_type"].Value.ToString();
            description_richtext.Text = datagrid_Recherche.Rows[e.RowIndex].Cells["EF_description"].Value.ToString();
            cost_label.Text = datagrid_Recherche.Rows[e.RowIndex].Cells["EF_cost"].Value.ToString();
            dateLABEL.Text = datagrid_Recherche.Rows[e.RowIndex].Cells["EF_date"].Value.ToString();


        }

        private void Printbutton_MouseHover(object sender, EventArgs e)
        {
            ToolTip a = new ToolTip();
            a.SetToolTip(Printbutton, "Print");
        }

        private void Printbutton_Click(object sender, EventArgs e)
        {
            Print_FraisForm fr = new Print_FraisForm();
            fr.type = Type_label.Text;
            fr.description = description_richtext.Text;
            fr.cost = cost_label.Text;
            fr.datefrais = dateLABEL.Text;
            fr.ShowDialog();

        }
    }
}
