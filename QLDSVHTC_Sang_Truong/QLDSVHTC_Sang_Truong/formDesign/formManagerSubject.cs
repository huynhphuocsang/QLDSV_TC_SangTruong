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

namespace QLDSVHTC_Sang_Truong.formDesign
{
    public partial class formManagerSubject : DevExpress.XtraEditors.XtraForm
    {
        private CommandManager cmdManager;
        private Boolean isInsert = false;
        private float tongTiet = 0;
        private int totalOfficalSubject = 0;
        private bool inValid = true; 
        public formManagerSubject()
        {
            InitializeComponent();
            cmdManager = new CommandManager();
        }

        
        private void formManagerSubject_Load(object sender, EventArgs e)
        {
            this.qLDSV_TCDataSet.EnforceConstraints = false;
            this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet.LOPTINCHI' table. You can move, or remove it, as needed.
            this.lOPTINCHITableAdapter.Fill(this.qLDSV_TCDataSet.LOPTINCHI);
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.qLDSV_TCDataSet.MONHOC);
            setEnableGrid(false);
            btnEdit.Caption = "Sửa";
            btnSave.Enabled=btnUndo.Enabled=btnRedo.Enabled = false;
            totalOfficalSubject = bdsMONHOC.Count;


            gridView1.CellValueChanged += (s, ex) =>
            {
                string subjectCode = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAMH").ToString();
                string subjectName = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TENMH").ToString();
                string numberOfTheory = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SOTIET_LT").ToString();
                string numberOfPractice = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SOTIET_TH").ToString();
                btnUndo.Enabled = true;
                
                if ((subjectCode == "" && subjectName == "" && numberOfTheory == "" && numberOfPractice=="") || inValid == true)
                {
                    return;
                }
                else
                {
                    cmdManager.execute(new UpdateAction(bdsMONHOC));
                }

            };
        }

        private void setEnableGrid(Boolean column)
        {
            for (int i = 0; i < gridView1.Columns.Count; i++)
            {
                gridView1.Columns[i].OptionsColumn.AllowEdit = column;
            }
            //label1.Text= ((DataRowView)bdsMONHOC[bdsMONHOC.Position]).Row.ToString();
        }

