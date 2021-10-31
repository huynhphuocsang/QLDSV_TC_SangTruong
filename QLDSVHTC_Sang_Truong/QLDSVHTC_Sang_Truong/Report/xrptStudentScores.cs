using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSVHTC_Sang_Truong.Report
{
    public partial class xrptStudentScores : DevExpress.XtraReports.UI.XtraReport
    {
        public xrptStudentScores(String maSV)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = maSV;
            this.sqlDataSource1.Fill();
        }

        public static implicit operator ReportUnit(xrptStudentScores v)
        {
            throw new NotImplementedException();
        }
    }
}
