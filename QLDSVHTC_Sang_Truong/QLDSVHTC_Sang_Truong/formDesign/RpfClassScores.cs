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
using QLDSVHTC_Sang_Truong.Report;

namespace QLDSVHTC_Sang_Truong.formDesign
{
    public partial class RpfClassScores : DevExpress.XtraEditors.XtraForm
    {
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

            this.v_DS_NIENKHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_DS_NIENKHOATableAdapter.Fill(this.qLDSV_TCDataSet.V_DS_NIENKHOA);
            this.dS_MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dS_MONHOCTableAdapter.Fill(this.qLDSV_TCDataSet.DS_MONHOC);


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
                        this.v_DS_NIENKHOATableAdapter.Connection.ConnectionString = Program.connstr;
                        this.v_DS_NIENKHOATableAdapter.Fill(this.qLDSV_TCDataSet.V_DS_NIENKHOA);
                        this.dS_MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.dS_MONHOCTableAdapter.Fill(this.qLDSV_TCDataSet.DS_MONHOC);
                    }
                    catch (Exception) { }
                }


            }
            catch
            {
                return;
            }
        }

        private void cbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnInDS_Click(object sender, EventArgs e)
        {
            xrptClassScores rpt = new xrptClassScores(cbNienkhoa.Text, Int32.Parse(cbHocky.Value.ToString()), cbMonHoc.SelectedValue.ToString(), Int32.Parse(cbNhom.Value.ToString()));

            rpt.lbKhoa.Text = cbDepartment.Text;
            rpt.lbNienKhoa.Text = cbNienkhoa.Text;
            rpt.lbHocKy.Text = cbHocky.Text;
            rpt.lbMonHoc.Text = cbMonHoc.Text;
            rpt.lbNhom.Text = cbNhom.Text;

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}