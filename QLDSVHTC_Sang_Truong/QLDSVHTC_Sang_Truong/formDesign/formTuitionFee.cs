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
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet1.SINHVIEN' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter1.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter1.Fill(this.qLDSV_TCDataSet1.SINHVIEN);

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
    }
}