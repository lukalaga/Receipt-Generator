using System.Data;
using System.Data.SqlClient;

namespace CARGODESK
{
    internal class db
    {
        private SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\Cazenter A Lukalaga\Desktop\CARGODESK2\CargoDatabase.mdf;Integrated Security=True");

        public DataSet Invoice(string invid)
        {
            SqlCommand cmd = new SqlCommand("Sp_RepairRecord", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ReceiptNo", invid);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }
    }
}