using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSVHTC_Sang_Truong
{
    public partial class formClassRegistration : DevExpress.XtraEditors.XtraForm
    {
        private CommandManager cmdManager;
        public formClassRegistration()
        {
            InitializeComponent();
            cmdManager= new CommandManager();
        }

        private void formClassRegistration_Load(object sender, EventArgs e)
        {
            this.v_DS_NIENKHOATableAdapter.Connection.ConnectionString = Program.connstr; 
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet.V_DS_NIENKHOA' table. You can move, or remove it, as needed.
            this.v_DS_NIENKHOATableAdapter.Fill(this.qLDSV_TCDataSet.V_DS_NIENKHOA);
            execSP_DS_DKY_SV();
        }
        private void execSP_LOAD_REGISTER_INFOR()
        {
            try
            {
                this.qLDSV_TCDataSet.EnforceConstraints = false;
                this.sP_LOAD_REGISTER_INFORTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_LOAD_REGISTER_INFORTableAdapter.Fill(this.qLDSV_TCDataSet.SP_LOAD_REGISTER_INFOR, cbPhase.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(nbSemester.Value, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void execSP_DS_DKY_SV()
        {
            try
            {
                this.qLDSV_TCDataSet.EnforceConstraints = false;
                this.sP_DS_DKY_SVTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_DS_DKY_SVTableAdapter.Fill(this.qLDSV_TCDataSet.SP_DS_DKY_SV, Program.frmChinh.statusMa.Text, cbPhase.Text, Int32.Parse(nbSemester.Value.ToString()),Program.chiPhi);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            
        }


        private void nbSemester_ValueChanged(object sender, EventArgs e)
        {
            execSP_LOAD_REGISTER_INFOR();
            execSP_DS_DKY_SV();
        }

        private void cbPhase_EditValueChanged_1(object sender, EventArgs e)
        {
            execSP_LOAD_REGISTER_INFOR();
            execSP_DS_DKY_SV();
        }

        private void gridConSp_LOAD_REGISTER_INFOR_Click(object sender, EventArgs e)
        {

            
        }

        private void gridViewSpLoadRegister_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
           //lbDebug.Text= gridViewSpLoadRegister.GetRowCellValue(gridViewSpLoadRegister.FocusedRowHandle, "MALTC").ToString();
        }

        private void barBtnDky_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            if (txtMaMH.Text == "")
            {
                MessageBox.Show("Vui lòng chọn môn học ");
                return;
            }

            //lấy mã lớp tín chỉ
            String maLTC= gridViewSpLoadRegister.GetRowCellValue(gridViewSpLoadRegister.FocusedRowHandle, "MALTC").ToString();
            
           /* //so sánh vs danh sách đã đăng ký để kt trùng
            for (int i = 0; i < bdsSP_DS_DKY_SV.Count; i++)
            {
                DataRow dr = gridView1.GetDataRow(i);
                if (dr["MAMH"].ToString().Equals(txtMaMH.Text) && dr["NIENKHOA"].ToString().Equals(cbPhase.Text) 
                    && dr["HOCKY"].ToString().Equals(nbSemester.Value.ToString()))
                {
                    MessageBox.Show("Sinh viên đã đăng ký môn này");
                    return;
                }
            }*/

            //đăng ký
            String str_sp = "dbo.SP_DKY_LOPTINCHI";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = str_sp;
            Program.sqlcmd.Parameters.Add("@MALTC", SqlDbType.Int).Value = maLTC;
            Program.sqlcmd.Parameters.Add("@MASV", SqlDbType.NChar).Value = Program.frmChinh.statusMa.Text;
            Program.sqlcmd.Parameters.Add("@CHIPHI", SqlDbType.Int).Value = Program.chiPhi;

            try
            {
                Program.sqlcmd.ExecuteNonQuery();
               
            }
            catch (SqlException ex)
            {
                XtraMessageBox.Show(ex.Message, "Lỗi đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Program.conn.Close();
            }
            
            execSP_DS_DKY_SV();
        }

        private void gridView1_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {
            
        }

        private void xoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            String maLTC = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MALTC").ToString();
            String str_sp = "dbo.SP_DELETE_DKY_SV";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = str_sp;
            Program.sqlcmd.Parameters.Add("@MALTC", SqlDbType.Int).Value = maLTC;
            Program.sqlcmd.Parameters.Add("@MASV", SqlDbType.NChar).Value = Program.frmChinh.statusMa.Text;
            Program.sqlcmd.Parameters.Add("@CHIPHI", SqlDbType.Int).Value = Program.chiPhi;

            try 
            {
                Program.sqlcmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                XtraMessageBox.Show(ex.Message, "Lỗi hủy đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Program.conn.Close();
            }
           

            execSP_DS_DKY_SV();
        }

        private void gridView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(sP_DS_DKY_SVGridControl, e.Location);
            }
        }
    }
}