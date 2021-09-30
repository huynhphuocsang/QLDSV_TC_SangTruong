
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
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSV_TCDataSet = new QLDSVHTC_Sang_Truong.QLDSV_TCDataSet();
            this.sINHVIENTableAdapter = new QLDSVHTC_Sang_Truong.QLDSV_TCDataSetTableAdapters.SINHVIENTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.tableAdapterManager = new QLDSVHTC_Sang_Truong.QLDSV_TCDataSetTableAdapters.TableAdapterManager();
            this.txtFullname = new DevExpress.XtraEditors.TextEdit();
            this.txtClass = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.qLDSV_TCDataSet1 = new QLDSVHTC_Sang_Truong.QLDSV_TCDataSet1();
            this.sP_PAY_TUITIONFEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_PAY_TUITIONFEETableAdapter = new QLDSVHTC_Sang_Truong.QLDSV_TCDataSet1TableAdapters.SP_PAY_TUITIONFEETableAdapter();
            this.tableAdapterManager1 = new QLDSVHTC_Sang_Truong.QLDSV_TCDataSet1TableAdapters.TableAdapterManager();
            this.sP_PAY_TUITIONFEEGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNIENKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTOTAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPAYED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_PAY_TUITIONFEEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_PAY_TUITIONFEEGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
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
            this.panelControl1.Size = new System.Drawing.Size(1272, 78);
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
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource.DataSource = this.qLDSV_TCDataSet;
            // 
            // qLDSV_TCDataSet
            // 
            this.qLDSV_TCDataSet.DataSetName = "QLDSV_TCDataSet";
            this.qLDSV_TCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã sinh viên";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLDSVHTC_Sang_Truong.QLDSV_TCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(128, 171);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Properties.ReadOnly = true;
            this.txtFullname.Size = new System.Drawing.Size(125, 22);
            this.txtFullname.TabIndex = 3;
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(128, 227);
            this.txtClass.Name = "txtClass";
            this.txtClass.Properties.ReadOnly = true;
            this.txtClass.Size = new System.Drawing.Size(125, 22);
            this.txtClass.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Họ và tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lớp";
            // 
            // qLDSV_TCDataSet1
            // 
            this.qLDSV_TCDataSet1.DataSetName = "QLDSV_TCDataSet1";
            this.qLDSV_TCDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CT_DONGHOCPHITableAdapter = null;
            this.tableAdapterManager1.GIANGVIENTableAdapter = null;
            this.tableAdapterManager1.HOCPHITableAdapter = null;
            this.tableAdapterManager1.KHOATableAdapter = null;
            this.tableAdapterManager1.LOPTableAdapter = null;
            this.tableAdapterManager1.SINHVIENTableAdapter = null;
            this.tableAdapterManager1.SP_PAY_TUITIONFEETableAdapter = this.sP_PAY_TUITIONFEETableAdapter;
            this.tableAdapterManager1.UpdateOrder = QLDSVHTC_Sang_Truong.QLDSV_TCDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sP_PAY_TUITIONFEEGridControl
            // 
            this.sP_PAY_TUITIONFEEGridControl.DataSource = this.sP_PAY_TUITIONFEEBindingSource;
            this.sP_PAY_TUITIONFEEGridControl.Location = new System.Drawing.Point(540, 333);
            this.sP_PAY_TUITIONFEEGridControl.MainView = this.gridView1;
            this.sP_PAY_TUITIONFEEGridControl.Name = "sP_PAY_TUITIONFEEGridControl";
            this.sP_PAY_TUITIONFEEGridControl.Size = new System.Drawing.Size(630, 354);
            this.sP_PAY_TUITIONFEEGridControl.TabIndex = 8;
            this.sP_PAY_TUITIONFEEGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNIENKHOA,
            this.colHOCKY,
            this.colTOTAL,
            this.colPAYED});
            this.gridView1.GridControl = this.sP_PAY_TUITIONFEEGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colNIENKHOA
            // 
            this.colNIENKHOA.FieldName = "NIENKHOA";
            this.colNIENKHOA.MinWidth = 25;
            this.colNIENKHOA.Name = "colNIENKHOA";
            this.colNIENKHOA.Visible = true;
            this.colNIENKHOA.VisibleIndex = 0;
            this.colNIENKHOA.Width = 94;
            // 
            // colHOCKY
            // 
            this.colHOCKY.FieldName = "HOCKY";
            this.colHOCKY.MinWidth = 25;
            this.colHOCKY.Name = "colHOCKY";
            this.colHOCKY.Visible = true;
            this.colHOCKY.VisibleIndex = 1;
            this.colHOCKY.Width = 94;
            // 
            // colTOTAL
            // 
            this.colTOTAL.FieldName = "TOTAL";
            this.colTOTAL.MinWidth = 25;
            this.colTOTAL.Name = "colTOTAL";
            this.colTOTAL.Visible = true;
            this.colTOTAL.VisibleIndex = 2;
            this.colTOTAL.Width = 94;
            // 
            // colPAYED
            // 
            this.colPAYED.FieldName = "PAYED";
            this.colPAYED.MinWidth = 25;
            this.colPAYED.Name = "colPAYED";
            this.colPAYED.Visible = true;
            this.colPAYED.VisibleIndex = 3;
            this.colPAYED.Width = 94;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(128, 106);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MASV", "MASV", 5, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HO", "HO", 5, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TEN", "TEN", 5, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PHAI", "PHAI", 5, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DIACHI", "DIACHI", 5, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NGAYSINH", "NGAYSINH", 5, DevExpress.Utils.FormatType.DateTime, "M/d/yyyy", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MALOP", "MALOP", 5, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpEdit1.Properties.DataSource = this.sINHVIENBindingSource;
            this.lookUpEdit1.Properties.DisplayMember = "MASV";
            this.lookUpEdit1.Properties.NullText = "Tìm mã sinh viên ";
            this.lookUpEdit1.Properties.ShowHeader = false;
            this.lookUpEdit1.Properties.ValueMember = "MASV";
            this.lookUpEdit1.Size = new System.Drawing.Size(856, 22);
            this.lookUpEdit1.TabIndex = 1;
            this.lookUpEdit1.EditValueChanged += new System.EventHandler(this.lookUpEdit1_EditValueChanged);
            // 
            // formTuitionFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 803);
            this.Controls.Add(this.sP_PAY_TUITIONFEEGridControl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lookUpEdit1);
            this.Controls.Add(this.panelControl1);
            this.Name = "formTuitionFee";
            this.Text = "formTuitionFee";
            this.Load += new System.EventHandler(this.formTuitionFee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_PAY_TUITIONFEEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_PAY_TUITIONFEEGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnShowDetail;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnPayMoney;
        private QLDSV_TCDataSet qLDSV_TCDataSet;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private QLDSV_TCDataSetTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.Label label1;
        private QLDSV_TCDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit txtFullname;
        private DevExpress.XtraEditors.TextEdit txtClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private QLDSV_TCDataSet1 qLDSV_TCDataSet1;
        private System.Windows.Forms.BindingSource sP_PAY_TUITIONFEEBindingSource;
        private QLDSV_TCDataSet1TableAdapters.SP_PAY_TUITIONFEETableAdapter sP_PAY_TUITIONFEETableAdapter;
        private QLDSV_TCDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private DevExpress.XtraGrid.GridControl sP_PAY_TUITIONFEEGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colNIENKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCKY;
        private DevExpress.XtraGrid.Columns.GridColumn colTOTAL;
        private DevExpress.XtraGrid.Columns.GridColumn colPAYED;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
    }
}