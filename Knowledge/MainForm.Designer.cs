namespace Knowledge
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.dgvCompounds = new System.Windows.Forms.DataGridView();
            this.Compound = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormulaDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Properties = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsDeleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRules = new System.Windows.Forms.DataGridView();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.excuteTab = new System.Windows.Forms.TabPage();
            this.responsePanel = new System.Windows.Forms.Panel();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.requestPanel = new System.Windows.Forms.Panel();
            this.targetPanel = new System.Windows.Forms.Panel();
            this.dgvTargets = new System.Windows.Forms.DataGridView();
            this.TargetCompound = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.chemicalCompoundBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actionPanel = new System.Windows.Forms.Panel();
            this.btnExcute = new System.Windows.Forms.Button();
            this.initPanel = new System.Windows.Forms.Panel();
            this.dgvInits = new System.Windows.Forms.DataGridView();
            this.InitCompound = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CompoundTab = new System.Windows.Forms.TabPage();
            this.GridCompoundPanel = new System.Windows.Forms.Panel();
            this.AddCompoundPanel = new System.Windows.Forms.Panel();
            this.btnAddCompound = new System.Windows.Forms.Button();
            this.RuleTab = new System.Windows.Forms.TabPage();
            this.GridRulePanel = new System.Windows.Forms.Panel();
            this.AddRulePanel = new System.Windows.Forms.Panel();
            this.btnAddRule = new System.Windows.Forms.Button();
            this.Rule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Items = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompounds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRules)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.excuteTab.SuspendLayout();
            this.responsePanel.SuspendLayout();
            this.requestPanel.SuspendLayout();
            this.targetPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTargets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chemicalCompoundBindingSource)).BeginInit();
            this.actionPanel.SuspendLayout();
            this.initPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInits)).BeginInit();
            this.CompoundTab.SuspendLayout();
            this.GridCompoundPanel.SuspendLayout();
            this.AddCompoundPanel.SuspendLayout();
            this.RuleTab.SuspendLayout();
            this.GridRulePanel.SuspendLayout();
            this.AddRulePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCompounds
            // 
            this.dgvCompounds.AllowUserToAddRows = false;
            this.dgvCompounds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompounds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Compound,
            this.FormulaDetails,
            this.Properties,
            this.Id,
            this.IsDeleted});
            this.dgvCompounds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCompounds.Location = new System.Drawing.Point(0, 0);
            this.dgvCompounds.Name = "dgvCompounds";
            this.dgvCompounds.RowTemplate.Height = 25;
            this.dgvCompounds.Size = new System.Drawing.Size(786, 361);
            this.dgvCompounds.TabIndex = 0;
            // 
            // Compound
            // 
            this.Compound.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Compound.DataPropertyName = "Name";
            this.Compound.HeaderText = "Compound";
            this.Compound.Name = "Compound";
            this.Compound.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FormulaDetails
            // 
            this.FormulaDetails.DataPropertyName = "FormulaDetails";
            this.FormulaDetails.HeaderText = "FormulaDetails";
            this.FormulaDetails.Name = "FormulaDetails";
            this.FormulaDetails.Visible = false;
            // 
            // Properties
            // 
            this.Properties.DataPropertyName = "Properties";
            this.Properties.HeaderText = "Properties";
            this.Properties.Name = "Properties";
            this.Properties.Visible = false;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // IsDeleted
            // 
            this.IsDeleted.DataPropertyName = "IsDeleted";
            this.IsDeleted.HeaderText = "IsDeleted";
            this.IsDeleted.Name = "IsDeleted";
            this.IsDeleted.Visible = false;
            // 
            // dgvRules
            // 
            this.dgvRules.AllowUserToAddRows = false;
            this.dgvRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rule,
            this.dataGridViewTextBoxColumn1,
            this.Items,
            this.dataGridViewTextBoxColumn2});
            this.dgvRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRules.Location = new System.Drawing.Point(0, 0);
            this.dgvRules.Name = "dgvRules";
            this.dgvRules.ReadOnly = true;
            this.dgvRules.RowTemplate.Height = 25;
            this.dgvRules.Size = new System.Drawing.Size(786, 361);
            this.dgvRules.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.MainTabControl);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(800, 450);
            this.MainPanel.TabIndex = 0;
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.excuteTab);
            this.MainTabControl.Controls.Add(this.CompoundTab);
            this.MainTabControl.Controls.Add(this.RuleTab);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(800, 450);
            this.MainTabControl.TabIndex = 0;
            // 
            // excuteTab
            // 
            this.excuteTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.excuteTab.Controls.Add(this.responsePanel);
            this.excuteTab.Controls.Add(this.requestPanel);
            this.excuteTab.Location = new System.Drawing.Point(4, 24);
            this.excuteTab.Name = "excuteTab";
            this.excuteTab.Padding = new System.Windows.Forms.Padding(3);
            this.excuteTab.Size = new System.Drawing.Size(792, 422);
            this.excuteTab.TabIndex = 0;
            this.excuteTab.Text = "Main";
            this.excuteTab.UseVisualStyleBackColor = true;
            // 
            // responsePanel
            // 
            this.responsePanel.Controls.Add(this.txtResponse);
            this.responsePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.responsePanel.Location = new System.Drawing.Point(3, 190);
            this.responsePanel.Name = "responsePanel";
            this.responsePanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.responsePanel.Size = new System.Drawing.Size(784, 227);
            this.responsePanel.TabIndex = 0;
            // 
            // txtResponse
            // 
            this.txtResponse.BackColor = System.Drawing.SystemColors.Window;
            this.txtResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResponse.Location = new System.Drawing.Point(0, 10);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(784, 217);
            this.txtResponse.TabIndex = 0;
            // 
            // requestPanel
            // 
            this.requestPanel.Controls.Add(this.targetPanel);
            this.requestPanel.Controls.Add(this.actionPanel);
            this.requestPanel.Controls.Add(this.initPanel);
            this.requestPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.requestPanel.Location = new System.Drawing.Point(3, 3);
            this.requestPanel.Name = "requestPanel";
            this.requestPanel.Size = new System.Drawing.Size(784, 187);
            this.requestPanel.TabIndex = 0;
            // 
            // targetPanel
            // 
            this.targetPanel.Controls.Add(this.dgvTargets);
            this.targetPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetPanel.Location = new System.Drawing.Point(323, 0);
            this.targetPanel.Name = "targetPanel";
            this.targetPanel.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.targetPanel.Size = new System.Drawing.Size(359, 187);
            this.targetPanel.TabIndex = 2;
            // 
            // dgvTargets
            // 
            this.dgvTargets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTargets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TargetCompound});
            this.dgvTargets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTargets.Location = new System.Drawing.Point(5, 0);
            this.dgvTargets.Name = "dgvTargets";
            this.dgvTargets.RowTemplate.Height = 25;
            this.dgvTargets.Size = new System.Drawing.Size(349, 187);
            this.dgvTargets.TabIndex = 0;
            // 
            // TargetCompound
            // 
            this.TargetCompound.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TargetCompound.DataSource = this.chemicalCompoundBindingSource;
            this.TargetCompound.DisplayMember = "Name";
            this.TargetCompound.HeaderText = "Target Compounds";
            this.TargetCompound.Name = "TargetCompound";
            this.TargetCompound.ValueMember = "Id";
            // 
            // chemicalCompoundBindingSource
            // 
            this.chemicalCompoundBindingSource.DataSource = typeof(Knowledge.Entities.Chemicals.Chemical_Compound);
            // 
            // actionPanel
            // 
            this.actionPanel.Controls.Add(this.btnExcute);
            this.actionPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.actionPanel.Location = new System.Drawing.Point(682, 0);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(102, 187);
            this.actionPanel.TabIndex = 1;
            // 
            // btnExcute
            // 
            this.btnExcute.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExcute.Location = new System.Drawing.Point(9, 3);
            this.btnExcute.Name = "btnExcute";
            this.btnExcute.Size = new System.Drawing.Size(77, 33);
            this.btnExcute.TabIndex = 0;
            this.btnExcute.Text = "Excute";
            this.btnExcute.UseVisualStyleBackColor = true;
            this.btnExcute.Click += new System.EventHandler(this.btnExcute_Click);
            // 
            // initPanel
            // 
            this.initPanel.Controls.Add(this.dgvInits);
            this.initPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.initPanel.Location = new System.Drawing.Point(0, 0);
            this.initPanel.Name = "initPanel";
            this.initPanel.Size = new System.Drawing.Size(323, 187);
            this.initPanel.TabIndex = 0;
            // 
            // dgvInits
            // 
            this.dgvInits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InitCompound});
            this.dgvInits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInits.Location = new System.Drawing.Point(0, 0);
            this.dgvInits.Name = "dgvInits";
            this.dgvInits.RowTemplate.Height = 25;
            this.dgvInits.Size = new System.Drawing.Size(323, 187);
            this.dgvInits.TabIndex = 0;
            // 
            // InitCompound
            // 
            this.InitCompound.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InitCompound.DataSource = this.chemicalCompoundBindingSource;
            this.InitCompound.DisplayMember = "Name";
            this.InitCompound.HeaderText = "Initial Compounds";
            this.InitCompound.Name = "InitCompound";
            this.InitCompound.ValueMember = "Id";
            // 
            // CompoundTab
            // 
            this.CompoundTab.Controls.Add(this.GridCompoundPanel);
            this.CompoundTab.Controls.Add(this.AddCompoundPanel);
            this.CompoundTab.Location = new System.Drawing.Point(4, 24);
            this.CompoundTab.Name = "CompoundTab";
            this.CompoundTab.Padding = new System.Windows.Forms.Padding(3);
            this.CompoundTab.Size = new System.Drawing.Size(792, 422);
            this.CompoundTab.TabIndex = 1;
            this.CompoundTab.Text = "Compounds";
            this.CompoundTab.UseVisualStyleBackColor = true;
            // 
            // GridCompoundPanel
            // 
            this.GridCompoundPanel.Controls.Add(this.dgvCompounds);
            this.GridCompoundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridCompoundPanel.Location = new System.Drawing.Point(3, 3);
            this.GridCompoundPanel.Name = "GridCompoundPanel";
            this.GridCompoundPanel.Size = new System.Drawing.Size(786, 361);
            this.GridCompoundPanel.TabIndex = 1;
            // 
            // AddCompoundPanel
            // 
            this.AddCompoundPanel.Controls.Add(this.btnAddCompound);
            this.AddCompoundPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddCompoundPanel.Location = new System.Drawing.Point(3, 364);
            this.AddCompoundPanel.Name = "AddCompoundPanel";
            this.AddCompoundPanel.Size = new System.Drawing.Size(786, 55);
            this.AddCompoundPanel.TabIndex = 0;
            // 
            // btnAddCompound
            // 
            this.btnAddCompound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCompound.Location = new System.Drawing.Point(678, 6);
            this.btnAddCompound.Name = "btnAddCompound";
            this.btnAddCompound.Size = new System.Drawing.Size(105, 34);
            this.btnAddCompound.TabIndex = 0;
            this.btnAddCompound.Text = "Add";
            this.btnAddCompound.UseVisualStyleBackColor = true;
            this.btnAddCompound.Click += new System.EventHandler(this.btnAddCompound_Click);
            // 
            // RuleTab
            // 
            this.RuleTab.Controls.Add(this.GridRulePanel);
            this.RuleTab.Controls.Add(this.AddRulePanel);
            this.RuleTab.Location = new System.Drawing.Point(4, 24);
            this.RuleTab.Name = "RuleTab";
            this.RuleTab.Padding = new System.Windows.Forms.Padding(3);
            this.RuleTab.Size = new System.Drawing.Size(792, 422);
            this.RuleTab.TabIndex = 2;
            this.RuleTab.Text = "Rules";
            this.RuleTab.UseVisualStyleBackColor = true;
            // 
            // GridRulePanel
            // 
            this.GridRulePanel.Controls.Add(this.dgvRules);
            this.GridRulePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridRulePanel.Location = new System.Drawing.Point(3, 3);
            this.GridRulePanel.Name = "GridRulePanel";
            this.GridRulePanel.Size = new System.Drawing.Size(786, 361);
            this.GridRulePanel.TabIndex = 3;
            // 
            // AddRulePanel
            // 
            this.AddRulePanel.Controls.Add(this.btnAddRule);
            this.AddRulePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddRulePanel.Location = new System.Drawing.Point(3, 364);
            this.AddRulePanel.Name = "AddRulePanel";
            this.AddRulePanel.Size = new System.Drawing.Size(786, 55);
            this.AddRulePanel.TabIndex = 2;
            // 
            // btnAddRule
            // 
            this.btnAddRule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRule.Location = new System.Drawing.Point(678, 6);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(105, 34);
            this.btnAddRule.TabIndex = 0;
            this.btnAddRule.Text = "Add";
            this.btnAddRule.UseVisualStyleBackColor = true;
            this.btnAddRule.Click += new System.EventHandler(this.btnAddRule_Click);
            // 
            // Rule
            // 
            this.Rule.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Rule.DataPropertyName = "Name";
            this.Rule.HeaderText = "Rule";
            this.Rule.Name = "Rule";
            this.Rule.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // Items
            // 
            this.Items.DataPropertyName = "Items";
            this.Items.HeaderText = "Items";
            this.Items.Name = "Items";
            this.Items.ReadOnly = true;
            this.Items.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IsDeleted";
            this.dataGridViewTextBoxColumn2.HeaderText = "IsDeleted";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompounds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRules)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainTabControl.ResumeLayout(false);
            this.excuteTab.ResumeLayout(false);
            this.responsePanel.ResumeLayout(false);
            this.responsePanel.PerformLayout();
            this.requestPanel.ResumeLayout(false);
            this.targetPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTargets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chemicalCompoundBindingSource)).EndInit();
            this.actionPanel.ResumeLayout(false);
            this.initPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInits)).EndInit();
            this.CompoundTab.ResumeLayout(false);
            this.GridCompoundPanel.ResumeLayout(false);
            this.AddCompoundPanel.ResumeLayout(false);
            this.RuleTab.ResumeLayout(false);
            this.GridRulePanel.ResumeLayout(false);
            this.AddRulePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MainPanel;
        private TabControl MainTabControl;
        private TabPage excuteTab;
        private TabPage CompoundTab;
        private TabPage RuleTab;
        private Panel GridCompoundPanel;
        private Panel AddCompoundPanel;
        private Panel GridRulePanel;
        private Panel AddRulePanel;
        private DataGridView dgvRules;
        private DataGridView dgvCompounds;
        private Button btnAddCompound;
        private Button btnAddRule;
        private BindingSource chemicalCompoundBindingSource;
        private Panel responsePanel;
        private Panel requestPanel;
        private TextBox txtResponse;
        private Panel initPanel;
        private Panel actionPanel;
        private Button btnExcute;
        private DataGridView dgvInits;
        private DataGridView dgvTargets;
        private Panel targetPanel;
        private DataGridViewComboBoxColumn TargetCompound;
        private DataGridViewComboBoxColumn InitCompound;
        private DataGridViewTextBoxColumn Compound;
        private DataGridViewTextBoxColumn FormulaDetails;
        private DataGridViewTextBoxColumn Properties;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn IsDeleted;
        private DataGridViewTextBoxColumn Rule;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Items;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}