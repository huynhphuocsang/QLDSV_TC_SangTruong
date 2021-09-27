using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;
using System.Collections.Generic;



namespace QLDSVHTC_Sang_Truong.formDesign
{
    public partial class formClasses : DevExpress.XtraEditors.XtraForm
    {
        private bool addClass = false;
        private bool addStudent = false;
        
        private bool changeClassName = false;
        private int rowEditableGv1 = -1;

        //tempClassName: dùng để so sánh với tên của lớp trong trường hợp sửa lại tên mới của lớp: 
        private string tempClassName = "xxxxxxxxxxxxxxxxxxxx"; 

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

            string classCode = gridView1.GetRowCellValue(gridView1.FocusedRowHandle,"MALOP").ToString();
            string className = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TENLOP").ToString();
            string classSchoolYear = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "KHOAHOC").ToString();
            
            if (checkEmpty(classCode, className, classSchoolYear) == true) return;

            if (checkExistValue(classCode,className, "LOP") == true) return; 



            this.Validate();
            this.lOPBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.qLDSV_TCDataSet);
            this.lOPTableAdapter.Update(this.qLDSV_TCDataSet.LOP); 
            gridView1.ClearColumnErrors();


            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet.LOP);
            //reset lai gia tri: 
            addClass =false;
            changeClassName = false;
            rowEditableGv1 = -1;
            tempClassName = "xxxxxxxxxxxxxxxxxxxx"; 

            btnEdit.Enabled = true;
            bindingNavigatorAddNewItem.Enabled = true; 
        }

        private void formClasses_Load(object sender, EventArgs e)
        {
           
            
            Program.bdsDSPM.Filter = "PHONGBAN LIKE 'KHOA%'";

            //chuyển dữ liệu từ danh sách phân mảnh vào cho combobox.
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
                if (rowEditableGv1 != -1)
                {
                    editableGridview1(); 
                }
                else
                {
                    setReadOnly("MALOP", gridView1, addClass);
                    setReadOnly("TENLOP", gridView1, addClass);
                    setReadOnly("KHOAHOC", gridView1, addClass);
                }
               
                if (addClass != true)
                    cmdManager.execute(new UpdateAction(lOPBindingSource));

            };


            gridView1.CellValueChanging += (s, ex) =>
             {
                if (ex.Column.FieldName.Equals("TENLOP"))
                 {
                     changeClassName = true; 

                 }
             };

            gridView1.CellValueChanged += (s, ex) =>
             {
                 btnUndo.Enabled = true;
                 if (addClass == true) ((InsertAction)cmdManager.getLastUndoNode()).getData();
                 else ((UpdateAction)cmdManager.getLastUndoNode()).getData();
             };


            gridView2.ShowingEditor += (s, ex) =>
            {
                setStudentCodeReadOnly(); 

                //if (addClass != true)
                //    cmdManager.execute(new UpdateAction(lOPBindingSource));

            };



            btnUndo.Enabled = btnRedo.Enabled = false;
        }
        private void load()
        {

            
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet.LOP);
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet.SINHVIEN);


            //gridView1.OptionsBehavior.Editable = false; 
            //setReadOnly("MALOP", gridView1, addClass);
            //setReadOnly("TENLOP", gridView1, addClass);
            //setReadOnly("KHOAHOC", gridView1, addClass);
            setReadOnly("MAKHOA", gridView1, false);

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
                    Program.mlogin = Program.mloginDN;
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
        
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            //kiêm tra thử xem liệu lớp đã được tham chiếu hay chưa? 

            cmdManager.execute(new DeleteAction(lOPBindingSource));
            btnUndo.Enabled = true;
            addClass = false;
            changeClassName = false;
            if (lOPBindingSource.Count == 0) bindingNavigatorAddNewItem.Enabled = false;
        }

        

        

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //if (addClass == true && gridView1.FocusedRowHandle == gridView1.RowCount-1)
            //{
            //    this.Validate();
            //    this.lOPBindingSource.EndEdit();
            //    this.tableAdapterManager.UpdateAll(this.qLDSV_TCDataSet);
            //}

            bindingNavigatorAddNewItem.Enabled = false;
            btnEdit.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;

            cmdManager.execute(new InsertAction(lOPBindingSource));
            addClass = true;

            if (cbDepartment.SelectedIndex == 0)
            {
                gridView1.SetFocusedRowCellValue("MAKHOA", "CNTT");
            }else if (cbDepartment.SelectedIndex == 1)
            {
                gridView1.SetFocusedRowCellValue("MAKHOA", "VT"); 
            }
        }

        private void setReadOnly(String col, GridView GridView, bool addClass)
        {

            if (addClass == true)
            {

                if (GridView.FocusedRowHandle == DevExpress.XtraGrid.GridControl.NewItemRowHandle)
                {
                    GridView.Columns[col].OptionsColumn.ReadOnly = false;
                    
                }
                else
                {
                    if (GridView.FocusedRowHandle == gridView1.RowCount - 1)
                        GridView.Columns[col].OptionsColumn.ReadOnly = false;
                    else
                        GridView.Columns[col].OptionsColumn.ReadOnly = true;
                }


            } 
            else
            {
                GridView.Columns[col].OptionsColumn.ReadOnly = true;
            }

            
        }
        private bool checkEmpty(string classCode, string className, string classSchoolYear)
        {
            if (classCode.Trim().Equals(""))
            {
                MessageBox.Show("Mã lớp không được rỗng!");
                return true;
            }
            else if (className.Trim().Equals(""))
            {
                MessageBox.Show("Tên lớp không được rỗng!");
                return true;
            }
            else if (classSchoolYear.Trim().Equals(""))
            {
                MessageBox.Show("Niên khóa không được rỗng!");
                return true;
            }
            return false;

        }

        private bool checkExistValue(string idValue,string nameValue, string type)
        {
            if (type.Equals("LOP"))
            {
                if (changeClassName == true && nameValue.Equals(tempClassName)==false)
                {
                    //kiểm tra tên trước: 
                    string queryName = "DECLARE @return_value int "
                       + "EXEC @return_value = [dbo].[SP_CHECKNAME] @Name = N'" + nameValue + "', @Type = N'TENLOP' SELECT  'Return Value' = @return_value";
                    SqlDataReader resultClassName = Program.ExecSqlDataReader(queryName);

                    if (resultClassName == null)
                    {
                        MessageBox.Show("Server bị lỗi");
                        resultClassName.Close();
                        return true;
                    }
                    resultClassName.Read();
                    if (resultClassName.GetInt32(0) == 1)
                    {
                        gridView1.SetColumnError(gridView1.Columns["TENLOP"], "TÊN LỚP ĐÃ TỒN TẠI", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical);
                        resultClassName.Close();
                        return true;
                    }
                    else if (resultClassName.GetInt32(0) == 2)
                    {
                        gridView1.SetColumnError(gridView1.Columns["TENLOP"], "TÊN LỚP ĐÃ TỒN TẠI Ở KHOA KHÁC", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical);
                        resultClassName.Close();
                        return true;
                    }
                    resultClassName.Close();

                }




                //kiểm tra id 
                if (addClass == true)
                {
                    string queryId = "DECLARE @return_value int "
                   + "EXEC @return_value = [dbo].[SP_CHECKID] @Ma = N'" + idValue + "', @Type = N'MALOP' SELECT  'Return Value' = @return_value";
                    SqlDataReader resultClassId = Program.ExecSqlDataReader(queryId);

                    if (resultClassId == null)
                    {
                        MessageBox.Show("Server bị lỗi");
                        resultClassId.Close();
                        return true;
                    }
                    resultClassId.Read();
                    int tempvalue = resultClassId.GetInt32(0);
                    int i = tempvalue; 
                    if (tempvalue == 1)
                    {
                        gridView1.SetColumnError(gridView1.Columns["MALOP"], "MÃ LỚP ĐÃ TỒN TẠI", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical);
                        resultClassId.Close();
                        return true;
                    }

                    else if (tempvalue == 2)
                    {
                        gridView1.SetColumnError(gridView1.Columns["MALOP"], "MÃ LỚP ĐÃ TỒN TẠI Ở KHOA KHÁC", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical);
                        resultClassId.Close();
                        return true;
                    }
                }
                



            }
            return false; 
                
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
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet.LOP);
            addClass = false;
            changeClassName = false;
            rowEditableGv1 = -1;
            tempClassName = "xxxxxxxxxxxxxxxxxxxx"; 
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            rowEditableGv1 = gridView1.FocusedRowHandle;
            tempClassName = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TENLOP").ToString(); 


            editableGridview1();
            btnEdit.Enabled = false;
            //btnadd : 
            bindingNavigatorAddNewItem.Enabled = false;
        }
        private void editableGridview1()
        {
            if (gridView1.FocusedRowHandle == rowEditableGv1 && rowEditableGv1!=-1)
            {
                gridView1.Columns["TENLOP"].OptionsColumn.ReadOnly = false;
                gridView1.Columns["KHOAHOC"].OptionsColumn.ReadOnly = false;
            }
            else
            {
                gridView1.Columns["TENLOP"].OptionsColumn.ReadOnly = true;
                gridView1.Columns["KHOAHOC"].OptionsColumn.ReadOnly = true;
            }
            
            //editable1 = false;
        }

        private void btnAddSV_Click(object sender, EventArgs e)
        {
            addStudent = true; 

            //enable button: 
            btnAddSV.Enabled = false;
            btnDeleteSV.Enabled = false;//lỡ đâu người dùng nhấn thêm tên trùng, nhưng mà sau đó xóa record có tên tồn tại trước đó nhưng không lưu, thành ra chương trình báo lỗi vô lý.
    

            cmdManagerSV.execute(new InsertAction(sINHVIENBindingSource));
            gridView2.SetFocusedRowCellValue("PHAI", false);
            gridView2.SetFocusedRowCellValue("DANGHIHOC", false); 
        }

        private void btnDeleteSV_Click(object sender, EventArgs e)
        {
            cmdManagerSV.execute(new DeleteAction(sINHVIENBindingSource));
            btnUndoSV.Enabled = true; 

        }

        private void bntSaveSV_Click(object sender, EventArgs e)
        {
            string studentCode = gridView2.GetRowCellValue(gridView1.FocusedRowHandle, "MASV").ToString();
            string lastName = gridView2.GetRowCellValue(gridView1.FocusedRowHandle, "HO").ToString();
            string firstName = gridView2.GetRowCellValue(gridView1.FocusedRowHandle, "TEN").ToString();
           

            if (studentCode.Equals(""))
            {
                gridView2.SetColumnError(gridView2.Columns["MASV"], "Mã sinh viên rỗng", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
                return; 
            }
            if (lastName.Equals(""))
            {
                gridView2.SetColumnError(gridView2.Columns["HO"], "Họ sinh viên rỗng", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
                return;
            }
            if (firstName.Equals(""))
            {
                gridView2.SetColumnError(gridView2.Columns["TEN"], "Tên sinh viên rỗng", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
                return;
            }

            try
            {

                this.Validate();
                this.sINHVIENBindingSource.EndEdit();

                //điều đặc biệt
                this.sINHVIENTableAdapter.Update(this.qLDSV_TCDataSet.SINHVIEN);

                MessageBox.Show("Thành công");

                //reset button: 
                btnDeleteSV.Enabled = true;
                btnAddSV.Enabled = true;
                addStudent = false;


            }catch(Exception ex)
            {
                MessageBox.Show("Thất bại!");
            }

            

            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet.SINHVIEN); 
            
        }

        private void setStudentCodeReadOnly()
        {
            if (addStudent == false)
            {
                gridView2.Columns["MASV"].OptionsColumn.ReadOnly = true;
            }
            else
            {
                if(gridView2.FocusedRowHandle== DevExpress.XtraGrid.GridControl.NewItemRowHandle)
                {
                    gridView2.Columns["MASV"].OptionsColumn.ReadOnly = false;
                }
                else
                {
                    gridView2.Columns["MASV"].OptionsColumn.ReadOnly = true;
                }
            }
            
        }
    }
}