        private Boolean checkEmpty()
        {
            bool maMH = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAMH")==null;
            bool tenMH = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TENMH") == null;
            bool soLT = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SOTIET_LT") == null;
            bool soTH = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SOTIET_TH") == null;
            if (maMH){
                gridView1.SetColumnError(gridView1.Columns["MAMH"], "Mã môn học không được để trống!!!", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Default);
                MessageBox.Show("Mã môn học không được để trống!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            if (tenMH)
            {
                MessageBox.Show("Tên môn học không được để trống!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            if (soLT)
            {
                MessageBox.Show("Số tiết lý thuyết không được để trống!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            if (soTH)
            {
                MessageBox.Show("Số tiết thực hành không được để trống!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }
        private int checkExists(String name, String type)
        {
            if (type.Equals("id"))
            { 
                string queryName = "DECLARE @return_value int "
                   + "EXEC @return_value = [dbo].[SP_CHECKID] @Ma = N'" + name + "', @Type = N'MAMONHOC' SELECT  'Return Value' = @return_value";
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
            else if (type.Equals("name"))
            {
                string queryName = "DECLARE @return_value int "
                   + "EXEC @return_value = [dbo].[SP_CHECKNAME] @Name = N'" + name + "', @Type = N'TENMONHOC' SELECT  'Return Value' = @return_value";
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
            return 1;
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            btnSave.Enabled = true;
            if (bdsLopTinChi.Count > 0)
            {
                MessageBox.Show("Môn học bạn muốn xóa đã có lớp đăng ký, không thể xóa!!!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string tenMH = ((DataRowView)bdsMONHOC[bdsMONHOC.Position])["TENMH"].ToString();
            DialogResult choose =MessageBox.Show("Bạn có muốn xóa môn: "+ tenMH, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (choose == DialogResult.Yes)
            {
                cmdManager.execute(new DeleteAction(bdsMONHOC));
                btnUndo.Enabled = true; 
            }

        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnEdit.Caption.Equals("Sửa"))
            {
                //btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = false;
                btnSave.Enabled = true;
                setEnableGrid(true);
                btnEdit.Caption = "Hủy sửa";
            }
            else
            {
                setEnableGrid(false);
                btnEdit.Caption = "Sửa";
            }
            
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //btnEdit.Enabled = btnDelete.Enabled = false;
            btnSave.Enabled = true;
            cmdManager.execute(new InsertAction(bdsMONHOC));
            setEnableGrid(true);
            btnEdit.Caption = "Sửa";
            isInsert = true;
            btnUndo.Enabled = true; 
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Validate();
                this.bdsMONHOC.EndEdit();
                this.mONHOCTableAdapter.Update(this.qLDSV_TCDataSet.MONHOC);
                MessageBox.Show("Lưu dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isInsert = false;

                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(this.qLDSV_TCDataSet.MONHOC);
                setEnableGrid(false);
                btnEdit.Caption = "Sửa";
                btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = true;
                btnSave.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu dữ liệu thất bại!!\r\n Vui lòng kiểm tra và nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = XtraMessageBox.Show("Xác nhận tải lại trang", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.No)
            {
                return;
            }
            else if (dr == DialogResult.Yes)
            {
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(this.qLDSV_TCDataSet.MONHOC);
                //btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = true;
                btnSave.Enabled = false;
                setEnableGrid(false);
                btnEdit.Caption = "Sửa";
                isInsert = false;
                cmdManager.clear();
                btnRedo.Enabled = btnUndo.Enabled = false; 
            }
            
        }

        private void gridView1_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            
            string input = e.Value as string;
            if (input.Equals(""))
            {
                e.Valid = false;
                //e.ErrorText = "Dữ liệu không được để trống";
                DialogResult choose = MessageBox.Show("Dữ liệu không được để trống, bạn có muốn tiếp tục", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (choose == DialogResult.No)
                {
                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONHOCTableAdapter.Fill(this.qLDSV_TCDataSet.MONHOC);
                    btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = true;
                    btnSave.Enabled = false;
                }
            }
            if (isInsert && gridView1.FocusedColumn.FieldName == "MAMH")
            {
                
                int checkValue = checkExists(input, "id");
                if (checkValue == 1)
                {
                    e.Valid = false;
                    e.ErrorText = "Mã môn học đã tồn tại";
                    btnAdd.Enabled = false;
                    inValid = true; 
                    MessageBox.Show(this, "Mã mã môn học đã tồn tại!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    btnAdd.Enabled = true;

                    inValid = false;
                    if (bdsMONHOC.Position < totalOfficalSubject)
                    {
                        cmdManager.execute(new UpdateAction(bdsMONHOC)); 
                    }
                }
            }

            if (isInsert && gridView1.FocusedColumn.FieldName == "TENMH")
            {
                int checkValue = checkExists(input, "name");
                if (checkValue == 1)
                {
                    e.Valid = false;
                    e.ErrorText = "Tên môn học đã tồn tại";
                    btnAdd.Enabled = false;
                    inValid = true; 
                    MessageBox.Show(this, "Tên mã môn học đã tồn tại!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    btnAdd.Enabled = true;
                    inValid = false;
                    if (bdsMONHOC.Position < totalOfficalSubject)
                    {
                        cmdManager.execute(new UpdateAction(bdsMONHOC));
                    }
                }
            }

            if (gridView1.FocusedColumn.FieldName == "SOTIET_LT" || gridView1.FocusedColumn.FieldName == "SOTIET_TH")
            {
                int scoreCode;
                bool isNumeric = int.TryParse(input, out scoreCode);
                if (isNumeric)
                {
                    int rowFocus = gridView1.FocusedRowHandle;
                    //tên cột số tiết học đang nhập
                    string fieldNameFocus = gridView1.FocusedColumn.FieldName;

                    //kt có đang focus cột nào trong gridview ko
                    if (rowFocus<0 || gridView1.GetRowCellValue(rowFocus, fieldNameFocus.Equals("SOTIET_LT") ? "SOTIET_TH" : "SOTIET_LT")==null) return;

                    string inputNext = "";
                    try
                    {
                        //dữ liệu của cột số tiết học còn lại: nếu fieldNameFocus là SOTIET_LT thì ta sẽ lấy dữ liệu SOTIET_TH để cộng lại r tính toán hợp lệ ko
                        inputNext = gridView1.GetRowCellValue(rowFocus, fieldNameFocus.Equals("SOTIET_LT") ? "SOTIET_TH" : "SOTIET_LT").ToString();
                    }
                    catch (InvalidCastException ex) { return; }
                    
                    if (scoreCode < 0)
                    {
                        e.Valid = false;
                        e.ErrorText = "Số tiết học phải lớn hơn 0";
                        //MessageBox.Show(this, "Số tiết học phải lớn hơn 0!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (!inputNext.Equals("")) { 
                        tongTiet = scoreCode + float.Parse(gridView1.GetRowCellValue(rowFocus, fieldNameFocus.Equals("SOTIET_LT") ? "SOTIET_TH" : "SOTIET_LT").ToString());
                        label1.Text = tongTiet.ToString();
                        if (tongTiet % 15 != 0)
                        {
                            e.Valid = false;
                            e.ErrorText = "Số tiết học không hợp lệ";
                            inValid = true; 
                            MessageBox.Show(this, "Số tiết học không hợp lệ!\r\n Do 1 tín chỉ bằng 15 tiết nên tổng số tiết cần phải chia hết cho 15", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            inValid = false;
                            if (bdsMONHOC.Position < totalOfficalSubject)
                            {
                                cmdManager.execute(new UpdateAction(bdsMONHOC));
                            }
                        }
                    }
                }
                
            }
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cmdManager.undo();
            if (cmdManager.undoStackSize() == 0)
            {
                btnUndo.Enabled = false;
            }
            btnRedo.Enabled = true;
        }

        private void btnRedo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cmdManager.redo();
            if (cmdManager.redoStackSize() == 0)
            {
                btnRedo.Enabled = false;
            }
            btnUndo.Enabled = true;
        }
    }
}