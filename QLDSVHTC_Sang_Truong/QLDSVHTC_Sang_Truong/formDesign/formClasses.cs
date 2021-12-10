using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;
using System.Collections.Generic;
using DevExpress.XtraEditors;


namespace QLDSVHTC_Sang_Truong.formDesign
{
    public partial class formClasses : DevExpress.XtraEditors.XtraForm
    {
        
        private bool inValid = false;
        private bool inValidStudent = false;
        private int totalOfficalClass = 0;
        private int totalOfficalSv = 0;
        bool changeClass = false; 
        //tempClassName: dùng để so sánh với tên của lớp trong trường hợp sửa lại tên mới của lớp: 
        
        

        private CommandManager cmdManager;

        private CommandManager cmdManagerSV; 
        public formClasses()
        {
            InitializeComponent();
            cmdManager = new CommandManager();
            cmdManagerSV = new CommandManager(); 
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            string classCode = gridView1.GetRowCellValue(gridView1.RowCount-1,"MALOP").ToString();
            string className = gridView1.GetRowCellValue(gridView1.RowCount-1 , "TENLOP").ToString();
            string classSchoolYear = gridView1.GetRowCellValue(gridView1.RowCount-1 , "KHOAHOC").ToString();
            
            if (checkEmpty(classCode, className, classSchoolYear) == true) return;

            try
            {
                this.Validate();
                this.lOPBindingSource.EndEdit();
                this.lOPTableAdapter.Update(this.qLDSV_TCDataSet.LOP);
                gridView1.ClearColumnErrors();

                totalOfficalClass = lOPBindingSource.Count; 
                bindingNavigatorAddNewItem.Enabled = true;
                changeClass = false; 
                MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK); 
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thêm lớp thất bại!","Thông báo!",MessageBoxButtons.OK); 
            }
            
        }

        private void formClasses_Load(object sender, EventArgs e)
        {
           
            
            Program.bdsDSPM.Filter = "PHONGBAN LIKE 'KHOA%'";

            
            func.BindingDataToComBo(cbDepartment, Program.bdsDSPM);
            load(); 
            if (Program.mGroup.Equals("KHOA"))
            {
                cbDepartment.Enabled = false;
            }else if (Program.mGroup.Equals("PGV"))
            {
                cbDepartment.Enabled = true;
            }

           
            gridView1.ShowingEditor += (s, ex) =>
            {

                

            };



            gridView1.CellValueChanged += (s, ex) =>
             {
                 string classCode = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MALOP").ToString();
                 string className = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TENLOP").ToString();
                 string classSchoolYear = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "KHOAHOC").ToString();
                 btnUndo.Enabled = true;
                 changeClass = true; 
                 if((classCode=="" && className=="" && classSchoolYear == "") || inValid == true)
                 {
                     return; 
                 }
                 else
                 {
                     cmdManager.execute(new UpdateAction(lOPBindingSource));
                 }
                 
             };


