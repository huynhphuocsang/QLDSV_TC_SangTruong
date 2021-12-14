using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private CommandManagerForCredit cmdManager;
        
        //private int totalOfficalClass = 0; 
        public formManageCreditClass()
        {
            InitializeComponent();
            cmdManager = new CommandManagerForCredit();
        }

        private void lOPTINCHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPTINCHIBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSV_TCDataSet);

        }

        private void formManageCreditClass_Load(object sender, EventArgs e)
        {
          
            this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr; 
            this.dANGKYTableAdapter.Fill(this.qLDSV_TCDataSet.DANGKY);

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
            
            btnUndo.Enabled = btnRedo.Enabled = false;
            //totalOfficalClass = lOPTINCHIBindingSource.Count; 

        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            
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
            try
            {
                string subject = gridView1.GetRowCellValue(gridView1.RowCount - 1, "MAMH").ToString();
                string teacher = gridView1.GetRowCellValue(gridView1.RowCount - 1, "MAGV").ToString();
                if (checkEmpty(subject, teacher)) return;


                this.Validate();
                this.lOPTINCHIBindingSource.EndEdit();
                this.lOPTINCHITableAdapter.Update(this.qLDSV_TCDataSet.LOPTINCHI);
                //this.totalOfficalClass = lOPTINCHIBindingSource.Count;
                XtraMessageBox.Show("Lưu dữ liệu mới thành công", "Thông báo!", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lớp tín chỉ bị trùng lại 'Nhóm-Môn học-Học kỳ-Niên khóa'","Lỗi khi lưu! Hãy kiểm tra lại thông tin", MessageBoxButtons.OK); 
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (lOPTINCHIBindingSource.Count > 0)
            {
                
                string subject = gridView1.GetRowCellValue(gridView1.DataRowCount-1, "MAMH").ToString();
                string teacherCode = gridView1.GetRowCellValue(gridView1.DataRowCount-1, "MAGV").ToString();
                if(subject =="" || teacherCode == "")
                {
                    XtraMessageBox.Show("Bạn phải hoàn thành thao tác trước đó!","Cảnh báo!", MessageBoxButtons.OK);
                    return; 
                }
            }


            cmdManager.execute(new InsertActionForCredit(lOPTINCHIBindingSource));
            if (cbDepartment.SelectedIndex == 0)
            {
                gridView1.SetFocusedRowCellValue("MAKHOA", "CNTT");
            }
            else if (cbDepartment.SelectedIndex == 1)
            {
                gridView1.SetFocusedRowCellValue("MAKHOA", "VT"); 
            }
            

            gridView1.SetFocusedRowCellValue("NIENKHOA", cbxShoolyear.Items[0]);
            gridView1.SetFocusedRowCellValue("HOCKY", 1);
            gridView1.SetFocusedRowCellValue("MAMH","");
            gridView1.SetFocusedRowCellValue("NHOM", 1);
            gridView1.SetFocusedRowCellValue("MAGV", "");
            gridView1.SetFocusedRowCellValue("SOSVTOITHIEU", 10);
            gridView1.SetFocusedRowCellValue("HUYLOP", false);

            gridView1.FocusedRowHandle = gridView1.DataRowCount;
            btnUndo.Enabled = true; 
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            cmdManager.clear();
            btnUndo.Enabled = false;
            btnRedo.Enabled = false;
            this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTINCHITableAdapter.Fill(this.qLDSV_TCDataSet.LOPTINCHI);

            XtraMessageBox.Show("Load dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lOPTINCHIBindingSource.Count == 0)
            {
                XtraMessageBox.Show("Không còn lớp để xóa","Cảnh báo!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if (dANGKYBindingSource.Count > 0)
            {
                MessageBox.Show("Không thể xóa lớp này vì đã có người đăng ký!\nGợi ý: hãy 'Hủy' lớp");
                return; 
            }
            cmdManager.execute(new DeleteActionForCredit(lOPTINCHIBindingSource));
            btnUndo.Enabled = true; 
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            cmdManager.undo();
            if (cmdManager.undoStackSize() == 0)
            {
                btnUndo.Enabled = false;
            }
            btnRedo.Enabled = true;
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            cmdManager.redo();
            if (cmdManager.redoStackSize() == 0)
            {
                btnRedo.Enabled = false;
            }
            btnUndo.Enabled = true;
        }

        private void gridView1_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (gridView1.FocusedColumn.FieldName == "MAMH" || gridView1.FocusedColumn.FieldName == "NHOM" || gridView1.FocusedColumn.FieldName == "HOCKY"|| gridView1.FocusedColumn.FieldName == "NIENKHOA")
            {

                string schoolYear = (gridView1.FocusedColumn.FieldName != "NIENKHOA") ?gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NIENKHOA").ToString() : e.Value as string;
                int semester = (gridView1.FocusedColumn.FieldName != "HOCKY") ? int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HOCKY").ToString()) : int.Parse(e.Value.ToString());
                string subjectCode = (gridView1.FocusedColumn.FieldName != "MAMH") ? gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAMH").ToString() : e.Value as string;
                int group = (gridView1.FocusedColumn.FieldName != "NHOM") ? int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NHOM").ToString()): int.Parse(e.Value.ToString());

                if (subjectCode != "" && schoolYear != "" && semester != 0 && group != 0)
                {
                    int checkValue = this.checkExistValue(schoolYear, semester, subjectCode, group);

                    if (checkValue == 1)
                    {
                        e.Valid = false;
                        e.ErrorText = "Lớp tín chỉ này đã bị trùng ở khoa khác!";
                        MessageBox.Show(this, "Lớp tín chỉ này đã bị trùng ở khoa khác!", "Thông báo!", MessageBoxButtons.OK);
                    }
                }

            }


            // không cho update vì phải xử lý thêm nhiều trường hợp null; 
            //if (lOPTINCHIBindingSource.Position < totalOfficalClass)
            //{
            //    cmdManager.execute(new UpdateActionForCredit(lOPTINCHIBindingSource));
            //}

            //if (gridView1.FocusedColumn.FieldName != "NIENKHOA")
            //{
            //    if (lOPTINCHIBindingSource.Position < totalOfficalClass)
            //    {
            //        cmdManager.execute(new UpdateAction(lOPTINCHIBindingSource));
            //    }


            //}

            //if (gridView1.FocusedColumn.FieldName == "NIENKHOA")
            //{
            //    if (lOPTINCHIBindingSource.Position < totalOfficalClass)
            //    {
            //        cmdManager.execute(new UpdateAction(lOPTINCHIBindingSource)); 
            //    }


            //}
            //else if (gridView1.FocusedColumn.FieldName == "HOCKY")
            //{
            //    if (lOPTINCHIBindingSource.Position < totalOfficalClass)
            //    {
            //        cmdManager.execute(new UpdateAction(lOPTINCHIBindingSource));
            //    }
            //}
            //else if (gridView1.FocusedColumn.FieldName == "MAMH")
            //{
            //    if (lOPTINCHIBindingSource.Position < totalOfficalClass)
            //    {
            //        cmdManager.execute(new UpdateAction(lOPTINCHIBindingSource));
            //    }
            //}
            //else if (gridView1.FocusedColumn.FieldName == "NHOM")
            //{

            //}else if(gridView1.FocusedColumn.FieldName == "MAGV")
            //{
            //    if (lOPTINCHIBindingSource.Position < totalOfficalClass)
            //    {
            //        cmdManager.execute(new UpdateAction(lOPTINCHIBindingSource));
            //    }
            //}
            //else if (gridView1.FocusedColumn.FieldName == "SOSVTOITHIEU")
            //{
            //    if (lOPTINCHIBindingSource.Position < totalOfficalClass)
            //    {
            //        cmdManager.execute(new UpdateAction(lOPTINCHIBindingSource));
            //    }
            //}
            //else if (gridView1.FocusedColumn.FieldName == "HUYLOP")
            //{
            //    if (lOPTINCHIBindingSource.Position < totalOfficalClass)
            //    {
            //        cmdManager.execute(new UpdateAction(lOPTINCHIBindingSource));
            //    }
            //}

        }

            public bool checkEmpty(string subject, string teacher)
        {
            if (subject.Trim().Equals(""))
            {
                XtraMessageBox.Show("Môn không được rỗng!", "Cảnh báo!", MessageBoxButtons.OK);
                return true;
            }
            if (teacher.Trim().Equals(""))
            {
                XtraMessageBox.Show("Giảng viên không được rỗng!", "Cảnh báo!", MessageBoxButtons.OK);
                return true;
            }
            return false; 
        }
        private int checkExistValue(string schoolyear, int semester, string subjectCode, int group)
        {

            
                //kiểm tra tên trước: 
                string queryName = "DECLARE @return_value int "
                   + "EXEC @return_value = [dbo].[SP_CHECK_EXIST_CREDITCLASS] @Nienkhoa = N'" + schoolyear + "', @Hocky ="+semester+",@MaMH = "+subjectCode+ ",@Nhom = "+group+" SELECT  'Return Value' = @return_value";
                SqlDataReader resultClassName = Program.ExecSqlDataReader(queryName);

                if (resultClassName == null)
                {
                    MessageBox.Show("Server bị lỗi");
                    resultClassName.Close();
                    return -1;
                }
                resultClassName.Read();
                int tempvalue = resultClassName.GetInt32(0);
                resultClassName.Close();
                return tempvalue;

        }
    }
}