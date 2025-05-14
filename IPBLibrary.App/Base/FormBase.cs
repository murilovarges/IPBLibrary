using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;

namespace IPBLibrary.App.Base
{
    public partial class FormBase : MaterialForm
    {
        protected DataGridViewRow selectedRow;
        public FormBase()
        {
            InitializeComponent();
            txtId.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                Save();
            }
        }

        protected virtual bool ValidateFields()
        {
            return true;
        }

        protected virtual void Save()
        {

        }

        private void tabPageList_Enter(object sender, EventArgs e)
        {
            LoadList();
        }
        protected virtual void LoadList()
        {
            // Implement loading logic here
        }

        private void dataGridViewRegister_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Edit();
        }

        protected virtual void Edit()
        {
            if (dataGridViewRegister.CurrentRow != null)
            {
                selectedRow = dataGridViewRegister.CurrentRow;
                FillFormFields(selectedRow);
                tabControlRegister.SelectedTab = tabPageRegister;
            }
            else
            {
                MessageBox.Show(@"Please select a row to edit.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void FillFormFields(DataGridViewRow row)
        {
            // Implement filling logic here
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewRegister.CurrentRow != null)
            {
                var result = MessageBox.Show(@"Are you sure you want to delete this item?", @"Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    selectedRow = dataGridViewRegister.CurrentRow;
                    Delete(selectedRow);
                    LoadList();
                }
            }
            else
            {
                MessageBox.Show(@"Please select a row to delete.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void Delete(DataGridViewRow row)
        {
            // Implement delete logic here
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            tabControlRegister.SelectedTab = tabPageRegister;
            ClearFields();
        }

        private void ClearFields()
        {
            foreach (Control control in tabPageRegister.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
                else if (control is MaterialTextBoxEdit materialTextBox)
                {
                    materialTextBox.Clear();
                }
                else if (control is MaterialMultiLineTextBoxEdit materialMultiLineTextBoxEdit)
                {
                    materialMultiLineTextBoxEdit.Clear();
                }
                else if (control is DateTimePicker dateTimePicker)
                {
                    dateTimePicker.Value = DateTime.Now;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
            tabControlRegister.SelectedTab = tabPageList;
        }
    }
}
