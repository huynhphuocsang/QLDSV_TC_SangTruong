using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using System.Data.SqlClient;

namespace QLDSVHTC_Sang_Truong.formDesign
{
    public partial class RpfTuitionFee : DevExpress.XtraEditors.XtraForm
    {
        private string departmentId; 
        public RpfTuitionFee()
        {
            InitializeComponent();
        }

        private void RpfTuitionFee_Load(object sender, EventArgs e)
        {
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet1.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet1.LOP);

            cbSchoolyear.SelectedIndex = 0;
            
            lkClass.Properties.PopulateColumns();
            lkClass.Properties.Columns["KHOAHOC"].Visible = false;
            lkClass.Properties.Columns["MAKHOA"].Visible = false;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (lkClass.EditValue == null)
            {
                MessageBox.Show("Vui lòng chọn lớp");
                return; 
            }
            string classId = lkClass.EditValue.ToString(); 
            
            string schoolYear = this.cbSchoolyear.Text;
            int semester = Convert.ToInt32(this.nmSemester.Value);


            //kiểm tra tên trước: 
            string queryName = "SELECT TENKHOA FROM KHOA WHERE MAKHOA = '"+departmentId+"'";
            SqlDataReader resultClassName = Program.ExecSqlDataReader(queryName);

            if (resultClassName == null)
            {
                MessageBox.Show("Server bị lỗi");
                resultClassName.Close();
                return; 
            }
            resultClassName.Read();
            string departmentName = resultClassName.GetString(0); 
            resultClassName.Close();
          



            xrptTuitionFee xrpt = new xrptTuitionFee(classId,schoolYear, semester);


            xrpt.xrlbClassId.Text = classId;
            xrpt.xrlbDeparment.Text = departmentName;
            xrpt.xrlbSchoolyear.Text = schoolYear;
            xrpt.xrlbSemester.Text = semester.ToString(); 


            ReportPrintTool printTool = new ReportPrintTool(xrpt);
            printTool.ShowPreviewDialog();
        }

        private void lkClass_EditValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.LookUpEdit editor = sender as DevExpress.XtraEditors.LookUpEdit;
            departmentId=(string) editor.GetColumnValue("MAKHOA");
        }
    }
}