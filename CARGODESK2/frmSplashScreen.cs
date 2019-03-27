using System;
using System.Windows.Forms;

namespace CARGODESK
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(2);
            if (progressBar1.Value == progressBar1.Maximum)
            {
                frmLogin logins = new frmLogin();
                timer1.Stop();
                this.Hide();
                logins.Show();
            }
        }
    }
}