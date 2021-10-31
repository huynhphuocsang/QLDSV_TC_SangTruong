using DevExpress.XtraEditors;
using QLDSVHTC_Sang_Truong.Report;
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
    public partial class RpfClassScores : DevExpress.XtraEditors.XtraForm
    {
        String maLop = "";
        public RpfClassScores()
        {
            InitializeComponent();
        }

        private void RpfClassScores_Load(object sender, EventArgs e)
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
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr; 
            this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet.LOP);

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
                        this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet.LOP);
                    }
                    catch (Exception) { }
                }


            }
            catch
            {
                return;
            }
        }

        private void btnInDS_Click(object sender, EventArgs e)
        {
            try
            {
                maLop = ((DataRowView)bdsLOP[bdsLOP.Position])["MALOP"].ToString();
            }
            catch
            {
                MessageBox.Show("Vui lòng click lớp cần in điểm", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            xrptClassScores rpt = new xrptClassScores(maLop);
            rpt.lbLop.Text = "LỚP: "+maLop+" - KHÓA HỌC: "+ ((DataRowView)bdsLOP[bdsLOP.Position])["KHOAHOC"].ToString();
            rpt.lbKhoa.Text ="KHOA: "+cbDepartment.Text;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}