
namespace QLDSVHTC_Sang_Truong.formDesign
{
    partial class formCreateLogin
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
            System.Windows.Forms.Label hOTENLabel;
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NhomQuyenGroup = new DevExpress.XtraEditors.RadioGroup();
            this.lookUpUser = new DevExpress.XtraEditors.LookUpEdit();
            this.gIANGVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSV_TCDataSet = new QLDSVHTC_Sang_Truong.QLDSV_TCDataSet();
            this.taoLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.showConfirmPass = new System.Windows.Forms.CheckBox();
            this.PassWord = new System.Windows.Forms.CheckBox();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gIANGVIENTableAdapter = new QLDSVHTC_Sang_Truong.QLDSV_TCDataSetTableAdapters.GIANGVIENTableAdapter();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            hOTENLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NhomQuyenGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.BackColor = System.Drawing.Color.Transparent;
            hOTENLabel.Location = new System.Drawing.Point(354, 331);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(130, 17);
            hOTENLabel.TabIndex = 39;
            hOTENLabel.Text = "CHỌN GIẢNG VIÊN :";
            // 
            // cbDepartment
            // 
            this.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartment.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(525, 61);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(208, 29);
            this.cbDepartment.TabIndex = 5;
            this.cbDepartment.SelectedIndexChanged += new System.EventHandler(this.cbDepartment_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(412, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "KHOA:";
            // 
            // NhomQuyenGroup
            // 
            this.NhomQuyenGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NhomQuyenGroup.EditValue = "PGV";
            this.NhomQuyenGroup.Location = new System.Drawing.Point(516, 370);
            this.NhomQuyenGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NhomQuyenGroup.Name = "NhomQuyenGroup";
            this.NhomQuyenGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.NhomQuyenGroup.Properties.Appearance.BorderColor = System.Drawing.Color.White;
            this.NhomQuyenGroup.Properties.Appearance.Options.UseBackColor = true;
            this.NhomQuyenGroup.Properties.Appearance.Options.UseBorderColor = true;
            this.NhomQuyenGroup.Properties.AppearanceDisabled.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText;
            this.NhomQuyenGroup.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.NhomQuyenGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.NhomQuyenGroup.Properties.Columns = 3;
            this.NhomQuyenGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("PGV", "Phòng Giáo Vụ", true, "PGV"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("KHOA", "KHOA"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("PKT", "Phòng Kế toán")});
            this.NhomQuyenGroup.Properties.NullText = "Chọn nhóm quyền";
            this.NhomQuyenGroup.Size = new System.Drawing.Size(493, 98);
            this.NhomQuyenGroup.TabIndex = 44;
            // 
            // lookUpUser
            // 
            this.lookUpUser.Location = new System.Drawing.Point(520, 327);
            this.lookUpUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lookUpUser.Name = "lookUpUser";
            this.lookUpUser.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.lookUpUser.Properties.Appearance.Options.UseBackColor = true;
            this.lookUpUser.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpUser.Properties.DataSource = this.gIANGVIENBindingSource;
            this.lookUpUser.Properties.DisplayMember = "HO";
            this.lookUpUser.Properties.DropDownRows = 5;
            this.lookUpUser.Properties.NullText = "Chọn mã giảng viên";
            this.lookUpUser.Properties.ValueMember = "MAGV";
            this.lookUpUser.Size = new System.Drawing.Size(350, 22);
            this.lookUpUser.TabIndex = 43;
            this.lookUpUser.EditValueChanged += new System.EventHandler(this.lookUpUser_EditValueChanged);
            // 
            // gIANGVIENBindingSource
            // 
            this.gIANGVIENBindingSource.DataMember = "GIANGVIEN";
            this.gIANGVIENBindingSource.DataSource = this.qLDSV_TCDataSet;
            // 
            // qLDSV_TCDataSet
            // 
            this.qLDSV_TCDataSet.DataSetName = "QLDSV_TCDataSet";
            this.qLDSV_TCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taoLogin
            // 
            this.taoLogin.Location = new System.Drawing.Point(640, 498);
            this.taoLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.taoLogin.Name = "taoLogin";
            this.taoLogin.Size = new System.Drawing.Size(138, 50);
            this.taoLogin.TabIndex = 41;
            this.taoLogin.Text = "TẠO LOGIN";
            this.taoLogin.UseVisualStyleBackColor = true;
            this.taoLogin.Click += new System.EventHandler(this.taoLogin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(380, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "NHÓM QUYỀN :";
            // 
            // showConfirmPass
            // 
            this.showConfirmPass.AutoSize = true;
            this.showConfirmPass.Location = new System.Drawing.Point(891, 266);
            this.showConfirmPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.showConfirmPass.Name = "showConfirmPass";
            this.showConfirmPass.Size = new System.Drawing.Size(118, 21);
            this.showConfirmPass.TabIndex = 37;
            this.showConfirmPass.Text = "Hiện password";
            this.showConfirmPass.UseVisualStyleBackColor = true;
            this.showConfirmPass.CheckedChanged += new System.EventHandler(this.showConfirmPass_CheckedChanged);
            // 
            // PassWord
            // 
            this.PassWord.AutoSize = true;
            this.PassWord.Location = new System.Drawing.Point(891, 209);
            this.PassWord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PassWord.Name = "PassWord";
            this.PassWord.Size = new System.Drawing.Size(118, 21);
            this.PassWord.TabIndex = 38;
            this.PassWord.Text = "Hiện password";
            this.PassWord.UseVisualStyleBackColor = true;
            this.PassWord.CheckedChanged += new System.EventHandler(this.PassWord_CheckedChanged);
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(516, 261);
            this.txtConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(354, 23);
            this.txtConfirm.TabIndex = 35;
            this.txtConfirm.UseSystemPasswordChar = true;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(516, 204);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(354, 23);
            this.txtPass.TabIndex = 36;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(354, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Nhập lại mật khẩu:";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(516, 138);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(354, 23);
            this.txtLogin.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(410, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(382, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Tên đăng nhập :";
            // 
            // gIANGVIENTableAdapter
            // 
            this.gIANGVIENTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // formCreateLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 663);
            this.Controls.Add(this.NhomQuyenGroup);
            this.Controls.Add(this.lookUpUser);
            this.Controls.Add(this.taoLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(hOTENLabel);
            this.Controls.Add(this.showConfirmPass);
            this.Controls.Add(this.PassWord);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.label1);
            this.Name = "formCreateLogin";
            this.Text = "Tạo tài khoản";
            this.Load += new System.EventHandler(this.formCreateLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NhomQuyenGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.RadioGroup NhomQuyenGroup;
        private DevExpress.XtraEditors.LookUpEdit lookUpUser;
        private System.Windows.Forms.Button taoLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox showConfirmPass;
        private System.Windows.Forms.CheckBox PassWord;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private QLDSV_TCDataSet qLDSV_TCDataSet;
        private System.Windows.Forms.BindingSource gIANGVIENBindingSource;
        private QLDSV_TCDataSetTableAdapters.GIANGVIENTableAdapter gIANGVIENTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}