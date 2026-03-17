using System.ComponentModel;

namespace FinalProject_IT111
{
    public partial class frmDocumentationApp : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BindingList<Record> Records { get; set; }
        public frmDocumentationApp()
        {
            InitializeComponent();
            Records = new BindingList<Record>
            {
                AllowNew = true,
                AllowRemove = true,
                AllowEdit = false
            };
        }

        private void btnNewEntry_Click(object sender, EventArgs e)
        {
            // code to open up a new entry form
            var newAddEntryForm = new frmAddEntry();

            if (newAddEntryForm.ShowDialog() == DialogResult.OK)
            {
                Records.Add(newAddEntryForm.GetRecord());
            }

        }

        private void frmDocumentationApp_Load(object sender, EventArgs e)
        {
            lbEntries.DataSource = Records;
        }
    }
}
