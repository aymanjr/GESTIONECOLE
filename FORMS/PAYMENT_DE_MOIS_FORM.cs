﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GESTIONECOLE.FORMS
{
    public partial class PAYMENT_DE_MOIS_FORM : Form
    {


        RESOURCES.SQLRESOURCES r = new RESOURCES.SQLRESOURCES();
        
        public PAYMENT_DE_MOIS_FORM()
        {
            InitializeComponent();
        }

        int eleveid;
        bool validElev = false;

        public void rechercheleve()
        {
            try
            {
                r.connecter();
                r.adapter = new SqlDataAdapter("select * FROM eleve where el_nom = '" + txt_nomeleve.Text + "' and el_prenom = '" + txtprenom.Text + "' ", r.connection);
                r.ds = new System.Data.DataSet();
                r.adapter.Fill(r.ds, "eleve");

                if (r.ds.Tables["eleve"].Rows.Count == 0)
                { MessageBox.Show("Aucune éleve avec ce nom et ce prénom", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Hand); }
                else
                {
                                validElev = true;
                                eleveid = int.Parse(r.ds.Tables["eleve"].Rows[0]["el_id"].ToString());
                               // TrsprtTYPENOM.Text = eleveid.ToString();
                                nomcompleteleveLABEL.Text = r.ds.Tables["eleve"].Rows[0]["el_nom"].ToString() + "  " + r.ds.Tables["eleve"].Rows[0]["el_prenom"].ToString();
                                moisshow();
                                showpayedmois();
                                classrecherche();
                                inscriptionrech();
                                showlastpayment();

                 }
                 r.deconnecter();
            }
            catch
            { MessageBox.Show("Aucune éleve avec ce nom et ce prénom et ce mois", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Hand); }
        }
        
        public void FRAIS_MOIS_ELEVE()
        {
            r.connecter();
            r.command = new SqlCommand("", r.connection);
            r.reader = r.command.ExecuteReader();
            while (r.reader.Read())
            {

                moispayerlist.Items.Add(r.reader.GetValue(0).ToString());

            }

            r.deconnecter();
        }

        public void moisshow()
        {
            comboBox_mois.Clear();
            moisnonpayerlist.Items.Clear();
            r.connecter();
            r.command = new SqlCommand("select Mois_nom from MOIS where Mois_id not in(select m.Mois_id from mois m, FRAIS_MOIS_ELEVE fm , INSCRIPTION i where m.Mois_id = fm.FR_MOISID# and fm.FR_INSID# = i.INS_id and i.INS_eleveID# = '" + eleveid + "')", r.connection);
            r.reader = r.command.ExecuteReader();
            while (r.reader.Read())
            {
                comboBox_mois.Items.Add(r.reader.GetValue(0).ToString());
                moisnonpayerlist.Items.Add(r.reader.GetValue(0).ToString());

            }

            r.deconnecter();


        }
        int moisid;
        public void moididrecherche()
        {
            r.connecter();
            r.command = new SqlCommand(" select Mois_id from mois where Mois_nom  = '" + comboBox_mois.selectedValue.ToString() + "' ", r.connection);
            r.reader = r.command.ExecuteReader();
            while (r.reader.Read())
            {
                moisid = int.Parse(r.reader.GetValue(0).ToString());
            }

            r.deconnecter();
        }
        public void showpayedmois()
        {
            moispayerlist.Items.Clear();
            r.connecter();
            r.command = new SqlCommand("select Mois_nom from MOIS where Mois_id  in(select m.Mois_id from mois m, FRAIS_MOIS_ELEVE fm , INSCRIPTION i where m.Mois_id = fm.FR_MOISID# and fm.FR_INSID# = i.INS_id and i.INS_eleveID# = '" + eleveid + "')", r.connection);
            r.reader = r.command.ExecuteReader();
            while (r.reader.Read())
            {

                moispayerlist.Items.Add(r.reader.GetValue(0).ToString());

            }

            r.deconnecter();

        }

        int classid;
        string annescolaire;
        public void classrecherche()
        {

            r.connecter();
            r.command = new SqlCommand("  select c.CL_id,c.CL_nom,fc.Fr_cl_montant,c.CL_annee_scolaire from CLASS c , INSCRIPTION i, FRAIS_MOIS_CLASS fc where c.CL_id = i.INS_classID# and fc.Fr_cl_Class_id# = c.CL_id and i.INS_eleveID# = '" + eleveid + "'", r.connection);
            r.reader = r.command.ExecuteReader();
            while (r.reader.Read())
            {

                classid = int.Parse(r.reader.GetValue(0).ToString());
                classnomLABEL.Text = r.reader.GetValue(1).ToString();
                NOMCLASSLABEL2.Text = r.reader.GetValue(1).ToString();
                txtfraisCLASS.Text = r.reader.GetValue(2).ToString();
                annescolaire = r.reader.GetValue(3).ToString();

            }

            r.deconnecter();
        }

    
        


        //public void lastpayment()
        //{

        //    SqlDataReader dr ;
        //    r.connecter();
        //    r.command = new SqlCommand("select top 1 ft.FRTRSP_type,m.Mois_nom,f.FR_TOTAL,f.FR_datepayment from INSCRIPTION i , ELEVE e , FRAIS_MOIS_ELEVE f,FRAIS_MOIS_TRSP ft,MOIS m ,CLASS c where e.EL_ID = i.INS_id and i.INS_id = f.FR_INSID# and f.FR_FRTRSPID# = ft.FRTRSP_id and f.FR_MOISID# = m.Mois_id and c.CL_id = i.INS_classID# and i.INS_eleveID# = '"+eleveid+"'  order by f.FR_datepayment desc ", r.connection);


        //    dr = r.command.ExecuteReader();
        //    while (dr.Read())
        //    {

        //        TrsprtTYPENOM.Text = dr.GetValue(0).ToString();
        //        moislabel.Text = dr.GetValue(1).ToString();
        //        MontantLABEL.Text = dr.GetValue(2).ToString();
        //        datepaymentlabel.Text = dr.GetValue(3).ToString();


        //    }

         


            
        //    r.deconnecter();


        //}
        public void trsptypeshow()
        {
            combo_typetrsp.Clear();
            r.connecter();
            r.command = new SqlCommand(" select f.FRTRSP_type from FRAIS_MOIS_TRSP f  ", r.connection);
            r.reader = r.command.ExecuteReader();
            while (r.reader.Read())
            {

                combo_typetrsp.AddItem(r.reader.GetValue(0).ToString());

            }

            r.deconnecter();


        }

        int trsptypeid;
        float trspmontant;

        public void trsptypeidrecherche()
        {
            r.connecter();
            r.command = new SqlCommand(" select f.FRTRSP_id,f.FRTRSP_montant from FRAIS_MOIS_TRSP f where f.FRTRSP_type  = '" + combo_typetrsp.selectedValue.ToString() + "'  ", r.connection);

            r.reader = r.command.ExecuteReader();
            while (r.reader.Read())
            {

                trsptypeid = int.Parse(r.reader.GetValue(0).ToString());
                trspmontant = float.Parse(r.reader.GetValue(1).ToString());

            }

            r.deconnecter();



        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void label14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PAYMENT_DE_MOIS_FORM_Load(object sender, EventArgs e)
        {
            paneltrsp.Hide();
            trsptypeshow();
        }

        private void UPDATEBTN_Click(object sender, EventArgs e)
        {
        }

        private void paymentgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PAYERBTN_Click(object sender, EventArgs e)
        {

        }



        private void eleverechercherBTN_Click(object sender, EventArgs e)
        {
            //nomcompleteleveLABEL.Text = "";
            //NOMCLASSLABEL2.Text = "";
            //TrsprtTYPENOM.Text = "";
            //moislabel.Text = "";
            //MontantLABEL.Text = "";
            //datepaymentlabel.Text = "";
            //classnomLABEL.Text = "";

            if (string.IsNullOrWhiteSpace(txt_nomeleve.Text) || string.IsNullOrWhiteSpace(txtprenom.Text))
            {
                MessageBox.Show("Entrer le nom et le prénom d'éleve", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                rechercheleve();
            }
        }

        private void comboBox_mois_onItemSelected(object sender, EventArgs e)
        {
            moididrecherche();
        }

        bool trsp = false;

        private void trspCHECKBOX_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (trspCHECKBOX.Checked)
            {
                trsp = true;
                paneltrsp.Show();

            }
            else
            {
                trsp = false;
                paneltrsp.Hide();
            }
        }

        private void combo_typetrsp_onItemSelected(object sender, EventArgs e)
        {
            trsptypeidrecherche();
        }

        private void txtfraisCLASS_OnValueChanged(object sender, EventArgs e)
        {

        }

        bool clickcalcul = false;
        private void calculerBTN_Click(object sender, EventArgs e)
        {
            clickcalcul = true;
            if (trspCHECKBOX.Checked)
            {
                txtmontanttotal.Text = (trspmontant + float.Parse(txtfraisCLASS.Text)).ToString();

            }
            else
            {
                txtmontanttotal.Text = (float.Parse(txtfraisCLASS.Text)).ToString();
                trsptypeid = 0;
            }
        }
        int insid;
        public void inscriptionrech()
        {
            r.connecter();
            r.command = new SqlCommand(" select i.INS_id from INSCRIPTION i where i.INS_eleveID# = '" + eleveid + "' and i.INS_classID# ='" + classid + "' ", r.connection);
            r.reader = r.command.ExecuteReader();
            while (r.reader.Read())
            {
                insid = int.Parse(r.reader.GetValue(0).ToString());
            }

            r.deconnecter();
        }

        public void clean()
        {

            txtprenom.Text = "Prenom";
            txt_nomeleve.Text = "Nom";
            txtmontanttotal.Text = "0";
            txtprenom.Text = "Prenom";
            txtprenom.Text = "Prenom";
            txtfraisCLASS.Text = "0";
            comboBox_mois.Clear();
            combo_typetrsp.Clear();
            trspCHECKBOX.Checked = false;
            moisnonpayerlist.Items.Clear();
            moispayerlist.Items.Clear();
            nomcompleteleveLABEL.Text = "";
            NOMCLASSLABEL2.Text = "";
            TrsprtTYPENOM.Text = "";
            moislabel.Text = "";
            MontantLABEL.Text = "";
            datepaymentlabel.Text = "";
            classnomLABEL.Text = "";


        }


        public void showlastpayment()
        {

            //TrsprtTYPENOM.Text = "ssssss";
            //r.connecter();
            //r.command = new SqlCommand(" exec showlastpayment '" + eleveid + "'", r.connection);
            //r.reader = r.command.ExecuteReader();
            //while (r.reader.Read())
            //{
            //    //  TrsprtTYPENOM.Text = r.reader.GetValue(0).ToString();
            //    TrsprtTYPENOM.Text = r.reader["FRTRSP_type"].ToString();
            //    moislabel.Text = r.reader["Mois_nom"].ToString();
            //    MontantLABEL.Text = r.reader["FR_TOTAL"].ToString();
            //    datepaymentlabel.Text = r.reader["FR_datepayment"].ToString();
            //}
            //r.deconnecter();


            r.connecter();

            r.command = new SqlCommand(" 	" +
                "select  fme.FR_MOISID# ,  fme.FR_TOTAL ,  fme.FR_datepayment , fme.FR_FRTRSPID#, fme.FR_INSID# " +
                "from FRAIS_MOIS_ELEVE fme , INSCRIPTION ins, ELEVE el " +
                "where ins.INS_id = fme.FR_INSID# and ins.INS_eleveID# = el.EL_ID and   el.EL_ID = '" + eleveid + "'", r.connection);
            r.reader = r.command.ExecuteReader();
            while (r.reader.Read())
            {
                moislabel.Text = r.reader.GetValue(0).ToString();
                MontantLABEL.Text = r.reader.GetValue(1).ToString();
                datepaymentlabel.Text = r.reader.GetValue(2).ToString();
                TrsprtTYPENOM.Text = r.reader.GetValue(3).ToString();
            }


            r.deconnecter();
        }


        public void showtrp()
        {
            r.connecter();
            r.command = new SqlCommand(" select f.FRTRSP_id,f.FRTRSP_montant from FRAIS_MOIS_TRSP f where f.FRTRSP_type  = '" + combo_typetrsp.selectedValue.ToString() + "'  ", r.connection);

            r.reader = r.command.ExecuteReader();
            while (r.reader.Read())
            {

                trsptypeid = int.Parse(r.reader.GetValue(0).ToString());
                trspmontant = float.Parse(r.reader.GetValue(1).ToString());

            }

            r.deconnecter();
        }

        private void PyerBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtprenom.Text == "Prenom" || txt_nomeleve.Text == "Nom")
                {
                    MessageBox.Show("Enter un éleve ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (validElev == false)
                {
                    MessageBox.Show("Enter un éleve ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (comboBox_mois.selectedValue == null)
                    {
                        MessageBox.Show("Selectioner un mois  ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        if (clickcalcul == false)
                        {
                            MessageBox.Show("Calculer le montant depuis payer ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {

                            if (!trspCHECKBOX.Checked)
                            {
                                trsptypeid = 0;
                            }
                            r.connecter();
                            r.command = new SqlCommand(" exec ajouterfraismois '" + insid + "','" + annescolaire + "','" + trsptypeid + "','" + moisid + "','" + txtmontanttotal.Text + "','" + DateTime.Now.ToShortDateString() + "' ", r.connection);

                            r.command.ExecuteNonQuery();
                            MessageBox.Show("Paiment a été ajouter ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);



                            r.deconnecter();

                            showlastpayment();


                            //   PD.cost = MontantLABEL.Text;
                            //  PD.class_ = classnomLABEL.Text;
                            // PD.mois = moislabel.Text;
                            // PD.nomcomplet = nomcompleteleveLABEL.Text;
                            // PD.transporttype = TrsprtTYPENOM.Text;
                            //PD.annescolaire = annescolaire;
                            //PD.DatePayment = datepaymentlabel.Text;
                            printthelastpayment();


                        }

                    }
                }
            }
            catch { MessageBox.Show("Calculer le montant depuis payer et Selectioner le mois", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        
        public void printthelastpayment()
        {
            print_Paymentdemois PD = new print_Paymentdemois(nomcompleteleveLABEL.Text,MontantLABEL.Text,classnomLABEL.Text, moislabel.Text, TrsprtTYPENOM.Text, annescolaire, datepaymentlabel.Text);
            PD.ShowDialog();

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            THEMAINFORM ee = new THEMAINFORM();
            this.Hide();
            ee.ShowDialog();
            this.Close();
        }


        private void txt_nomeleve_Enter(object sender, EventArgs e)
        {
            if (txt_nomeleve.Text.Trim() != "" || txt_nomeleve.Text != null)
            {
                txt_nomeleve.Text = "";
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
