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
    public partial class formCreateLogin : DevExpress.XtraEditors.XtraForm
    {
        String nLogin = "";
        String nPass = "";
        String nUserName = "";
        String nRole = "";
        public formCreateLogin()
        {
            InitializeComponent();
        }

        private void formCreateLogin_Load(object sender, EventArgs e)
        {
           
            if (Program.mGroup.ToLower() == "khoa" || Program.mGroup.ToLower() == "pkt")
            {
                cbDepartment.Enabled = false;
                func.BindingDataToComBo(cbDepartment, Program.bdsDSPM);
                if (Program.mGroup.ToLower() == "khoa")
                {
                    cbDepartment.SelectedIndex = Program.mPhongBan;
                    NhomQuyenGroup.SelectedIndex = 1;
                    NhomQuyenGroup.Properties.Items[0].Enabled = NhomQuyenGroup.Properties.Items[2].Enabled = false;
                }
                else if (Program.mGroup.ToLower() == "pkt")
                {
                    NhomQuyenGroup.Enabled = false;
                    NhomQuyenGroup.SelectedIndex = 2;
                }
            }
            else if (Program.mGroup.ToLower() == "pgv")
            {
                Program.bdsDSPM.Filter = "PHONGBAN LIKE 'KHOA%'";
                func.BindingDataToComBo(cbDepartment, Program.bdsDSPM);
                NhomQuyenGroup.Properties.Items[2].Enabled = false;
            }

            this.qLDSV_TCDataSet.EnforceConstraints = false;
            this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet.GIANGVIEN' table. You can move, or remove it, as needed.
            this.gIANGVIENTableAdapter.Fill(this.qLDSV_TCDataSet.GIANGVIEN);

        }

        private bool Validated()
        {
            bool isValid = true;

            errorProvider.Clear();

            if (txtLogin.Text.Trim() == "")
            {
                this.errorProvider.SetError(this.txtLogin, "Vui lòng nhập tên login !");
                isValid = false;
            }
            else if (txtLogin.Text.Contains(" "))
            {
                this.errorProvider.SetError(this.txtLogin, "Tên login không được chứa khoảng trắng !");
                txtLogin.Focus();
                isValid = false;
            }

            if (txtPass.Text.Trim() == "")
            {
                this.errorProvider.SetError(this.txtPass, "Vui lòng nhập mật khẩu");
                isValid = false;
            }
            else if (txtConfirm.Text.Trim() == "")
            {
                this.errorProvider.SetError(this.txtConfirm, "Vui lòng nhập mật khẩu");
                isValid = false;
            }
            else if (txtConfirm.Text != txtPass.Text)
            {
                this.errorProvider.SetError(this.txtConfirm, "Mật khẩu không khớp");
                txtConfirm.Focus();
                isValid = false;
            }
            if (lookUpUser.EditValue == null)
            {
                this.errorProvider.SetError(this.lookUpUser, "Vui lòng chọn giảng viên");
                isValid = false;
            }
            return isValid;
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
            }
            catch
            {
                return;
            }
        }

        private void lookUpUser_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void taoLogin_Click(object sender, EventArgs e)
        {
            bool check = this.Validated();
            if (check)
            {

                nLogin = txtLogin.Text.Trim();
                nPass = txtPass.Text.Trim();
                nUserName = lookUpUser.EditValue.ToString();
                nRole = NhomQuyenGroup.EditValue.ToString();

                string strLenh = "DECLARE @A INT \n"
                    + "EXEC  @A= SP_TAOLOGIN '" + nLogin + "','" + nPass + "','" + nUserName + "','" + nRole + "'\n"
                    + "SELECT K=@A ";
                //string strLenh = "EXEC SP_TAOLOGIN '" + nLogin + "','" + nPass + "','" + nUserName + "','" + nRole + "'";
                try
                {
                    Program.myReader = Program.ExecSqlDataReader(strLenh);
                    if (Program.myReader == null) return;
                    Program.myReader.Read();
                    int noti = Program.myReader.GetInt32(0);
                    if (noti == 1)
                    {
                        MessageBox.Show("Trùng TÊN ĐĂNG NHẬP", "Thông báo !", MessageBoxButtons.OK);
                    }
                    else if (noti == 2)
                    {
                        MessageBox.Show("Giảng viên đã có tài khoản", "Thông báo !", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Tạo tài khoản thành công", "Thông báo !", MessageBoxButtons.OK);
                    }
                    Program.myReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tạo tài khoản!\r\n"+ex.Message, "Thông báo !", MessageBoxButtons.OK);
                    return;
                }
            }
            else { return; }
        }

        private void PassWord_CheckedChanged(object sender, EventArgs e)
        {
            if (PassWord.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void showConfirmPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showConfirmPass.Checked)
            {
                txtConfirm.UseSystemPasswordChar = false;
            }
            else
            {
                txtConfirm.UseSystemPasswordChar = true;
            }
        }
    }
}