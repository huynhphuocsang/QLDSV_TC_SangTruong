
namespace QLDSVHTC_Sang_Truong.formDesign
{
    partial class RpfTuitionFee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RpfTuitionFee));
            this.cbSchoolyear = new System.Windows.Forms.ComboBox();
            this.nmSemester = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lkClass = new DevExpress.XtraEditors.LookUpEdit();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSV_TCDataSet1 = new QLDSVHTC_Sang_Truong.QLDSV_TCDataSet1();
            this.label4 = new System.Windows.Forms.Label();
            this.lOPTableAdapter = new QLDSVHTC_Sang_Truong.QLDSV_TCDataSet1TableAdapters.LOPTableAdapter();
            this.btnPreview = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.nmSemester)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkClass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSchoolyear
            // 
            this.cbSchoolyear.FormattingEnabled = true;
            this.cbSchoolyear.Items.AddRange(new object[] {
            "2019-2020",
            "2020-2021",
            "2021-2022",
            "2022-2023",
            "2023-2024"});
            this.cbSchoolyear.Location = new System.Drawing.Point(244, 178);
            this.cbSchoolyear.Name = "cbSchoolyear";
            this.cbSchoolyear.Size = new System.Drawing.Size(148, 24);
            this.cbSchoolyear.TabIndex = 1;
            // 
            // nmSemester
            // 
            this.nmSemester.Location = new System.Drawing.Point(244, 262);
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
            this.nmSemester.Size = new System.Drawing.Size(85, 23);
            this.nmSemester.TabIndex = 2;
            this.nmSemester.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(138, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Niên khóa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(138, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Học kỳ";
            // 
            // lkClass
            // 
            this.lkClass.Location = new System.Drawing.Point(244, 120);
            this.lkClass.Name = "lkClass";
            this.lkClass.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkClass.Properties.DataSource = this.lOPBindingSource;
            this.lkClass.Properties.DisplayMember = "TENLOP";
            this.lkClass.Properties.NullText = "";
            this.lkClass.Properties.ValueMember = "MALOP";
            this.lkClass.Size = new System.Drawing.Size(244, 22);
            this.lkClass.TabIndex = 4;
            this.lkClass.EditValueChanged += new System.EventHandler(this.lkClass_EditValueChanged);
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.qLDSV_TCDataSet1;
            // 
            // qLDSV_TCDataSet1
            // 
            this.qLDSV_TCDataSet1.DataSetName = "QLDSV_TCDataSet1";
            this.qLDSV_TCDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(138, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lớp";
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // btnPreview
            // 
            this.btnPreview.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPreview.ImageOptions.SvgImage")));
            this.btnPreview.Location = new System.Drawing.Point(215, 339);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(140, 46);
            this.btnPreview.TabIndex = 5;
            this.btnPreview.Text = "Xem bản thảo";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // RpfTuitionFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 459);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.lkClass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nmSemester);
            this.Controls.Add(this.cbSchoolyear);
            this.Name = "RpfTuitionFee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In danh sách sinh viên đóng học phí theo lớp";
            this.Load += new System.EventHandler(this.RpfTuitionFee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmSemester)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkClass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbSchoolyear;
        private System.Windows.Forms.NumericUpDown nmSemester;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.LookUpEdit lkClass;
        private System.Windows.Forms.Label label4;
        private QLDSV_TCDataSet1 qLDSV_TCDataSet1;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private QLDSV_TCDataSet1TableAdapters.LOPTableAdapter lOPTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnPreview;
    }
}