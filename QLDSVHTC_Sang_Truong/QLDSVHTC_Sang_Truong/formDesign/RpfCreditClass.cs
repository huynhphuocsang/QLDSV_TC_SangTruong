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
namespace QLDSVHTC_Sang_Truong.formDesign
{
    public partial class RpfCreditClass : DevExpress.XtraEditors.XtraForm
    {
        public RpfCreditClass()
        {
            InitializeComponent();
        }

        private void RpfCreditClass_Load(object sender, EventArgs e)
        {
            Program.bdsDSPM.Filter = "PHONGBAN LIKE 'KHOA%'";

            //chuyển dữ liệu từ danh sách phân mảnh vào cho combobox.
            func.BindingDataToComBo(cbDepartment, Program.bdsDSPM);

            cbxSchoolyear.SelectedIndex = 0; 
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

        private void btnPreview_Click(object sender, EventArgs e)
        {
            string schoolYear = this.cbxSchoolyear.Text;
            int semester =Convert.ToInt32(this.nmSemester.Value);

            xrptCreditClass xrpt = new xrptCreditClass(schoolYear,semester);

            //xrpt.xrlbDepartment.Text = cbDepartment.Text;  
            if (cbDepartment.SelectedIndex == 0) xrpt.xrlbDepartment.Text = "Công nghệ thông tin";
            else xrpt.xrlbDepartment.Text = "Viễn thông"; 
            xrpt.xrlbShoolyear.Text = schoolYear;
            xrpt.xrlbSemester.Text = semester.ToString();

            ReportPrintTool printTool = new ReportPrintTool(xrpt);
            printTool.ShowPreviewDialog(); 
        }
    }
}