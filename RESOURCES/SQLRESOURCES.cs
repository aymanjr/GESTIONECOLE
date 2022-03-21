using System.Data;
using System.Data.SqlClient;


namespace GESTIONECOLE.RESOURCES
{
    class SQLRESOURCES
    {


        public SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=The_school_management;Integrated Security=True");


        public DataSet ds = new DataSet();
        public SqlDataAdapter adapter;
        public SqlDataAdapter adapter1;
        public SqlDataReader reader;
        public SqlCommand command;
        public DataTable dt = new DataTable();
        public DataTable dt1 = new DataTable();


        public SqlCommandBuilder cmdb;


        public void connecter()
        {
            if (connection.State == ConnectionState.Closed || connection.State == ConnectionState.Broken)
            {
                connection.Open();
            }
        }

        public void deconnecter()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

    }
}
