using DevExpress.XtraBars;
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
    public partial class formMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void bntManageClass_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formClasses));
            if (frm != null) frm.Activate();
            else {
                Program.frmClasses = new formClasses();
                Program.frmClasses.MdiParent = this;
                Program.frmClasses.Show(); 
            }
            
        }

        private void btnReportTuition_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(ReportTuitionFee));
            if (frm != null) frm.Activate();
            else
            {
                Program.tutionFee = new ReportTuitionFee(); 
                Program.tutionFee.MdiParent = this;
                Program.tutionFee.Show();
            }
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }

        private void btnLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dialog = XtraMessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo!", MessageBoxButtons.YesNo); 
            if(dialog == DialogResult.Yes)
            {
                Close();
                Program.frmLogin.Visible = true; 
                Program.bdsDSPM.RemoveFilter();
                Program.frmLogin.loadAgain(); 
            }
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void formMain_Load(object sender, EventArgs e)
        {
            
        }
    }
}