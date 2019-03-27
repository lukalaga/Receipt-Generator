using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CARGODESK
{
    public partial class frmLogin : Form
    {
        //private Database cs = new Database();

        private SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        private static int attempt = 3;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (attempt == 0)
            {
                label3.Text = "All attempts failed - Contact Admin";
                return;
            }
            else if (txtpass.Text == "" || txtuser.Text == "")
            {
                label3.Text = "Fields Cannot be blank";
            }
            else
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Register WHERE username=@username AND password=@password", con);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@username", txtuser.Text);
                cmd.Parameters.AddWithValue("@password", txtpass.Text);
                con.Open();

                if (cmd.ExecuteScalar().ToString() == "1")
                {
                    MessageBox.Show("Successful", "CARGODESK DESK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dashboard frm = new Dashboard();
                    Hide();
                    frm.ShowDialog();
                }
                else
                {
                    label3.Text = "You Have only " + Convert.ToString(attempt) + " Attempts Left";
                    --attempt;
                    txtpass.Clear();
                    txtuser.Clear();
                }

                con.Close();
            }
        }

        private void LinkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Join frm = new Join();
            Hide();
            frm.ShowDialog();
        }
    }
}