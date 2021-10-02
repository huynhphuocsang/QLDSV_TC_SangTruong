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
using DevExpress.XtraGrid.Views.Grid; 

namespace QLDSVHTC_Sang_Truong.formDesign
{
    public partial class formTuitionFee : DevExpress.XtraEditors.XtraForm
    {


        private string studentCode="";
        private string schoolYear;
        private string semester;
        private string fullName; 
        public formTuitionFee()
        {
            InitializeComponent();
        }

        private void btnShowDetail_Click(object sender, EventArgs e)
        {

        }

        private void formTuitionFee_Load(object sender, EventArgs e)
        {
          
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr; 
            this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet1.SINHVIEN);
            gridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;

            gridView1.Columns["NIENKHOA"].OptionsColumn.ReadOnly = true;
            gridView1.Columns["HOCKY"].OptionsColumn.ReadOnly = true;
            gridView1.Columns["HOCPHI"].OptionsColumn.ReadOnly = true;
            gridView1.Columns["PADED"].OptionsColumn.ReadOnly = true;

            gridView2.Columns["NGAYDONG"].OptionsColumn.ReadOnly = true;
            gridView2.Columns["SOTIENDONG"].OptionsColumn.ReadOnly = true;
            btnPay.Enabled = false; 
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

            
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void lkStudent_EditValueChanged(object sender, EventArgs e)
        {
            studentCode = lkStudent.GetColumnValue("MASV").ToString();
            string classCode = lkStudent.GetColumnValue("MALOP").ToString();
            fullName = lkStudent.GetColumnValue("HO").ToString() + " " + lkStudent.GetColumnValue("TEN").ToString();

            txtClass.Text = classCode;
            txtFullname.Text = fullName;

            
            this.sP_PAY_TUITIONFEETableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_PAY_TUITIONFEETableAdapter.Fill(this.qLDSV_TCDataSet1.SP_PAY_TUITIONFEE, studentCode);
        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
              
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtFullname_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtClass_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click_3(object sender, EventArgs e)
        {
            try
            {
                //this.sP_SHOW_DETAIL_TUITIONFEETableAdapter.Fill(this.qLDSV_TCDataSet1.SP_SHOW_DETAIL_TUITIONFEE, maToolStripTextBox.Text, nienkhoaToolStripTextBox.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(hockyToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void sP_PAY_TUITIONFEEGridControl_Click(object sender, EventArgs e)
        {
           
        }

        private void sP_PAY_TUITIONFEEGridControl_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void sP_PAY_TUITIONFEEGridControl_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        

        private void sP_PAY_TUITIONFEEGridControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            nmMoney.Maximum = 1000000000;
            studentCode = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MASV").ToString();
            schoolYear = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NIENKHOA").ToString();
            semester = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HOCKY").ToString();
            string total = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HOCPHI").ToString();
            string payed = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "PADED").ToString();
            int remain = int.Parse(total) - int.Parse(payed);
            txtShoolYear.Text = schoolYear;
            txtSemester.Text = semester;
            nmMoney.Value = remain;
            nmMoney.Maximum = remain;
            if (nmMoney.Value == 0)
            {
                btnPay.Enabled = false;
            }
            else
            {
                btnPay.Enabled = true; 
            }

            this.sP_SHOW_DETAIL_TUITIONFEETableAdapter.Connection.ConnectionString = Program.connstr; 
            this.sP_SHOW_DETAIL_TUITIONFEETableAdapter.Fill(this.qLDSV_TCDataSet1.SP_SHOW_DETAIL_TUITIONFEE, studentCode, schoolYear, new System.Nullable<int>((int.Parse(semester))));
        }

        private void fillToolStripButton_Click_4(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            int money = Convert.ToInt32(nmMoney.Value);
            DialogResult dialog = XtraMessageBox.Show("Bạn cần kiểm tra trước khi thanh toán:\n\nMSSV:"+studentCode+"\n\nHọ và tên:"+fullName+" \n\nSố tiền thanh toán: "+ String.Format("{0:n0}",money)+" VND"
                , "Thông báo!", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                DateTime datetime = DateTime.Now;

                //đăng ký
                String str_sp = "dbo.SP_PAY_TUITION_MONEY";
                Program.sqlcmd = Program.conn.CreateCommand();
                Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.sqlcmd.CommandText = str_sp;
                Program.sqlcmd.Parameters.Add("@Ma", SqlDbType.NChar).Value = this.studentCode;
                Program.sqlcmd.Parameters.Add("@Nienkhoa", SqlDbType.NChar).Value = this.schoolYear;
                Program.sqlcmd.Parameters.Add("@Hocky", SqlDbType.Int).Value = int.Parse(this.semester);
                Program.sqlcmd.Parameters.Add("@Ngaydong", SqlDbType.DateTime).Value = datetime;
                Program.sqlcmd.Parameters.Add("@Sotiendong", SqlDbType.Int).Value = money;
                //cần phải mở kết nổi trước, nếu không đôi khi sẽ bị lỗi
                Program.sqlcmd.ExecuteNonQuery();
                Program.conn.Close();

                //reload: 
                this.sP_PAY_TUITIONFEETableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_PAY_TUITIONFEETableAdapter.Fill(this.qLDSV_TCDataSet1.SP_PAY_TUITIONFEE, studentCode);
                this.sP_SHOW_DETAIL_TUITIONFEETableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_SHOW_DETAIL_TUITIONFEETableAdapter.Fill(this.qLDSV_TCDataSet1.SP_SHOW_DETAIL_TUITIONFEE, studentCode, schoolYear, new System.Nullable<int>((int.Parse(semester))));


            }
            else
            {
                DialogResult dialog2 = XtraMessageBox.Show("Thao tác thanh toán đã hủy!", "Thông báo!", MessageBoxButtons.OK);
            }

            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtShoolYear.Text = "";
            txtSemester.Text = "";
            nmMoney.Value = 0;
            btnPay.Enabled = false;
        }

        
        private void sP_PAY_TUITIONFEEGridControl_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string total = view.GetRowCellDisplayText(e.RowHandle, view.Columns["HOCPHI"]);
                string payed = view.GetRowCellDisplayText(e.RowHandle, view.Columns["PADED"]);
                int remain = int.Parse(total) - int.Parse(payed);
                if (remain != 0)
                {
                    e.Appearance.BackColor = Color.FromArgb(150, Color.LightCoral);
                    e.Appearance.BackColor2 = Color.FromArgb(150, Color.LightCoral);
                }
            }


        }
    }
}