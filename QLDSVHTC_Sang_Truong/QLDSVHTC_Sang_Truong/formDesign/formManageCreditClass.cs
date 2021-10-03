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
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet.GIANGVIEN' table. You can move, or remove it, as needed.
            this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr; 
            this.gIANGVIENTableAdapter.Fill(this.qLDSV_TCDataSet.GIANGVIEN);
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr; 
            this.mONHOCTableAdapter.Fill(this.qLDSV_TCDataSet.MONHOC);
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet.LOPTINCHI' table. You can move, or remove it, as needed.
            this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr; 
            this.lOPTINCHITableAdapter.Fill(this.qLDSV_TCDataSet.LOPTINCHI);
            gridView1.OptionsBehavior.Editable = false;

        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            string teacherCode = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAGV").ToString();
            lkTeacher.EditValue = teacherCode; 
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
    }
}