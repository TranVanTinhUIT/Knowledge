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
            this.txtCompoundInfo = new System.Windows.Forms.TextBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.DetailRulePanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.dgvCompoundDetails = new System.Windows.Forms.DataGridView();
            this.Atom = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.mainPanel.SuspendLayout();
            this.DetailRulePanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompoundDetails)).BeginInit();
            this.InfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCompoundInfo
            // 
            this.txtCompoundInfo.BackColor = System.Drawing.SystemColors.Menu;
            this.txtCompoundInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCompoundInfo.Enabled = false;
            this.txtCompoundInfo.Location = new System.Drawing.Point(0, 0);
            this.txtCompoundInfo.Multiline = true;
            this.txtCompoundInfo.Name = "txtCompoundInfo";
            this.txtCompoundInfo.ReadOnly = true;
            this.txtCompoundInfo.Size = new System.Drawing.Size(526, 80);
            this.txtCompoundInfo.TabIndex = 100;
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
            this.mainPanel.TabIndex = 1;
            // 
            // DetailRulePanel
            // 
            this.DetailRulePanel.Controls.Add(this.bottomPanel);
            this.DetailRulePanel.Controls.Add(this.dgvCompoundDetails);
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
            this.bottomPanel.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(440, 14);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
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
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dgvCompoundDetails
            // 
            this.dgvCompoundDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompoundDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Atom,
            this.Weight});
            this.dgvCompoundDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCompoundDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvCompoundDetails.Name = "dgvCompoundDetails";
            this.dgvCompoundDetails.RowTemplate.Height = 25;
            this.dgvCompoundDetails.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvCompoundDetails.Size = new System.Drawing.Size(526, 394);
            this.dgvCompoundDetails.TabIndex = 1;
            this.dgvCompoundDetails.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvCompoundDetails_CellValidating);
            this.dgvCompoundDetails.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompoundDetails_CellValueChanged);
            // 
            // Atom
            // 
            this.Atom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Atom.HeaderText = "Atom";
            this.Atom.Name = "Atom";
            this.Atom.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Weight
            // 
            this.Weight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Weight.HeaderText = "Weight";
            this.Weight.Name = "Weight";
            this.Weight.Width = 70;
            // 
            // InfoPanel
            // 
            this.InfoPanel.Controls.Add(this.txtCompoundInfo);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoPanel.Location = new System.Drawing.Point(0, 0);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(526, 80);
            this.InfoPanel.TabIndex = 0;
            // 
            // AddCompoundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 476);
            this.Controls.Add(this.mainPanel);
            this.MinimumSize = new System.Drawing.Size(544, 515);
            this.Name = "AddCompoundForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCompoundForm";
            this.Load += new System.EventHandler(this.AddCompoundForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.DetailRulePanel.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompoundDetails)).EndInit();
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox txtCompoundInfo;
        private Panel mainPanel;
        private Panel DetailRulePanel;
        private DataGridView dgvCompoundDetails;
        private Panel InfoPanel;
        private Panel bottomPanel;
        private Button btnOK;
        private Button btnCancel;
        private DataGridViewComboBoxColumn Atom;
        private DataGridViewTextBoxColumn Weight;
    }
}