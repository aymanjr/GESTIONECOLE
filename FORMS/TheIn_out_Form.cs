using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTIONECOLE.FORMS
{
    public partial class TheIn_out_Form : Form
    {
        RESOURCES.SQLRESOURCES r = new RESOURCES.SQLRESOURCES();
        DataTable tbl = new DataTable();
        public TheIn_out_Form()
        {
            InitializeComponent();
        }

        float theintotal;
        decimal theintotall;
        float theouttotal;
        float costrech;
        bool deja;
        public void eleve_mois_frais_out()
        {
            if (deja == true)
            {


            }

            deja = true;

            r.connecter();
            r.adapter = new SqlDataAdapter("select (e.EL_NOM + ' ' + e.EL_PRENOM) as Eleve ,m.Mois_nom as Mois,YEAR(f.FR_datepayment) as Annee , t.FRTRSP_type as TransportType, f.FR_TOTAL as Montanttotal  from FRAIS_MOIS_ELEVE f ,ELEVE e , MOIS m ,INSCRIPTION i , FRAIS_MOIS_TRSP t  where f.FR_INSID# = i.INS_id and f.FR_MOISID# = m.Mois_id and i.INS_eleveID# = e.EL_ID and t.FRTRSP_id = f.FR_FRTRSPID# order by f.FR_datepayment desc ", r.connection);



            r.adapter.Fill(r.ds, "Moiseleve");
            datagrid_Recherche.DataSource = r.ds.Tables["Moiseleve"];

            for (int i = 0; i < r.ds.Tables["Moiseleve"].Rows.Count; i++)
            {
                costrech = costrech + float.Parse(r.ds.Tables["Moiseleve"].Rows[i]["Montanttotal"].ToString());
            }
            totalrecherchLABEL.Text = costrech.ToString() + " DH";
            r.deconnecter();

        }
        public void the_in()
        {
            if (deja == true)
            {


            }



            r.connecter();
            r.adapter = new SqlDataAdapter("select f.ft_description description ,f.ft_cout cout,f.annescolaire ,f.ft_date date from frais_total f where f.ft_type = 'IN' ", r.connection);

            r.adapter.Fill(r.ds, "thein");

            datagrid_Recherche.DataSource = r.ds.Tables["thein"];

            for (int i = 0; i < r.ds.Tables["thein"].Rows.Count; i++)
            {
                costrech = costrech + float.Parse(r.ds.Tables["thein"].Rows[i]["cout"].ToString());
            }
            totalrecherchLABEL.Text = costrech.ToString() + " DH";
            r.deconnecter();

        }
        public void the_out()
        {


            r.connecter();
            r.adapter = new SqlDataAdapter("select f.ft_description description ,f.ft_cout cout,f.annescolaire ,f.ft_date date from frais_total f where f.ft_type = 'OUT' ", r.connection);

            r.adapter.Fill(r.ds, "theout");

            datagrid_Recherche.DataSource = r.ds.Tables["theout"];

            for (int i = 0; i < r.ds.Tables["theout"].Rows.Count; i++)
            {
                costrech = costrech + float.Parse(r.ds.Tables["theout"].Rows[i]["cout"].ToString());
            }
            totalrecherchLABEL.Text = costrech.ToString() + " DH";
            r.deconnecter();

        }
        public void recent_activ()
        {
            r.connecter();
            r.adapter = new SqlDataAdapter("select f.ft_type as Type,f.ft_cout as Cout,f.ft_date as Date,f.ft_description as Description from frais_total f where MONTH(f.ft_date)=MONTH(GETDATE()) order by f.ft_date desc", r.connection);
            r.adapter.Fill(r.ds, "frais");
            datagrid_Recherche.DataSource = r.ds.Tables["frais"];
            for (int i = 0; i < r.ds.Tables["frais"].Rows.Count; i++)
            {
                costrech = costrech + float.Parse(r.ds.Tables["frais"].Rows[i]["Cout"].ToString());
            }
            totalrecherchLABEL.Text = costrech.ToString() + " DH";

            r.deconnecter();
        }
        public void inscription_frais_out()
        {
            r.connecter();
            r.command = new SqlCommand("select sum(i.INS_cout) from INSCRIPTION i", r.connection);

            r.reader = r.command.ExecuteReader();
            while (r.reader.Read())
            {

                //   inscription_label.Text = r.reader.GetValue(0).ToString()+ " DH";
                theintotal = theintotal + float.Parse(r.reader.GetValue(0).ToString());
            }
            r.deconnecter();

        }
        public void extras_frais_out()
        {
            r.connecter();
            r.command = new SqlCommand("select sum(EF_cost) from Extra_Frais e where e.EF_date between '01/09/'+trim(str((YEAR(GETDATE())-1))) and GETDATE() ", r.connection);

            r.reader = r.command.ExecuteReader();
            while (r.reader.Read())
            {

                //extra_frais_label.Text = r.reader.GetValue(0).ToString()+ " DH";
                theouttotal = float.Parse(r.reader.GetValue(0).ToString());
            }
            r.deconnecter();

        }
        public void salaire_frais_out()
        {
            r.connecter();
            r.command = new SqlCommand("   select (sum(e.Sal_cout) * (datediff(month,('09/01/'+trim(str((YEAR(GETDATE())-1)))),GETDATE()))) from EMP_SALAIRE e ", r.connection);

            r.reader = r.command.ExecuteReader();
            while (r.reader.Read())
            {

                //   salaire_frais_label.Text = r.reader.GetValue(0).ToString()+ " DH";
                theouttotal = theouttotal + float.Parse(r.reader.GetValue(0).ToString());

            }
            r.deconnecter();

        }
        public void lastin()
        {
            r.connecter();

            r.command = new SqlCommand(" select top 1 * from frais_total where ft_type = 'IN' order by ft_id desc ", r.connection);

            r.reader = r.command.ExecuteReader();
            while (r.reader.Read())
            {

                txt_desc_in.Text = r.reader.GetValue(2).ToString();
                cose_frais_in_label.Text = r.reader.GetValue(3).ToString();
                date_frais_in_label.Text = r.reader.GetValue(5).ToString();
            }

            r.deconnecter();
        }
        public void lastOut()
        {
            r.connecter();

            r.command = new SqlCommand("select top 1 * from frais_total where ft_type = 'OUT' order by ft_id desc ", r.connection);

            r.reader = r.command.ExecuteReader();
            while (r.reader.Read())
            {

                txt_descr_outfrais.Text = r.reader.GetValue(2).ToString();
                cout_out_frais_label.Text = r.reader.GetValue(3).ToString();
                date_out_frais_label.Text = r.reader.GetValue(5).ToString();
            }

            r.deconnecter();
        }
        public void inscription_()
        {
            r.connecter();

            r.adapter = new SqlDataAdapter(" select * from INSCRIPTION ", r.connection);

            r.adapter.Fill(r.ds, "Inscription");

            datagrid_Recherche.DataSource = r.ds.Tables["Inscription"];

            for (int i = 0; i <= datagrid_Recherche.Rows.Count - 1; i++)
            {
                theintotall += Convert.ToDecimal(datagrid_Recherche.Rows[i].Cells[4].Value);
            }
            totalrecherchLABEL.Text = Math.Round(theintotall, 2).ToString();

            r.deconnecter();
        }
        public void extra_frais()
        {
            r.connecter();

            r.adapter = new SqlDataAdapter(" select * from Extra_Frais ", r.connection);

            r.adapter.Fill(r.ds, "ExtraFrais");

            datagrid_Recherche.DataSource = r.ds.Tables["ExtraFrais"];

            for (int i = 0; i <= datagrid_Recherche.Rows.Count - 1; i++)
            {
                theintotall += Convert.ToDecimal(datagrid_Recherche.Rows[i].Cells[3].Value);
            }
            totalrecherchLABEL.Text = Math.Round(theintotall, 2).ToString();

            r.deconnecter();
        }
        private void TheIn_out_Form_Load(object sender, EventArgs e)
        {

            // eleve_mois_frais_out();
            //   recent_activ();
            lastin();
            lastOut();
            //eleve_mois_frais_out();
            //inscription_frais_out();
            // extras_frais_out();
            // salaire_frais_out();
            //    Total_frais_in_label.Text = theintotal.ToString() + "  DH"; 
            //  total_frais_out_label.Text = theouttotal.ToString()+"  DH";
            datetimepicker_from.Text = DateTime.Now.ToShortDateString();
            datetimepicker_TO.Text = DateTime.Now.ToShortDateString();
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            THEMAINFORM ee = new THEMAINFORM();
            this.Hide();
            ee.ShowDialog();
            this.Close();
        }

        private void recherchbtn_date_Click(object sender, EventArgs e)
        {
            //r.ds.Tables["frais"].Clear();
            costrech = 0;

            string date1;
            string date2;

            date1 = datetimepicker_from.Value.ToString("yyyy-MM-dd");
            date2 = datetimepicker_TO.Value.ToString("yyyy-MM-dd");

            tbl.Clear();

            r.connecter();
            r.adapter = new SqlDataAdapter("select f.ft_type as Type,f.ft_cout as Cout,f.ft_date as Date,f.ft_description as Description from frais_total f where f.ft_date between'" + date1 + "' and '" + date2 + "' order by f.ft_date desc ", r.connection);
            r.adapter.Fill(r.ds, "frais");
            datagrid_Recherche.DataSource = r.ds.Tables["frais"];

            for (int i = 0; i < r.ds.Tables["frais"].Rows.Count; i++)
            {   
                costrech = costrech + float.Parse(r.ds.Tables["frais"].Rows[i]["Cout"].ToString());
            }
            totalrecherchLABEL.Text = costrech.ToString();

            r.deconnecter();

        }
        private void Combo_section_onItemSelected(object sender, EventArgs e)
        {
            //inscription salaire extra_frais
            if (Combo_section.selectedValue == "Payment Mois")
            {
                datagrid_Recherche.DataSource = null;
                datagrid_Recherche.Rows.Clear();
                costrech = 0;
                deja = true;

                eleve_mois_frais_out();
            }
            else if (Combo_section.selectedValue == "Inscription")
            {
                datagrid_Recherche.DataSource = null;
                datagrid_Recherche.Rows.Clear();
                deja = true;

                inscription_();
            }
            else if (Combo_section.selectedValue == "ExtraFrais")
            {
                datagrid_Recherche.DataSource = null;
                datagrid_Recherche.Rows.Clear();
                deja = true;

                extra_frais();
            }
        }
        private void combo_inoutsearch_onItemSelected(object sender, EventArgs e)
        {
            if (combo_inoutsearch.selectedValue == "In")
            {
                datagrid_Recherche.DataSource = null;
                datagrid_Recherche.Rows.Clear();

                costrech = 0;
                deja = true;
                the_in();
            }
            else if (combo_inoutsearch.selectedValue == "Out")
            {
                datagrid_Recherche.DataSource = null;
                datagrid_Recherche.Rows.Clear();

                costrech = 0;
                deja = true;
                the_out();
            }
        }
        private void refreshBTN_Click(object sender, EventArgs e)
        {

            if (deja == true)
            {
                r.ds.Tables["frais"].Clear();
                costrech = 0;
            }
            deja = true;
            

        }

        private void rechercheBTN_type_Click(object sender, EventArgs e)
        {
            //r.ds.Tables["frais"].Clear();
            costrech = 0;
            r.connecter();
            r.adapter = new SqlDataAdapter("select f.ft_type as Type,f.ft_cout as Cout,f.ft_date as Date,f.ft_description as Description from frais_total f where f.ft_type =" + combobox_type.selectedValue.ToString() + "'", r.connection);
            r.adapter.Fill(r.ds, "frais");

            datagrid_Recherche.DataSource = r.ds.Tables["frais"];

            for (int i = 0; i < r.ds.Tables["frais"].Rows.Count; i++)
            {
                costrech = costrech + float.Parse(r.ds.Tables["frais"].Rows[i]["Cout"].ToString());
            }
            totalrecherchLABEL.Text = costrech.ToString();

            r.deconnecter();
        }

        private void combo_choice_onItemSelected(object sender, EventArgs e)
        {

            if (combo_choice.selectedValue.ToString() == "Date")
            {
                panel_date.Show();
            }

            else
            {
                panel_date.Hide();
            }
        }

        private void Printbutton_Click(object sender, EventArgs e)
        {
            //PRINT_IN_OUT io = new PRINT_IN_OUT();


            //if (Combo_section.selectedValue == "Payment Mois")
            //{

            //}
            //else if (Combo_section.selectedValue == "Inscription")
            //{

            //}
            //else if (Combo_section.selectedValue == "ExtraFrais")
            //{

            //} 
            //else if(combo_choice.selectedValue == "Date")
            //{

            //}
            //else if (combo_choice.selectedValue == "In")
            //{

            //}
            //else if (combo_choice.selectedValue == "Out")
            //{
            //}

        }

        private void datagrid_Recherche_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
