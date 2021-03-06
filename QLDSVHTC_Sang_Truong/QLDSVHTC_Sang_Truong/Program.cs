using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraEditors;
using QLDSVHTC_Sang_Truong.formDesign;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QLDSVHTC_Sang_Truong
{
    static class Program
    {
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static SqlCommand sqlcmd = new SqlCommand();
        //=======================================================================================================mode lấy tk của user window
        public static String constr_publisher = "Data Source=DESKTOP-PCNAJ04\\MSSQL14; Initial Catalog=QLDSV_TC; Integrated Security=true";

        public static SqlDataReader myReader;
        public static String servername = "";
        public static String username = ""; //thực sự là mã nhân viên: do ta gán username chính là mã nhân viên
        public static String mlogin = "";
        public static String pass = "";

        public static String database = "QLDSV_TC";
        public static String remoteLogin = "HTKN"; //kết nối site khác
        public static String remotePass = "123"; //kết nối site khác
        public static String mloginDN = ""; //loginname hiện tại
        public static String passDN = "";//pass hiện tại
        public static String mGroup = ""; //khoa-pgv-pkt
        public static String mHoten = "";
        public static int mPhongBan = 0;//khoa cntt hay vt
         

        public static BindingSource bdsDSPM = new BindingSource();//dùng để giữ ds phân mảnh khi login
        public static formDesign.formLogin frmLogin; 
        public static  formDesign.formMain frmChinh;
        public static formDesign.formClasses frmClasses;
        public static formClassRegistration frmRegister;
        public static formScores frmScores;
        public static formManagerSubject frmSubject;

        public static int chiPhi = 480000;  //tiền học/1 tín

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]



        public static int KetNoi(Boolean isShow = true)
        {
            if (Program.connstr != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                    Program.database + ";User ID=" +
                    Program.mlogin + ";password=" + Program.pass;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }
            catch (Exception e)
            {
                if(isShow)  XtraMessageBox.Show("Vui lòng xem lại user name và password\n", "Lỗi đăng nhập", MessageBoxButtons.OK);
                return 0;
            }
        }

        public static SqlDataReader ExecSqlDataReader(String strCmd)
        {
            SqlDataReader myreader;
            SqlCommand sqlCmd = new SqlCommand(strCmd, Program.conn);
            sqlCmd.CommandType = CommandType.Text;

            //cực kỳ quan trọng, nếu không có sẽ bị sai: 
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
            try
            {
                conn.ConnectionString = Program.connstr;
                conn.Open(); 
            //if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                myreader = sqlCmd.ExecuteReader();
                return myreader;
            }
            catch (SqlException e)
            {
                Program.conn.Close();
                MessageBox.Show(e.Message);
                return null;
            }
            
        }

        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static int ExecSqlNonQuery(String strLenh)
        {
            SqlCommand sqlCmd = new SqlCommand(strLenh, conn);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandTimeout = 600;//10p;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sqlCmd.ExecuteNonQuery();
                conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State;
            }
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins(); 

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin = new formDesign.formLogin(); 
            Application.Run(frmLogin);
        }
    }
}
