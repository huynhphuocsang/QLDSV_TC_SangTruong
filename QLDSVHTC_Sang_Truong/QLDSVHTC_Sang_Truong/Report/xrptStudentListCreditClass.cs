using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSVHTC_Sang_Truong
{
    public partial class xrptStudentListCreditClass : DevExpress.XtraReports.UI.XtraReport
    {
        public xrptStudentListCreditClass()
        {
            InitializeComponent();
        }
        public xrptStudentListCreditClass(string schoolYear, int semester, string subjectCode,int group)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = schoolYear;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = semester;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = subjectCode;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = group;
            this.sqlDataSource1.Fill();
        }
    }
}
