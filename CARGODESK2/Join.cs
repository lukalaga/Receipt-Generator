using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CARGODESK
{
    public partial class Join : Form
    {
        public Join()
        {
            InitializeComponent();
        }

        private SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

        private void Lblalready_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin frm = new frmLogin();
            Hide();
            frm.ShowDialog();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (txtfirstname.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("Fill All Fields", "CARGO DESK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Register(username,password,FirstName,LastName) VALUES(@username,@password,@FirstName,@LastName)", con);
                cmd.Parameters.AddWithValue("@username", txtusername.Text);
                cmd.Parameters.AddWithValue("@password", txtpassword.Text);
                cmd.Parameters.AddWithValue("@FirstName", txtfirstname.Text);
                cmd.Parameters.AddWithValue("@LastName", txtlastname.Text);

                txtusername.Text = "";
                txtpassword.Text = "";
                txtfirstname.Text = "";
                txtlastname.Text = "";

                Database.CreateRecord(cmd);

                MessageBox.Show("Registration Succesfull!", "CARGO DESK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmLogin frm = new frmLogin();
                frm.ShowDialog();
                Hide();
            }
        }
    }
}