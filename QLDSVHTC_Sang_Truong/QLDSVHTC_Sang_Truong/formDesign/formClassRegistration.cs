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

namespace QLDSVHTC_Sang_Truong
{
    public partial class formClassRegistration : DevExpress.XtraEditors.XtraForm
    {
        public formClassRegistration()
        {
            InitializeComponent();
        }

        private void formClassRegistration_Load(object sender, EventArgs e)
        {
            this.v_DS_NIENKHOATableAdapter.Connection.ConnectionString = Program.connstr; 
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet.V_DS_NIENKHOA' table. You can move, or remove it, as needed.
            this.v_DS_NIENKHOATableAdapter.Fill(this.qLDSV_TCDataSet.V_DS_NIENKHOA);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            try
            {
                this.qLDSV_TCDataSet.EnforceConstraints = false;
                this.sP_LOAD_REGISTER_INFORTableAdapter.Connection.ConnectionString = Program.connstr; 
                this.sP_LOAD_REGISTER_INFORTableAdapter.Fill(this.qLDSV_TCDataSet.SP_LOAD_REGISTER_INFOR, cbPhase.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(nbSemester.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}