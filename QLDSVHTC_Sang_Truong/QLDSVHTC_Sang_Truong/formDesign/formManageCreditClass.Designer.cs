
namespace QLDSVHTC_Sang_Truong.formDesign
{
    partial class formManageCreditClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formManageCreditClass));
            this.qLDSV_TCDataSet = new QLDSVHTC_Sang_Truong.QLDSV_TCDataSet();
            this.lOPTINCHIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTINCHITableAdapter = new QLDSVHTC_Sang_Truong.QLDSV_TCDataSetTableAdapters.LOPTINCHITableAdapter();
            this.tableAdapterManager = new QLDSVHTC_Sang_Truong.QLDSV_TCDataSetTableAdapters.TableAdapterManager();
            this.lOPTINCHIGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNIENKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkSubjectEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colNHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOSVTOITHIEU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHUYLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fKLOPTINCHIMONHOCBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.cbSchoolYear = new System.Windows.Forms.ComboBox();
            this.nmGroup = new System.Windows.Forms.NumericUpDown();
            this.nmMinimumStudent = new System.Windows.Forms.NumericUpDown();
            this.nmSemester = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lkTeacher = new DevExpress.XtraEditors.LookUpEdit();
            this.gIANGVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.mONHOCTableAdapter = new QLDSVHTC_Sang_Truong.QLDSV_TCDataSetTableAdapters.MONHOCTableAdapter();
            this.fKLOPTINCHIMONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIANGVIENTableAdapter = new QLDSVHTC_Sang_Truong.QLDSV_TCDataSetTableAdapters.GIANGVIENTableAdapter();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPTINCHIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPTINCHIGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkSubjectEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKLOPTINCHIMONHOCBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMinimumStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSemester)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkTeacher.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKLOPTINCHIMONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // qLDSV_TCDataSet
            // 
            this.qLDSV_TCDataSet.DataSetName = "QLDSV_TCDataSet";
            this.qLDSV_TCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOPTINCHIBindingSource
            // 
            this.lOPTINCHIBindingSource.DataMember = "LOPTINCHI";
            this.lOPTINCHIBindingSource.DataSource = this.qLDSV_TCDataSet;
            // 
            // lOPTINCHITableAdapter
            // 
            this.lOPTINCHITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = this.lOPTINCHITableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSVHTC_Sang_Truong.QLDSV_TCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lOPTINCHIGridControl
            // 
            this.lOPTINCHIGridControl.DataSource = this.lOPTINCHIBindingSource;
            this.lOPTINCHIGridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lOPTINCHIGridControl.Location = new System.Drawing.Point(0, 211);
            this.lOPTINCHIGridControl.MainView = this.gridView1;
            this.lOPTINCHIGridControl.Name = "lOPTINCHIGridControl";
            this.lOPTINCHIGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lkSubjectEdit});
            this.lOPTINCHIGridControl.Size = new System.Drawing.Size(1240, 401);
            this.lOPTINCHIGridControl.TabIndex = 1;
            this.lOPTINCHIGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.lOPTINCHIGridControl.Click += new System.EventHandler(this.lOPTINCHIGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.GroupPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridView1.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.GroupPanel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gridView1.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNIENKHOA,
            this.colHOCKY,
            this.colMAMH,
            this.colNHOM,
            this.colMAGV,
            this.colMAKHOA,
            this.colSOSVTOITHIEU,
            this.colHUYLOP});
            this.gridView1.GridControl = this.lOPTINCHIGridControl;
            this.gridView1.GroupPanelText = "DANH SÁCH LỚP TÍN CHỈ";
            this.gridView1.Name = "gridView1";
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // colNIENKHOA
            // 
            this.colNIENKHOA.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colNIENKHOA.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNIENKHOA.AppearanceHeader.Options.UseBackColor = true;
            this.colNIENKHOA.AppearanceHeader.Options.UseFont = true;
            this.colNIENKHOA.Caption = "Niên khóa";
            this.colNIENKHOA.FieldName = "NIENKHOA";
            this.colNIENKHOA.MinWidth = 25;
            this.colNIENKHOA.Name = "colNIENKHOA";
            this.colNIENKHOA.Visible = true;
            this.colNIENKHOA.VisibleIndex = 0;
            this.colNIENKHOA.Width = 133;
            // 
            // colHOCKY
            // 
            this.colHOCKY.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colHOCKY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHOCKY.AppearanceHeader.Options.UseBackColor = true;
            this.colHOCKY.AppearanceHeader.Options.UseFont = true;
            this.colHOCKY.Caption = "Học kỳ";
            this.colHOCKY.FieldName = "HOCKY";
            this.colHOCKY.MinWidth = 25;
            this.colHOCKY.Name = "colHOCKY";
            this.colHOCKY.Visible = true;
            this.colHOCKY.VisibleIndex = 1;
            this.colHOCKY.Width = 133;
            // 
            // colMAMH
            // 
            this.colMAMH.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colMAMH.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAMH.AppearanceHeader.Options.UseBackColor = true;
            this.colMAMH.AppearanceHeader.Options.UseFont = true;
            this.colMAMH.Caption = "Mã môn ";
            this.colMAMH.ColumnEdit = this.lkSubjectEdit;
            this.colMAMH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 25;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 2;
            this.colMAMH.Width = 133;
            // 
            // lkSubjectEdit
            // 
            this.lkSubjectEdit.AutoHeight = false;
            this.lkSubjectEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkSubjectEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MAMH", "Name1"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENMH", "Name2"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SOTIET_LT", "Name3"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SOTIET_TH", "Name4")});
            this.lkSubjectEdit.DataSource = this.mONHOCBindingSource;
            this.lkSubjectEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.lkSubjectEdit.DisplayMember = "TENMH";
            this.lkSubjectEdit.Name = "lkSubjectEdit";
            this.lkSubjectEdit.ValueMember = "MAMH";
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.qLDSV_TCDataSet;
            // 
            // colNHOM
            // 
            this.colNHOM.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colNHOM.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNHOM.AppearanceHeader.Options.UseBackColor = true;
            this.colNHOM.AppearanceHeader.Options.UseFont = true;
            this.colNHOM.Caption = "Mã nhóm";
            this.colNHOM.FieldName = "NHOM";
            this.colNHOM.MinWidth = 25;
            this.colNHOM.Name = "colNHOM";
            this.colNHOM.Visible = true;
            this.colNHOM.VisibleIndex = 3;
            this.colNHOM.Width = 103;
            // 
            // colMAGV
            // 
            this.colMAGV.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colMAGV.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAGV.AppearanceHeader.Options.UseBackColor = true;
            this.colMAGV.AppearanceHeader.Options.UseFont = true;
            this.colMAGV.Caption = "Mã giáo viên";
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.MinWidth = 25;
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 4;
            this.colMAGV.Width = 120;
            // 
            // colMAKHOA
            // 
            this.colMAKHOA.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colMAKHOA.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAKHOA.AppearanceHeader.Options.UseBackColor = true;
            this.colMAKHOA.AppearanceHeader.Options.UseFont = true;
            this.colMAKHOA.Caption = "Mã khoa";
            this.colMAKHOA.FieldName = "MAKHOA";
            this.colMAKHOA.MinWidth = 25;
            this.colMAKHOA.Name = "colMAKHOA";
            this.colMAKHOA.Visible = true;
            this.colMAKHOA.VisibleIndex = 5;
            this.colMAKHOA.Width = 95;
            // 
            // colSOSVTOITHIEU
            // 
            this.colSOSVTOITHIEU.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colSOSVTOITHIEU.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSOSVTOITHIEU.AppearanceHeader.Options.UseBackColor = true;
            this.colSOSVTOITHIEU.AppearanceHeader.Options.UseFont = true;
            this.colSOSVTOITHIEU.Caption = "Số sinh viên tối thiểu";
            this.colSOSVTOITHIEU.FieldName = "SOSVTOITHIEU";
            this.colSOSVTOITHIEU.MinWidth = 25;
            this.colSOSVTOITHIEU.Name = "colSOSVTOITHIEU";
            this.colSOSVTOITHIEU.Visible = true;
            this.colSOSVTOITHIEU.VisibleIndex = 6;
            this.colSOSVTOITHIEU.Width = 194;
            // 
            // colHUYLOP
            // 
            this.colHUYLOP.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colHUYLOP.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHUYLOP.AppearanceHeader.Options.UseBackColor = true;
            this.colHUYLOP.AppearanceHeader.Options.UseFont = true;
            this.colHUYLOP.Caption = "Đã hủy lớp";
            this.colHUYLOP.FieldName = "HUYLOP";
            this.colHUYLOP.MinWidth = 25;
            this.colHUYLOP.Name = "colHUYLOP";
            this.colHUYLOP.Visible = true;
            this.colHUYLOP.VisibleIndex = 7;
            this.colHUYLOP.Width = 159;
            // 
            // fKLOPTINCHIMONHOCBindingSource1
            // 
            this.fKLOPTINCHIMONHOCBindingSource1.DataMember = "FK_LOPTINCHI_MONHOC";
            this.fKLOPTINCHIMONHOCBindingSource1.DataSource = this.mONHOCBindingSource;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton5);
            this.panel1.Controls.Add(this.simpleButton4);
            this.panel1.Controls.Add(this.simpleButton3);
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.cbDepartment);
            this.panel1.Controls.Add(this.cbSchoolYear);
            this.panel1.Controls.Add(this.nmGroup);
            this.panel1.Controls.Add(this.nmMinimumStudent);
            this.panel1.Controls.Add(this.nmSemester);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lkTeacher);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbSubject);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 259);
            this.panel1.TabIndex = 2;
            // 
            // simpleButton5
            // 
            this.simpleButton5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton5.ImageOptions.SvgImage")));
            this.simpleButton5.Location = new System.Drawing.Point(537, 12);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(96, 38);
            this.simpleButton5.TabIndex = 7;
            this.simpleButton5.Text = "Reload";
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton4.ImageOptions.SvgImage")));
            this.simpleButton4.Location = new System.Drawing.Point(434, 12);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(97, 38);
            this.simpleButton4.TabIndex = 7;
            this.simpleButton4.Text = "Redo";
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton3.ImageOptions.SvgImage")));
            this.simpleButton3.Location = new System.Drawing.Point(330, 12);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(98, 38);
            this.simpleButton3.TabIndex = 7;
            this.simpleButton3.Text = "Undo";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(230, 12);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(93, 38);
            this.simpleButton2.TabIndex = 7;
            this.simpleButton2.Text = "Xóa";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(12, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(91, 38);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Lưu";
            // 
            // btnAdd
            // 
            this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
            this.btnAdd.Location = new System.Drawing.Point(109, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 38);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm mới";
            // 
            // cbDepartment
            // 
            this.cbDepartment.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartment.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(514, 82);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(237, 32);
            this.cbDepartment.TabIndex = 5;
            this.cbDepartment.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cbSchoolYear
            // 
            this.cbSchoolYear.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.lOPTINCHIBindingSource, "MALTC", true));
            this.cbSchoolYear.FormattingEnabled = true;
            this.cbSchoolYear.Items.AddRange(new object[] {
            "2019-2020",
            "2020-2021",
            "2021-2022",
            "2022-2023"});
            this.cbSchoolYear.Location = new System.Drawing.Point(102, 155);
            this.cbSchoolYear.Name = "cbSchoolYear";
            this.cbSchoolYear.Size = new System.Drawing.Size(121, 24);
            this.cbSchoolYear.TabIndex = 5;
            this.cbSchoolYear.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // nmGroup
            // 
            this.nmGroup.Location = new System.Drawing.Point(1055, 228);
            this.nmGroup.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmGroup.Name = "nmGroup";
            this.nmGroup.Size = new System.Drawing.Size(76, 23);
            this.nmGroup.TabIndex = 4;
            this.nmGroup.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmGroup.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // nmMinimumStudent
            // 
            this.nmMinimumStudent.Location = new System.Drawing.Point(1055, 156);
            this.nmMinimumStudent.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmMinimumStudent.Name = "nmMinimumStudent";
            this.nmMinimumStudent.Size = new System.Drawing.Size(76, 23);
            this.nmMinimumStudent.TabIndex = 4;
            this.nmMinimumStudent.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmMinimumStudent.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // nmSemester
            // 
            this.nmSemester.Location = new System.Drawing.Point(102, 231);
            this.nmSemester.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nmSemester.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmSemester.Name = "nmSemester";
            this.nmSemester.Size = new System.Drawing.Size(76, 23);
            this.nmSemester.TabIndex = 4;
            this.nmSemester.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmSemester.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Giảng viên";
            // 
            // lkTeacher
            // 
            this.lkTeacher.Location = new System.Drawing.Point(370, 232);
            this.lkTeacher.Name = "lkTeacher";
            this.lkTeacher.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkTeacher.Properties.DataSource = this.gIANGVIENBindingSource;
            this.lkTeacher.Properties.DisplayMember = "TEN";
            this.lkTeacher.Properties.NullText = "Chọn giảng viên";
            this.lkTeacher.Properties.ValueMember = "MAGV";
            this.lkTeacher.Size = new System.Drawing.Size(499, 22);
            this.lkTeacher.TabIndex = 2;
            this.lkTeacher.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.lkTeacher_CustomDisplayText);
            // 
            // gIANGVIENBindingSource
            // 
            this.gIANGVIENBindingSource.DataMember = "GIANGVIEN";
            this.gIANGVIENBindingSource.DataSource = this.qLDSV_TCDataSet;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(915, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mã nhóm";
            this.label7.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(417, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 40);
            this.label6.TabIndex = 1;
            this.label6.Text = "Khoa";
            this.label6.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(915, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số sinh viên tối thiểu";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Niên khóa";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Học kỳ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Môn học";
            // 
            // cbSubject
            // 
            this.cbSubject.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.lOPTINCHIBindingSource, "MAMH", true));
            this.cbSubject.DataSource = this.mONHOCBindingSource;
            this.cbSubject.DisplayMember = "TENMH";
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Location = new System.Drawing.Point(370, 155);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(121, 24);
            this.cbSubject.TabIndex = 0;
            this.cbSubject.ValueMember = "MAMH";
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // fKLOPTINCHIMONHOCBindingSource
            // 
            this.fKLOPTINCHIMONHOCBindingSource.DataMember = "FK_LOPTINCHI_MONHOC";
            this.fKLOPTINCHIMONHOCBindingSource.DataSource = this.mONHOCBindingSource;
            // 
            // gIANGVIENTableAdapter
            // 
            this.gIANGVIENTableAdapter.ClearBeforeFill = true;
            // 
            // formManageCreditClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 612);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lOPTINCHIGridControl);
            this.Name = "formManageCreditClass";
            this.Text = "Danh sách lớp tín chỉ";
            this.Load += new System.EventHandler(this.formManageCreditClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPTINCHIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPTINCHIGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkSubjectEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKLOPTINCHIMONHOCBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMinimumStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSemester)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkTeacher.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKLOPTINCHIMONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private QLDSV_TCDataSet qLDSV_TCDataSet;
        private System.Windows.Forms.BindingSource lOPTINCHIBindingSource;
        private QLDSV_TCDataSetTableAdapters.LOPTINCHITableAdapter lOPTINCHITableAdapter;
        private QLDSV_TCDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl lOPTINCHIGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colNIENKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCKY;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOM;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colSOSVTOITHIEU;
        private DevExpress.XtraGrid.Columns.GridColumn colHUYLOP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private QLDSV_TCDataSetTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.BindingSource fKLOPTINCHIMONHOCBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource gIANGVIENBindingSource;
        private QLDSV_TCDataSetTableAdapters.GIANGVIENTableAdapter gIANGVIENTableAdapter;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.LookUpEdit lkTeacher;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.ComboBox cbSchoolYear;
        private System.Windows.Forms.NumericUpDown nmSemester;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmMinimumStudent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.NumericUpDown nmGroup;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkSubjectEdit;
        private System.Windows.Forms.BindingSource fKLOPTINCHIMONHOCBindingSource1;
    }
}