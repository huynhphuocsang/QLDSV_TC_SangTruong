
namespace QLDSVHTC_Sang_Truong.formDesign
{
    partial class RpfStudentScores
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
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RpfStudentScores));
            this.btnInDS = new DevExpress.XtraEditors.SimpleButton();
            this.vDSNIENKHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSV_TCDataSet = new QLDSVHTC_Sang_Truong.QLDSV_TCDataSet();
            this.v_DS_NIENKHOATableAdapter = new QLDSVHTC_Sang_Truong.QLDSV_TCDataSetTableAdapters.V_DS_NIENKHOATableAdapter();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new QLDSVHTC_Sang_Truong.QLDSV_TCDataSetTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSVHTC_Sang_Truong.QLDSV_TCDataSetTableAdapters.TableAdapterManager();
            this.sINHVIENTableAdapter = new QLDSVHTC_Sang_Truong.QLDSV_TCDataSetTableAdapters.SINHVIENTableAdapter();
            this.bdsSINHVIEN = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vDSNIENKHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSINHVIEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(291, 74);
            label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(42, 21);
            label3.TabIndex = 29;
            label3.Text = "Lớp:";
            // 
            // btnInDS
            // 
            this.btnInDS.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnInDS.ImageOptions.SvgImage")));
            this.btnInDS.Location = new System.Drawing.Point(436, 445);
            this.btnInDS.Margin = new System.Windows.Forms.Padding(5);
            this.btnInDS.Name = "btnInDS";
            this.btnInDS.Size = new System.Drawing.Size(190, 60);
            this.btnInDS.TabIndex = 25;
            this.btnInDS.Text = "IN BẢNG ĐIỂM";
            this.btnInDS.Click += new System.EventHandler(this.btnInDS_Click);
            // 
            // vDSNIENKHOABindingSource
            // 
            this.vDSNIENKHOABindingSource.DataMember = "V_DS_NIENKHOA";
            this.vDSNIENKHOABindingSource.DataSource = this.qLDSV_TCDataSet;
            // 
            // qLDSV_TCDataSet
            // 
            this.qLDSV_TCDataSet.DataSetName = "QLDSV_TCDataSet";
            this.qLDSV_TCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_DS_NIENKHOATableAdapter
            // 
            this.v_DS_NIENKHOATableAdapter.ClearBeforeFill = true;
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.qLDSV_TCDataSet;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager.SP_LOAD_LIST_SCORESTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSVHTC_Sang_Truong.QLDSV_TCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // bdsSINHVIEN
            // 
            this.bdsSINHVIEN.DataMember = "FK_SINHVIEN_LOP";
            this.bdsSINHVIEN.DataSource = this.lOPBindingSource;
            // 
            // sINHVIENGridControl
            // 
            this.sINHVIENGridControl.DataSource = this.bdsSINHVIEN;
            this.sINHVIENGridControl.Location = new System.Drawing.Point(12, 143);
            this.sINHVIENGridControl.MainView = this.gridView1;
            this.sINHVIENGridControl.Name = "sINHVIENGridControl";
            this.sINHVIENGridControl.Size = new System.Drawing.Size(1028, 280);
            this.sINHVIENGridControl.TabIndex = 31;
            this.sINHVIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.GroupPanel.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.GroupPanel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gridView1.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHO,
            this.colTEN,
            this.colPHAI,
            this.colDIACHI,
            this.colNGAYSINH});
            this.gridView1.GridControl = this.sINHVIENGridControl;
            this.gridView1.GroupPanelText = "DANH SÁCH SINH VIÊN";
            this.gridView1.Name = "gridView1";
            // 
            // colMASV
            // 
            this.colMASV.AppearanceCell.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMASV.AppearanceCell.Options.UseFont = true;
            this.colMASV.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colMASV.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMASV.AppearanceHeader.Options.UseBackColor = true;
            this.colMASV.AppearanceHeader.Options.UseFont = true;
            this.colMASV.AppearanceHeader.Options.UseTextOptions = true;
            this.colMASV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMASV.Caption = "Mã sinh viên";
            this.colMASV.FieldName = "MASV";
            this.colMASV.MinWidth = 25;
            this.colMASV.Name = "colMASV";
            this.colMASV.OptionsColumn.AllowEdit = false;
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            this.colMASV.Width = 94;
            // 
            // colHO
            // 
            this.colHO.AppearanceCell.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHO.AppearanceCell.Options.UseFont = true;
            this.colHO.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colHO.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHO.AppearanceHeader.Options.UseBackColor = true;
            this.colHO.AppearanceHeader.Options.UseFont = true;
            this.colHO.AppearanceHeader.Options.UseTextOptions = true;
            this.colHO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 25;
            this.colHO.Name = "colHO";
            this.colHO.OptionsColumn.AllowEdit = false;
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 94;
            // 
            // colTEN
            // 
            this.colTEN.AppearanceCell.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTEN.AppearanceCell.Options.UseFont = true;
            this.colTEN.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colTEN.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTEN.AppearanceHeader.Options.UseBackColor = true;
            this.colTEN.AppearanceHeader.Options.UseFont = true;
            this.colTEN.AppearanceHeader.Options.UseTextOptions = true;
            this.colTEN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 25;
            this.colTEN.Name = "colTEN";
            this.colTEN.OptionsColumn.AllowEdit = false;
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 94;
            // 
            // colPHAI
            // 
            this.colPHAI.AppearanceCell.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPHAI.AppearanceCell.Options.UseFont = true;
            this.colPHAI.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colPHAI.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPHAI.AppearanceHeader.Options.UseBackColor = true;
            this.colPHAI.AppearanceHeader.Options.UseFont = true;
            this.colPHAI.AppearanceHeader.Options.UseTextOptions = true;
            this.colPHAI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPHAI.Caption = "Phái (tích là nữ)";
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 25;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.OptionsColumn.AllowEdit = false;
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 3;
            this.colPHAI.Width = 94;
            // 
            // colDIACHI
            // 
            this.colDIACHI.AppearanceCell.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDIACHI.AppearanceCell.Options.UseFont = true;
            this.colDIACHI.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colDIACHI.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDIACHI.AppearanceHeader.Options.UseBackColor = true;
            this.colDIACHI.AppearanceHeader.Options.UseFont = true;
            this.colDIACHI.AppearanceHeader.Options.UseTextOptions = true;
            this.colDIACHI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 25;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.AllowEdit = false;
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            this.colDIACHI.Width = 94;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.AppearanceCell.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNGAYSINH.AppearanceCell.Options.UseFont = true;
            this.colNGAYSINH.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colNGAYSINH.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNGAYSINH.AppearanceHeader.Options.UseBackColor = true;
            this.colNGAYSINH.AppearanceHeader.Options.UseFont = true;
            this.colNGAYSINH.AppearanceHeader.Options.UseTextOptions = true;
            this.colNGAYSINH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNGAYSINH.Caption = "Ngày sinh";
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.MinWidth = 25;
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.OptionsColumn.AllowEdit = false;
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 5;
            this.colNGAYSINH.Width = 94;
            // 
            // cbLop
            // 
            this.cbLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPBindingSource, "TENLOP", true));
            this.cbLop.DataSource = this.lOPBindingSource;
            this.cbLop.DisplayMember = "TENLOP";
            this.cbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLop.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(341, 71);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(371, 29);
            this.cbLop.TabIndex = 32;
            this.cbLop.ValueMember = "MALOP";
            // 
            // cbDepartment
            // 
            this.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartment.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(378, 0);
            this.cbDepartment.Margin = new System.Windows.Forms.Padding(5);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(323, 29);
            this.cbDepartment.TabIndex = 34;
            this.cbDepartment.SelectedIndexChanged += new System.EventHandler(this.cbDepartment_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(274, -5);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 40);
            this.label1.TabIndex = 33;
            this.label1.Text = "KHOA:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RpfStudentScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 528);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLop);
            this.Controls.Add(this.sINHVIENGridControl);
            this.Controls.Add(label3);
            this.Controls.Add(this.btnInDS);
            this.Name = "RpfStudentScores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Điểm tổng kết sinh viên";
            this.Load += new System.EventHandler(this.RpfStudentScores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vDSNIENKHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSINHVIEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnInDS;
        private QLDSV_TCDataSet qLDSV_TCDataSet;
        private System.Windows.Forms.BindingSource vDSNIENKHOABindingSource;
        private QLDSV_TCDataSetTableAdapters.V_DS_NIENKHOATableAdapter v_DS_NIENKHOATableAdapter;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private QLDSV_TCDataSetTableAdapters.LOPTableAdapter lOPTableAdapter;
        private QLDSV_TCDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private QLDSV_TCDataSetTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.BindingSource bdsSINHVIEN;
        private DevExpress.XtraGrid.GridControl sINHVIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Label label1;
    }
}