using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_IT111
{
    public partial class frmAddEntry : Form
    {
        public frmAddEntry()
        {
            InitializeComponent();
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
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "";
            txtEntry.Text = "";
        }
    }
}
