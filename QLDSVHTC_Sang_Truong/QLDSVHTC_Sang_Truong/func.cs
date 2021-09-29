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

            combo.SelectedIndex = Program.mPhongBan;
        }
    }
}
