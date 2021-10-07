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

namespace QLDSVHTC_Sang_Truong.formDesign
{
    public partial class formManagerSubject : DevExpress.XtraEditors.XtraForm
    {
        private CommandManager cmdManager;
        public formManagerSubject()
        {
            InitializeComponent();
            cmdManager = new CommandManager();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMONHOC.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSV_TCDataSet);

        }

        private Boolean checkEmty()
        {
            
            return false;
        }
        private void setEnableGrid(Boolean column, Boolean txt)
        {
            for (int i = 0; i < gridView1.Columns.Count; i++)
            {
                gridView1.Columns[i].OptionsColumn.AllowEdit = column;
            }
            txtMaMH.Enabled = txtTenMH.Enabled = nbSoLT.Enabled = nbSoTH.Enabled = txt;
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
            setEnableGrid(false, false);
            btnCancel.Enabled = btnSave.Enabled=btnUndo.Enabled=btnRedo.Enabled = false;
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = false;
            btnCancel.Enabled = btnSave.Enabled = true;
            if (bdsLopTinChi.Count > 0)
            {
                MessageBox.Show("Môn học bạn muốn xóa đã có lớp đăng ký, không thể xóa!!!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult choose =MessageBox.Show("Bạn có muốn xóa môn: "+txtTenMH.Text, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (choose == DialogResult.Yes) cmdManager.execute(new DeleteAction(bdsMONHOC));

        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = false;
            btnCancel.Enabled = btnSave.Enabled = true;
            setEnableGrid(true, true);
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = false;
            btnCancel.Enabled = btnSave.Enabled = true;
            cmdManager.execute(new InsertAction(bdsMONHOC));
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (checkEmptySV() == true) return;


            try
            {
                this.Validate();
                this.bdsMONHOC.EndEdit();
                this.mONHOCTableAdapter.Update(this.qLDSV_TCDataSet.MONHOC);
                MessageBox.Show("Lưu dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu dữ liệu thất bại!!\r\n"+ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.qLDSV_TCDataSet.MONHOC);
            setEnableGrid(false, false);
            btnAdd.Enabled= btnEdit.Enabled = btnDelete.Enabled = true;
            btnCancel.Enabled = btnSave.Enabled = false;
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.qLDSV_TCDataSet.MONHOC);
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = true;
            btnCancel.Enabled = btnSave.Enabled = false;
        }
    }
}