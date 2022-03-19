using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTIONECOLE.FORMS
{
    public partial class Frais_Salaire : UserControl
    {
        RESOURCES.SQLRESOURCES r = new RESOURCES.SQLRESOURCES();

        public Frais_Salaire()
        {
            InitializeComponent();
        }

        public void salaireshow()
        {
            r.dt.Clear();
            r.connecter();

            r.command = new SqlCommand("select e.Emp_nom as nom,e.Emp_prenom as prenom,e.Emp_cin as cin,e.Emp_post as post ,s.Sal_cout as salaire from EMP_SALAIRE s,EMPLOYEE e where e.Emp_id = s.Sal_empid#",r.connection);
           r.reader = r.command.ExecuteReader();
            r.dt.Load(r.reader);
            datagridviewsalaire.DataSource = r.dt;

            r.deconnecter();
        }

        private void Frais_Salaire_Load(object sender, EventArgs e)
        {
            salaireshow();
        }

        string empcin;
        string cout;
        private void datagridviewsalaire_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.datagridviewsalaire.Rows[e.RowIndex];
            empcin = row.Cells["cin"].Value.ToString();
            cout = row.Cells["salaire"].Value.ToString();
        }

        private void ModifierBtn_Click(object sender, EventArgs e)
        {

            r.connecter();
            r.command = new SqlCommand(" update EMP_SALAIRE set Sal_cout = '"+cout+"' where Sal_empid# = (select Emp_id from EMPLOYEE where Emp_cin = '"+empcin+"')  ",r.connection);

            r.command.ExecuteNonQuery();
            MessageBox.Show("bien modifier");
            salaireshow();
            r.deconnecter();

        }

        private void SupprimerBtn_Click(object sender, EventArgs e)
        {
         
        }
    }
}
