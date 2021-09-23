
namespace QLDSVHTC_Sang_Truong
{
    partial class formClassRegistration
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
            System.Windows.Forms.Label nIENKHOALabel;
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnStart = new DevExpress.XtraEditors.SimpleButton();
            this.nbSemester = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPhase = new DevExpress.XtraEditors.LookUpEdit();
            this.v_DS_NIENKHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSV_TCDataSet = new QLDSVHTC_Sang_Truong.QLDSV_TCDataSet();
            this.v_DS_NIENKHOATableAdapter = new QLDSVHTC_Sang_Truong.QLDSV_TCDataSetTableAdapters.V_DS_NIENKHOATableAdapter();
            this.tableAdapterManager = new QLDSVHTC_Sang_Truong.QLDSV_TCDataSetTableAdapters.TableAdapterManager();
            this.sP_LOAD_REGISTER_INFORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_LOAD_REGISTER_INFORTableAdapter = new QLDSVHTC_Sang_Truong.QLDSV_TCDataSetTableAdapters.SP_LOAD_REGISTER_INFORTableAdapter();
            this.sP_LOAD_REGISTER_INFORGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOSV = new DevExpress.XtraGrid.Columns.GridColumn();
            nIENKHOALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbSemester)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPhase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_NIENKHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LOAD_REGISTER_INFORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LOAD_REGISTER_INFORGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nIENKHOALabel
            // 
            nIENKHOALabel.AutoSize = true;
            nIENKHOALabel.Location = new System.Drawing.Point(89, 44);
            nIENKHOALabel.Name = "nIENKHOALabel";
            nIENKHOALabel.Size = new System.Drawing.Size(68, 17);
            nIENKHOALabel.TabIndex = 0;
            nIENKHOALabel.Text = "Niên khóa";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnStart);
            this.groupControl1.Controls.Add(this.nbSemester);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(nIENKHOALabel);
            this.groupControl1.Controls.Add(this.cbPhase);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(987, 162);
            this.groupControl1.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(5, 31);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(94, 29);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // nbSemester
            // 
            this.nbSemester.Location = new System.Drawing.Point(173, 111);
            this.nbSemester.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nbSemester.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbSemester.Name = "nbSemester";
            this.nbSemester.Size = new System.Drawing.Size(82, 23);
            this.nbSemester.TabIndex = 3;
            this.nbSemester.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Học kỳ";
            // 
            // cbPhase
            // 
            this.cbPhase.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.v_DS_NIENKHOABindingSource, "NIENKHOA", true));
            this.cbPhase.Location = new System.Drawing.Point(173, 67);
            this.cbPhase.Name = "cbPhase";
            this.cbPhase.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPhase.Properties.DataSource = this.v_DS_NIENKHOABindingSource;
            this.cbPhase.Properties.DisplayMember = "NIENKHOA";
            this.cbPhase.Properties.NullText = "Chọn học kỳ";
            this.cbPhase.Properties.ValueMember = "NIENKHOA";
            this.cbPhase.Size = new System.Drawing.Size(165, 22);
            this.cbPhase.TabIndex = 1;
            // 
            // v_DS_NIENKHOABindingSource
            // 
            this.v_DS_NIENKHOABindingSource.DataMember = "V_DS_NIENKHOA";
            this.v_DS_NIENKHOABindingSource.DataSource = this.qLDSV_TCDataSet;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSVHTC_Sang_Truong.QLDSV_TCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sP_LOAD_REGISTER_INFORBindingSource
            // 
            this.sP_LOAD_REGISTER_INFORBindingSource.DataMember = "SP_LOAD_REGISTER_INFOR";
            this.sP_LOAD_REGISTER_INFORBindingSource.DataSource = this.qLDSV_TCDataSet;
            // 
            // sP_LOAD_REGISTER_INFORTableAdapter
            // 
            this.sP_LOAD_REGISTER_INFORTableAdapter.ClearBeforeFill = true;
            // 
            // sP_LOAD_REGISTER_INFORGridControl
            // 
            this.sP_LOAD_REGISTER_INFORGridControl.DataSource = this.sP_LOAD_REGISTER_INFORBindingSource;
            this.sP_LOAD_REGISTER_INFORGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_LOAD_REGISTER_INFORGridControl.Location = new System.Drawing.Point(0, 162);
            this.sP_LOAD_REGISTER_INFORGridControl.MainView = this.gridView1;
            this.sP_LOAD_REGISTER_INFORGridControl.Name = "sP_LOAD_REGISTER_INFORGridControl";
            this.sP_LOAD_REGISTER_INFORGridControl.Size = new System.Drawing.Size(987, 378);
            this.sP_LOAD_REGISTER_INFORGridControl.TabIndex = 3;
            this.sP_LOAD_REGISTER_INFORGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH,
            this.colNHOM,
            this.colHOTEN,
            this.colSOSV});
            this.gridView1.GridControl = this.sP_LOAD_REGISTER_INFORGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMAMH
            // 
            this.colMAMH.AppearanceCell.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAMH.AppearanceCell.Options.UseFont = true;
            this.colMAMH.AppearanceCell.Options.UseTextOptions = true;
            this.colMAMH.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMAMH.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colMAMH.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAMH.AppearanceHeader.Options.UseBackColor = true;
            this.colMAMH.AppearanceHeader.Options.UseFont = true;
            this.colMAMH.AppearanceHeader.Options.UseTextOptions = true;
            this.colMAMH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMAMH.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMAMH.Caption = "Mã môn học";
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.ImageOptions.SvgImageSize = new System.Drawing.Size(0, 1);
            this.colMAMH.MinWidth = 40;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.OptionsColumn.AllowEdit = false;
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            this.colMAMH.Width = 94;
            // 
            // colTENMH
            // 
            this.colTENMH.AppearanceCell.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTENMH.AppearanceCell.Options.UseFont = true;
            this.colTENMH.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colTENMH.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTENMH.AppearanceHeader.Options.UseBackColor = true;
            this.colTENMH.AppearanceHeader.Options.UseFont = true;
            this.colTENMH.AppearanceHeader.Options.UseTextOptions = true;
            this.colTENMH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTENMH.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colTENMH.Caption = "Tên môn học";
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.MinWidth = 40;
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.OptionsColumn.AllowEdit = false;
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            this.colTENMH.Width = 94;
            // 
            // colNHOM
            // 
            this.colNHOM.AppearanceCell.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNHOM.AppearanceCell.Options.UseFont = true;
            this.colNHOM.AppearanceCell.Options.UseTextOptions = true;
            this.colNHOM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNHOM.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colNHOM.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNHOM.AppearanceHeader.Options.UseBackColor = true;
            this.colNHOM.AppearanceHeader.Options.UseFont = true;
            this.colNHOM.AppearanceHeader.Options.UseTextOptions = true;
            this.colNHOM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNHOM.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNHOM.Caption = "Nhóm";
            this.colNHOM.FieldName = "NHOM";
            this.colNHOM.MinWidth = 40;
            this.colNHOM.Name = "colNHOM";
            this.colNHOM.OptionsColumn.AllowEdit = false;
            this.colNHOM.Visible = true;
            this.colNHOM.VisibleIndex = 2;
            this.colNHOM.Width = 94;
            // 
            // colHOTEN
            // 
            this.colHOTEN.AppearanceCell.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHOTEN.AppearanceCell.Options.UseFont = true;
            this.colHOTEN.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colHOTEN.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHOTEN.AppearanceHeader.Options.UseBackColor = true;
            this.colHOTEN.AppearanceHeader.Options.UseFont = true;
            this.colHOTEN.AppearanceHeader.Options.UseTextOptions = true;
            this.colHOTEN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHOTEN.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colHOTEN.Caption = "Tên giảng viên";
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.MinWidth = 40;
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.OptionsColumn.AllowEdit = false;
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 3;
            this.colHOTEN.Width = 94;
            // 
            // colSOSV
            // 
            this.colSOSV.AppearanceCell.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSOSV.AppearanceCell.Options.UseFont = true;
            this.colSOSV.AppearanceCell.Options.UseTextOptions = true;
            this.colSOSV.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSOSV.AppearanceHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.colSOSV.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSOSV.AppearanceHeader.Options.UseBackColor = true;
            this.colSOSV.AppearanceHeader.Options.UseFont = true;
            this.colSOSV.AppearanceHeader.Options.UseTextOptions = true;
            this.colSOSV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSOSV.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSOSV.Caption = "Số lượng sinh viên đăng ký";
            this.colSOSV.FieldName = "SOSV";
            this.colSOSV.MinWidth = 40;
            this.colSOSV.Name = "colSOSV";
            this.colSOSV.OptionsColumn.AllowEdit = false;
            this.colSOSV.Visible = true;
            this.colSOSV.VisibleIndex = 4;
            this.colSOSV.Width = 94;
            // 
            // formClassRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 540);
            this.Controls.Add(this.sP_LOAD_REGISTER_INFORGridControl);
            this.Controls.Add(this.groupControl1);
            this.Name = "formClassRegistration";
            this.Text = "Đăng kí lớp tín chỉ";
            this.Load += new System.EventHandler(this.formClassRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbSemester)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPhase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_NIENKHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LOAD_REGISTER_INFORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LOAD_REGISTER_INFORGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private QLDSV_TCDataSet qLDSV_TCDataSet;
        private System.Windows.Forms.BindingSource v_DS_NIENKHOABindingSource;
        private QLDSV_TCDataSetTableAdapters.V_DS_NIENKHOATableAdapter v_DS_NIENKHOATableAdapter;
        private QLDSV_TCDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.NumericUpDown nbSemester;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.LookUpEdit cbPhase;
        private System.Windows.Forms.BindingSource sP_LOAD_REGISTER_INFORBindingSource;
        private QLDSV_TCDataSetTableAdapters.SP_LOAD_REGISTER_INFORTableAdapter sP_LOAD_REGISTER_INFORTableAdapter;
        private DevExpress.XtraGrid.GridControl sP_LOAD_REGISTER_INFORGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOM;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOSV;
        private DevExpress.XtraEditors.SimpleButton btnStart;
    }
}