using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CARGODESK
{
    public partial class MonthlyMaintenance : Form
    {
        public MonthlyMaintenance()
        {
            InitializeComponent();
        }

        private SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (TxtRecepient.Text == "" || txtTitle.Text == "")
            {
                MessageBox.Show("Fields Cannot Be Blank", "CARGO DESK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("" +
                    "INSERT INTO Maintenance(Recepient,Address,Phone,Date1,Time1,OriginatorNo,Project,Title,Site1,Equipment,Originator,ProblemValidated," +
                    "Activity,ProbDescription,OSCondition,SystemStatus,SysNomenclature,SysSerialNo,MeterTime,TechnicalAnalyzer,ProblemStatus," +
                    "ProbRecomendation,ProgNomenclature,VersionNumber,SoftwareConfig,Recommendation,SubsysSerialNo,SubsysNomenclature)" +
                    "VALUES(@Recepient,@Address,@Phone,@Date1,@Time1,@OriginatorNo,@Project,@Title,@Site1,@Equipment,@Originator,@ProblemValidated," +
                    "@Activity,@ProbDescription,@OSCondition,@SystemStatus,@SysNomenclature,@SubsysSerialNo,@MeterTime,@TechnicalAnalyzer,@ProblemStatus," +
                    "@ProbRecomendation,@ProgNomenclature,@VersionNumber,@SoftwareConfig,@Recommendation,@SubsysSerialNo,@SubsysNomenclature)", con);

                cmd.Parameters.AddWithValue("Recepient", TxtRecepient.Text);
                cmd.Parameters.AddWithValue("Address", TxtAddress.Text);
                cmd.Parameters.AddWithValue("Phone", TxtPhone.Text);
                cmd.Parameters.AddWithValue("Date1", dtDate.Text);
                cmd.Parameters.AddWithValue("Time1", dtTime.Text);
                cmd.Parameters.AddWithValue("OriginatorNo", cmbOriginatorNo.Text);
                cmd.Parameters.AddWithValue("Project", txtProject.Text);
                cmd.Parameters.AddWithValue("Title", txtTitle.Text);
                cmd.Parameters.AddWithValue("Site1", txtSite.Text);
                cmd.Parameters.AddWithValue("Equipment", cmbEquipment.Text);
                cmd.Parameters.AddWithValue("Originator", cmbOriginator.Text);
                cmd.Parameters.AddWithValue("ProblemValidated", dtValidated.Text);
                cmd.Parameters.AddWithValue("Activity", cmbActivity.Text);
                cmd.Parameters.AddWithValue("ProbDescription", richDescription.Text);
                cmd.Parameters.AddWithValue("OSCondition", richOSCond.Text);

                if (radioFaulty.Checked)
                {
                    cmd.Parameters.AddWithValue("SystemStatus", "Faulty");
                }
                else
                {
                    cmd.Parameters.AddWithValue("SystemStatus", "OK");
                }

                cmd.Parameters.AddWithValue("SysNomenclature", txtSysNome.Text);
                cmd.Parameters.AddWithValue("SubsysSerialNo", txtSubsysSerialNo.Text);
                cmd.Parameters.AddWithValue("SubsysNomenclature", txtSubsysSerialNo.Text);
                cmd.Parameters.AddWithValue("SysSerialNo", txtSysSerialNo.Text);
                cmd.Parameters.AddWithValue("MeterTime", txtMeterNo.Text);
                cmd.Parameters.AddWithValue("TechnicalAnalyzer", cmbTechnician.Text);
                cmd.Parameters.AddWithValue("ProblemStatus", richProblemStatus.Text);
                cmd.Parameters.AddWithValue("ProbRecomendation", richAdditional.Text);
                cmd.Parameters.AddWithValue("ProgNomenclature", txtProgramNome.Text);
                cmd.Parameters.AddWithValue("VersionNumber", txtVersionNo.Text);
                cmd.Parameters.AddWithValue("SoftwareConfig", txtSoftConfig.Text);
                cmd.Parameters.AddWithValue("Recommendation", RichRecommendation.Text);

                Database.CreateRecord(cmd);
                MessageBox.Show("Operation Successfull", "CARGODESK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TxtRecepient.Text = "";
                TxtAddress.Text = "";
                TxtPhone.Text = "";
                cmbEquipment.Text = "";
                cmbOriginator.Text = "";
                cmbOriginatorNo.Text = "";
                cmbActivity.Text = "";
                richDescription.Text = "";
                richOSCond.Text = "";

                txtSysNome.Text = "";
                txtSubsysSerialNo.Text = "";
                txtMeterNo.Text = "";
                cmbTechnician.Text = "";
                richProblemStatus.Text = "";
                richAdditional.Text = "";
                txtProgramNome.Text = "";
                txtVersionNo.Text = "";
                txtSoftConfig.Text = "";
                RichRecommendation.Text = "";
                txtSysSerialNo.Text = "";
                txtSubSysNome.Text = "";
            }
        }
    }
}