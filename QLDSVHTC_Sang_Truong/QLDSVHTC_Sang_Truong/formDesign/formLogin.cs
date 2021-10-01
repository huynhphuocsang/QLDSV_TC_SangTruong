using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace QLDSVHTC_Sang_Truong.formDesign
{
    public partial class formLogin : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection conn_publisher = new SqlConnection();
        String loginNameSV = "";
        String passSV = "";
        //private String regexStudent = "N(([0-1][1-9])|([2][0]))[a-zA-Z]{4}\\d{3}";
        public Boolean isStudent = false;

        private void LayDSPM(String cmd)
        {
            DataTable dt = new DataTable();

            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);
            conn_publisher.Close();
            Program.bdsDSPM.DataSource = dt;
            cbPhongBan.DataSource = Program.bdsDSPM;
            cbPhongBan.DisplayMember = "PHONGBAN";
            cbPhongBan.ValueMember = "TENSERVER";
        }
        private int KetNoi_CSDLGoc()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
                conn_publisher.Close();
            try
            {
                conn_publisher.ConnectionString = Program.constr_publisher;
                conn_publisher.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối\n" + e.Message);
                return 0;
            }
        }
        public formLogin()
        {
            InitializeComponent();
        }

        private void fromLogin_Load(object sender, EventArgs e)
        {
            skins();
            if (KetNoi_CSDLGoc() == 0) return;
            LayDSPM("SELECT * FROM V_DS_PHANMANH");
            cbPhongBan.SelectedIndex = 1; cbPhongBan.SelectedIndex = 0;
            
            txtPass.Properties.UseSystemPasswordChar = true; 
        }


        public void loadAgain()
        {
            cbPhongBan.SelectedItem = Program.mGroup;
            Program.servername = cbPhongBan.SelectedValue.ToString(); 
        }

        public void skins()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Office 2019 Colorful";

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtTK.Text.Trim() == "" || txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản và mật khẩu không hợp lệ", "", MessageBoxButtons.OK);
                return;
            }
            /*if (Regex.IsMatch(txtTK.Text.ToUpper(), regexStudent))
            {
                Program.mlogin = "Student";
                Program.pass = "123456";
                isStudent = true;
            }*/
            Program.mlogin = txtTK.Text;
            Program.pass = txtPass.Text;
            if (Program.KetNoi(false) == 1)
            {
                String strCmd = "EXEC SP_DANGNHAP '" + Program.mlogin + "'";
                Program.myReader = Program.ExecSqlDataReader(strCmd);
            }
            else
            {
                Program.mlogin = "Student";
                Program.pass = "123456";
                loginNameSV = txtTK.Text;
                passSV = txtPass.Text;

                if(Program.KetNoi()==0) return;//site 3'

                String strCmd = "EXEC SP_LOGIN_SV '" + Program.mlogin + "', '"+loginNameSV+"','"+passSV+"'";
                Program.myReader = Program.ExecSqlDataReader(strCmd);
            }
            
            Program.mPhongBan = cbPhongBan.SelectedIndex;
            Program.mloginDN = Program.mlogin;
            Program.passDN = Program.pass;
            if (Program.myReader == null) return; 
            
            Program.myReader.Read();
            try
            {
                Program.username = Program.myReader.GetString(0);
                if (Convert.IsDBNull(Program.username))
                {
                    MessageBox.Show("Login không có quyền truy cập dữ liệu", "", MessageBoxButtons.OK);
                    return;
                }
                Program.mHoten = Program.myReader.GetString(1);
                Program.mGroup = Program.myReader.GetString(2);
                Program.myReader.Close();
                Program.frmChinh = new formMain();
                Program.frmChinh.statusMa.Text = Program.username;
                Program.frmChinh.statusTen.Text = Program.mHoten;
                Program.frmChinh.statusNhom.Text = Program.mGroup;
                this.Visible = false;
                Program.frmChinh.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ", "", MessageBoxButtons.OK);
                return;
            }
           
            
        }

        private void cbPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cbPhongBan.SelectedValue.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void ckPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckPass.Checked)
            {
                txtPass.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.Properties.UseSystemPasswordChar = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}