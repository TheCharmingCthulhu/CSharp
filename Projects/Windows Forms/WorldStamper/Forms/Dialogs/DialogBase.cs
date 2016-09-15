namespace WorldStamper.Forms.Dialogs
{
    public class DialogBase : FormBase
    {
        public DialogBase() : base()
        {
            ShowInTaskbar = false;
            ControlBox = false;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        }
    }
}
