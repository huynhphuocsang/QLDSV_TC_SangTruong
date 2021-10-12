using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSVHTC_Sang_Truong
{
    public partial class xrptTuitionFee : DevExpress.XtraReports.UI.XtraReport
    {
        public xrptTuitionFee()
        {
            InitializeComponent();
        }
        public xrptTuitionFee(string classId, string schoolYear, int semester)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = classId;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = schoolYear;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = semester;
            this.sqlDataSource1.Fill();
            
        }

    }
}
