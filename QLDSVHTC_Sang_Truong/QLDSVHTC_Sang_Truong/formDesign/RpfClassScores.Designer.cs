namespace QLDSVHTC_Sang_Truong.formDesign
{
	partial class RpfClassScores
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label tENMHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RpfClassScores));
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bdsDSNIENKHOA = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSV_TCDataSet = new QLDSVHTC_Sang_Truong.QLDSV_TCDataSet();
            this.bdsDS_MONHOC = new System.Windows.Forms.BindingSource(this.components);
            this.dS_MONHOCTableAdapter = new QLDSVHTC_Sang_Truong.QLDSV_TCDataSetTableAdapters.DS_MONHOCTableAdapter();
            this.tableAdapterManager = new QLDSVHTC_Sang_Truong.QLDSV_TCDataSetTableAdapters.TableAdapterManager();
            this.cbMonHoc = new System.Windows.Forms.ComboBox();
            this.v_DS_NIENKHOATableAdapter = new QLDSVHTC_Sang_Truong.QLDSV_TCDataSetTableAdapters.V_DS_NIENKHOATableAdapter();
            this.btnInDS = new DevExpress.XtraEditors.SimpleButton();
            this.cbHocky = new System.Windows.Forms.NumericUpDown();
            this.cbNhom = new System.Windows.Forms.NumericUpDown();
            this.cbNienkhoa = new System.Windows.Forms.ComboBox();
            nIENKHOALabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSNIENKHOA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDS_MONHOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHocky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNhom)).BeginInit();
            this.SuspendLayout();
            // 
            // nIENKHOALabel
            // 
            nIENKHOALabel.AutoSize = true;
            nIENKHOALabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nIENKHOALabel.Location = new System.Drawing.Point(99, 149);
            nIENKHOALabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            nIENKHOALabel.Name = "nIENKHOALabel";
            nIENKHOALabel.Size = new System.Drawing.Size(83, 21);
            nIENKHOALabel.TabIndex = 10;
            nIENKHOALabel.Text = "Niên khóa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(484, 220);
            label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(58, 20);
            label3.TabIndex = 15;
            label3.Text = "Nhóm:";
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENMHLabel.Location = new System.Drawing.Point(98, 214);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(78, 21);
            tENMHLabel.TabIndex = 17;
            tENMHLabel.Text = "Môn học:";
            // 
            // cbDepartment
            // 
            this.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartment.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(360, 56);
            this.cbDepartment.Margin = new System.Windows.Forms.Padding(5);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(323, 29);
            this.cbDepartment.TabIndex = 3;
            this.cbDepartment.SelectedIndexChanged += new System.EventHandler(this.cbDepartment_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(254, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "KHOA:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(481, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Học kỳ";
            // 
            // bdsDSNIENKHOA
            // 
            this.bdsDSNIENKHOA.DataMember = "V_DS_NIENKHOA";
            this.bdsDSNIENKHOA.DataSource = this.qLDSV_TCDataSet;
            // 
            // qLDSV_TCDataSet
            // 
            this.qLDSV_TCDataSet.DataSetName = "QLDSV_TCDataSet";
            this.qLDSV_TCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDS_MONHOC
            // 
            this.bdsDS_MONHOC.DataMember = "DS_MONHOC";
            this.bdsDS_MONHOC.DataSource = this.qLDSV_TCDataSet;
            // 
            // dS_MONHOCTableAdapter
            // 
            this.dS_MONHOCTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.SP_LOAD_LIST_SCORESTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSVHTC_Sang_Truong.QLDSV_TCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cbMonHoc
            // 
            this.cbMonHoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDS_MONHOC, "TENMH", true));
            this.cbMonHoc.DataSource = this.bdsDS_MONHOC;
            this.cbMonHoc.DisplayMember = "TENMH";
            this.cbMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonHoc.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMonHoc.FormattingEnabled = true;
            this.cbMonHoc.Location = new System.Drawing.Point(192, 214);
            this.cbMonHoc.Name = "cbMonHoc";
            this.cbMonHoc.Size = new System.Drawing.Size(228, 29);
            this.cbMonHoc.TabIndex = 18;
            this.cbMonHoc.ValueMember = "MAMH";
            this.cbMonHoc.SelectedIndexChanged += new System.EventHandler(this.cbMonHoc_SelectedIndexChanged);
            // 
            // v_DS_NIENKHOATableAdapter
            // 
            this.v_DS_NIENKHOATableAdapter.ClearBeforeFill = true;
            // 
            // btnInDS
            // 
            this.btnInDS.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnInDS.ImageOptions.SvgImage")));
            this.btnInDS.Location = new System.Drawing.Point(408, 312);
            this.btnInDS.Margin = new System.Windows.Forms.Padding(5);
            this.btnInDS.Name = "btnInDS";
            this.btnInDS.Size = new System.Drawing.Size(190, 60);
            this.btnInDS.TabIndex = 19;
            this.btnInDS.Text = "IN DANH SÁCH";
            this.btnInDS.Click += new System.EventHandler(this.btnInDS_Click);
            // 
            // cbHocky
            // 
            this.cbHocky.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHocky.Location = new System.Drawing.Point(552, 149);
            this.cbHocky.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.cbHocky.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cbHocky.Name = "cbHocky";
            this.cbHocky.Size = new System.Drawing.Size(120, 28);
            this.cbHocky.TabIndex = 20;
            this.cbHocky.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbNhom
            // 
            this.cbNhom.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNhom.Location = new System.Drawing.Point(552, 217);
            this.cbNhom.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.cbNhom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cbNhom.Name = "cbNhom";
            this.cbNhom.Size = new System.Drawing.Size(120, 28);
            this.cbNhom.TabIndex = 21;
            this.cbNhom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbNienkhoa
            // 
            this.cbNienkhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDSNIENKHOA, "NIENKHOA", true));
            this.cbNienkhoa.DataSource = this.bdsDSNIENKHOA;
            this.cbNienkhoa.DisplayMember = "NIENKHOA";
            this.cbNienkhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNienkhoa.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNienkhoa.FormattingEnabled = true;
            this.cbNienkhoa.Location = new System.Drawing.Point(192, 149);
            this.cbNienkhoa.Name = "cbNienkhoa";
            this.cbNienkhoa.Size = new System.Drawing.Size(228, 29);
            this.cbNienkhoa.TabIndex = 22;
            this.cbNienkhoa.ValueMember = "NIENKHOA";
            // 
            // RpfClassScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 462);
            this.Controls.Add(this.cbNienkhoa);
            this.Controls.Add(this.cbNhom);
            this.Controls.Add(this.cbHocky);
            this.Controls.Add(this.btnInDS);
            this.Controls.Add(tENMHLabel);
            this.Controls.Add(this.cbMonHoc);
            this.Controls.Add(label3);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.label1);
            this.Controls.Add(nIENKHOALabel);
            this.Controls.Add(this.label2);
            this.Name = "RpfClassScores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo điểm lớp tín chỉ";
            this.Load += new System.EventHandler(this.RpfClassScores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSNIENKHOA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDS_MONHOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHocky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNhom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private QLDSV_TCDataSet qLDSV_TCDataSet;
        private System.Windows.Forms.BindingSource bdsDS_MONHOC;
        private QLDSV_TCDataSetTableAdapters.DS_MONHOCTableAdapter dS_MONHOCTableAdapter;
        private QLDSV_TCDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbMonHoc;
        private System.Windows.Forms.BindingSource bdsDSNIENKHOA;
        private QLDSV_TCDataSetTableAdapters.V_DS_NIENKHOATableAdapter v_DS_NIENKHOATableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnInDS;
        private System.Windows.Forms.NumericUpDown cbHocky;
        private System.Windows.Forms.NumericUpDown cbNhom;
        private System.Windows.Forms.ComboBox cbNienkhoa;
    }
}