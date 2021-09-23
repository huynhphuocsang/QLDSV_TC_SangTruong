
namespace QLDSVHTC_Sang_Truong.formDesign
{
    partial class formLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTK = new DevExpress.XtraEditors.TextEdit();
            this.label = new System.Windows.Forms.Label();
            this.txtPass = new DevExpress.XtraEditors.TextEdit();
            this.cbPhongBan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.ckPass = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(285, 102);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(183, 22);
            this.txtTK.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(185, 188);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(64, 17);
            this.label.TabIndex = 0;
            this.label.Text = "Mật khẩu";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(285, 185);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(183, 22);
            this.txtPass.TabIndex = 1;
            // 
            // cbPhongBan
            // 
            this.cbPhongBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhongBan.FormattingEnabled = true;
            this.cbPhongBan.Location = new System.Drawing.Point(281, 43);
            this.cbPhongBan.Name = "cbPhongBan";
            this.cbPhongBan.Size = new System.Drawing.Size(187, 24);
            this.cbPhongBan.TabIndex = 2;
            this.cbPhongBan.SelectedIndexChanged += new System.EventHandler(this.cbPhongBan_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chọn khoa";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(213, 269);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(94, 29);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(370, 269);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ckPass
            // 
            this.ckPass.AutoSize = true;
            this.ckPass.Location = new System.Drawing.Point(507, 188);
            this.ckPass.Name = "ckPass";
            this.ckPass.Size = new System.Drawing.Size(118, 21);
            this.ckPass.TabIndex = 4;
            this.ckPass.Text = "Hiện mật khẩu";
            this.ckPass.UseVisualStyleBackColor = true;
            this.ckPass.CheckedChanged += new System.EventHandler(this.ckPass_CheckedChanged);
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 417);
            this.Controls.Add(this.ckPass);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cbPhongBan);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "formLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fromLogin";
            this.Load += new System.EventHandler(this.fromLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtTK;
        private System.Windows.Forms.Label label;
        private DevExpress.XtraEditors.TextEdit txtPass;
        private System.Windows.Forms.ComboBox cbPhongBan;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.CheckBox ckPass;
    }
}