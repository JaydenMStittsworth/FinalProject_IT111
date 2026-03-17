namespace FinalProject_IT111
{
    partial class frmDocumentationApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbEntries = new ListBox();
            btnNewEntry = new Button();
            lblTitle = new Label();
            gbDocumentationApp = new GroupBox();
            gbDocumentationApp.SuspendLayout();
            SuspendLayout();
            // 
            // lbEntries
            // 
            lbEntries.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEntries.FormattingEnabled = true;
            lbEntries.Location = new Point(6, 63);
            lbEntries.Name = "lbEntries";
            lbEntries.Size = new Size(364, 361);
            lbEntries.TabIndex = 0;
            lbEntries.Click += lbEntries_Click;
            // 
            // btnNewEntry
            // 
            btnNewEntry.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNewEntry.Location = new Point(252, 21);
            btnNewEntry.Name = "btnNewEntry";
            btnNewEntry.Size = new Size(109, 36);
            btnNewEntry.TabIndex = 1;
            btnNewEntry.Text = "New Entry";
            btnNewEntry.UseVisualStyleBackColor = true;
            btnNewEntry.Click += btnNewEntry_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(16, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(230, 32);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Documentation App";
            // 
            // gbDocumentationApp
            // 
            gbDocumentationApp.Anchor = AnchorStyles.Top;
            gbDocumentationApp.Controls.Add(lbEntries);
            gbDocumentationApp.Controls.Add(lblTitle);
            gbDocumentationApp.Controls.Add(btnNewEntry);
            gbDocumentationApp.Location = new Point(16, 12);
            gbDocumentationApp.Name = "gbDocumentationApp";
            gbDocumentationApp.Size = new Size(376, 437);
            gbDocumentationApp.TabIndex = 3;
            gbDocumentationApp.TabStop = false;
            // 
            // frmDocumentationApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 461);
            Controls.Add(gbDocumentationApp);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmDocumentationApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Documentation App";
            Load += frmDocumentationApp_Load;
            gbDocumentationApp.ResumeLayout(false);
            gbDocumentationApp.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbEntries;
        private Button btnNewEntry;
        private Label lblTitle;
        private GroupBox gbDocumentationApp;
    }
}
