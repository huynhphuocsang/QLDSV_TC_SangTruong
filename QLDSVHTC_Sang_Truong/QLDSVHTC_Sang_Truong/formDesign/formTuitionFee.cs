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
    public partial class formTuitionFee : DevExpress.XtraEditors.XtraForm
    {
        

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
            string studentCode = lkStudent.GetColumnValue("MASV").ToString();
            string classCode = lkStudent.GetColumnValue("MALOP").ToString();
            string fullName = lkStudent.GetColumnValue("HO").ToString() + " " + lkStudent.GetColumnValue("TEN").ToString();

            txtClass.Text = classCode;
            txtFullname.Text = fullName;

            string temp = studentCode;
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
            string masv = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NIENKHOA").ToString();
            txtShoolYear.Text = masv; 
        }

        private void sP_PAY_TUITIONFEEGridControl_MouseClick(object sender, MouseEventArgs e)
        {
            string masv = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NIENKHOA").ToString();
            txtShoolYear.Text = masv;
        }

        private void sP_PAY_TUITIONFEEGridControl_MouseDown(object sender, MouseEventArgs e)
        {
            string schoolYear = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NIENKHOA").ToString();
            string semester = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HOCKY").ToString();
            string total = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HOCPHI").ToString();
            string payed = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "PADED").ToString();
            int remain = int.Parse(total) - int.Parse(payed); 
            txtShoolYear.Text = schoolYear;
            txtSemester.Text = semester;
            nmMoney.Value = remain; 
        }

        

        private void sP_PAY_TUITIONFEEGridControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string schoolYear = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NIENKHOA").ToString();
            string semester = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HOCKY").ToString();
            string total = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HOCPHI").ToString();
            string payed = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "PADED").ToString();
            int remain = int.Parse(total) - int.Parse(payed);
            txtShoolYear.Text = schoolYear;
            txtSemester.Text = semester;
            nmMoney.Value = remain;
        }
    }
}