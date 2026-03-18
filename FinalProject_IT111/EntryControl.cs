using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_IT111
{
    public partial class EntryControl : UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Record RecordDetails { get; set; }
        public EntryControl(Record recordDetails)
        {
            InitializeComponent();
            RecordDetails = recordDetails;

            // fill in the title of the record using data
            lblEntryTitle.Text = $"{RecordDetails.Title}";
        }

        // display messagebox containing contents of entry
        private void btnViewContents_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{RecordDetails.Entry}", $"{RecordDetails.Title}");
        }

        // delete the entry from the form
        private void btnDeleteEntry_Click(object sender, EventArgs e)
        {
            var frm = this.Parent?.Parent?.Parent as frmDocumentationApp;

            if (frm != null)
            {
                MessageBox.Show($"RECORD DELETED - {lblEntryTitle.Text}");
                frm.Records.Remove(RecordDetails);
                frm.RefreshEntries();
            }
        }
    }
}
