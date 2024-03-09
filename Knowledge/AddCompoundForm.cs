using Knowledge.Core.Chemical;
using Knowledge.Entities.Chemicals;
using System.Data;

namespace Knowledge
{
    public partial class AddCompoundForm : Form
    {
        public AddCompoundForm()
        {
            InitializeComponent();
        }

        private void AddCompoundForm_Load(object sender, EventArgs e)
        {
            // Load grid Atom combobox
            var atomColumn = (DataGridViewComboBoxColumn)this.dgvCompoundDetails.Columns["Atom"];
            var atomList = Enum.GetValues(typeof(Core.Chemical.Atom)).Cast<Atom>().Select(x => new KeyValuePair<Atom, string>(x, $"{x}({(int)x})")).ToList();
            atomColumn.DataSource = atomList;
            atomColumn.ValueMember = "Key";
            atomColumn.DisplayMember = "Value";

            this.dgvCompoundDetails.Focus();
        }

        private void dgvCompoundDetails_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var column = dgvCompoundDetails.Columns[e.ColumnIndex];
            dgvCompoundDetails.Rows[e.RowIndex].ErrorText = "";
            if (column.Name == "Weight")
            {
                string value = string.IsNullOrEmpty(e.FormattedValue?.ToString()) ? "1" : e.FormattedValue?.ToString();
                int number;
                // Check if the entered value is a valid decimal number
                if (!int.TryParse(value, out number) || number <= 0)
                {
                    // Cancel the event to prevent the user from leaving the cell
                    dgvCompoundDetails.Rows[e.RowIndex].ErrorText = "Please enter a number > 0.";
                    e.Cancel = true;
                }
                else
                {
                    dgvCompoundDetails.Rows[e.RowIndex].ErrorText = "";
                }
            }
        }

        private void dgvCompoundDetails_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var formularDetails = BuildFormularDetails();
            this.txtCompoundInfo.Text = Helpers.BuildCompoundName(formularDetails);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var details = BuildFormularDetails();
            if (details.Count > 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Can't not create new Compound");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public List<Chemical_FormulaDetail> BuildFormularDetails()
        {
            var result = new List<Chemical_FormulaDetail>();
            foreach (DataGridViewRow row in dgvCompoundDetails.Rows)
            {
                var elementCol = (DataGridViewComboBoxCell)row.Cells[0];
                var weightCol = (DataGridViewTextBoxCell)row.Cells[1];
                if (!string.IsNullOrEmpty(elementCol.Value?.ToString()))
                {
                    var ele = (Atom)elementCol.Value;
                    var weight = int.Parse(!string.IsNullOrEmpty(weightCol.Value?.ToString()) ? weightCol.Value?.ToString() : "1");
                    result.Add(new Chemical_FormulaDetail()
                    {
                        Atom = ele,
                        AtomWeight = weight,
                        CompoundId = 0
                    });
                }
            }
            return result;
        }
    }
}
