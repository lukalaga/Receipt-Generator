using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CARGODESK
{
    public partial class printReport : Form
    {
        private DataTable dtable = new DataTable();
        private SqlDataAdapter sda;
        private DataSet ds = new DataSet();
        private Database cs = new Database();

        public printReport()
        {
            InitializeComponent();
        }

        private void cmbReceipt_SelectedIndexChanged(object sender, EventArgs e)
        {
            RepairReport rpt = new RepairReport();
            SqlConnection mycon = default(SqlConnection);
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter myDA = new SqlDataAdapter();
            myDataset myDS = new myDataset();

            mycon = new SqlConnection(cs.con1);
            cmd.Connection = mycon;
            cmd.CommandText = "SELECT * FROM Repairs WHERE ReceiptNo='" + cmbReceipt.Text + "' ORDER BY RepairDate";
            cmd.CommandType = CommandType.Text;
            myDA.SelectCommand = cmd;
            myDA.Fill(myDS, "RepairSet");
            rpt.SetDataSource(myDS);

            crystalReportViewer2.ReportSource = rpt;
        }

        private void AutoCompleteReceiptName()
        {
            try
            {
                SqlConnection cn = new SqlConnection(cs.con1);
                cn.Open();
                sda = new SqlDataAdapter();
                sda.SelectCommand = new SqlCommand("SELECT DISTINCT RTRIM(ReceiptNo) FROM Repairs", cn);
                ds = new DataSet("myDataset");

                sda.Fill(ds);
                dtable = ds.Tables[0];
                cmbReceipt.Items.Clear();

                foreach (DataRow drow in dtable.Rows)
                {
                    cmbReceipt.Items.Add(drow[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printReport_Load(object sender, EventArgs e)
        {
            AutoCompleteReceiptName();
        }
    }
}