using Sandbox.Sources.Sequences;
using System.Windows.Forms;

namespace Sandbox
{
    public partial class FormSequences : Form
    {
        SequenceManager _sequenceMgr;

        public FormSequences()
        {
            InitializeComponent();
        }

        public static DialogResult Run()
        {
            var f = new FormSequences();

            return f.ShowDialog();
        }

        private void buttonGenerate_Click(object sender, System.EventArgs e)
        {
            _sequenceMgr = new SequenceManager();

            var sequences = _sequenceMgr.ParseItems(12 * 60 * 60 * 1000);
            var xml = _sequenceMgr.OutputXML(sequences);

            richTextBox1.Text = xml;
        }
    }
}
