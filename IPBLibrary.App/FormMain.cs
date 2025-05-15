using IPBLibrary.App.OperationForms;
using IPBLibrary.App.RegisterForms;
using IPBLibrary.Domain.Entities;
using ReaLTaiizor.Forms;

namespace IPBLibrary.App
{
    public partial class FormMain : MaterialForm
    {
        public Librarian? Librarian;

        public FormMain(Librarian? librarian = null)
        {
            Librarian = librarian;
            InitializeComponent();
            lblUserName.Text = $@"User Name: {Librarian?.Name}";
            lblUserRole.Text = $@"Role: {Librarian?.Role}";
        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var form = new FormAuthor();
            form.ShowDialog();
        }
            
        private void bookCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var form = new FormCategory();
            form.ShowDialog();
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var form = new FormBook();
            form.ShowDialog();
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var form = new FormMember();
            form.ShowDialog();
        }

        private void librarianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var form = new FormLibrarian();
            form.ShowDialog();
        }

        private void publisherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormPublisher();
            form.ShowDialog();
        }

        private void bookLoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormLoan(Librarian);
            form.ShowDialog();
        }

        private void bookReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormReservation();
            form.ShowDialog();
        }

        private void fineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormFine();
            form.ShowDialog();
        }
    }
}
