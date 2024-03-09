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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.DetailRulePanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.dgvRuleDetails = new System.Windows.Forms.DataGridView();
            this.Compound = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MoleWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.txtRuleInfo = new System.Windows.Forms.TextBox();
            this.mainPanel.SuspendLayout();
            this.DetailRulePanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRuleDetails)).BeginInit();
            this.InfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.DetailRulePanel);
            this.mainPanel.Controls.Add(this.InfoPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(528, 476);
            this.mainPanel.TabIndex = 0;
            // 
            // DetailRulePanel
            // 
            this.DetailRulePanel.Controls.Add(this.bottomPanel);
            this.DetailRulePanel.Controls.Add(this.dgvRuleDetails);
            this.DetailRulePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetailRulePanel.Location = new System.Drawing.Point(0, 80);
            this.DetailRulePanel.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.DetailRulePanel.Name = "DetailRulePanel";
            this.DetailRulePanel.Size = new System.Drawing.Size(526, 394);
            this.DetailRulePanel.TabIndex = 1;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.btnCancel);
            this.bottomPanel.Controls.Add(this.btnOK);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 346);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(526, 48);
            this.bottomPanel.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(440, 14);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(365, 14);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(64, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dgvRuleDetails
            // 
            this.dgvRuleDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRuleDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Compound,
            this.Type,
            this.MoleWeight});
            this.dgvRuleDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRuleDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvRuleDetails.Name = "dgvRuleDetails";
            this.dgvRuleDetails.RowTemplate.Height = 25;
            this.dgvRuleDetails.Size = new System.Drawing.Size(526, 394);
            this.dgvRuleDetails.TabIndex = 0;
            this.dgvRuleDetails.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvRuleDetails_CellValidating);
            this.dgvRuleDetails.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRuleDetails_CellValueChanged);
            // 
            // Compound
            // 
            this.Compound.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Compound.HeaderText = "Compound";
            this.Compound.Name = "Compound";
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // MoleWeight
            // 
            this.MoleWeight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MoleWeight.HeaderText = "MoleWeight";
            this.MoleWeight.Name = "MoleWeight";
            this.MoleWeight.Width = 97;
            // 
            // InfoPanel
            // 
            this.InfoPanel.Controls.Add(this.txtRuleInfo);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoPanel.Location = new System.Drawing.Point(0, 0);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(526, 80);
            this.InfoPanel.TabIndex = 0;
            // 
            // txtRuleInfo
            // 
            this.txtRuleInfo.BackColor = System.Drawing.SystemColors.Window;
            this.txtRuleInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRuleInfo.Location = new System.Drawing.Point(0, 0);
            this.txtRuleInfo.Multiline = true;
            this.txtRuleInfo.Name = "txtRuleInfo";
            this.txtRuleInfo.ReadOnly = true;
            this.txtRuleInfo.Size = new System.Drawing.Size(526, 80);
            this.txtRuleInfo.TabIndex = 0;
            // 
            // AddRuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 476);
            this.Controls.Add(this.mainPanel);
            this.MinimumSize = new System.Drawing.Size(544, 515);
            this.Name = "AddRuleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRuleForm";
            this.Load += new System.EventHandler(this.AddRuleForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.DetailRulePanel.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRuleDetails)).EndInit();
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel mainPanel;
        private Panel InfoPanel;
        private TextBox txtRuleInfo;
        private Panel DetailRulePanel;
        private DataGridView dgvRuleDetails;
        private Panel bottomPanel;
        private Button btnCancel;
        private Button btnOK;
        private DataGridViewComboBoxColumn Compound;
        private DataGridViewComboBoxColumn Type;
        private DataGridViewTextBoxColumn MoleWeight;
    }
}