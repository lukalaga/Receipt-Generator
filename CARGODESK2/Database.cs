using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CARGODESK
{
    internal class Database
    {
        private SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

        public string con1 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Cazenter A Lukalaga\Desktop\CARGODESK2\CargoDatabase.mdf;Integrated Security=True";

        public DataTable ReadFromDb(SqlCommand cmd)
        {
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            con.Close();
            DataTable DT = new DataTable();
            DA.Fill(DT);
            return DT;
        }

        public static void CreateRecord(SqlCommand cmd)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}