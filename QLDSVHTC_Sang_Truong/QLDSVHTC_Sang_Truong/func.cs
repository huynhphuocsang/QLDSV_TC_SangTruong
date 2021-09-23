using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QLDSVHTC_Sang_Truong
{
    class func
    {

        public static void BindingDataToComBo(ComboBox combo, Object data)
        {
            combo.DataSource = data;
            combo.DisplayMember = "PHONGBAN";
            combo.ValueMember = "TENSERVER";

            // lệnh này quan trọng... phải bỏ vào. ==> để cho combo box chạy đúng.


            // nếu login vào là khoa cntt, thì combox sẽ hiện khoa cntt
            // nếu login vào là khoa vt, thì combox sẽ hiện khoa vt
            combo.SelectedIndex = Program.mPhongBan;
        }
    }
}
