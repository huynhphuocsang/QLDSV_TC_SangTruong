using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository; 

namespace QLDSVHTC_Sang_Truong.formDesign
{
    public partial class formManageCreditClass : DevExpress.XtraEditors.XtraForm
    {
        public formManageCreditClass()
        {
            InitializeComponent();
        }

        private void lOPTINCHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPTINCHIBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSV_TCDataSet);

        }

        private void formManageCreditClass_Load(object sender, EventArgs e)
        {

            //load combobox: 
            Program.bdsDSPM.Filter = "PHONGBAN LIKE 'KHOA%'";

            //chuyển dữ liệu từ danh sách phân mảnh vào cho combobox.
            func.BindingDataToComBo(cbDepartment, Program.bdsDSPM);
            load();
            if (Program.mGroup.Equals("KHOA"))
            {
                cbDepartment.Enabled = false;
            }
            else if (Program.mGroup.Equals("PGV"))
            {
                cbDepartment.Enabled = true;
            }




            //gridView1.OptionsBehavior.Editable = false;

        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            //string teacherCode = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAGV").ToString();
            //lkTeacher.EditValue = teacherCode;

            //string schoolYear = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NIENKHOA").ToString();

            ////đặc biệt
            ////cbSchoolYear.SelectedIndex = cbSchoolYear.FindString(schoolYear);
            //cbSchoolYear.SelectedItem = schoolYear;

            //int  semester =int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HOCKY").ToString());
            //nmSemester.Value = semester;

            //int group = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NHOM").ToString());
            //nmGroup.Value = group;

            //int minimumStudent = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SOSVTOITHIEU").ToString());
            //nmMinimumStudent.Value = minimumStudent; 
        }
        private void load()
        {


            this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTINCHITableAdapter.Fill(this.qLDSV_TCDataSet.LOPTINCHI);

            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.qLDSV_TCDataSet.MONHOC);
           

            this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIANGVIENTableAdapter.Fill(this.qLDSV_TCDataSet.GIANGVIEN);

            //loadItems(); 
        }
        
        //KẾT HỢP MORE THAN ONE COLUMNS IN LOOKUP EDIT: 
        private void lkTeacher_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {

            RepositoryItemLookUpEdit props;
            if (sender is LookUpEdit)
                props = (sender as LookUpEdit).Properties;
            else
                props = sender as RepositoryItemLookUpEdit;

            if (props != null && (e.Value is string))
            {
                DataRowView row = props.GetDataSourceRowByKeyValue(e.Value) as DataRowView;

                if (row != null)
                {
                    e.DisplayText = String.Format("{0} {1}", row["HO"], row["TEN"]);

                }
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbDepartment.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    Program.servername = cbDepartment.SelectedValue.ToString();
                }
                if (cbDepartment.SelectedIndex != Program.mPhongBan)
                {
                    Program.mlogin = Program.remoteLogin;
                    Program.pass = Program.remotePass;
                }
                else
                {
                    Program.mlogin = Program.mloginDN;
                    Program.pass = Program.passDN;
                }

                if (Program.KetNoi() == 0)
                {
                    MessageBox.Show("Lỗi chuyển khoa", "Thông báo !", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    try
                    {
                        load();

                    }
                    catch (Exception) { }
                }


            }
            catch
            {
                return;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lOPTINCHIGridControl_Click(object sender, EventArgs e)
        {

        }


        private void loadItems()
        {
            lkSubjectEdit.DataSource = mONHOCBindingSource;
            lkSubjectEdit.ValueMember = "MAMH";
            lkSubjectEdit.DisplayMember = "TENMH"; 
        }

        private void lkTeacher_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lkTeacher2_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            RepositoryItemLookUpEdit props;
            if (sender is LookUpEdit)
                props = (sender as LookUpEdit).Properties;
            else
                props = sender as RepositoryItemLookUpEdit;

            if (props != null && (e.Value is string))
            {
                DataRowView row = props.GetDataSourceRowByKeyValue(e.Value) as DataRowView;

                if (row != null)
                {
                    e.DisplayText = String.Format("{0} {1}", row["HO"], row["TEN"]);

                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPTINCHIBindingSource.EndEdit();
            this.lOPTINCHITableAdapter.Update(this.qLDSV_TCDataSet.LOPTINCHI); 

        }
    }
}