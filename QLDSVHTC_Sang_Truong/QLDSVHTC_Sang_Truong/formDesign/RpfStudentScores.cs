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
using QLDSVHTC_Sang_Truong.Report;
using DevExpress.XtraReports.UI;

namespace QLDSVHTC_Sang_Truong.formDesign
{
    public partial class RpfStudentScores : DevExpress.XtraEditors.XtraForm
    {
        String maSV = "";
        public RpfStudentScores()
        {
            InitializeComponent();
        }

        private void RpfStudentScores_Load(object sender, EventArgs e)
        {
            Program.bdsDSPM.Filter = "PHONGBAN LIKE 'KHOA%'";
            //chuyển dữ liệu từ danh sách phân mảnh vào cho combobox.
            func.BindingDataToComBo(cbDepartment, Program.bdsDSPM);
            if (Program.mGroup.Equals("KHOA"))
            {
                cbDepartment.Enabled = false;
            }
            else if (Program.mGroup.Equals("PGV"))
            {
                cbDepartment.Enabled = true;
            }
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet.SINHVIEN);

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet.LOP);

            this.v_DS_NIENKHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_DS_NIENKHOATableAdapter.Fill(this.qLDSV_TCDataSet.V_DS_NIENKHOA);

        }

        private void btnInDS_Click(object sender, EventArgs e)
        {
            try
            {
                maSV = ((DataRowView)bdsSINHVIEN[bdsSINHVIEN.Position])["MASV"].ToString();
            }
            catch
            {
                MessageBox.Show("Vui lòng click chọn sinh viên cần in điểm", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
            xrptStudentScores rpt = new xrptStudentScores(maSV);
            rpt.lbMaSV.Text = maSV;
            rpt.lbTenSV.Text = ((DataRowView)bdsSINHVIEN[bdsSINHVIEN.Position])["HO"].ToString()+" "+ ((DataRowView)bdsSINHVIEN[bdsSINHVIEN.Position])["TEN"].ToString();
            rpt.lbLop.Text = cbLop.SelectedValue.ToString();
            rpt.lbKhoa.Text = cbDepartment.Text;

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
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
                    MessageBox.Show("Lỗi chuyển khoa", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    try
                    {
                        this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet.SINHVIEN);

                        this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet.LOP);

                        this.v_DS_NIENKHOATableAdapter.Connection.ConnectionString = Program.connstr;
                        this.v_DS_NIENKHOATableAdapter.Fill(this.qLDSV_TCDataSet.V_DS_NIENKHOA);
                    }
                    catch (Exception) { }
                }


            }
            catch
            {
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}