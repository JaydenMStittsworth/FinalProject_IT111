namespace FinalProject_IT111
{
    partial class EntryControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblEntryValue = new Label();
            btnViewContents = new Button();
            btnDeleteEntry = new Button();
            SuspendLayout();
            // 
            // lblEntryValue
            // 
            lblEntryValue.AutoSize = true;
            lblEntryValue.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEntryValue.Location = new Point(13, 10);
            lblEntryValue.Name = "lblEntryValue";
            lblEntryValue.Size = new Size(140, 25);
            lblEntryValue.TabIndex = 0;
            lblEntryValue.Text = "Title Goes Here";
            // 
            // btnViewContents
            // 
            btnViewContents.Location = new Point(245, 14);
            btnViewContents.Name = "btnViewContents";
            btnViewContents.Size = new Size(102, 23);
            btnViewContents.TabIndex = 1;
            btnViewContents.Text = "View Contents";
            btnViewContents.UseVisualStyleBackColor = true;
            // 
            // btnDeleteEntry
            // 
            btnDeleteEntry.Location = new Point(245, 48);
            btnDeleteEntry.Name = "btnDeleteEntry";
            btnDeleteEntry.Size = new Size(102, 23);
            btnDeleteEntry.TabIndex = 2;
            btnDeleteEntry.Text = "Delete Entry";
            btnDeleteEntry.UseVisualStyleBackColor = true;
            // 
            // EntryControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDeleteEntry);
            Controls.Add(btnViewContents);
            Controls.Add(lblEntryValue);
            Name = "EntryControl";
            Size = new Size(364, 84);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEntryValue;
        private Button btnViewContents;
        private Button btnDeleteEntry;
    }
}
