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
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraReports.UI;
using System.Data.SqlClient;
namespace QLDSVHTC_Sang_Truong.formDesign
{
    public partial class RpfStudentListCreditClass : DevExpress.XtraEditors.XtraForm
    {
        public RpfStudentListCreditClass()
        {
            InitializeComponent();
            
        }

        private void RpfStudentListCreditClass_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.qLDSV_TCDataSet.MONHOC);
            Program.bdsDSPM.Filter = "PHONGBAN LIKE 'KHOA%'";

            //chuyển dữ liệu từ danh sách phân mảnh vào cho combobox.
            func.BindingDataToComBo(cbDepartment, Program.bdsDSPM);

            cbSchoolyear.SelectedIndex = 0;
            lkSubject.Properties.PopulateColumns(); 
            lkSubject.Properties.Columns["SOTIET_LT"].Visible = false;
            lkSubject.Properties.Columns["SOTIET_TH"].Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbDepartment.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    Program.servername = cbDepartment.SelectedValue.ToString();
                }
                if (cbDepartment.SelectedIndex != Program.mPhongBan)
                {
                    Program.mlogin = Program.remoteLogin;
                    Program.pass = Program.remotePass;
                }
                else
                {
                    Program.mlogin = Program.mloginDN;
                    Program.pass = Program.passDN;
                }

                if (Program.KetNoi() == 0)
                {
                    MessageBox.Show("Lỗi chuyển khoa", "Thông báo !", MessageBoxButtons.OK);
                    return;
                }


            }
            catch
            {
                return;
            }
        }

        private void lkSubject_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            //RepositoryItemLookUpEdit props;
            //if (sender is LookUpEdit)
            //    props = (sender as LookUpEdit).Properties;
            //else
            //    props = sender as RepositoryItemLookUpEdit;

            //if (props != null && (e.Value is string))
            //{
            //    DataRowView row = props.GetDataSourceRowByKeyValue(e.Value) as DataRowView;

            //    if (row != null)
            //    {
            //        e.DisplayText = String.Format("{0} {1}", row["MAMH"], row["TENMH"]);

            //    }
            //}
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            string schoolYear = this.cbSchoolyear.Text;
            int semester = Convert.ToInt32(this.nmSemester.Value);
            string subjectName = lkSubject.Text;
            string subjectCode = lkSubject.EditValue.ToString(); 
            int group = Convert.ToInt32(nmGroup.Value); 

            xrptStudentListCreditClass xrpt = new xrptStudentListCreditClass(schoolYear,semester,subjectCode,group); 

            //xrpt.xrlbDepartment.Text = cbDepartment.Text;
            
            if (cbDepartment.SelectedIndex == 0) xrpt.xrlbDepartment.Text = "Công nghệ thông tin";
            else xrpt.xrlbDepartment.Text = "Viễn thông";
            xrpt.xrlbSchoolyear.Text = cbSchoolyear.Text; 
            xrpt.xrlbSemester.Text = semester.ToString();
            xrpt.xrlbSubject.Text = subjectName;
            xrpt.xrlbGroup.Text = group.ToString(); 

            ReportPrintTool printTool = new ReportPrintTool(xrpt);
            printTool.ShowPreviewDialog();
        }
    }
}