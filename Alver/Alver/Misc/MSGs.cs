using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alver.MISC
{
    public static class MSGs
    {
        public static void SaveMessage(string ExtensionMessage = "")
        {
            string _msg = "تم الحفظ بنجاح";
            if (ExtensionMessage != "")
            {
                _msg += Environment.NewLine;
                _msg += ExtensionMessage;
            }
            string _caption = "تنبيه";
            MessageBoxButtons _buttons = MessageBoxButtons.OK;
            MessageBoxIcon _icon = MessageBoxIcon.Information;
            MessageBoxDefaultButton _defaultButton = MessageBoxDefaultButton.Button1;
            MessageBoxOptions _options = MessageBoxOptions.RightAlign;
            MessageBox.Show(_msg, _caption, _buttons, _icon, _defaultButton, _options, false);
        }

        public static void ErrorMessage(Exception Ex = null)
        {
            string _msg = "حدث خطأ داخلي";
            if (Ex != null)
            {
                _msg += Environment.NewLine;
                _msg += Ex.Message;
            }
            string _caption = "تنبيه";
            MessageBoxButtons _buttons = MessageBoxButtons.OK;
            MessageBoxIcon _icon = MessageBoxIcon.Error;
            MessageBoxDefaultButton _defaultButton = MessageBoxDefaultButton.Button1;
            MessageBoxOptions _options = MessageBoxOptions.RightAlign;
            MessageBox.Show(_msg, _caption, _buttons, _icon, _defaultButton, _options, false);
        }
    }
}