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

namespace QLDSVHTC_Sang_Truong.formDesign
{
    public partial class formClasses : DevExpress.XtraEditors.XtraForm
    {
        public formClasses()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSV_TCDataSet);

        }

        private void formClasses_Load(object sender, EventArgs e)
        {

            Program.bdsDSPM.Filter = "PHONGBAN LIKE 'KHOA%'";

            //chuyển dữ liệu từ danh sách phân mảnh vào cho combobox.
            func.BindingDataToComBo(cbDepartment, Program.bdsDSPM);
            load(); 
            if (Program.mGroup.Equals("KHOA"))
            {
                cbDepartment.Enabled = false;
            }else if (Program.mGroup.Equals("PGV"))
            {
                cbDepartment.Enabled = true;
            }



            gridView1.Columns["MALOP"].Caption = "Mã lớp";
            gridView1.Columns["TENLOP"].Caption = "Tên lớp";
            gridView1.Columns["KHOAHOC"].Caption = "Khóa học";
            gridView1.Columns["MAKHOA"].Caption = "Mã khoa";


        }
        private void load()
        {
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet.LOP);
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
                    Program.mlogin = Program.mloginDN;
                }

                if (Program.KetNoi() == 0)
                {
                    MessageBox.Show("Lỗi chuyển khoa", "Thông báo !", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    try
                    {
                        load();

                    }
                    catch (Exception) { }
                }


            }
            catch
            {
                return;
            }

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void btnUndo_Click(object sender, EventArgs e)
        {

        }
    }
}