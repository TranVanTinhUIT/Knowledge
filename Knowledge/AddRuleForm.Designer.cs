namespace Knowledge
{
    partial class AddRuleForm
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
            mainPanel = new Panel();
            DetailRulePanel = new Panel();
            bottomPanel = new Panel();
            btnCancel = new Button();
            btnOK = new Button();
            dgvRuleDetails = new DataGridView();
            Compound = new DataGridViewComboBoxColumn();
            MoleWeight = new DataGridViewTextBoxColumn();
            InfoPanel = new Panel();
            txtRuleInfo = new TextBox();
            mainPanel.SuspendLayout();
            DetailRulePanel.SuspendLayout();
            bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRuleDetails).BeginInit();
            InfoPanel.SuspendLayout();
            SuspendLayout();
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
            mainPanel.TabIndex = 0;
            // 
            // DetailRulePanel
            // 
            DetailRulePanel.Controls.Add(bottomPanel);
            DetailRulePanel.Controls.Add(dgvRuleDetails);
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
            bottomPanel.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.Location = new Point(440, 14);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOK.Location = new Point(365, 14);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(64, 23);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // dgvRuleDetails
            // 
            dgvRuleDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRuleDetails.Columns.AddRange(new DataGridViewColumn[] { Compound, MoleWeight });
            dgvRuleDetails.Dock = DockStyle.Fill;
            dgvRuleDetails.Location = new Point(0, 0);
            dgvRuleDetails.Name = "dgvRuleDetails";
            dgvRuleDetails.RowTemplate.Height = 25;
            dgvRuleDetails.Size = new Size(526, 394);
            dgvRuleDetails.TabIndex = 0;
            dgvRuleDetails.CellValidating += dgvRuleDetails_CellValidating;
            // 
            // Compound
            // 
            Compound.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Compound.HeaderText = "Compound";
            Compound.Name = "Compound";
            // 
            // MoleWeight
            // 
            MoleWeight.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            MoleWeight.HeaderText = "MoleWeight";
            MoleWeight.Name = "MoleWeight";
            MoleWeight.Width = 97;
            // 
            // InfoPanel
            // 
            InfoPanel.Controls.Add(txtRuleInfo);
            InfoPanel.Dock = DockStyle.Top;
            InfoPanel.Location = new Point(0, 0);
            InfoPanel.Name = "InfoPanel";
            InfoPanel.Size = new Size(526, 80);
            InfoPanel.TabIndex = 0;
            // 
            // txtRuleInfo
            // 
            txtRuleInfo.BackColor = SystemColors.Window;
            txtRuleInfo.Dock = DockStyle.Fill;
            txtRuleInfo.Location = new Point(0, 0);
            txtRuleInfo.Multiline = true;
            txtRuleInfo.Name = "txtRuleInfo";
            txtRuleInfo.ReadOnly = true;
            txtRuleInfo.Size = new Size(526, 80);
            txtRuleInfo.TabIndex = 0;
            // 
            // AddRuleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 476);
            Controls.Add(mainPanel);
            MinimumSize = new Size(544, 515);
            Name = "AddRuleForm";
            Text = "AddRuleForm";
            mainPanel.ResumeLayout(false);
            DetailRulePanel.ResumeLayout(false);
            bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRuleDetails).EndInit();
            InfoPanel.ResumeLayout(false);
            InfoPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Panel InfoPanel;
        private TextBox txtRuleInfo;
        private Panel DetailRulePanel;
        private DataGridView dgvRuleDetails;
        private DataGridViewComboBoxColumn Compound;
        private DataGridViewTextBoxColumn MoleWeight;
        private Panel bottomPanel;
        private Button btnCancel;
        private Button btnOK;
    }
}