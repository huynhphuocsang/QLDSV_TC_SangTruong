
namespace QLDSVHTC_Sang_Truong.Report
{
    partial class xrptCreditClass
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xrptCreditClass));
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.pageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrlbSemester = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlbShoolyear = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlbDepartment = new DevExpress.XtraReports.UI.XRLabel();
            this.label1 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table1 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableIndex = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.table2 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrCellIndex = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.calculatedField1 = new DevExpress.XtraReports.UI.CalculatedField();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.qldsV_TCDataSet1 = new QLDSVHTC_Sang_Truong.QLDSV_TCDataSet();
            this.dANGKYTableAdapter = new QLDSVHTC_Sang_Truong.QLDSV_TCDataSetTableAdapters.DANGKYTableAdapter();
            this.qldsV_TCDataSet21 = new QLDSVHTC_Sang_Truong.QLDSV_TCDataSet2();
            this.qldsV_TCDataSet22 = new QLDSVHTC_Sang_Truong.QLDSV_TCDataSet2();
            this.qldsV_TCDataSet23 = new QLDSVHTC_Sang_Truong.QLDSV_TCDataSet2();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qldsV_TCDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qldsV_TCDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qldsV_TCDataSet22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qldsV_TCDataSet23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "QLDSV_TCConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "SP_REPORT_LOPTINCHI";
            queryParameter1.Name = "@Nienkhoa";
            queryParameter1.Type = typeof(string);
            queryParameter1.ValueInfo = "2021-2022";
            queryParameter2.Name = "@Hocky";
            queryParameter2.Type = typeof(int);
            queryParameter2.ValueInfo = "1";
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.Parameters.Add(queryParameter2);
            storedProcQuery1.StoredProcName = "SP_REPORT_LOPTINCHI";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.BorderColor = System.Drawing.Color.Black;
            this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Title.BorderWidth = 1F;
            this.Title.Font = new System.Drawing.Font("Arial", 14.25F);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.Title.Name = "Title";
            // 
            // DetailCaption1
            // 
            this.DetailCaption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(104)))), ((int)(((byte)(196)))));
            this.DetailCaption1.BorderColor = System.Drawing.Color.White;
            this.DetailCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.DetailCaption1.BorderWidth = 2F;
            this.DetailCaption1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.DetailCaption1.ForeColor = System.Drawing.Color.White;
            this.DetailCaption1.Name = "DetailCaption1";
            this.DetailCaption1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailData1
            // 
            this.DetailData1.BorderColor = System.Drawing.Color.Transparent;
            this.DetailData1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.DetailData1.BorderWidth = 2F;
            this.DetailData1.Font = new System.Drawing.Font("Arial", 8.25F);
            this.DetailData1.ForeColor = System.Drawing.Color.Black;
            this.DetailData1.Name = "DetailData1";
            this.DetailData1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailData3_Odd
            // 
            this.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent;
            this.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DetailData3_Odd.BorderWidth = 1F;
            this.DetailData3_Odd.Font = new System.Drawing.Font("Arial", 8.25F);
            this.DetailData3_Odd.ForeColor = System.Drawing.Color.Black;
            this.DetailData3_Odd.Name = "DetailData3_Odd";
            this.DetailData3_Odd.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // PageInfo
            // 
            this.PageInfo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.PageInfo.Name = "PageInfo";
            this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pageInfo1,
            this.pageInfo2});
            this.BottomMargin.Name = "BottomMargin";
            // 
            // pageInfo1
            // 
            this.pageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(5F, 5F);
            this.pageInfo1.Name = "pageInfo1";
            this.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.pageInfo1.SizeF = new System.Drawing.SizeF(315F, 23F);
            this.pageInfo1.StyleName = "PageInfo";
            // 
            // pageInfo2
            // 
            this.pageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(330F, 5F);
            this.pageInfo2.Name = "pageInfo2";
            this.pageInfo2.SizeF = new System.Drawing.SizeF(315F, 23F);
            this.pageInfo2.StyleName = "PageInfo";
            this.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.pageInfo2.TextFormatString = "Page {0} of {1}";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrlbSemester,
            this.xrlbShoolyear,
            this.xrlabel2,
            this.xrlabel1,
            this.xrlbDepartment,
            this.label1});
            this.ReportHeader.HeightF = 73F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrlbSemester
            // 
            this.xrlbSemester.LocationFloat = new DevExpress.Utils.PointFloat(378.3333F, 26.99999F);
            this.xrlbSemester.Multiline = true;
            this.xrlbSemester.Name = "xrlbSemester";
            this.xrlbSemester.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlbSemester.SizeF = new System.Drawing.SizeF(100F, 23F);
            // 
            // xrlbShoolyear
            // 
            this.xrlbShoolyear.LocationFloat = new DevExpress.Utils.PointFloat(172.5F, 26.99999F);
            this.xrlbShoolyear.Multiline = true;
            this.xrlbShoolyear.Name = "xrlbShoolyear";
            this.xrlbShoolyear.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlbShoolyear.SizeF = new System.Drawing.SizeF(100F, 23F);
            // 
            // xrlabel2
            // 
            this.xrlabel2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrlabel2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.xrlabel2.LocationFloat = new DevExpress.Utils.PointFloat(306.1521F, 26.99999F);
            this.xrlabel2.Name = "xrlabel2";
            this.xrlabel2.SizeF = new System.Drawing.SizeF(61.3479F, 24.19433F);
            this.xrlabel2.StyleName = "Title";
            this.xrlabel2.StylePriority.UseFont = false;
            this.xrlabel2.StylePriority.UseForeColor = false;
            this.xrlabel2.Text = "Học kỳ";
            // 
            // xrlabel1
            // 
            this.xrlabel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrlabel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.xrlabel1.LocationFloat = new DevExpress.Utils.PointFloat(82.81876F, 26.99999F);
            this.xrlabel1.Name = "xrlabel1";
            this.xrlabel1.SizeF = new System.Drawing.SizeF(78.84792F, 24.19433F);
            this.xrlabel1.StyleName = "Title";
            this.xrlabel1.StylePriority.UseFont = false;
            this.xrlabel1.StylePriority.UseForeColor = false;
            this.xrlabel1.Text = "Niên khóa";
            // 
            // xrlbDepartment
            // 
            this.xrlbDepartment.LocationFloat = new DevExpress.Utils.PointFloat(320F, 1.194331F);
            this.xrlbDepartment.Multiline = true;
            this.xrlbDepartment.Name = "xrlbDepartment";
            this.xrlbDepartment.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlbDepartment.SizeF = new System.Drawing.SizeF(100F, 23F);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.LocationFloat = new DevExpress.Utils.PointFloat(241.1521F, 0F);
            this.label1.Name = "label1";
            this.label1.SizeF = new System.Drawing.SizeF(78.84792F, 24.19433F);
            this.label1.StyleName = "Title";
            this.label1.StylePriority.UseFont = false;
            this.label1.StylePriority.UseForeColor = false;
            this.label1.Text = "KHOA";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table1});
            this.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader1.HeightF = 28F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // table1
            // 
            this.table1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.table1.Name = "table1";
            this.table1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow1});
            this.table1.SizeF = new System.Drawing.SizeF(650F, 28F);
            // 
            // tableRow1
            // 
            this.tableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableIndex,
            this.tableCell1,
            this.tableCell2,
            this.tableCell3,
            this.tableCell4,
            this.tableCell5});
            this.tableRow1.Name = "tableRow1";
            this.tableRow1.Weight = 1D;
            // 
            // xrTableIndex
            // 
            this.xrTableIndex.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableIndex.Multiline = true;
            this.xrTableIndex.Name = "xrTableIndex";
            this.xrTableIndex.StyleName = "DetailCaption1";
            this.xrTableIndex.StylePriority.UseBorders = false;
            this.xrTableIndex.Text = "Số thứ tự";
            this.xrTableIndex.Weight = 0.17808474027193511D;
            // 
            // tableCell1
            // 
            this.tableCell1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.tableCell1.Name = "tableCell1";
            this.tableCell1.StyleName = "DetailCaption1";
            this.tableCell1.StylePriority.UseBorders = false;
            this.tableCell1.Text = "Môn học";
            this.tableCell1.Weight = 0.17808474027193511D;
            // 
            // tableCell2
            // 
            this.tableCell2.Name = "tableCell2";
            this.tableCell2.StyleName = "DetailCaption1";
            this.tableCell2.StylePriority.UseTextAlignment = false;
            this.tableCell2.Text = "Nhóm";
            this.tableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell2.Weight = 0.131903076171875D;
            // 
            // tableCell3
            // 
            this.tableCell3.Name = "tableCell3";
            this.tableCell3.StyleName = "DetailCaption1";
            this.tableCell3.Text = "Giảng viên";
            this.tableCell3.Weight = 0.21061638465294472D;
            // 
            // tableCell4
            // 
            this.tableCell4.Name = "tableCell4";
            this.tableCell4.StyleName = "DetailCaption1";
            this.tableCell4.StylePriority.UseTextAlignment = false;
            this.tableCell4.Text = "Số SV tối thiểu";
            this.tableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell4.Weight = 0.267065664438101D;
            // 
            // tableCell5
            // 
            this.tableCell5.Name = "tableCell5";
            this.tableCell5.StyleName = "DetailCaption1";
            this.tableCell5.StylePriority.UseTextAlignment = false;
            this.tableCell5.Text = "Số SV đã đăng ký";
            this.tableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell5.Weight = 0.21233015794020432D;
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table2});
            this.Detail.HeightF = 25F;
            this.Detail.Name = "Detail";
            // 
            // table2
            // 
            this.table2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.table2.Name = "table2";
            this.table2.OddStyleName = "DetailData3_Odd";
            this.table2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow2});
            this.table2.SizeF = new System.Drawing.SizeF(650F, 25F);
            // 
            // tableRow2
            // 
            this.tableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrCellIndex,
            this.tableCell6,
            this.tableCell7,
            this.tableCell8,
            this.tableCell9,
            this.tableCell10});
            this.tableRow2.Name = "tableRow2";
            this.tableRow2.Weight = 11.5D;
            // 
            // xrCellIndex
            // 
            this.xrCellIndex.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrCellIndex.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DataSource.CurrentRowIndex]")});
            this.xrCellIndex.Multiline = true;
            this.xrCellIndex.Name = "xrCellIndex";
            this.xrCellIndex.StyleName = "DetailData1";
            this.xrCellIndex.StylePriority.UseBorders = false;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrCellIndex.Summary = xrSummary1;
            this.xrCellIndex.Weight = 0.17808474027193511D;
            // 
            // tableCell6
            // 
            this.tableCell6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.tableCell6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MONHOC]")});
            this.tableCell6.Name = "tableCell6";
            this.tableCell6.StyleName = "DetailData1";
            this.tableCell6.StylePriority.UseBorders = false;
            this.tableCell6.Weight = 0.17808474027193511D;
            // 
            // tableCell7
            // 
            this.tableCell7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NHOM]")});
            this.tableCell7.Name = "tableCell7";
            this.tableCell7.StyleName = "DetailData1";
            this.tableCell7.StylePriority.UseTextAlignment = false;
            this.tableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell7.Weight = 0.131903076171875D;
            // 
            // tableCell8
            // 
            this.tableCell8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[GIANGVIEN]")});
            this.tableCell8.Name = "tableCell8";
            this.tableCell8.StyleName = "DetailData1";
            this.tableCell8.Weight = 0.21061638465294472D;
            // 
            // tableCell9
            // 
            this.tableCell9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SOSVTOITHIEU]")});
            this.tableCell9.Name = "tableCell9";
            this.tableCell9.StyleName = "DetailData1";
            this.tableCell9.StylePriority.UseTextAlignment = false;
            this.tableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell9.Weight = 0.267065664438101D;
            // 
            // tableCell10
            // 
            this.tableCell10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SVDANGKY]")});
            this.tableCell10.Name = "tableCell10";
            this.tableCell10.StyleName = "DetailData1";
            this.tableCell10.StylePriority.UseTextAlignment = false;
            this.tableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell10.Weight = 0.21233013446514423D;
            // 
            // calculatedField1
            // 
            this.calculatedField1.DataMember = "SP_REPORT_LOPTINCHI";
            this.calculatedField1.DisplayName = "STT";
            this.calculatedField1.Name = "calculatedField1";
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel4,
            this.xrLabel3});
            this.ReportFooter.HeightF = 67.33332F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(10F, 29.16667F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.SizeF = new System.Drawing.SizeF(151.6667F, 24.19433F);
            this.xrLabel4.StyleName = "Title";
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseForeColor = false;
            this.xrLabel4.Text = "Số lượng lớp đã mở: ";
            // 
            // xrLabel3
            // 
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([DataSource.RowCount])")});
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(183.1807F, 30.36097F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(100F, 23F);
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrLabel3.Summary = xrSummary2;
            this.xrLabel3.Text = "xrLabel3";
            // 
            // qldsV_TCDataSet1
            // 
            this.qldsV_TCDataSet1.DataSetName = "QLDSV_TCDataSet";
            this.qldsV_TCDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dANGKYTableAdapter
            // 
            this.dANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // qldsV_TCDataSet21
            // 
            this.qldsV_TCDataSet21.DataSetName = "QLDSV_TCDataSet2";
            this.qldsV_TCDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qldsV_TCDataSet22
            // 
            this.qldsV_TCDataSet22.DataSetName = "QLDSV_TCDataSet2";
            this.qldsV_TCDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qldsV_TCDataSet23
            // 
            this.qldsV_TCDataSet23.DataSetName = "QLDSV_TCDataSet2";
            this.qldsV_TCDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xrptCreditClass
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.GroupHeader1,
            this.Detail,
            this.ReportFooter});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.calculatedField1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1,
            this.qldsV_TCDataSet1,
            this.qldsV_TCDataSet21,
            this.qldsV_TCDataSet22,
            this.qldsV_TCDataSet23});
            this.DataAdapter = this.dANGKYTableAdapter;
            this.DataMember = "SP_REPORT_LOPTINCHI";
            this.DataSource = this.qldsV_TCDataSet23;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.DetailCaption1,
            this.DetailData1,
            this.DetailData3_Odd,
            this.PageInfo});
            this.Version = "19.2";
            ((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qldsV_TCDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qldsV_TCDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qldsV_TCDataSet22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qldsV_TCDataSet23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle DetailCaption1;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData1;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData3_Odd;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo1;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo2;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel label1;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRTable table1;
        private DevExpress.XtraReports.UI.XRTableRow tableRow1;
        private DevExpress.XtraReports.UI.XRTableCell tableCell1;
        private DevExpress.XtraReports.UI.XRTableCell tableCell2;
        private DevExpress.XtraReports.UI.XRTableCell tableCell3;
        private DevExpress.XtraReports.UI.XRTableCell tableCell4;
        private DevExpress.XtraReports.UI.XRTableCell tableCell5;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRTable table2;
        private DevExpress.XtraReports.UI.XRTableRow tableRow2;
        private DevExpress.XtraReports.UI.XRTableCell tableCell6;
        private DevExpress.XtraReports.UI.XRTableCell tableCell7;
        private DevExpress.XtraReports.UI.XRTableCell tableCell8;
        private DevExpress.XtraReports.UI.XRTableCell tableCell9;
        private DevExpress.XtraReports.UI.XRTableCell tableCell10;
        private DevExpress.XtraReports.UI.XRLabel xrlbSemester;
        private DevExpress.XtraReports.UI.XRLabel xrlbShoolyear;
        private DevExpress.XtraReports.UI.XRLabel xrlabel2;
        private DevExpress.XtraReports.UI.XRLabel xrlabel1;
        private DevExpress.XtraReports.UI.XRLabel xrlbDepartment;
        private DevExpress.XtraReports.UI.XRTableCell xrTableIndex;
        private DevExpress.XtraReports.UI.XRTableCell xrCellIndex;
        private DevExpress.XtraReports.UI.CalculatedField calculatedField1;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private QLDSV_TCDataSet qldsV_TCDataSet1;
        private QLDSV_TCDataSetTableAdapters.DANGKYTableAdapter dANGKYTableAdapter;
        private QLDSV_TCDataSet2 qldsV_TCDataSet21;
        private QLDSV_TCDataSet2 qldsV_TCDataSet22;
        private QLDSV_TCDataSet2 qldsV_TCDataSet23;
    }
}
