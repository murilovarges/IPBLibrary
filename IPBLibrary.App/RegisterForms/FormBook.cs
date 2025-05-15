
using IPBLibrary.App.Base;
using IPBLibrary.Domain.Entities;
using IPBLibrary.Repository;

namespace IPBLibrary.App.RegisterForms
{
    public partial class FormBook : FormBase
    {
        private readonly Repository<Category> _categoryRepository;
        private readonly Repository<Author> _authorRepository;
        private readonly Repository<Publisher> _publisherRepository;
        private readonly Repository<Book> _bookRepository;

        public FormBook()
        {
            InitializeComponent();
            _categoryRepository = new Repository<Category>("data/categories.json");
            _authorRepository = new Repository<Author>("data/authors.json");
            _publisherRepository = new Repository<Publisher>("data/publishers.json");
            _bookRepository = new Repository<Book>("data/books.json");
            PopulateComboBoxes();
        }

        private void PopulateComboBoxes()
        {
            // Popula o ComboBox de autores
            var authors = _authorRepository.GetAll();
            cboAuthor.DataSource = authors;
            cboAuthor.DisplayMember = "Name";
            cboAuthor.ValueMember = "Id";
            // Popula o ComboBox de editoras
            var publishers = _publisherRepository.GetAll();
            cboPublisher.DataSource = publishers;
            cboPublisher.DisplayMember = "Name";
            cboPublisher.ValueMember = "Id";
            // Popula o ComboBox de categorias
            var categories = _categoryRepository.GetAll();
            cboCategory.DataSource = categories;
            cboCategory.DisplayMember = "Name";
            cboCategory.ValueMember = "Id";
        }

        protected override void Save()
        {
            var book = new Book
            {
                Id = int.TryParse(txtId.Text, out var id) ? id : 0,
                Title = txtTitle.Text,
                Author = _authorRepository.GetById(a => a.Id == int.Parse(cboAuthor.SelectedValue.ToString())),
                ISBN = txtISBN.Text,
                PublishedDate = dtmPublishedDate.Value,
                Genre = txtGenre.Text,
                Publisher = _publisherRepository.GetById(p => p.Id == int.Parse(cboPublisher.SelectedValue.ToString())),
                Category = _categoryRepository.GetById(c => c.Id == int.Parse(cboCategory.SelectedValue.ToString()))
            };
            // Verifica se o livro já existe no repositório
            var existingBook = _bookRepository.GetById(b => b.Id == book.Id);
            if (existingBook != null)
            {
                // Atualiza o registro existente
                _bookRepository.Update(b => b.Id == book.Id, book);
                MessageBox.Show(@"Book updated successfully!", @"Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                // Adiciona um novo registro
                _bookRepository.Add(book);
                MessageBox.Show(@"Book saved successfully!", @"Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            tabControlRegister.SelectedTab = tabPageList;
        }

        protected override void LoadList()
        {
            var books = _bookRepository.GetAll();
            var bookView = books.Select(loan => new
            {
                Id = loan.Id,
                Title = loan.Title,
                ISBN = loan.ISBN,
                PublishedDate = loan.PublishedDate.ToString("dd/MM/yyyy"),
                Genre = loan.Genre,
                IdAuthor = loan.Author.Id,
                AuthorName = loan.Author.Name,
                IdPublisher = loan.Publisher?.Id,
                PublisherName = loan.Publisher?.Name,
                IdCategory = loan.Category.Id,
                CategoryName = loan.Category.Name


            }).ToList();
            dataGridViewRegister.DataSource = bookView;
            dataGridViewRegister.Columns["Id"]!.Visible = false; // Hide the Id column
            dataGridViewRegister.Columns["IdAuthor"]!.Visible = false; // Hide the Author column
            dataGridViewRegister.Columns["IdPublisher"]!.Visible = false; // Hide the Publisher column
            dataGridViewRegister.Columns["IdCategory"]!.Visible = false; // Hide the Category column
        }

        protected override void FillFormFields(DataGridViewRow row)
        {

            txtId.Text = row.Cells["Id"].Value.ToString();
            txtTitle.Text = row.Cells["Title"].Value.ToString();
            txtISBN.Text = row.Cells["ISBN"].Value.ToString();
            dtmPublishedDate.Value = DateTime.Parse(row.Cells["PublishedDate"].Value.ToString());
            txtGenre.Text = row.Cells["Genre"].Value.ToString();
            cboAuthor.SelectedValue = row.Cells["IdAuthor"].Value?.ToString();
            cboPublisher.SelectedValue = row.Cells["IdPublisher"].Value?.ToString();
            cboCategory.SelectedValue = row.Cells["IdCategory"].Value?.ToString();
        }

        protected override void Delete(DataGridViewRow row)
        {
            if (int.TryParse(row.Cells["Id"].Value?.ToString(), out int id))
            {
                _bookRepository.Delete(a => a.Id == id);
                MessageBox.Show(@"Book deleted successfully!", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
