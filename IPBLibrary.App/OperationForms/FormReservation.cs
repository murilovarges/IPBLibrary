using IPBLibrary.App.Base;
using IPBLibrary.Domain.Entities;
using IPBLibrary.Repository;

namespace IPBLibrary.App.OperationForms
{
    public partial class FormReservation : FormBase
    {
        private readonly Repository<Reservation> _reservationRepository;
        private readonly Repository<Book> _bookRepository;
        private readonly Repository<Member> _memberRepository;

        public FormReservation()
        {
            InitializeComponent();
            _reservationRepository = new Repository<Reservation>("data/reservations.json");
            _bookRepository = new Repository<Book>("data/books.json");
            _memberRepository = new Repository<Member>("data/members.json");
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
        }

        protected override void Save()
        {
            var reservation = new Reservation
            {
                Id = int.TryParse(txtId.Text, out var id) ? id : 0,
                Book = _bookRepository.GetById(b => b.Id == int.Parse(cboBook.SelectedValue.ToString())),
                Member = _memberRepository.GetById(m => m.Id == int.Parse(cboMember.SelectedValue.ToString())),
                ReservationDate = dtmReservationDate.Value,
                ExpirationDate = dtmExpirationDate.Value    

            };
            // Verifica se o empréstimo já existe no repositório
            var existingReservation = _reservationRepository.GetById(l => l.Id == reservation.Id);
            if (existingReservation != null)
            {
                // Atualiza o registro existente
                _reservationRepository.Update(l => l.Id == reservation.Id, reservation);
                MessageBox.Show(@"Reservation updated successfully!", @"Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                // Adiciona um novo registro
                _reservationRepository.Add(reservation);
                MessageBox.Show(@"Reservation added successfully!", @"Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            tabControlRegister.SelectedTab = tabPageList;
        }

        protected override void LoadList()
        {
            var reservations = _reservationRepository.GetAll();
            var reservationView = reservations.Select(reservation => new
            {
                Id = reservation.Id,
                IdBook = reservation.Book.Id,
                BookTitle = reservation.Book.Title,
                IdMember = reservation.Member.Id,
                MemberName = reservation.Member.Name,
                ReservationDate = reservation.ReservationDate,
                ExpirationDate = reservation.ExpirationDate
            }).ToList();
            dataGridViewRegister.DataSource = reservationView;
            dataGridViewRegister.Columns["Id"]!.Visible = false; // Hide the Id column
            dataGridViewRegister.Columns["IdBook"]!.Visible = false; // Hide the Id column
            dataGridViewRegister.Columns["IdMember"]!.Visible = false; // Hide the Id column
        }

        protected override void FillFormFields(DataGridViewRow row)
        {
            txtId.Text = row.Cells["Id"].Value.ToString();
            cboBook.SelectedValue = row.Cells["IdBook"].Value;
            cboMember.SelectedValue = row.Cells["IdMember"].Value;
            dtmReservationDate.Value = DateTime.Parse(row.Cells["ReservationDate"].Value.ToString());
            dtmExpirationDate.Value = DateTime.Parse(row.Cells["ExpirationDate"].Value.ToString());
        }

        protected override void Delete(DataGridViewRow row)
        {
            if (int.TryParse(row.Cells["Id"].Value?.ToString(), out int id))
            {
                _reservationRepository.Delete(a => a.Id == id);
                MessageBox.Show(@"Reservation deleted successfully!", @"Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