            gridView2.CellValueChanged += (s, ex) =>
            {
                string studentCode = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MASV").ToString();
                string firstName = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "HO").ToString();
                string lastName = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "TEN").ToString();
                btnUndoSV.Enabled = true;
                if ((studentCode == "" && firstName == "" && firstName == "") || inValidStudent == true)
                {
                    return;
                }
                else
                {
                    cmdManagerSV.execute(new UpdateAction(svBds)); 
                }

            };

            setReadOnly(); 
            btnUndo.Enabled = btnRedo.Enabled = false;
            btnUndoSV.Enabled = btnRedoSV.Enabled = false; 

            totalOfficalClass = lOPBindingSource.Count;
            totalOfficalSv = svBds.Count; 
        }
        private void load()
        {

            
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet.LOP);

            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet.SINHVIEN);
           
            this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dANGKYTableAdapter.Fill(this.qLDSV_TCDataSet.DANGKY);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
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
                        cmdManager.clear();
                        cmdManagerSV.clear(); 

                    }
                    catch (Exception) { }
                }


            }
            catch
            {
                return;
            }

        }
        
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (lOPBindingSource.Count == 0)
            {
                MessageBox.Show("Không có lớp để xóa!", "Cảnh báo!", MessageBoxButtons.OK);
                return;
            }
            try
            {
                //kiêm tra thử xem liệu lớp đã được tham chiếu hay chưa? 
                if (svBds.Count > 0)
                {
                    MessageBox.Show("Không thể xóa lớp vì đã có sinh viên!", "Cảnh báo!", MessageBoxButtons.OK);
                    return;
                }
                //cmdManager.updatePosition(lOPBindingSource); 
                cmdManager.execute(new DeleteAction(lOPBindingSource));

                btnUndo.Enabled = true;
            }catch(Exception ex)
            {
                XtraMessageBox.Show("Đã xảy ra lỗi khi xóa!", "Thông báo", MessageBoxButtons.OK);
            }
            
           
            
        }

        

        

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
             

            if (lOPBindingSource.Count > 0)
            {


                string classCode = gridView1.GetRowCellValue(gridView1.DataRowCount - 1, "MALOP").ToString();
                string className = gridView1.GetRowCellValue(gridView1.DataRowCount - 1, "TENLOP").ToString();
                if (classCode.Equals("") || className.Equals(""))
                {
                    MessageBox.Show("Bạn phải hoàn tất thao tác trước đó!", "Cảnh báo!", MessageBoxButtons.OK);
                    return;
                }
            }



            cmdManager.execute(new InsertAction(lOPBindingSource));
            
           
             

            if (cbDepartment.SelectedIndex == 0)
            {
                gridView1.SetFocusedRowCellValue("MAKHOA", "CNTT");
            }else if (cbDepartment.SelectedIndex == 1)
            {
                gridView1.SetFocusedRowCellValue("MAKHOA", "VT"); 
            }

            //quan trọng: để chương trình không tự báo lỗi.
            gridView1.SetFocusedRowCellValue("MALOP", "");
            gridView1.SetFocusedRowCellValue("TENLOP", "");
            gridView1.SetFocusedRowCellValue("KHOAHOC", "");

            //quan trọng, nhấm đánh dấu là đã được tồn tại
            gridView1.FocusedRowHandle = gridView1.DataRowCount;
        }

        private bool checkEmpty(string classCode, string className, string classSchoolYear)
        {
            if (classCode.Trim().Equals(""))
            {
                MessageBox.Show("Mã lớp không được rỗng", "Cảnh báo!", MessageBoxButtons.OK);
                return true;
            }
            else if (className.Trim().Equals(""))
            {
                MessageBox.Show("Tên lớp không được rỗng!", "Cảnh báo!", MessageBoxButtons.OK);
                return true;
            }
            else if (classSchoolYear.Trim().Equals(""))
            {
                MessageBox.Show("Niên khóa không được rỗng!", "Cảnh báo!", MessageBoxButtons.OK);
                return true;
            }
            return false;

        }
        private bool checkEmptySV()
        {

            string lastName = gridView2.GetRowCellValue(gridView2.RowCount-1, "HO").ToString();
            string firstName = gridView2.GetRowCellValue(gridView2.RowCount-1, "TEN").ToString();
            string studentCode = gridView2.GetRowCellValue(gridView2.RowCount-1, "MASV").ToString();

            if (studentCode.Equals(""))
            {
                gridView2.SetColumnError(gridView2.Columns["MASV"], "Mã sinh viên rỗng", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
                return true;
            }
            if (lastName.Equals(""))
            {
                gridView2.SetColumnError(gridView2.Columns["HO"], "Họ sinh viên rỗng", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
                return true;
            }
            if (firstName.Equals(""))
            {
                gridView2.SetColumnError(gridView2.Columns["TEN"], "Tên sinh viên rỗng", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
                return true;
            }
            return false;
        }
        private int checkExistValue(string value, string type)
        {
           
                if (type.Equals("TENLOP"))
                {
                    //kiểm tra tên trước: 
                    string queryName = "DECLARE @return_value int "
                       + "EXEC @return_value = [dbo].[SP_CHECKNAME] @Name = N'" + value + "', @Type = N'TENLOP' SELECT  'Return Value' = @return_value";
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




                //kiểm tra id 
                else if (type.Equals("MALOP"))
                {
                    string queryId = "DECLARE @return_value int "
                   + "EXEC @return_value = [dbo].[SP_CHECKID] @Ma = N'" + value + "', @Type = N'MALOP' SELECT  'Return Value' = @return_value";
                    SqlDataReader resultClassId = Program.ExecSqlDataReader(queryId);

                    if (resultClassId == null)
                    {
                        MessageBox.Show("Server bị lỗi");
                        resultClassId.Close();
                        return -1;
                    }
                    resultClassId.Read();
                    int tempvalue = resultClassId.GetInt32(0);
                    resultClassId.Close(); 
                    return tempvalue; 
                }
                
            else if (type.Equals("SV"))
            {
                string queryId = "DECLARE @return_value int "
                   + "EXEC @return_value = [dbo].[SP_CHECKID] @Ma = N'" + value + "', @Type = N'MASV' SELECT  'Return Value' = @return_value";
                SqlDataReader resultSVId = Program.ExecSqlDataReader(queryId);

                if (resultSVId == null)
                {
                    MessageBox.Show("Server bị lỗi");
                    resultSVId.Close();
                    return -1;
                }
                resultSVId.Read();
                int tempvalue = resultSVId.GetInt32(0);
                resultSVId.Close(); 
                return tempvalue; 
            }
            return 0;       
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
        private void btnUndo_Click(object sender, EventArgs e)
        {
            cmdManager.undo();
            if (cmdManager.undoStackSize() == 0)
            {
                btnUndo.Enabled = false;
            }
            btnRedo.Enabled = true; 
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            cmdManager.clear();
            btnUndo.Enabled = false;
            btnRedo.Enabled = false;
            changeClass = false; 
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet.LOP);
           
            MessageBox.Show("Load dữ liệu thành công!", "Thông báo!", MessageBoxButtons.OK);
        }

        
        //private void editableGridview1()
        //{
        //    if (gridView1.FocusedRowHandle == rowEditableGv1 && rowEditableGv1!=-1)
        //    {
        //        gridView1.Columns["TENLOP"].OptionsColumn.ReadOnly = false;
        //        gridView1.Columns["KHOAHOC"].OptionsColumn.ReadOnly = false;
        //    }
        //    else
        //    {
        //        gridView1.Columns["TENLOP"].OptionsColumn.ReadOnly = true;
        //        gridView1.Columns["KHOAHOC"].OptionsColumn.ReadOnly = true;
        //    }
            
        //    //editable1 = false;
        //}

        private void btnAddSV_Click(object sender, EventArgs e)
        {
           
            if (changeClass == true)
            {
                MessageBox.Show("Bạn phải lưu lớp này trước khi thêm sinh viên", "Cảnh báo!", MessageBoxButtons.OK);
                return;
            }

            if (svBds.Count > 0)
            {
                string studentCode = gridView2.GetRowCellValue(gridView2.DataRowCount-1, "MASV").ToString();
                string firstName = gridView2.GetRowCellValue(gridView2.DataRowCount-1, "HO").ToString();
                string lastName = gridView2.GetRowCellValue(gridView2.DataRowCount-1, "TEN").ToString();
                if (studentCode.Equals("") || firstName.Equals("") || lastName.Equals(""))
                {
                    MessageBox.Show("Bạn phải hoàn tất thao tác trước đó!", "Cảnh báo!", MessageBoxButtons.OK);
                    return;
                }
            }

            cmdManagerSV.execute(new InsertAction(svBds));
            gridView2.SetFocusedRowCellValue("MASV", "");
            gridView2.SetFocusedRowCellValue("HO", "");
            gridView2.SetFocusedRowCellValue("TEN", "");
            gridView2.SetFocusedRowCellValue("PHAI", false);
            gridView2.SetFocusedRowCellValue("DANGHIHOC", false);


            gridView2.FocusedRowHandle = gridView2.DataRowCount; 
        }

        private void btnDeleteSV_Click(object sender, EventArgs e)
        {
            if (svBds.Count == 0)
            {
                XtraMessageBox.Show("Không còn sinh viên để xóa!", "Cảnh báo!", MessageBoxButtons.OK);
                return;
            }
            try
            {
                if (dANGKYBindingSource.Count > 0)
                {

                    XtraMessageBox.Show("Bạn không thể xóa sinh viên này!\nGợi ý: bạn hãy chuyển trạng thái thành : 'Đã nghỉ học'", "Cảnh báo!", MessageBoxButtons.OK);
                    return;
                }
                cmdManagerSV.execute(new DeleteAction(svBds));
                //cmdManagerSV.updatePosition(); 
                btnUndoSV.Enabled = true;
            }catch(Exception ex)
            {
                XtraMessageBox.Show("Đã xảy ra lỗi khi xóa!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           

        }

        private void bntSaveSV_Click(object sender, EventArgs e)
        {

          


            if (checkEmptySV() == true) return; 

            
                try
                {

                    this.Validate();
                    this.svBds.EndEdit();

                    //điều đặc biệt
                    this.sINHVIENTableAdapter.Update(this.qLDSV_TCDataSet.SINHVIEN);
                    totalOfficalSv = svBds.Count; 
                    MessageBox.Show("Thành công");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thất bại!");
                }
            


            //this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            //this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet.SINHVIEN); 
            
        }

        

        private void bntEditSV_Click(object sender, EventArgs e)
        {

        }

        private void gridView2_InvalidValueException(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            //string studentCode = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MASV").ToString();
            //if (checkExistValue(studentCode, "nothing", "SV") == true)
            //{
            //    MessageBox.Show(this, "Mã số sinh viên bị trùng");
            //}
        }

        private void gridView2_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if(gridView2.FocusedColumn.FieldName == "MASV")
            {
                string studentCode = e.Value as string;
                if (studentCode.Equals(""))
                {
                    e.Valid = false;
                    e.ErrorText = "Mã sinh viên bị rỗng";
                    MessageBox.Show(this, "Mã sinh viên bị rỗng!", "Cảnh báo!", MessageBoxButtons.OK);
                    return; 
                }


                int checkValue = checkExistValue(studentCode, "SV");
                
                if (checkValue == 1)
                {
                    e.Valid = false;
                    e.ErrorText = "Mã sinh viên đã tồn tại ở khoa khác";
                    inValidStudent = true;
                    MessageBox.Show(this, "Mã số sinh viên bị trùng ở khoa khác!", "Cảnh báo!", MessageBoxButtons.OK);
                }
                else
                {
                    inValidStudent = false;
                    if (svBds.Position < totalOfficalSv)
                    {
                        cmdManagerSV.execute(new UpdateAction(svBds)); 
                    }
                }
            }else if (gridView2.FocusedColumn.FieldName == "HO")
            {
                string firstName = e.Value as string;
                if (firstName.Equals(""))
                {
                    e.Valid = false;
                    e.ErrorText = "Họ sinh viên bị rỗng";
                    MessageBox.Show(this, "Họ sinh viên bị rỗng!", "Cảnh báo!", MessageBoxButtons.OK);
                    return; 
                }
                if (svBds.Position < totalOfficalSv)
                {
                    cmdManagerSV.execute(new UpdateAction(svBds));
                }

            }
            else if (gridView2.FocusedColumn.FieldName == "TEN")
            {
                string lastName = e.Value as string;
                if (lastName.Equals(""))
                {
                    e.Valid = false;
                    e.ErrorText = "Tên sinh viên bị rỗng";
                    MessageBox.Show(this, "Tên sinh viên bị rỗng!", "Cảnh báo!", MessageBoxButtons.OK);
                    return; 
                }

                if (svBds.Position < totalOfficalSv)
                {
                    cmdManagerSV.execute(new UpdateAction(svBds));
                }
            }
        }

        private void gridView1_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (gridView1.FocusedColumn.FieldName == "MALOP")
            {

                string classCode = e.Value as string;
                if (classCode.Trim().Equals(""))
                {
                    e.Valid = false;
                    e.ErrorText = "Mã lớp bị rỗng!";
                    MessageBox.Show(this, "Mã lớp bị rỗng", "Cảnh báo!", MessageBoxButtons.OK);
                    return; 
                }

                int checkValue = checkExistValue(classCode, "MALOP");
           
                if (checkValue == 1)
                {
                    e.Valid = false;
                    e.ErrorText = "Mã lớp đã bị trùng ở khoa khác!";
                    MessageBox.Show("Mã lớp lớp bị trùng ở khoa khác!", "Cảnh báo!", MessageBoxButtons.OK);
                    inValid = true;
                }
                    else
                    {
                        inValid = false;
                        if(lOPBindingSource.Position <totalOfficalClass)
                            cmdManager.execute(new UpdateAction(lOPBindingSource));
                    }
            }
            else if (gridView1.FocusedColumn.FieldName == "TENLOP")
            {
                string className = e.Value as string;
                if (className.Trim().Equals(""))
                {
                    e.Valid = false;
                    e.ErrorText = "Tên lớp bị rỗng!";
                    MessageBox.Show(this, "Tên lớp bị rỗng", "Cảnh báo!", MessageBoxButtons.OK);
                }
                int checkValue = checkExistValue(className, "TENLOP");
                
                 if (checkValue == 1)
                {
                    e.Valid = false;
                    e.ErrorText = "Tên lớp đã bị trùng ở khoa khác!";
                    bindingNavigatorAddNewItem.Enabled = false;
                    MessageBox.Show(this, "Tên lớp bị trùng ở khoa khác!", "Thông báo!", MessageBoxButtons.OK);
                    inValid = true;
                }
                else
                {

                    
                    inValid = false;
                    if (lOPBindingSource.Position < totalOfficalClass)
                        cmdManager.execute(new UpdateAction(lOPBindingSource));
                }
            }
            else if (gridView1.FocusedColumn.FieldName == "KHOAHOC")
            {
                if (lOPBindingSource.Position < totalOfficalClass)
                    cmdManager.execute(new UpdateAction(lOPBindingSource));

            }
        }

        private void btnReloadSV_Click(object sender, EventArgs e)
        {
            cmdManagerSV.clear();
            btnUndoSV.Enabled = false;
            btnRedoSV.Enabled = false; 
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet.SINHVIEN);
           
            MessageBox.Show("Đã tải dữ liệu thành công!", "Thông báo!", MessageBoxButtons.OK); 
        }
        //set malop  & makhoa thành chỉ đọc:
        private void setReadOnly()
        {
            gridView1.Columns["MAKHOA"].OptionsColumn.ReadOnly = true; 
            gridView2.Columns["MALOP"].OptionsColumn.ReadOnly = true; 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnUndoSV_Click(object sender, EventArgs e)
        {
            cmdManagerSV.undo(); 
            if(cmdManagerSV.undoStackSize() == 0)
            {
                btnUndoSV.Enabled = false;
            }
            btnRedoSV.Enabled = true; 
        }

        private void btnRedoSV_Click(object sender, EventArgs e)
        {
            cmdManagerSV.redo(); 
            if(cmdManagerSV.redoStackSize() == 0)
            {
                btnRedoSV.Enabled = false; 
            }
            btnUndoSV.Enabled = true; 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            cmdManagerSV.clear();
            btnUndoSV.Enabled = false;
            btnRedoSV.Enabled = false; 
        }

        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            cmdManagerSV.clear();
            btnUndoSV.Enabled = false;
            btnRedoSV.Enabled = false;
        }

        private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            cmdManagerSV.clear();
            btnUndoSV.Enabled = false;

            btnRedoSV.Enabled = false;
        }
    }
}