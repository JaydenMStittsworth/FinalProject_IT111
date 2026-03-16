namespace FinalProject_IT111
{
    partial class frmAddEntry
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblEntry = new Label();
            txtTitle = new TextBox();
            txtEntry = new TextBox();
            btnAddNewEntry = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(50, 45);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(32, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title:";
            // 
            // lblEntry
            // 
            lblEntry.AutoSize = true;
            lblEntry.Location = new Point(50, 75);
            lblEntry.Name = "lblEntry";
            lblEntry.Size = new Size(37, 15);
            lblEntry.TabIndex = 1;
            lblEntry.Text = "Entry:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(101, 37);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(382, 23);
            txtTitle.TabIndex = 2;
            // 
            // txtEntry
            // 
            txtEntry.Location = new Point(101, 72);
            txtEntry.Name = "txtEntry";
            txtEntry.Size = new Size(382, 23);
            txtEntry.TabIndex = 3;
            // 
            // btnAddNewEntry
            // 
            btnAddNewEntry.Location = new Point(388, 119);
            btnAddNewEntry.Name = "btnAddNewEntry";
            btnAddNewEntry.Size = new Size(95, 23);
            btnAddNewEntry.TabIndex = 4;
            btnAddNewEntry.Text = "Add New Entry";
            btnAddNewEntry.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(287, 119);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(95, 23);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // frmAddEntry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnAddNewEntry);
            Controls.Add(txtEntry);
            Controls.Add(txtTitle);
            Controls.Add(lblEntry);
            Controls.Add(lblTitle);
            Name = "frmAddEntry";
            Text = "frmAddEntry";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblEntry;
        private TextBox txtTitle;
        private TextBox txtEntry;
        private Button btnAddNewEntry;
        private Button btnClear;
    }
}