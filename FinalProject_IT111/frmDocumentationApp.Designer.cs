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
            btnNewEntry = new Button();
            lblTitle = new Label();
            gbTitleAndNewEntry = new GroupBox();
            fpEntries = new FlowLayoutPanel();
            gbEntriesContainer = new GroupBox();
            gbTitleAndNewEntry.SuspendLayout();
            gbEntriesContainer.SuspendLayout();
            SuspendLayout();
            // 
            // btnNewEntry
            // 
            btnNewEntry.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNewEntry.Location = new Point(267, 21);
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
            lblTitle.Location = new Point(6, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(230, 32);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Documentation App";
            // 
            // gbTitleAndNewEntry
            // 
            gbTitleAndNewEntry.Anchor = AnchorStyles.Top;
            gbTitleAndNewEntry.Controls.Add(lblTitle);
            gbTitleAndNewEntry.Controls.Add(btnNewEntry);
            gbTitleAndNewEntry.Location = new Point(12, 12);
            gbTitleAndNewEntry.Name = "gbTitleAndNewEntry";
            gbTitleAndNewEntry.Size = new Size(384, 64);
            gbTitleAndNewEntry.TabIndex = 3;
            gbTitleAndNewEntry.TabStop = false;
            // 
            // fpEntries
            // 
            fpEntries.AutoScroll = true;
            fpEntries.FlowDirection = FlowDirection.TopDown;
            fpEntries.Location = new Point(6, 22);
            fpEntries.Name = "fpEntries";
            fpEntries.Size = new Size(370, 416);
            fpEntries.TabIndex = 3;
            fpEntries.WrapContents = false;
            // 
            // gbEntriesContainer
            // 
            gbEntriesContainer.Anchor = AnchorStyles.Bottom;
            gbEntriesContainer.Controls.Add(fpEntries);
            gbEntriesContainer.Location = new Point(12, 82);
            gbEntriesContainer.Name = "gbEntriesContainer";
            gbEntriesContainer.Size = new Size(384, 444);
            gbEntriesContainer.TabIndex = 4;
            gbEntriesContainer.TabStop = false;
            // 
            // frmDocumentationApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 538);
            Controls.Add(gbEntriesContainer);
            Controls.Add(gbTitleAndNewEntry);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmDocumentationApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Documentation App";
            Load += frmDocumentationApp_Load;
            gbTitleAndNewEntry.ResumeLayout(false);
            gbTitleAndNewEntry.PerformLayout();
            gbEntriesContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnNewEntry;
        private Label lblTitle;
        private GroupBox gbTitleAndNewEntry;
        private FlowLayoutPanel fpEntries;
        private GroupBox gbEntriesContainer;
    }
}
