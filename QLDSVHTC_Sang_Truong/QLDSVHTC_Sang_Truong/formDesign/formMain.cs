using DevExpress.XtraBars;
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
            formClasses classes = new formClasses();
            classes.Show(); 
        }

        private void btnReportTuition_ItemClick(object sender, ItemClickEventArgs e)
        {
            ReportTuitionFee report = new ReportTuitionFee();
            report.Show();
        }
    }
}