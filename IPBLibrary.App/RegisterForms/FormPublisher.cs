using IPBLibrary.App.Base;
using IPBLibrary.Domain.Entities;
using IPBLibrary.Repository;

namespace IPBLibrary.App.RegisterForms
{
    public partial class FormPublisher : FormBase
    {
        private readonly Repository<Publisher> _publisherRepository;

        public FormPublisher()
        {
            InitializeComponent();
            _publisherRepository = new Repository<Publisher>("publishers.json");
        }

        protected override void Save()
        {
            var publisher = new Publisher
            {
                Id = int.Parse(txtId.Text),
                Name = txtName.Text,
                Address = txtAddress.Text,
                Email = txtEmail.Text,
                ContactNumber = txtContactNumber.Text
            };
            // Verifica se a publisher já existe no repositório
            var existingPublisher = _publisherRepository.GetById(c => c.Id == publisher.Id);
            if (existingPublisher != null)
            {
                // Atualiza o registro existente
                _publisherRepository.Update(c => c.Id == publisher.Id, publisher);
                MessageBox.Show(@"Publisher updated successfully!", @"Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                // Adiciona um novo registro
                _publisherRepository.Add(publisher);
                MessageBox.Show(@"Publisher saved successfully!", @"Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }


            tabControlRegister.SelectedTab = tabPageList;
        }

        protected override void LoadList()
        {
            var publishers = _publisherRepository.GetAll();
            dataGridViewRegister.DataSource = publishers;
            dataGridViewRegister.Columns["Id"]!.Visible = false; // Hide the Id column
        }

        protected override void FillFormFields(DataGridViewRow row)
        {
            txtId.Text = row.Cells["Id"].Value.ToString();
            txtName.Text = row.Cells["Name"].Value.ToString();
            txtAddress.Text = row.Cells["Address"].Value.ToString();
            txtEmail.Text = row.Cells["Email"].Value.ToString();
            txtContactNumber.Text = row.Cells["ContactNumber"].Value.ToString();
        }

        protected override void Delete(DataGridViewRow row)
        {
            if (row.DataBoundItem is Publisher publisher)
            {
                _publisherRepository.Delete(a => a.Id == publisher.Id);
                MessageBox.Show(@"Publisher deleted successfully!", @"Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
