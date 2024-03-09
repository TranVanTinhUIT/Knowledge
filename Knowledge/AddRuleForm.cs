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
    public partial class AddRuleForm : Form
    {
        private readonly IChemicalRepositoryFactory _factory;
        public AddRuleForm(IChemicalRepositoryFactory factory)
        {
            this._factory = factory;
            InitializeComponent();
        }

        private IList<Chemical_Compound> _compounds;
        private void AddRuleForm_Load(object sender, EventArgs e)
        {
            // Load grid Compound combobox
            var compoundColumn = (DataGridViewComboBoxColumn)this.dgvRuleDetails.Columns["Compound"];
            var repository = _factory.CreateChemicalRepository("fileJson");
            var compoundTask = repository.GetAvailableCompounds();
            this._compounds = compoundTask.Result;
            compoundColumn.DataSource = this._compounds;
            compoundColumn.ValueMember = nameof(Chemical_Compound.Id);
            compoundColumn.DisplayMember = nameof(Chemical_Compound.Name);

            // Load for type column
            var typeColumn = (DataGridViewComboBoxColumn)this.dgvRuleDetails.Columns["Type"];
            var typeList = Enum.GetValues(typeof(RuleType)).Cast<RuleType>().Select(x => new KeyValuePair<RuleType, string>(x, x.ToString())).ToList();
            typeColumn.DataSource = typeList;
            typeColumn.ValueMember = "Key";
            typeColumn.DisplayMember = "Value";

            this.dgvRuleDetails.Focus();
        }

        private void dgvRuleDetails_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var column = dgvRuleDetails.Columns[e.ColumnIndex];
            dgvRuleDetails.Rows[e.RowIndex].ErrorText = "";
            if (column.Name == "MoleWeight")
            {
                string value = string.IsNullOrEmpty(e.FormattedValue?.ToString()) ? "1" : e.FormattedValue?.ToString();
                int number;
                // Check if the entered value is a valid decimal number
                if (!int.TryParse(value, out number) || number <= 0)
                {
                    // Cancel the event to prevent the user from leaving the cell
                    dgvRuleDetails.Rows[e.RowIndex].ErrorText = "Please enter a number > 0.";
                    e.Cancel = true;
                }
                else
                {
                    dgvRuleDetails.Rows[e.RowIndex].ErrorText = "";
                }
            }
        }

        private void dgvRuleDetails_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var items = BuildRuleItems();
            this.txtRuleInfo.Text = Helpers.BuildRuleName(items, this._compounds);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var items = BuildRuleItems();
            if (items.Count > 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Can't not create new Rule");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public List<Chemical_RuleItem> BuildRuleItems()
        {
            var result = new List<Chemical_RuleItem>();
            foreach (DataGridViewRow row in dgvRuleDetails.Rows)
            {
                var compoundCol = (DataGridViewComboBoxCell)row.Cells[0];
                var typeCol = (DataGridViewComboBoxCell)row.Cells[1];
                var weightCol = (DataGridViewTextBoxCell)row.Cells[2];
                if (!string.IsNullOrEmpty(compoundCol.Value?.ToString()) && !string.IsNullOrEmpty(typeCol.Value?.ToString()))
                {
                    var compoundId = long.Parse(compoundCol.Value.ToString()!);
                    var type = (RuleType)typeCol.Value;
                    var weight = int.Parse(!string.IsNullOrEmpty(weightCol.Value?.ToString()) ? weightCol.Value?.ToString() : "1");
                    result.Add(new Chemical_RuleItem()
                    {
                        CompoundId = compoundId,
                        RuleType = type,
                        MoleWeight = weight,
                    });
                }
            }
            return result;
        }
    }
}
