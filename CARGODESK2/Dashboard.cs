using System;
using System.Windows.Forms;

namespace CARGODESK
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void BtnRepairs_Click(object sender, EventArgs e)
        {
            RepairsDelivery frm = new RepairsDelivery();

            frm.ShowDialog();
        }

        private void BtnMaintenance_Click(object sender, EventArgs e)
        {
            MonthlyMaintenance frm = new MonthlyMaintenance();
            frm.ShowDialog();
        }

        private void reportGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Invoice frm = new Invoice();

            frm.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs frm = new AboutUs();
            frm.ShowDialog();
        }

        private void repairReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printReport frm = new printReport();
            frm.ShowDialog();
        }
    }
}