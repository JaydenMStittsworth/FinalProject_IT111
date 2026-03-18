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
            btnCancel = new Button();
            gbAddEntry = new GroupBox();
            gbAddEntry.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(6, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(42, 21);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title:";
            // 
            // lblEntry
            // 
            lblEntry.AutoSize = true;
            lblEntry.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEntry.Location = new Point(6, 51);
            lblEntry.Name = "lblEntry";
            lblEntry.Size = new Size(49, 21);
            lblEntry.TabIndex = 1;
            lblEntry.Text = "Entry:";
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitle.Location = new Point(61, 16);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(382, 29);
            txtTitle.TabIndex = 2;
            // 
            // txtEntry
            // 
            txtEntry.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEntry.Location = new Point(61, 51);
            txtEntry.Multiline = true;
            txtEntry.Name = "txtEntry";
            txtEntry.Size = new Size(382, 189);
            txtEntry.TabIndex = 3;
            // 
            // btnAddNewEntry
            // 
            btnAddNewEntry.Location = new Point(348, 246);
            btnAddNewEntry.Name = "btnAddNewEntry";
            btnAddNewEntry.Size = new Size(95, 23);
            btnAddNewEntry.TabIndex = 4;
            btnAddNewEntry.Text = "Add New Entry";
            btnAddNewEntry.UseVisualStyleBackColor = true;
            btnAddNewEntry.Click += btnAddNewEntry_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(247, 246);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(95, 23);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(61, 246);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(95, 23);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // gbAddEntry
            // 
            gbAddEntry.Anchor = AnchorStyles.Top;
            gbAddEntry.Controls.Add(lblTitle);
            gbAddEntry.Controls.Add(btnCancel);
            gbAddEntry.Controls.Add(lblEntry);
            gbAddEntry.Controls.Add(btnClear);
            gbAddEntry.Controls.Add(txtTitle);
            gbAddEntry.Controls.Add(btnAddNewEntry);
            gbAddEntry.Controls.Add(txtEntry);
            gbAddEntry.Location = new Point(16, 12);
            gbAddEntry.Name = "gbAddEntry";
            gbAddEntry.Size = new Size(460, 280);
            gbAddEntry.TabIndex = 7;
            gbAddEntry.TabStop = false;
            // 
            // frmAddEntry
            // 
            AcceptButton = btnAddNewEntry;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(488, 305);
            Controls.Add(gbAddEntry);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmAddEntry";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Entry";
            Load += frmAddEntry_Load;
            gbAddEntry.ResumeLayout(false);
            gbAddEntry.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblEntry;
        private TextBox txtTitle;
        private TextBox txtEntry;
        private Button btnAddNewEntry;
        private Button btnClear;
        private Button btnCancel;
        private GroupBox gbAddEntry;
    }
}