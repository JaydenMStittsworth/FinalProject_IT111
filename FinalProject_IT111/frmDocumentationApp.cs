using System.ComponentModel;

namespace FinalProject_IT111
{
    public partial class frmDocumentationApp : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Record> Records { get; set; }
        public frmDocumentationApp()
        {
            InitializeComponent();
            Records = new List<Record>();
        }

        private void btnNewEntry_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yay it worked");

            // code to open up a new entry form
        }
    }
}
