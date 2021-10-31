using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSVHTC_Sang_Truong.formDesign
{
    public partial class formScores : DevExpress.XtraEditors.XtraForm
    {
        private CommandManager cmdManager;
        public formScores()
        {
            InitializeComponent();
           
        }

        private void frmScores_Load(object sender, EventArgs e)
        {

            

            Program.bdsDSPM.Filter = "PHONGBAN LIKE 'KHOA%'";
            //chuyển dữ liệu từ danh sách phân mảnh vào cho combobox.
            func.BindingDataToComBo(cbDepartment, Program.bdsDSPM);
            if (Program.mGroup.Equals("KHOA"))
            {
                cbDepartment.Enabled = false;
            }
            else if (Program.mGroup.Equals("PGV"))
            {
                cbDepartment.Enabled = true;
            }

            this.v_DS_NIENKHOATableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet.V_DS_NIENKHOA' table. You can move, or remove it, as needed.
            this.v_DS_NIENKHOATableAdapter.Fill(this.qLDSV_TCDataSet.V_DS_NIENKHOA);
            setEnableGrid(false);
            btnGhi.Enabled = btnReload.Enabled = btnUndo.Enabled = btnRedo.Enabled = btnReload.Enabled = false;
        }

        private void setEnableGrid(Boolean column)
        {
            gridViewDiem.Columns[2].OptionsColumn.AllowEdit = column;
            gridViewDiem.Columns[3].OptionsColumn.AllowEdit = column;
            gridViewDiem.Columns[4].OptionsColumn.AllowEdit = column;
        }
        private Boolean getEnableGrid()
        {
            return gridViewDiem.Columns[2].OptionsColumn.AllowEdit;
        }

        private void checkTuition()
        {
            if (btnNhapDiem.Enabled) return;

            string pay = gridViewDiem.GetRowCellValue(gridViewDiem.FocusedRowHandle, "TOPAY").ToString();
            if (getEnableGrid() && pay.Equals(""))
            {
                MessageBox.Show(this, "Không thể nhập, Sinh viên này chưa đóng học phí!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                setEnableGrid(false);
            }
            else if (!getEnableGrid() && !pay.Equals(""))
            {
                setEnableGrid(true);
            }
        }

        private void getEndScore()
        {
            int rowSelect = gridViewDiem.FocusedRowHandle;
            DataRow dr = gridViewDiem.GetDataRow(rowSelect);
            //gridView1.SetFocusedRowCellValue(gridView1.FocusedColumn, Math.Round(float.Parse(e.Value.ToString()) * 2, MidpointRounding.AwayFromZero) / 2);
            
            
            double diemCC = double.Parse(dr["DIEM_CC"].ToString().Equals("") ? "0" : (dr["DIEM_CC"].ToString()));
            double diemGK = float.Parse(dr["DIEM_GK"].ToString().Equals("") ? "0" : (dr["DIEM_GK"].ToString()));
            double diemCK = float.Parse(dr["DIEM_CK"].ToString().Equals("") ? "0" : (dr["DIEM_CK"].ToString()));
            if (!dr["DIEM_GK"].ToString().Equals(""))
            {
                diemGK = Math.Round(diemGK * 2, MidpointRounding.AwayFromZero) / 2;
                gridViewDiem.SetRowCellValue(rowSelect, "DIEM_GK", diemGK);
            }

            if (!dr["DIEM_GK"].ToString().Equals(""))
            {
                diemCK = Math.Round(diemCK * 2, MidpointRounding.AwayFromZero) / 2;
                gridViewDiem.SetRowCellValue(rowSelect, "DIEM_CK", diemCK);
            }
        }
        private void loadClassRegister()
        {
            try
            {
                this.qLDSV_TCDataSet.EnforceConstraints = false;
                this.sP_LOAD_REGISTER_INFORTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_LOAD_REGISTER_INFORTableAdapter.Fill(this.qLDSV_TCDataSet.SP_LOAD_REGISTER_INFOR, cbNienkhoa.Text, Int32.Parse(cbHocky.Value.ToString()));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void loadScoresSV()
        {
            String maMH = ((DataRowView)bdsSP_ClassRegister[bdsSP_ClassRegister.Position])["MAMH"].ToString();
            int nhom = (int)((DataRowView)bdsSP_ClassRegister[bdsSP_ClassRegister.Position])["NHOM"];
            try
            {
                this.qLDSV_TCDataSet.EnforceConstraints = false;
                this.sP_LOAD_LIST_SCORESTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_LOAD_LIST_SCORESTableAdapter.Fill(this.qLDSV_TCDataSet.SP_LOAD_LIST_SCORES, cbNienkhoa.Text, Int32.Parse(cbHocky.Value.ToString()), maMH, nhom);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
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
                    MessageBox.Show("Lỗi chuyển khoa", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    try
                    {
                        this.v_DS_NIENKHOATableAdapter.Connection.ConnectionString = Program.connstr;
                        this.v_DS_NIENKHOATableAdapter.Fill(this.qLDSV_TCDataSet.V_DS_NIENKHOA);
                        setEnableGrid(false);
                        btnNhapDiem.Enabled = true;
                        btnGhi.Enabled = btnReload.Enabled = btnUndo.Enabled = btnRedo.Enabled = btnReload.Enabled = false;
                        loadClassRegister();
                        loadScoresSV();
                    }
                    catch (Exception) { }
                }


            }
            catch
            {
                return;
            }
        }
     
        
        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            getEndScore();
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            if (gridViewLop.RowCount == 0)
            {
                MessageBox.Show("Dữ liệu đang trống!", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (gridViewDiem.RowCount == 0)
            {
                MessageBox.Show("Hãy chọn nhôm để nhập điểm!", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            setEnableGrid(true);
            btnNhapDiem.Enabled = false;
            btnGhi.Enabled = btnReload.Enabled = true;
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            try
            {

                this.Validate();
                this.sP_LOAD_LIST_SCORESBindingSource.EndEdit();

                this.sP_LOAD_LIST_SCORESTableAdapter.Update(this.qLDSV_TCDataSet.SP_LOAD_LIST_SCORES);

                MessageBox.Show("Lưu dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu dữ liệu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            setEnableGrid(false);
            loadScoresSV();
            btnNhapDiem.Enabled = true;
            btnGhi.Enabled = btnReload.Enabled = false;
        }

        private void cbNienkhoa_EditValueChanged(object sender, EventArgs e)
        {
            if (cbNienkhoa.Text.Equals("")) return;
            loadClassRegister();
            loadScoresSV();
           
        }

        private void cbHocky_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNienkhoa.Text.Equals("")) return;
            loadClassRegister();
            loadScoresSV();
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            
        }
        private void gridViewLop_Click(object sender, EventArgs e)
        {
            loadScoresSV();
        }

        private void gridView1_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (gridViewDiem.FocusedColumn.FieldName == "DIEM_CC" || gridViewDiem.FocusedColumn.FieldName == "DIEM_GK" || gridViewDiem.FocusedColumn.FieldName == "DIEM_CK")
            {
                String input = e.Value as string;
                bool test = !input.Equals("") && Regex.IsMatch(input, "\\d+");
                float scoreCode;
                bool isNumeric = float.TryParse(input, out scoreCode);
                if(isNumeric)
                {
                    if (scoreCode < 0 || scoreCode > 10)
                    {
                        e.Valid = false;
                        e.ErrorText = "Hãy nhập điểm trong khoảng 0-10";
                        MessageBox.Show(this, "Hãy nhập điểm trong khoảng 0-10!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            setEnableGrid(false);
            loadClassRegister();
            loadScoresSV();
            btnNhapDiem.Enabled = true;
            btnGhi.Enabled = btnReload.Enabled = false;
        }

        private void gridViewDiem_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            checkTuition();
        }

       

        private void gridViewDiem_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            checkTuition();
        }

        private void cbHocky_ValueChanged(object sender, EventArgs e)
        {
            if (cbNienkhoa.Text.Equals("")) return;
            loadClassRegister();
        }

        
    }
}