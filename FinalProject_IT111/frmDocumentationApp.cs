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

        //private void lbEntries_Click(object sender, EventArgs e)
        //{
        //    // code for opening the registered entry form upon click
        //    #pragma warning disable CS8600
        //    Record selectedObj = (Record)lbEntries.SelectedItem;
        //    #pragma warning restore CS8600

        //    if (selectedObj != null)
        //    {
        //        MessageBox.Show($"{selectedObj.Entry}", $"{selectedObj.Title}");
        //    }
        //}

        private void btnNewEntry_Click(object sender, EventArgs e)
        {
            // code to open up a new entry form
            // adds new entry to list
            var newAddEntryForm = new frmAddEntry();

            if (newAddEntryForm.ShowDialog() == DialogResult.OK)
            {
                Records.Add(newAddEntryForm.GetRecord());
            }

        }

        private void frmDocumentationApp_Load(object sender, EventArgs e)
        {
            // connects the entries list box to the records list
            // lbEntries.DataSource = Records;

            // adds a new entry for explaining how the application works
            Records.Add(new Record
            {
                Title = "Click Me",
                Entry = "This application keeps track of different " +
                "entries. Click the New Entry button to add " +
                "new entries to the form. Click on the entries in the " +
                "list box to view their contents."
            });
        }
    }
}
