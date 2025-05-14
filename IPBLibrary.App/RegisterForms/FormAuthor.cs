using IPBLibrary.App.Base;
using IPBLibrary.Domain.Entities;
using IPBLibrary.Repository;

namespace IPBLibrary.App.RegisterForms
{
    public partial class FormAuthor : FormBase
    {
        private readonly Repository<Author> _authorRepository;

        public FormAuthor()
        {
            InitializeComponent();
            _authorRepository = new Repository<Author>("data/authors.json");
        }

        protected override void Save()
        {
            var author = new Author
            {
                Id = int.TryParse(txtId.Text, out var id) ? id : 0,
                Name = txtName.Text,
                Email = txtEmail.Text,
                PhoneNumber = txtPhone.Text,
                DateOfBirth = dtmDateOfBird.Value,
                Title = txtTitle.Text,
                Biography = txtBiography.Text,
            };

            // Verifica se o autor já existe no repositório
            var existingAuthor = _authorRepository.GetById(a => a.Id == author.Id);

            if (existingAuthor != null)
            {
                // Atualiza o registro existente
                _authorRepository.Update(a => a.Id == author.Id, author);
                MessageBox.Show(@"Author updated successfully!", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Adiciona um novo registro
                _authorRepository.Add(author);
                MessageBox.Show(@"Author saved successfully!", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            tabControlRegister.SelectedTab = tabPageList;
        }


        protected override void LoadList()
        {
            var authors = _authorRepository.GetAll();
            dataGridViewRegister.DataSource = authors;
            dataGridViewRegister.Columns["Id"]!.Visible = false; // Hide the Id column
            dataGridViewRegister.Columns["Biography"]!.Visible = false; // Hide the Biography column
            dataGridViewRegister.Columns["Description"]!.Visible = false;
        }

        protected override void FillFormFields(DataGridViewRow row)
        {
            if (row.DataBoundItem is Author author)
            {
                txtId.Text = author.Id.ToString();
                txtName.Text = author.Name;
                txtEmail.Text = author.Email;
                txtPhone.Text = author.PhoneNumber;
                dtmDateOfBird.Value = author.DateOfBirth;
                txtTitle.Text = author.Title;
                txtBiography.Text = author.Biography;
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
                _authorRepository.Delete(a => a.Id == id);
                MessageBox.Show(@"Author deleted successfully!", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }

}
