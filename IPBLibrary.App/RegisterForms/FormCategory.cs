using IPBLibrary.App.Base;
using IPBLibrary.Domain.Entities;
using IPBLibrary.Repository;

namespace IPBLibrary.App.RegisterForms
{
    public partial class FormCategory : FormBase
    {
        private readonly Repository<Category> _categoryRepository;

        public FormCategory()
        {
            InitializeComponent();
            _categoryRepository = new Repository<Category>("data/categories.json");
        }

        protected override void Save()
        {
            var category = new Category
            {
                Id = int.TryParse(txtId.Text, out var id) ? id : 0,
                Name = txtName.Text,
                Description = txtDescription.Text,
            };
            // Verifica se a categoria já existe no repositório
            var existingCategory = _categoryRepository.GetById(c => c.Id == category.Id);
            if (existingCategory != null)
            {
                // Atualiza o registro existente
                _categoryRepository.Update(c => c.Id == category.Id, category);
                MessageBox.Show(@"Category updated successfully!", @"Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                // Adiciona um novo registro
                _categoryRepository.Add(category);
                MessageBox.Show(@"Category saved successfully!", @"Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            tabControlRegister.SelectedTab = tabPageList;
        }

        protected override void LoadList()
        {
            var categories = _categoryRepository.GetAll();
            dataGridViewRegister.DataSource = categories;
            dataGridViewRegister.Columns["Id"]!.Visible = false; // Hide the Id column
            dataGridViewRegister.Columns["Description"]!.Visible = false;
        }

        protected override void FillFormFields(DataGridViewRow row)
        {
            txtId.Text = row.Cells["Id"].Value.ToString();
            txtName.Text = row.Cells["Name"].Value.ToString();
            txtDescription.Text = row.Cells["Description"].Value.ToString();
        }

        protected override void Delete(DataGridViewRow row)
        {
            if (row.DataBoundItem is Category category)
            {
                _categoryRepository.Delete(a => a.Id == category.Id);
                MessageBox.Show(@"Category deleted successfully!", @"Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
