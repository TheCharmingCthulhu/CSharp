using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Motomatic.Controls.UI
{
    class FileEditor : UITypeEditor
    {
        OpenFileDialog _Dialog = new OpenFileDialog();

        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.DropDown;
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            return _Dialog.ShowDialog() == DialogResult.OK ? _Dialog.FileName : "";
        }
    }
}
