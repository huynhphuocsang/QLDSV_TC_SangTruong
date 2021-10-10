
namespace QLDSVHTC_Sang_Truong.formDesign
{
    partial class RpfStudentListCreditClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RpfStudentListCreditClass));
            this.cbSchoolyear = new System.Windows.Forms.ComboBox();
            this.lkSubject = new DevExpress.XtraEditors.LookUpEdit();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSV_TCDataSet = new QLDSVHTC_Sang_Truong.QLDSV_TCDataSet();
            this.nmSemester = new System.Windows.Forms.NumericUpDown();
            this.nmGroup = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.mONHOCTableAdapter = new QLDSVHTC_Sang_Truong.QLDSV_TCDataSetTableAdapters.MONHOCTableAdapter();
            this.btnPreview = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.lkSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSemester)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSchoolyear
            // 
            this.cbSchoolyear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSchoolyear.FormattingEnabled = true;
            this.cbSchoolyear.Items.AddRange(new object[] {
            "2019-2020",
            "2020-2021",
            "2021-2022",
            "2022-2023",
            "2023-2024"});
            this.cbSchoolyear.Location = new System.Drawing.Point(316, 95);
            this.cbSchoolyear.Name = "cbSchoolyear";
            this.cbSchoolyear.Size = new System.Drawing.Size(197, 24);
            this.cbSchoolyear.TabIndex = 0;
            // 
            // lkSubject
            // 
            this.lkSubject.Location = new System.Drawing.Point(316, 245);
            this.lkSubject.Name = "lkSubject";
            this.lkSubject.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkSubject.Properties.DataSource = this.mONHOCBindingSource;
            this.lkSubject.Properties.DisplayMember = "TENMH";
            this.lkSubject.Properties.NullText = "Chọn môn học";
            this.lkSubject.Properties.ValueMember = "MAMH";
            this.lkSubject.Size = new System.Drawing.Size(197, 22);
            this.lkSubject.TabIndex = 1;
            this.lkSubject.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.lkSubject_CustomDisplayText);
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.qLDSV_TCDataSet;
            // 
            // qLDSV_TCDataSet
            // 
            this.qLDSV_TCDataSet.DataSetName = "QLDSV_TCDataSet";
            this.qLDSV_TCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nmSemester
            // 
            this.nmSemester.Location = new System.Drawing.Point(316, 168);
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
            this.nmSemester.Size = new System.Drawing.Size(120, 23);
            this.nmSemester.TabIndex = 2;
            this.nmSemester.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nmGroup
            // 
            this.nmGroup.Location = new System.Drawing.Point(316, 311);
            this.nmGroup.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmGroup.Name = "nmGroup";
            this.nmGroup.Size = new System.Drawing.Size(120, 23);
            this.nmGroup.TabIndex = 2;
            this.nmGroup.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(101, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Niên khóa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(101, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Học kỳ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(101, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Môn học";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(101, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhóm";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(200, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 35);
            this.label5.TabIndex = 3;
            this.label5.Text = "KHOA";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbDepartment
            // 
            this.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Items.AddRange(new object[] {
            "2019-2020",
            "2020-2021",
            "2021-2022",
            "2022-2023",
            "2023-2024"});
            this.cbDepartment.Location = new System.Drawing.Point(316, 36);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(197, 24);
            this.cbDepartment.TabIndex = 0;
            this.cbDepartment.SelectedIndexChanged += new System.EventHandler(this.cbDepartment_SelectedIndexChanged);
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Appearance.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPreview.Appearance.Options.UseFont = true;
            this.btnPreview.Appearance.Options.UseForeColor = true;
            this.btnPreview.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPreview.ImageOptions.SvgImage")));
            this.btnPreview.Location = new System.Drawing.Point(301, 385);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(150, 41);
            this.btnPreview.TabIndex = 4;
            this.btnPreview.Text = "Xem bản thảo";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // RpfStudentListCreditClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 494);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmGroup);
            this.Controls.Add(this.nmSemester);
            this.Controls.Add(this.lkSubject);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.cbSchoolyear);
            this.Name = "RpfStudentListCreditClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In danh sách sinh viên theo lớp tín chỉ";
            this.Load += new System.EventHandler(this.RpfStudentListCreditClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lkSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSemester)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSchoolyear;
        private DevExpress.XtraEditors.LookUpEdit lkSubject;
        private System.Windows.Forms.NumericUpDown nmSemester;
        private System.Windows.Forms.NumericUpDown nmGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbDepartment;
        private QLDSV_TCDataSet qLDSV_TCDataSet;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private QLDSV_TCDataSetTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnPreview;
    }
}