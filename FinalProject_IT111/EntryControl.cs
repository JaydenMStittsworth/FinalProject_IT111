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

        private void btnViewContents_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{RecordDetails.Entry}", $"{RecordDetails.Title}");
        }
    }
}
