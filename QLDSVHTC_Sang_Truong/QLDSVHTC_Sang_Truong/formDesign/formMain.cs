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
            userRules();
        }

        //RULES 
        private void userRules()
        {
            if (Program.mGroup == "SV")
            {
                barBtnRegister.Enabled = true;
            }
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
            Form frm = this.CheckExists(typeof(formTuitionFee));
            if (frm != null) frm.Activate();
            else
            {
                formTuitionFee frmTuition = new formTuitionFee(); 
                frmTuition.MdiParent = this;
                frmTuition.Show(); 
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

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formClassRegistration));
            if (frm != null) frm.Activate();
            else
            {
                Program.frmRegister = new formClassRegistration();
                Program.frmRegister.MdiParent = this;
                Program.frmRegister.Show();
            }
        }

        private void btnCreditClass_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formManageCreditClass));
            if (frm != null) frm.Activate();
            else
            {
                formManageCreditClass form = new formManageCreditClass();
                 form.MdiParent = this;
                form.Show(); 
            }
        }

        private void barButtonItem2_ItemClick_1(object sender, ItemClickEventArgs e)
        {

            Form frm = this.CheckExists(typeof(formScores));
            if (frm != null) frm.Activate();
            else
            {
                formScores form = new formScores();
                form.MdiParent = this;
                form.Show();
            }

        }

        private void barButtonItem2_ItemClick_2(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formManagerSubject));
            if (frm != null) frm.Activate();
            else
            {
                formManagerSubject form = new formManagerSubject();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnCreateLogin_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formCreateLogin));
            if (frm != null) frm.Activate();
            else
            {
                formCreateLogin form = new formCreateLogin();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnRptCreditClass_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(RpfCreditClass));
            if (frm != null) frm.Activate();
            else
            {
                RpfCreditClass form = new RpfCreditClass();
                //form.MdiParent = this;
                form.Show();
            }
        }

        private void btnRptStudetList_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(RpfStudentListCreditClass));
            if (frm != null) frm.Activate();
            else
            {
                RpfStudentListCreditClass form = new RpfStudentListCreditClass();
                //form.MdiParent = this;
                form.Show();
            }
        }

        private void btnRptTuitionFee_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(RpfTuitionFee));
            if (frm != null) frm.Activate();
            else
            {
                RpfTuitionFee form = new RpfTuitionFee();
                //form.MdiParent = this;
                form.Show();
            }
        }
    }
}