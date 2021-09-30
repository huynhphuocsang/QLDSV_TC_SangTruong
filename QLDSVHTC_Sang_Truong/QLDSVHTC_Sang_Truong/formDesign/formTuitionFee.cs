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
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr; 
            this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet.SINHVIEN);

        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

            string studentCode = lookUpEdit1.GetColumnValue("MASV").ToString(); 
            string classCode =  lookUpEdit1.GetColumnValue("MALOP").ToString();
            string fullName = lookUpEdit1.GetColumnValue("HO").ToString() + " " + lookUpEdit1.GetColumnValue("TEN").ToString();

            txtClass.Text = classCode;
            txtFullname.Text = fullName;

            string temp = studentCode; 
            //this.sP_PAY_TUITIONFEETableAdapter.Connection.ConnectionString = Program.connstr; 
            //this.sP_PAY_TUITIONFEETableAdapter.Fill(this.qLDSV_TCDataSet1.SP_PAY_TUITIONFEE, studentCode);
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


    }
}