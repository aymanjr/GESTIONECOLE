using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GESTIONECOLE.FORMS
{
    public partial class CreateExtra_Frais : Form
    {

        RESOURCES.SQLRESOURCES r = new RESOURCES.SQLRESOURCES();


        public CreateExtra_Frais()
        {
            InitializeComponent();
        }

        public void type_show()
        {
            r.connecter();
            r.command = new SqlCommand("select distinct ef_type from extra_frais", r.connection);
            r.reader = r.command.ExecuteReader();
            while (r.reader.Read())
            {

                combo_type.AddItem(r.reader.GetValue(0).ToString());


            }
            combo_type.AddItem("Other");
            r.deconnecter();
        }

        private void CreateExtra_Frais_Load(object sender, EventArgs e)
        {
            type_show();
        }

        string thetype;
        private void btnajouter_Click(object sender, EventArgs e)
        {

            if (combo_type.selectedValue == "Other")
            {
                thetype = txt_type.Text;
            }
            else
            {
                thetype = combo_type.selectedValue.ToString();
            }

            if (thetype == "" || string.IsNullOrWhiteSpace(description_richtext.Text) || string.IsNullOrWhiteSpace(txt_cost.Text))
            {
                MessageBox.Show("Remplier svpl !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                r.connecter();

                r.command = new SqlCommand(" insert into extra_frais values('" + description_richtext.Text + "','" + thetype + "','" + txt_cost.Text + "','" + DateTime.Now.ToShortDateString() + "') ", r.connection);
                r.command.ExecuteNonQuery();
                MessageBox.Show("bien ajouter");
                r.deconnecter();

                Frais_Form ee = new Frais_Form();
                this.Hide();
                ee.ShowDialog();
               
                this.Close();
                


            }

        }



        private void txt_cost_OnValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < txt_cost.Text.Length; i++)
            {

                if (char.IsLetter(txt_cost.Text[i]))
                {
                    MessageBox.Show("just les digits");
                    txt_cost.Text = "";
                }

            }


        }

        private void txt_cost_Click(object sender, EventArgs e)
        {

        }

        private void combo_type_onItemSelected(object sender, EventArgs e)
        {
            if (combo_type.selectedValue == "Other")
            {
                panel1.Show();
            }
            else
            {
                panel1.Hide();
            }
        }
    }
}
