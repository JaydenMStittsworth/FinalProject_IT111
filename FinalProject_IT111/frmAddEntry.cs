using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_IT111
{
    public partial class frmAddEntry : Form
    {
        private Record _record;

        public frmAddEntry()
        {
            InitializeComponent();
            _record = new Record();
        }

        public void LoadRecord(Record record)
        {
            _record = record;
        }

        public Record GetRecord()
        {
            return _record;
        }

        private void frmAddEntry_Load(object sender, EventArgs e)
        {
            // uses data binding to connect the two forms
            txtTitle.DataBindings.Clear();
            txtEntry.DataBindings.Clear();
            txtTitle.DataBindings.Add("Text", _record, "Title");
            txtEntry.DataBindings.Add("Text", _record, "Entry");
        }

        private void btnAddNewEntry_Click(object sender, EventArgs e)
        {
            // error handling to avoid blank spaces
            if (txtTitle.Text == "" && txtEntry.Text == "")
            {
                MessageBox.Show("Enter both");
            }
            else if (txtTitle.Text == "")
            {
                MessageBox.Show("Enter one");
            }
            else if (txtEntry.Text == "")
            {
                MessageBox.Show("Enter other");
            }
            else
            {
                // enters new list information and closes the form
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "";
            txtEntry.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // closes the form
            this.Close();
        }
    }
}
