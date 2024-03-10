using Accessibility;
using Knowledge.Business.Chemical;
using Knowledge.Core.Chemical;
using Knowledge.Entities.Chemicals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knowledge
{
    public partial class MainForm : Form
    {
        private readonly IChemicalRepositoryFactory _factory;

        private IList<Chemical_Compound> _compounds = new List<Chemical_Compound>();

        private IList<Chemical_Rule> _rules = new List<Chemical_Rule>();

        public MainForm(IChemicalRepositoryFactory chemicalRepositoryFactory)
        {
            this._factory = chemicalRepositoryFactory;
            InitializeComponent();
            LoadData();
        }

        private void btnAddCompound_Click(object sender, EventArgs e)
        {
            var addCompoundForm = new AddCompoundForm();
            var dialogResult = addCompoundForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                var repository = _factory.CreateChemicalRepository("jsonFile");
                var formularDetails = addCompoundForm.BuildFormularDetails();

                var taks = repository.CreateNewCompound(formularDetails.ToDictionary(x => x.Atom, x => x.AtomWeight));
                var newId = taks.Result;

                var newCompoundTask = repository.GetAvailableCompounds();
                this._compounds.Clear();
                foreach (var compound in newCompoundTask.Result)
                {
                    this._compounds.Add(compound);
                }
                this.dgvCompounds.DataSource = null;
                this.dgvCompounds.DataSource = this._compounds;
            }
        }

        private void btnAddRule_Click(object sender, EventArgs e)
        {
            var addRuleForm = new AddRuleForm(this._factory);
            var dialogResult = addRuleForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                var repository = _factory.CreateChemicalRepository("jsonFile");
                var items = addRuleForm.BuildRuleItems();

                var taks = repository.CreateNewRule(items);
                var newId = taks.Result;

                var newCompoundTask = repository.GetAvailableRules();
                this._rules = newCompoundTask.Result;
                this.dgvRules.DataSource = null;
                this.dgvRules.DataSource = this._rules;
            }
        }

        private void LoadData()
        {
            // Load compounds, rules
            var repository = _factory.CreateChemicalRepository("jsonFile");
            var compoundTask = repository.GetAvailableCompounds();
            this._compounds = compoundTask.Result;
            this.dgvCompounds.DataSource = this._compounds;

            var ruleTask = repository.GetAvailableRules();
            this._rules = ruleTask.Result;
            this.dgvRules.DataSource = this._rules;
        }

        private void btnExcute_Click(object sender, EventArgs e)
        {
            var ruleBasedSystem = new RuleBasedSystem(this._factory);
            var initCompoundIds = GetInitCompoundIds();
            var targetCompoundIds = GetTargetCompoundIds();

            var resultRulesTask = ruleBasedSystem.ForwardChaining(initCompoundIds, targetCompoundIds);

            var rules = resultRulesTask.Result;

            var initCompoundNames = initCompoundIds.Select(initCompoundId => this._compounds.First(compound => compound.Id == initCompoundId).Name);
            var targetCompoundNames = targetCompoundIds.Select(targetCompoundId => this._compounds.First(compound => compound.Id == targetCompoundId).Name);

            if (rules == null)
            {
                this.txtResponse.Text = $"Không thể tìm thấy chuỗi phản ứng điều chế {string.Join(", ", targetCompoundNames)} từ {string.Join(", ", initCompoundNames)}";
            }
            else
            {
                var str = $"Chuỗi phản ứng điều chế {string.Join(", ", targetCompoundNames)} từ {string.Join(", ", initCompoundNames)} là:";
                for (int i = 0; i < rules.Count; i++)
                {
                    str += $"\r\n  {(i + 1)}. {rules[i].Name}";
                }

                this.txtResponse.Text = str;
            }
        }

        private IList<long> GetInitCompoundIds()
        {
            var result = new List<long>();
            foreach (DataGridViewRow row in this.dgvInits.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.OwningColumn.Name == "InitCompound" && !string.IsNullOrEmpty(cell.Value?.ToString()))
                    {
                        result.Add(long.Parse(cell.Value.ToString()!));
                    }
                }
            }
            return result;
        }

        private IList<long> GetTargetCompoundIds()
        {
            var result = new List<long>();
            foreach (DataGridViewRow row in this.dgvTargets.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.OwningColumn.Name == "TargetCompound" && !string.IsNullOrEmpty(cell.Value?.ToString()))
                    {
                        result.Add(long.Parse(cell.Value.ToString()!));
                    }
                }
            }
            return result;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Load grid Compound combobox
            var compoundInitColumn = (DataGridViewComboBoxColumn)this.dgvInits.Columns["InitCompound"];
            compoundInitColumn.DataSource = this._compounds;
            compoundInitColumn.ValueMember = nameof(Chemical_Compound.Id);
            compoundInitColumn.DisplayMember = nameof(Chemical_Compound.Name);

            var compoundTargetColumn = (DataGridViewComboBoxColumn)this.dgvTargets.Columns["TargetCompound"];
            compoundTargetColumn.DataSource = this._compounds;
            compoundTargetColumn.ValueMember = nameof(Chemical_Compound.Id);
            compoundTargetColumn.DisplayMember = nameof(Chemical_Compound.Name);

            //
            this.dgvCompounds.AutoGenerateColumns = false;
            this.dgvRules.AutoGenerateColumns = false;
        }
    }
}
