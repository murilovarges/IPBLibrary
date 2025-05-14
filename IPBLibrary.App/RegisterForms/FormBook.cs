
using IPBLibrary.App.Base;
using IPBLibrary.Domain.Entities;
using IPBLibrary.Repository;

namespace IPBLibrary.App.RegisterForms
{
    public partial class FormBook : FormBase
    {
        private readonly Repository<Category> _categoryRepository;
        private readonly Repository<Author> _authorRepository;
        private readonly Repository<Book> _bookRepository;

        public FormBook()
        {
            InitializeComponent();
            _categoryRepository = new Repository<Category>("data/categories.json");
            _authorRepository = new Repository<Author>("data/authors.json");
            _bookRepository = new Repository<Book>("data/books.json");
            PopulateComboBoxes();
        }

        private void PopulateComboBoxes()
        {
            // Popula o ComboBox de autores
            var authors = _authorRepository.GetAll();
            cmbAuthor.DataSource = authors;
            cmbAuthor.DisplayMember = "Name";
            cmbAuthor.ValueMember = "Id";
            // Popula o ComboBox de categorias
            var categories = _categoryRepository.GetAll();
            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
        }

        protected override void Save()
        {
            var book = new Book
            {
                Id = int.TryParse(txtId.Text, out var id) ? id : 0,
                Title = txtTitle.Text,
                Author = _authorRepository.GetById(a => a.Id == int.Parse(cmbAuthor.SelectedValue.ToString())),
                ISBN = txtISBN.Text,
                PublishedDate = dtmPublishedDate.Value,
                Genre = txtGenre.Text,
                Category = _categoryRepository.GetById(c => c.Id == int.Parse(cmbCategory.SelectedValue.ToString()))
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
            dataGridViewRegister.DataSource = books;
            dataGridViewRegister.Columns["Id"]!.Visible = false; // Hide the Id column
            dataGridViewRegister.Columns["Author"]!.Visible = false; // Hide the Author column
            dataGridViewRegister.Columns["Category"]!.Visible = false; // Hide the Category column
        }

        protected override void FillFormFields(DataGridViewRow row)
        {
            if (row.DataBoundItem is Book book)
            {
                txtId.Text = book.Id.ToString();
                txtTitle.Text = book.Title;
                txtISBN.Text = book.ISBN;
                dtmPublishedDate.Value = book.PublishedDate;
                txtGenre.Text = book.Genre;
                cmbAuthor.SelectedValue = book.Author.Id;
                cmbCategory.SelectedValue = book.Category.Id;
            }
        }

        protected override void Delete(DataGridViewRow row)
        {
            if (row.DataBoundItem is Book book)
            {
                _bookRepository.Delete(a => a.Id == book.Id);
                MessageBox.Show(@"Book deleted successfully!", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
