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
            MainPanel = new Panel();
            MainTabControl = new TabControl();
            excuteTab = new TabPage();
            CompoundTab = new TabPage();
            GridCompoundPanel = new Panel();
            dgvCompounds = new DataGridView();
            Compound = new DataGridViewTextBoxColumn();
            AddCompoundPanel = new Panel();
            btnAddCompound = new Button();
            RuleTab = new TabPage();
            GridRulePanel = new Panel();
            dgvRules = new DataGridView();
            Rule = new DataGridViewTextBoxColumn();
            AddRulePanel = new Panel();
            btnAddRule = new Button();
            MainPanel.SuspendLayout();
            MainTabControl.SuspendLayout();
            CompoundTab.SuspendLayout();
            GridCompoundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompounds).BeginInit();
            AddCompoundPanel.SuspendLayout();
            RuleTab.SuspendLayout();
            GridRulePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRules).BeginInit();
            AddRulePanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(MainTabControl);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(800, 450);
            MainPanel.TabIndex = 0;
            // 
            // MainTabControl
            // 
            MainTabControl.Controls.Add(excuteTab);
            MainTabControl.Controls.Add(CompoundTab);
            MainTabControl.Controls.Add(RuleTab);
            MainTabControl.Dock = DockStyle.Fill;
            MainTabControl.Location = new Point(0, 0);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.RightToLeft = RightToLeft.No;
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(800, 450);
            MainTabControl.TabIndex = 0;
            // 
            // excuteTab
            // 
            excuteTab.BorderStyle = BorderStyle.FixedSingle;
            excuteTab.Location = new Point(4, 24);
            excuteTab.Name = "excuteTab";
            excuteTab.Padding = new Padding(3);
            excuteTab.Size = new Size(792, 422);
            excuteTab.TabIndex = 0;
            excuteTab.Text = "Main";
            excuteTab.UseVisualStyleBackColor = true;
            // 
            // CompoundTab
            // 
            CompoundTab.Controls.Add(GridCompoundPanel);
            CompoundTab.Controls.Add(AddCompoundPanel);
            CompoundTab.Location = new Point(4, 24);
            CompoundTab.Name = "CompoundTab";
            CompoundTab.Padding = new Padding(3);
            CompoundTab.Size = new Size(792, 422);
            CompoundTab.TabIndex = 1;
            CompoundTab.Text = "Compounds";
            CompoundTab.UseVisualStyleBackColor = true;
            // 
            // GridCompoundPanel
            // 
            GridCompoundPanel.Controls.Add(dgvCompounds);
            GridCompoundPanel.Dock = DockStyle.Fill;
            GridCompoundPanel.Location = new Point(3, 3);
            GridCompoundPanel.Name = "GridCompoundPanel";
            GridCompoundPanel.Size = new Size(786, 361);
            GridCompoundPanel.TabIndex = 1;
            // 
            // dgvCompounds
            // 
            dgvCompounds.AllowUserToAddRows = false;
            dgvCompounds.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompounds.Columns.AddRange(new DataGridViewColumn[] { Compound });
            dgvCompounds.Dock = DockStyle.Fill;
            dgvCompounds.Location = new Point(0, 0);
            dgvCompounds.Name = "dgvCompounds";
            dgvCompounds.RowTemplate.Height = 25;
            dgvCompounds.Size = new Size(786, 361);
            dgvCompounds.TabIndex = 0;
            // 
            // Compound
            // 
            Compound.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Compound.HeaderText = "Compound";
            Compound.Name = "Compound";
            Compound.Resizable = DataGridViewTriState.True;
            // 
            // AddCompoundPanel
            // 
            AddCompoundPanel.Controls.Add(btnAddCompound);
            AddCompoundPanel.Dock = DockStyle.Bottom;
            AddCompoundPanel.Location = new Point(3, 364);
            AddCompoundPanel.Name = "AddCompoundPanel";
            AddCompoundPanel.Size = new Size(786, 55);
            AddCompoundPanel.TabIndex = 0;
            // 
            // btnAddCompound
            // 
            btnAddCompound.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddCompound.Location = new Point(678, 6);
            btnAddCompound.Name = "btnAddCompound";
            btnAddCompound.Size = new Size(105, 34);
            btnAddCompound.TabIndex = 0;
            btnAddCompound.Text = "Add";
            btnAddCompound.UseVisualStyleBackColor = true;
            btnAddCompound.Click += btnAddCompound_Click;
            // 
            // RuleTab
            // 
            RuleTab.Controls.Add(GridRulePanel);
            RuleTab.Controls.Add(AddRulePanel);
            RuleTab.Location = new Point(4, 24);
            RuleTab.Name = "RuleTab";
            RuleTab.Padding = new Padding(3);
            RuleTab.Size = new Size(792, 422);
            RuleTab.TabIndex = 2;
            RuleTab.Text = "Rules";
            RuleTab.UseVisualStyleBackColor = true;
            // 
            // GridRulePanel
            // 
            GridRulePanel.Controls.Add(dgvRules);
            GridRulePanel.Dock = DockStyle.Fill;
            GridRulePanel.Location = new Point(3, 3);
            GridRulePanel.Name = "GridRulePanel";
            GridRulePanel.Size = new Size(786, 361);
            GridRulePanel.TabIndex = 3;
            // 
            // dgvRules
            // 
            dgvRules.AllowUserToAddRows = false;
            dgvRules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRules.Columns.AddRange(new DataGridViewColumn[] { Rule });
            dgvRules.Dock = DockStyle.Fill;
            dgvRules.Location = new Point(0, 0);
            dgvRules.Name = "dgvRules";
            dgvRules.ReadOnly = true;
            dgvRules.RowTemplate.Height = 25;
            dgvRules.Size = new Size(786, 361);
            dgvRules.TabIndex = 0;
            // 
            // Rule
            // 
            Rule.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Rule.HeaderText = "Rule";
            Rule.Name = "Rule";
            Rule.ReadOnly = true;
            // 
            // AddRulePanel
            // 
            AddRulePanel.Controls.Add(btnAddRule);
            AddRulePanel.Dock = DockStyle.Bottom;
            AddRulePanel.Location = new Point(3, 364);
            AddRulePanel.Name = "AddRulePanel";
            AddRulePanel.Size = new Size(786, 55);
            AddRulePanel.TabIndex = 2;
            // 
            // btnAddRule
            // 
            btnAddRule.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddRule.Location = new Point(678, 6);
            btnAddRule.Name = "btnAddRule";
            btnAddRule.Size = new Size(105, 34);
            btnAddRule.TabIndex = 0;
            btnAddRule.Text = "Add";
            btnAddRule.UseVisualStyleBackColor = true;
            btnAddRule.Click += btnAddRule_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainPanel);
            MinimumSize = new Size(816, 489);
            Name = "MainForm";
            Text = "Main";
            MainPanel.ResumeLayout(false);
            MainTabControl.ResumeLayout(false);
            CompoundTab.ResumeLayout(false);
            GridCompoundPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCompounds).EndInit();
            AddCompoundPanel.ResumeLayout(false);
            RuleTab.ResumeLayout(false);
            GridRulePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRules).EndInit();
            AddRulePanel.ResumeLayout(false);
            ResumeLayout(false);
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
        private DataGridViewTextBoxColumn Compound;
        private DataGridViewTextBoxColumn Rule;
        private Button btnAddCompound;
        private Button btnAddRule;
    }
}