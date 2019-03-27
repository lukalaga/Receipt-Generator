using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CARGODESK
{
    public partial class RepairsDelivery : Form
    {
        public RepairsDelivery()
        {
            InitializeComponent();
        }

        private SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (TxtReceiptNo.Text == "" || TxtRepairCompany.Text == "")
            {
                MessageBox.Show("Some Fields Are Blank", "CARGO DESK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("" +
                    "INSERT INTO Repairs(RepairDate,RepairCompany,Timein,ReceiptNo,Item,Model,Quantity,Remarks,AuthorizingOfficer,Designation,ReceivedBy,IDNumber,RepairerRemarks,Diagnosis)" +
                    "values(@RepairDate,@RepairCompany,@Timein,@ReceiptNo,@Item,@Model,@Quantity,@Remarks,@AuthorizingOfficer,@Designation,@ReceivedBy,@IDNumber,@RepairerRemarks,@Diagnosis)", con);
                cmd.Parameters.AddWithValue("RepairDate", dtDate.Text);
                cmd.Parameters.AddWithValue("RepairCompany", TxtRepairCompany.Text);
                cmd.Parameters.AddWithValue("Timein", dtTimeIn.Text);
                cmd.Parameters.AddWithValue("ReceiptNo", TxtRecepientID.Text);
                cmd.Parameters.AddWithValue("Item", CmbItem.Text);
                cmd.Parameters.AddWithValue("Model", CmbModel.Text);
                cmd.Parameters.AddWithValue("Quantity", TxtQuantity.Text);
                cmd.Parameters.AddWithValue("Remarks", RichRemarks.Text);
                cmd.Parameters.AddWithValue("AuthorizingOfficer", CmbOfficer.Text);
                cmd.Parameters.AddWithValue("Designation", TxtDesignation.Text);
                cmd.Parameters.AddWithValue("ReceivedBy", TxtReceived.Text);
                cmd.Parameters.AddWithValue("IDNumber", TxtRecepientID.Text);
                cmd.Parameters.AddWithValue("RepairerRemarks", RichRepairRemarls.Text);
                cmd.Parameters.AddWithValue("Diagnosis", RichDiagnosis.Text);

                Database.CreateRecord(cmd);

                MessageBox.Show("Operation Successfull", "CARGODESK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtRepairCompany.Text = "";
                TxtRecepientID.Text = "";
                CmbItem.Text = "";
                CmbModel.Text = "";
                TxtQuantity.Text = "";
                RichRemarks.Text = "";
                CmbOfficer.Text = "";
                TxtDesignation.Text = "";
                TxtReceived.Text = "";
                TxtRecepientID.Text = "";
                RichRepairRemarls.Text = "";
                RichDiagnosis.Text = "";
            }
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard frm = new Dashboard();
            Hide();
            frm.ShowDialog();
        }
    }
}