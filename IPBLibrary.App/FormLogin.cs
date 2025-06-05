using IPBLibrary.Domain.Entities;
using IPBLibrary.Repository;
using ReaLTaiizor.Forms;

namespace IPBLibrary.App
{
    public partial class FormLogin : MaterialForm
    {
        private readonly Repository<Librarian> _librarianRepository;
        public FormLogin()
        {
            InitializeComponent();
            _librarianRepository = new Repository<Librarian>("data/librarians.json");
#if DEBUG
            txtEmail.Text = @"admin@ipb.pt";
            txtPassword.Text = @"admin";
#endif
            // Verifica se o repositório de bibliotecários está vazio e cria um administrador padrão
            VerifyIfExistLibrarian();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // Captura os dados de entrada
            var email = txtEmail.Text;
            var password = txtPassword.Text;

            // Valida se os campos estão preenchidos
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(@"Please enter both username and password.", @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // Busca o bibliotecário pelo nome de usuário (ou email)
            var librarian = _librarianRepository.GetById(l => l.Email == email);

            if (librarian == null)
            {
                MessageBox.Show(@"Invalid username or password.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica a senha
            if (librarian.Password != password)
            {
                MessageBox.Show(@"Invalid username or password.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Abre o formulário principal (ou outra ação)
            var mainForm = new FormMain(librarian);
            mainForm.Show();
            this.Hide();
        }

        private void VerifyIfExistLibrarian()
        {
            var exist = _librarianRepository.GetAll().Count > 0;
            if (!exist)
            {
                var adm = new Librarian
                {
                    Id = 1,
                    Name = "System Administrator",
                    EmployeeNumber = "9999",
                    Email = "admin@ipb.pt",
                    Password = "admin",
                    Role = "Librarian",
                    DateOfBirth = DateTime.Today
                };
                _librarianRepository.Add(adm);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
