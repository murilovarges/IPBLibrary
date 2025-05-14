
using IPBLibrary.App.Base;
using IPBLibrary.Domain.Entities;
using IPBLibrary.Repository;

namespace IPBLibrary.App.OperationForms
{
    public partial class FormLoan : FormBase
    {
        private readonly Repository<Loan> _loanRepository;
        private readonly Repository<Book> _bookRepository;
        private readonly Repository<Member> _memberRepository;
        private readonly Repository<Librarian> _librarianRepository;

        private Librarian? _librarian;

        public FormLoan(Librarian? librarian)
        {
            _librarian = librarian;
            InitializeComponent();
            _loanRepository = new Repository<Loan>("data/loans.json");
            _bookRepository = new Repository<Book>("data/books.json");
            _memberRepository = new Repository<Member>("data/members.json");
            _librarianRepository = new Repository<Librarian>("data/librarians.json");
            PopulateComboBoxes();
        }

        private void PopulateComboBoxes()
        {
            // Popula o ComboBox de livros
            cboBook.DataSource = _bookRepository.GetAll();
            cboBook.DisplayMember = "Title";
            cboBook.ValueMember = "Id";

            // Popula o ComboBox de members
            cboMember.DataSource = _memberRepository.GetAll();
            cboMember.DisplayMember = "Name";
            cboMember.ValueMember = "Id";

            // Popula o ComboBox de librarians
            cboLibrarian.DataSource = _librarianRepository.GetAll();
            cboLibrarian.DisplayMember = "Name";
            cboLibrarian.ValueMember = "Id";
            cboLibrarian.SelectedValue = _librarian.Id; // Set the current librarian
        }

        protected override void Save()
        {
            var loan = new Loan
            {
                Id = int.TryParse(txtId.Text, out var id) ? id : 0,
                Book = _bookRepository.GetById(b => b.Id == int.Parse(cboBook.SelectedValue.ToString())),
                Member = _memberRepository.GetById(m => m.Id == int.Parse(cboMember.SelectedValue.ToString())),
                Librarian = _librarianRepository.GetById(l => l.Id == int.Parse(cboLibrarian.SelectedValue.ToString())),
                LoanDate = dtmLoanDate.Value,
                ReturnDate = dtmReturnDate.Value
            };
            // Verifica se o empréstimo já existe no repositório
            var existingLoan = _loanRepository.GetById(l => l.Id == loan.Id);
            if (existingLoan != null)
            {
                // Atualiza o registro existente
                _loanRepository.Update(l => l.Id == loan.Id, loan);
                MessageBox.Show(@"Loan updated successfully!", @"Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                // Adiciona um novo registro
                _loanRepository.Add(loan);
                MessageBox.Show(@"Loan added successfully!", @"Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            tabControlRegister.SelectedTab = tabPageList;
        }

        protected override void LoadList()
        {
            var loans = _loanRepository.GetAll();
            var loanView = loans.Select(loan => new
            {
                Id = loan.Id,
                IdBook = loan.Book.Id,
                BookTitle = loan.Book.Title,
                IdMember = loan.Member.Id,
                MemberName = loan.Member.Name,
                IdLibrarian = loan.Librarian.Id,
                LibrarianName = loan.Librarian.Name,
                LoanDate = loan.LoanDate,
                ReturnDate = loan.ReturnDate,
                IsReturned = loan.IsReturned
            }).ToList();
            dataGridViewRegister.DataSource = loanView;
            dataGridViewRegister.Columns["Id"]!.Visible = false; // Hide the Id column
            dataGridViewRegister.Columns["IdBook"]!.Visible = false; // Hide the Id column
            dataGridViewRegister.Columns["IdMember"]!.Visible = false; // Hide the Id column
            dataGridViewRegister.Columns["IdLibrarian"]!.Visible = false; // Hide the Id column
        }

        protected override void FillFormFields(DataGridViewRow row)
        {
            txtId.Text = row.Cells["Id"].Value.ToString();
            cboBook.SelectedValue = row.Cells["IdBook"].Value;
            cboMember.SelectedValue = row.Cells["IdMember"].Value;
            cboLibrarian.SelectedValue = row.Cells["IdLibrarian"].Value;
            dtmLoanDate.Value = DateTime.Parse(row.Cells["LoanDate"].Value.ToString());
            dtmReturnDate.Value = DateTime.Parse(row.Cells["ReturnDate"].Value.ToString());
        }

        protected override void Delete(DataGridViewRow row)
        {
            if (int.TryParse(row.Cells["Id"].Value?.ToString(), out int id))
            {
                _loanRepository.Delete(a => a.Id == id);
                MessageBox.Show(@"Loan deleted successfully!", @"Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
