namespace Knowledge
{
    partial class AddCompoundForm
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
            txtCompoundInfo = new TextBox();
            mainPanel = new Panel();
            DetailRulePanel = new Panel();
            bottomPanel = new Panel();
            btnOK = new Button();
            dgvCompoundDetails = new DataGridView();
            Atom = new DataGridViewComboBoxColumn();
            Weight = new DataGridViewTextBoxColumn();
            InfoPanel = new Panel();
            btnCancel = new Button();
            mainPanel.SuspendLayout();
            DetailRulePanel.SuspendLayout();
            bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompoundDetails).BeginInit();
            InfoPanel.SuspendLayout();
            SuspendLayout();
            // 
            // txtCompoundInfo
            // 
            txtCompoundInfo.BackColor = SystemColors.Window;
            txtCompoundInfo.Dock = DockStyle.Top;
            txtCompoundInfo.Location = new Point(0, 0);
            txtCompoundInfo.Multiline = true;
            txtCompoundInfo.Name = "txtCompoundInfo";
            txtCompoundInfo.ReadOnly = true;
            txtCompoundInfo.Size = new Size(526, 80);
            txtCompoundInfo.TabIndex = 0;
            // 
            // mainPanel
            // 
            mainPanel.BorderStyle = BorderStyle.FixedSingle;
            mainPanel.Controls.Add(DetailRulePanel);
            mainPanel.Controls.Add(InfoPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(528, 476);
            mainPanel.TabIndex = 1;
            // 
            // DetailRulePanel
            // 
            DetailRulePanel.Controls.Add(bottomPanel);
            DetailRulePanel.Controls.Add(dgvCompoundDetails);
            DetailRulePanel.Dock = DockStyle.Fill;
            DetailRulePanel.Location = new Point(0, 80);
            DetailRulePanel.Margin = new Padding(3, 15, 3, 3);
            DetailRulePanel.Name = "DetailRulePanel";
            DetailRulePanel.Size = new Size(526, 394);
            DetailRulePanel.TabIndex = 1;
            // 
            // bottomPanel
            // 
            bottomPanel.Controls.Add(btnCancel);
            bottomPanel.Controls.Add(btnOK);
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Location = new Point(0, 346);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(526, 48);
            bottomPanel.TabIndex = 1;
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOK.Location = new Point(365, 14);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(64, 23);
            btnOK.TabIndex = 0;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // dgvCompoundDetails
            // 
            dgvCompoundDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompoundDetails.Columns.AddRange(new DataGridViewColumn[] { Atom, Weight });
            dgvCompoundDetails.Dock = DockStyle.Fill;
            dgvCompoundDetails.Location = new Point(0, 0);
            dgvCompoundDetails.Name = "dgvCompoundDetails";
            dgvCompoundDetails.RowTemplate.Height = 25;
            dgvCompoundDetails.Size = new Size(526, 394);
            dgvCompoundDetails.TabIndex = 0;
            dgvCompoundDetails.CellValidating += dgvCompoundDetails_CellValidating;
            // 
            // Atom
            // 
            Atom.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Atom.HeaderText = "Atom";
            Atom.Name = "Atom";
            // 
            // Weight
            // 
            Weight.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Weight.HeaderText = "Weight";
            Weight.Name = "Weight";
            Weight.Width = 70;
            // 
            // InfoPanel
            // 
            InfoPanel.Controls.Add(txtCompoundInfo);
            InfoPanel.Dock = DockStyle.Top;
            InfoPanel.Location = new Point(0, 0);
            InfoPanel.Name = "InfoPanel";
            InfoPanel.Size = new Size(526, 80);
            InfoPanel.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.Location = new Point(440, 14);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddCompoundForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 476);
            Controls.Add(mainPanel);
            MinimumSize = new Size(544, 515);
            Name = "AddCompoundForm";
            Text = "AddCompoundForm";
            mainPanel.ResumeLayout(false);
            DetailRulePanel.ResumeLayout(false);
            bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCompoundDetails).EndInit();
            InfoPanel.ResumeLayout(false);
            InfoPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtCompoundInfo;
        private Panel mainPanel;
        private Panel DetailRulePanel;
        private DataGridView dgvCompoundDetails;
        private Panel InfoPanel;
        private DataGridViewComboBoxColumn Atom;
        private DataGridViewTextBoxColumn Weight;
        private Panel bottomPanel;
        private Button btnOK;
        private Button btnCancel;
    }
}