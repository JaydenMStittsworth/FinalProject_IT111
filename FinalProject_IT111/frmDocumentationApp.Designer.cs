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
            SuspendLayout();
            // 
            // lbEntries
            // 
            lbEntries.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEntries.FormattingEnabled = true;
            lbEntries.Location = new Point(12, 54);
            lbEntries.Name = "lbEntries";
            lbEntries.Size = new Size(364, 361);
            lbEntries.TabIndex = 0;
            // 
            // btnNewEntry
            // 
            btnNewEntry.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNewEntry.Location = new Point(267, 12);
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
            lblTitle.Location = new Point(31, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(230, 32);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Documentation App";
            // 
            // frmDocumentationApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 450);
            Controls.Add(lblTitle);
            Controls.Add(btnNewEntry);
            Controls.Add(lbEntries);
            Name = "frmDocumentationApp";
            Text = "Documentation App";
            Load += frmDocumentationApp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbEntries;
        private Button btnNewEntry;
        private Label lblTitle;
    }
}
