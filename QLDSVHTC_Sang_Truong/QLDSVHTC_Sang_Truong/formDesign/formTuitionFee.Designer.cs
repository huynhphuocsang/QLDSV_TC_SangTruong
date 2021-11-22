
namespace QLDSVHTC_Sang_Truong.formDesign
{
    partial class formTuitionFee
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTuitionFee));
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSV_TCDataSet1 = new QLDSVHTC_Sang_Truong.QLDSV_TCDataSet1();
            this.sINHVIENTableAdapter = new QLDSVHTC_Sang_Truong.QLDSV_TCDataSet1TableAdapters.SINHVIENTableAdapter();
            this.sP_PAY_TUITIONFEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_PAY_TUITIONFEETableAdapter = new QLDSVHTC_Sang_Truong.QLDSV_TCDataSet1TableAdapters.SP_PAY_TUITIONFEETableAdapter();
            this.tableAdapterManager = new QLDSVHTC_Sang_Truong.QLDSV_TCDataSet1TableAdapters.TableAdapterManager();
            this.sP_PAY_TUITIONFEEGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNIENKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCPHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPADED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sP_SHOW_DETAIL_TUITIONFEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_SHOW_DETAIL_TUITIONFEETableAdapter = new QLDSVHTC_Sang_Truong.QLDSV_TCDataSet1TableAdapters.SP_SHOW_DETAIL_TUITIONFEETableAdapter();
            this.sP_SHOW_DETAIL_TUITIONFEEGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNGAYDONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIENDONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtClass = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nmMoney = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPay = new DevExpress.XtraEditors.SimpleButton();
            this.lkStudent = new DevExpress.XtraEditors.LookUpEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtShoolYear = new DevExpress.XtraEditors.TextEdit();
            this.txtFullname = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.txtSemester = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_PAY_TUITIONFEEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_PAY_TUITIONFEEGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_SHOW_DETAIL_TUITIONFEEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_SHOW_DETAIL_TUITIONFEEGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkStudent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShoolYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSemester.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource.DataSource = this.qLDSV_TCDataSet1;
            // 
            // qLDSV_TCDataSet1
            // 
            this.qLDSV_TCDataSet1.DataSetName = "QLDSV_TCDataSet1";
            this.qLDSV_TCDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // sP_PAY_TUITIONFEEBindingSource
            // 
            this.sP_PAY_TUITIONFEEBindingSource.DataMember = "SP_PAY_TUITIONFEE";
            this.sP_PAY_TUITIONFEEBindingSource.DataSource = this.qLDSV_TCDataSet1;
            // 
            // sP_PAY_TUITIONFEETableAdapter
            // 
            this.sP_PAY_TUITIONFEETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_DONGHOCPHITableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager.SP_PAY_TUITIONFEETableAdapter = this.sP_PAY_TUITIONFEETableAdapter;
            this.tableAdapterManager.UpdateOrder = QLDSVHTC_Sang_Truong.QLDSV_TCDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sP_PAY_TUITIONFEEGridControl
            // 
            this.sP_PAY_TUITIONFEEGridControl.DataSource = this.sP_PAY_TUITIONFEEBindingSource;
            this.sP_PAY_TUITIONFEEGridControl.EmbeddedNavigator.ToolTip = "Double click để đóng học phí!";
            this.sP_PAY_TUITIONFEEGridControl.EmbeddedNavigator.ToolTipTitle = "Double click để đóng học phí!";
            this.sP_PAY_TUITIONFEEGridControl.Location = new System.Drawing.Point(0, 274);
            this.sP_PAY_TUITIONFEEGridControl.MainView = this.gridView1;
            this.sP_PAY_TUITIONFEEGridControl.Name = "sP_PAY_TUITIONFEEGridControl";
            this.sP_PAY_TUITIONFEEGridControl.Size = new System.Drawing.Size(1012, 549);
            this.sP_PAY_TUITIONFEEGridControl.TabIndex = 10;
            this.sP_PAY_TUITIONFEEGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.sP_PAY_TUITIONFEEGridControl.VisibleChanged += new System.EventHandler(this.sP_PAY_TUITIONFEEGridControl_VisibleChanged);
            this.sP_PAY_TUITIONFEEGridControl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.sP_PAY_TUITIONFEEGridControl_MouseDoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.GroupPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridView1.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.GroupPanel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gridView1.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNIENKHOA,
            this.colHOCKY,
            this.colHOCPHI,
            this.colPADED});
            this.gridView1.GridControl = this.sP_PAY_TUITIONFEEGridControl;
            this.gridView1.GroupPanelText = "Danh sách học phí qua các kỳ";
            this.gridView1.Name = "gridView1";
            this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
            // 
            // colNIENKHOA
            // 
            this.colNIENKHOA.AppearanceCell.Options.UseTextOptions = true;
            this.colNIENKHOA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNIENKHOA.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colNIENKHOA.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNIENKHOA.AppearanceHeader.Options.UseBackColor = true;
            this.colNIENKHOA.AppearanceHeader.Options.UseFont = true;
            this.colNIENKHOA.AppearanceHeader.Options.UseTextOptions = true;
            this.colNIENKHOA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNIENKHOA.Caption = "Niên khóa";
            this.colNIENKHOA.FieldName = "NIENKHOA";
            this.colNIENKHOA.MinWidth = 25;
            this.colNIENKHOA.Name = "colNIENKHOA";
            this.colNIENKHOA.Visible = true;
            this.colNIENKHOA.VisibleIndex = 0;
            this.colNIENKHOA.Width = 94;
            // 
            // colHOCKY
            // 
            this.colHOCKY.AppearanceCell.Options.UseTextOptions = true;
            this.colHOCKY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHOCKY.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colHOCKY.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHOCKY.AppearanceHeader.Options.UseBackColor = true;
            this.colHOCKY.AppearanceHeader.Options.UseFont = true;
            this.colHOCKY.AppearanceHeader.Options.UseTextOptions = true;
            this.colHOCKY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHOCKY.Caption = "Học kỳ";
            this.colHOCKY.FieldName = "HOCKY";
            this.colHOCKY.MinWidth = 25;
            this.colHOCKY.Name = "colHOCKY";
            this.colHOCKY.Visible = true;
            this.colHOCKY.VisibleIndex = 1;
            this.colHOCKY.Width = 94;
            // 
            // colHOCPHI
            // 
            this.colHOCPHI.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colHOCPHI.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHOCPHI.AppearanceHeader.Options.UseBackColor = true;
            this.colHOCPHI.AppearanceHeader.Options.UseFont = true;
            this.colHOCPHI.AppearanceHeader.Options.UseTextOptions = true;
            this.colHOCPHI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHOCPHI.Caption = "Học phí";
            this.colHOCPHI.DisplayFormat.FormatString = "n0";
            this.colHOCPHI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colHOCPHI.FieldName = "HOCPHI";
            this.colHOCPHI.MinWidth = 25;
            this.colHOCPHI.Name = "colHOCPHI";
            this.colHOCPHI.Visible = true;
            this.colHOCPHI.VisibleIndex = 2;
            this.colHOCPHI.Width = 94;
            // 
            // colPADED
            // 
            this.colPADED.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colPADED.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPADED.AppearanceHeader.Options.UseBackColor = true;
            this.colPADED.AppearanceHeader.Options.UseFont = true;
            this.colPADED.AppearanceHeader.Options.UseTextOptions = true;
            this.colPADED.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPADED.Caption = "Số tiền đã đóng";
            this.colPADED.DisplayFormat.FormatString = "n0";
            this.colPADED.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPADED.FieldName = "PADED";
            this.colPADED.MinWidth = 25;
            this.colPADED.Name = "colPADED";
            this.colPADED.Visible = true;
            this.colPADED.VisibleIndex = 3;
            this.colPADED.Width = 94;
            // 
            // sP_SHOW_DETAIL_TUITIONFEEBindingSource
            // 
            this.sP_SHOW_DETAIL_TUITIONFEEBindingSource.DataMember = "SP_SHOW_DETAIL_TUITIONFEE";
            this.sP_SHOW_DETAIL_TUITIONFEEBindingSource.DataSource = this.qLDSV_TCDataSet1;
            // 
            // sP_SHOW_DETAIL_TUITIONFEETableAdapter
            // 
            this.sP_SHOW_DETAIL_TUITIONFEETableAdapter.ClearBeforeFill = true;
            // 
            // sP_SHOW_DETAIL_TUITIONFEEGridControl
            // 
            this.sP_SHOW_DETAIL_TUITIONFEEGridControl.DataSource = this.sP_SHOW_DETAIL_TUITIONFEEBindingSource;
            this.sP_SHOW_DETAIL_TUITIONFEEGridControl.Location = new System.Drawing.Point(1008, 274);
            this.sP_SHOW_DETAIL_TUITIONFEEGridControl.MainView = this.gridView2;
            this.sP_SHOW_DETAIL_TUITIONFEEGridControl.Name = "sP_SHOW_DETAIL_TUITIONFEEGridControl";
            this.sP_SHOW_DETAIL_TUITIONFEEGridControl.Size = new System.Drawing.Size(895, 549);
            this.sP_SHOW_DETAIL_TUITIONFEEGridControl.TabIndex = 12;
            this.sP_SHOW_DETAIL_TUITIONFEEGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.GroupPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.gridView2.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.GroupPanel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gridView2.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView2.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNGAYDONG,
            this.colSOTIENDONG});
            this.gridView2.GridControl = this.sP_SHOW_DETAIL_TUITIONFEEGridControl;
            this.gridView2.GroupPanelText = "Chi tiêt đóng học phí";
            this.gridView2.Name = "gridView2";
            // 
            // colNGAYDONG
            // 
            this.colNGAYDONG.AppearanceCell.Options.UseTextOptions = true;
            this.colNGAYDONG.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNGAYDONG.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNGAYDONG.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colNGAYDONG.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNGAYDONG.AppearanceHeader.Options.UseBackColor = true;
            this.colNGAYDONG.AppearanceHeader.Options.UseFont = true;
            this.colNGAYDONG.AppearanceHeader.Options.UseTextOptions = true;
            this.colNGAYDONG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNGAYDONG.Caption = "Ngày đóng";
            this.colNGAYDONG.FieldName = "NGAYDONG";
            this.colNGAYDONG.MinWidth = 25;
            this.colNGAYDONG.Name = "colNGAYDONG";
            this.colNGAYDONG.Visible = true;
            this.colNGAYDONG.VisibleIndex = 0;
            this.colNGAYDONG.Width = 94;
            // 
            // colSOTIENDONG
            // 
            this.colSOTIENDONG.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colSOTIENDONG.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSOTIENDONG.AppearanceHeader.Options.UseBackColor = true;
            this.colSOTIENDONG.AppearanceHeader.Options.UseFont = true;
            this.colSOTIENDONG.AppearanceHeader.Options.UseTextOptions = true;
            this.colSOTIENDONG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSOTIENDONG.Caption = "Số tiền đóng";
            this.colSOTIENDONG.DisplayFormat.FormatString = "n0";
            this.colSOTIENDONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSOTIENDONG.FieldName = "SOTIENDONG";
            this.colSOTIENDONG.MinWidth = 25;
            this.colSOTIENDONG.Name = "colSOTIENDONG";
            this.colSOTIENDONG.Visible = true;
            this.colSOTIENDONG.VisibleIndex = 1;
            this.colSOTIENDONG.Width = 94;
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(133, 179);
            this.txtClass.Name = "txtClass";
            this.txtClass.Properties.ReadOnly = true;
            this.txtClass.Size = new System.Drawing.Size(136, 22);
            this.txtClass.TabIndex = 4;
            this.txtClass.EditValueChanged += new System.EventHandler(this.txtClass_EditValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(465, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Số tiền cần đóng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lớp";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // nmMoney
            // 
            this.nmMoney.Location = new System.Drawing.Point(608, 178);
            this.nmMoney.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nmMoney.Name = "nmMoney";
            this.nmMoney.Size = new System.Drawing.Size(152, 23);
            this.nmMoney.TabIndex = 11;
            this.nmMoney.ThousandsSeparator = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Họ và tên";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnPay
            // 
            this.btnPay.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPay.ImageOptions.SvgImage")));
            this.btnPay.Location = new System.Drawing.Point(617, 223);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(130, 45);
            this.btnPay.TabIndex = 13;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lkStudent
            // 
            this.lkStudent.Location = new System.Drawing.Point(272, 32);
            this.lkStudent.Name = "lkStudent";
            this.lkStudent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkStudent.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MASV", "MASV", 57, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HO", "HO", 27, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TEN", "TEN", 33, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PHAI", "PHAI", 38, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DIACHI", "DIACHI", 51, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NGAYSINH", "NGAYSINH", 69, DevExpress.Utils.FormatType.DateTime, "M/d/yyyy", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MALOP", "MALOP", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lkStudent.Properties.DataSource = this.sINHVIENBindingSource;
            this.lkStudent.Properties.DisplayMember = "MASV";
            this.lkStudent.Properties.NullText = "Tìm sinh viên";
            this.lkStudent.Properties.ValueMember = "MASV";
            this.lkStudent.Size = new System.Drawing.Size(667, 22);
            this.lkStudent.TabIndex = 9;
            this.lkStudent.EditValueChanged += new System.EventHandler(this.lkStudent_EditValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Niên khóa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã sinh viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtShoolYear
            // 
            this.txtShoolYear.Location = new System.Drawing.Point(608, 81);
            this.txtShoolYear.Name = "txtShoolYear";
            this.txtShoolYear.Properties.ReadOnly = true;
            this.txtShoolYear.Size = new System.Drawing.Size(152, 22);
            this.txtShoolYear.TabIndex = 10;
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(133, 131);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Properties.ReadOnly = true;
            this.txtFullname.Size = new System.Drawing.Size(136, 22);
            this.txtFullname.TabIndex = 3;
            this.txtFullname.EditValueChanged += new System.EventHandler(this.txtFullname_EditValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(465, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Học kỳ";
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancel.ImageOptions.SvgImage")));
            this.btnCancel.Location = new System.Drawing.Point(767, 223);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 45);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtSemester
            // 
            this.txtSemester.Location = new System.Drawing.Point(608, 129);
            this.txtSemester.Name = "txtSemester";
            this.txtSemester.Properties.ReadOnly = true;
            this.txtSemester.Size = new System.Drawing.Size(152, 22);
            this.txtSemester.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtShoolYear);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.txtSemester);
            this.panel1.Controls.Add(this.txtFullname);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nmMoney);
            this.panel1.Controls.Add(this.lkStudent);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnPay);
            this.panel1.Controls.Add(this.txtClass);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1919, 271);
            this.panel1.TabIndex = 14;
            // 
            // formTuitionFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1919, 826);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sP_SHOW_DETAIL_TUITIONFEEGridControl);
            this.Controls.Add(this.sP_PAY_TUITIONFEEGridControl);
            this.Name = "formTuitionFee";
            this.Text = "Thanh toán học phí";
            this.Load += new System.EventHandler(this.formTuitionFee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_PAY_TUITIONFEEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_PAY_TUITIONFEEGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_SHOW_DETAIL_TUITIONFEEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_SHOW_DETAIL_TUITIONFEEGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkStudent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShoolYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSemester.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private QLDSV_TCDataSet1 qLDSV_TCDataSet1;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private QLDSV_TCDataSet1TableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.BindingSource sP_PAY_TUITIONFEEBindingSource;
        private QLDSV_TCDataSet1TableAdapters.SP_PAY_TUITIONFEETableAdapter sP_PAY_TUITIONFEETableAdapter;
        private QLDSV_TCDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sP_PAY_TUITIONFEEGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colNIENKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCKY;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCPHI;
        private DevExpress.XtraGrid.Columns.GridColumn colPADED;
        private System.Windows.Forms.BindingSource sP_SHOW_DETAIL_TUITIONFEEBindingSource;
        private QLDSV_TCDataSet1TableAdapters.SP_SHOW_DETAIL_TUITIONFEETableAdapter sP_SHOW_DETAIL_TUITIONFEETableAdapter;
        private DevExpress.XtraGrid.GridControl sP_SHOW_DETAIL_TUITIONFEEGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYDONG;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIENDONG;
        private DevExpress.XtraEditors.TextEdit txtSemester;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtFullname;
        private DevExpress.XtraEditors.TextEdit txtShoolYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.LookUpEdit lkStudent;
        private DevExpress.XtraEditors.SimpleButton btnPay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmMoney;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txtClass;
        private System.Windows.Forms.Panel panel1;
    }
}