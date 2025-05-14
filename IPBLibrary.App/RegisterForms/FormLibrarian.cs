using IPBLibrary.App.Base;
using IPBLibrary.Domain.Entities;
using IPBLibrary.Repository;

namespace IPBLibrary.App.RegisterForms
{
    public partial class FormLibrarian : FormBase
    {
        private readonly Repository<Librarian> _librarianRepository;

        public FormLibrarian()
        {
            InitializeComponent();
            _librarianRepository = new Repository<Librarian>("data/librarians.json");
        }

        protected override void Save()
        {
            var librarian = new Librarian
            {
                Id = int.TryParse(txtId.Text, out var id) ? id : 0,
                Name = txtName.Text,
                Email = txtEmail.Text,
                PhoneNumber = txtPhone.Text,
                DateOfBirth = dtmDateOfBird.Value,
                Role = cmbRole.Text,
                Password = txtPassword.Text,
                EmployeeNumber = txtEmployeeNumber.Text
            };

            // Verifica se o librarian já existe no repositório
            var existingLibrarian= _librarianRepository.GetById(a => a.Id == librarian.Id);

            if (existingLibrarian != null)
            {
                // Atualiza o registro existente
                _librarianRepository.Update(a => a.Id == librarian.Id, librarian);
                MessageBox.Show(@"Librarian updated successfully!", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Adiciona um novo registro
                _librarianRepository.Add(librarian);
                MessageBox.Show(@"Librarian saved successfully!", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            tabControlRegister.SelectedTab = tabPageList;
        }


        protected override void LoadList()
        {
            var librarians = _librarianRepository.GetAll();
            dataGridViewRegister.DataSource = librarians;
            dataGridViewRegister.Columns["Id"]!.Visible = false; // Hide the Id column
        }

        protected override void FillFormFields(DataGridViewRow row)
        {
            if (row.DataBoundItem is Librarian librarian)
            {
                txtId.Text = librarian.Id.ToString();
                txtName.Text = librarian.Name;
                txtEmail.Text = librarian.Email;
                txtPhone.Text = librarian.PhoneNumber;
                dtmDateOfBird.Value = librarian.DateOfBirth;
                cmbRole.Text = librarian.Role;
                txtPassword.Text = librarian.Password;
                txtEmployeeNumber.Text = librarian.EmployeeNumber;
            }
            else
            {
                MessageBox.Show(@"Please select a valid author.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Delete(DataGridViewRow row)
        {
            if (int.TryParse(row.Cells["Id"].Value?.ToString(), out int id))
            {
                _librarianRepository.Delete(a => a.Id == id);
                MessageBox.Show(@"Librarian deleted successfully!", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }

}
