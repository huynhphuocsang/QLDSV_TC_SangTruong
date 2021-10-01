
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnShowDetail = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnPayMoney = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFullname = new DevExpress.XtraEditors.TextEdit();
            this.txtClass = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lkStudent = new DevExpress.XtraEditors.LookUpEdit();
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
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nmMoney = new System.Windows.Forms.NumericUpDown();
            this.txtSemester = new DevExpress.XtraEditors.TextEdit();
            this.txtShoolYear = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkStudent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_PAY_TUITIONFEEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_PAY_TUITIONFEEGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSemester.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShoolYear.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Controls.Add(this.btnShowDetail);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.btnPayMoney);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1515, 78);
            this.panelControl1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancel.ImageOptions.SvgImage")));
            this.btnCancel.Location = new System.Drawing.Point(446, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 45);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Hủy";
            // 
            // btnShowDetail
            // 
            this.btnShowDetail.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnShowDetail.ImageOptions.SvgImage")));
            this.btnShowDetail.Location = new System.Drawing.Point(294, 12);
            this.btnShowDetail.Name = "btnShowDetail";
            this.btnShowDetail.Size = new System.Drawing.Size(129, 45);
            this.btnShowDetail.TabIndex = 0;
            this.btnShowDetail.Text = "Xem chi tiết";
            this.btnShowDetail.Click += new System.EventHandler(this.btnShowDetail_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
            this.btnSave.Location = new System.Drawing.Point(145, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 45);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Lưu thao tác";
            // 
            // btnPayMoney
            // 
            this.btnPayMoney.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPayMoney.ImageOptions.SvgImage")));
            this.btnPayMoney.Location = new System.Drawing.Point(5, 12);
            this.btnPayMoney.Name = "btnPayMoney";
            this.btnPayMoney.Size = new System.Drawing.Size(123, 45);
            this.btnPayMoney.TabIndex = 0;
            this.btnPayMoney.Text = "Đóng tiền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã sinh viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(127, 62);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Properties.ReadOnly = true;
            this.txtFullname.Size = new System.Drawing.Size(125, 22);
            this.txtFullname.TabIndex = 3;
            this.txtFullname.EditValueChanged += new System.EventHandler(this.txtFullname_EditValueChanged);
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(127, 110);
            this.txtClass.Name = "txtClass";
            this.txtClass.Properties.ReadOnly = true;
            this.txtClass.Size = new System.Drawing.Size(125, 22);
            this.txtClass.TabIndex = 4;
            this.txtClass.EditValueChanged += new System.EventHandler(this.txtClass_EditValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Họ và tên";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lớp";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lkStudent
            // 
            this.lkStudent.Location = new System.Drawing.Point(127, 12);
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
            this.lkStudent.Size = new System.Drawing.Size(767, 22);
            this.lkStudent.TabIndex = 9;
            this.lkStudent.EditValueChanged += new System.EventHandler(this.lkStudent_EditValueChanged);
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
            this.sP_PAY_TUITIONFEEGridControl.Location = new System.Drawing.Point(0, 236);
            this.sP_PAY_TUITIONFEEGridControl.MainView = this.gridView1;
            this.sP_PAY_TUITIONFEEGridControl.Name = "sP_PAY_TUITIONFEEGridControl";
            this.sP_PAY_TUITIONFEEGridControl.Size = new System.Drawing.Size(797, 570);
            this.sP_PAY_TUITIONFEEGridControl.TabIndex = 10;
            this.sP_PAY_TUITIONFEEGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.sP_PAY_TUITIONFEEGridControl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.sP_PAY_TUITIONFEEGridControl_MouseDoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNIENKHOA,
            this.colHOCKY,
            this.colHOCPHI,
            this.colPADED});
            this.gridView1.GridControl = this.sP_PAY_TUITIONFEEGridControl;
            this.gridView1.GroupPanelText = "Danh sách học phí qua các kỳ";
            this.gridView1.Name = "gridView1";
            // 
            // colNIENKHOA
            // 
            this.colNIENKHOA.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colNIENKHOA.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNIENKHOA.AppearanceHeader.Options.UseBackColor = true;
            this.colNIENKHOA.AppearanceHeader.Options.UseFont = true;
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
            this.colHOCKY.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colHOCKY.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHOCKY.AppearanceHeader.Options.UseBackColor = true;
            this.colHOCKY.AppearanceHeader.Options.UseFont = true;
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
            this.colHOCPHI.Caption = "Số tiền cần đóng";
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
            this.colPADED.Caption = "Số tiền đã đóng";
            this.colPADED.FieldName = "PADED";
            this.colPADED.MinWidth = 25;
            this.colPADED.Name = "colPADED";
            this.colPADED.Visible = true;
            this.colPADED.VisibleIndex = 3;
            this.colPADED.Width = 94;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.label6);
            this.panelControl2.Controls.Add(this.label5);
            this.panelControl2.Controls.Add(this.label4);
            this.panelControl2.Controls.Add(this.nmMoney);
            this.panelControl2.Controls.Add(this.txtSemester);
            this.panelControl2.Controls.Add(this.txtShoolYear);
            this.panelControl2.Controls.Add(this.txtFullname);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Controls.Add(this.lkStudent);
            this.panelControl2.Controls.Add(this.txtClass);
            this.panelControl2.Controls.Add(this.label3);
            this.panelControl2.Controls.Add(this.label2);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 78);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1515, 152);
            this.panelControl2.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1070, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Số tiền cần đóng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1070, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Học kỳ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1070, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Niên khóa";
            // 
            // nmMoney
            // 
            this.nmMoney.Location = new System.Drawing.Point(1198, 90);
            this.nmMoney.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nmMoney.Name = "nmMoney";
            this.nmMoney.Size = new System.Drawing.Size(152, 23);
            this.nmMoney.TabIndex = 11;
            // 
            // txtSemester
            // 
            this.txtSemester.Location = new System.Drawing.Point(1198, 52);
            this.txtSemester.Name = "txtSemester";
            this.txtSemester.Properties.ReadOnly = true;
            this.txtSemester.Size = new System.Drawing.Size(152, 22);
            this.txtSemester.TabIndex = 10;
            // 
            // txtShoolYear
            // 
            this.txtShoolYear.Location = new System.Drawing.Point(1198, 14);
            this.txtShoolYear.Name = "txtShoolYear";
            this.txtShoolYear.Properties.ReadOnly = true;
            this.txtShoolYear.Size = new System.Drawing.Size(152, 22);
            this.txtShoolYear.TabIndex = 10;
            // 
            // formTuitionFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1515, 803);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.sP_PAY_TUITIONFEEGridControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "formTuitionFee";
            this.Text = "formTuitionFee";
            this.Load += new System.EventHandler(this.formTuitionFee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtFullname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkStudent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_PAY_TUITIONFEEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_PAY_TUITIONFEEGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSemester.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShoolYear.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnShowDetail;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnPayMoney;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtFullname;
        private DevExpress.XtraEditors.TextEdit txtClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.LookUpEdit lkStudent;
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
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.TextEdit txtShoolYear;
        private System.Windows.Forms.NumericUpDown nmMoney;
        private DevExpress.XtraEditors.TextEdit txtSemester;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}