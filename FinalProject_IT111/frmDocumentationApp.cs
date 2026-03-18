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

            // creates the new Records list
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
            // adds new entry to list
            var newAddEntryForm = new frmAddEntry();

            if (newAddEntryForm.ShowDialog() == DialogResult.OK)
            {
                Records.Add(newAddEntryForm.GetRecord());

                RefreshEntries();
            }

        }

        // code for refreshing the flow layout panel
        public void RefreshEntries()
        {
            fpEntries.Controls.Clear();

            foreach (Record record in Records)
            {
                fpEntries.Controls.Add(new EntryControl(record));
            }
        }

        private void frmDocumentationApp_Load(object sender, EventArgs e)
        {
            Records.Add(new Record
            {
                Title = "Read Me",
                Entry = "This application is able to record entries put in " +
                "by users. The 'New Entry' button on the top of the form " +
                "will create a new entry. The 'View Contents' button on " +
                "the right of a control allows users to view the contents " +
                "of an entry. The 'Delete Entry' button under the 'View " +
                "Contents' button will prompt users on whether or not they " +
                "want to delete the entry."
            });

            RefreshEntries();
        }
    }
}
