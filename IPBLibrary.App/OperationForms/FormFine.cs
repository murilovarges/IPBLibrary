using IPBLibrary.App.Base;
using IPBLibrary.Domain.Entities;
using IPBLibrary.Repository;

namespace IPBLibrary.App.OperationForms
{
    public partial class FormFine : FormBase
    {
        private readonly Repository<Fine> _fineRepository;
        private readonly Repository<Member> _memberRepository;

        public FormFine()
        {
            InitializeComponent();
            _fineRepository = new Repository<Fine>("data/fines.json");
            _memberRepository = new Repository<Member>("data/members.json");
            PopulateComboBoxes();
        }

        private void PopulateComboBoxes()
        {
            // Popula o ComboBox de members
            cboMember.DataSource = _memberRepository.GetAll();
            cboMember.DisplayMember = "Name";
            cboMember.ValueMember = "Id";
        }

        protected override void Save()
        {
            var fine = new Fine
            {
                Id = int.TryParse(txtId.Text, out var id) ? id : 0,
                Member = _memberRepository.GetById(m => m.Id == int.Parse(cboMember.SelectedValue.ToString())),
                IssuedDate = dtmIssuedDate.Value,
                IsPaid = chbIsPaid.Checked
            };
            // Verifica se o empréstimo já existe no repositório
            var existingFine = _fineRepository.GetById(l => l.Id == fine.Id);
            if (existingFine != null)
            {
                // Atualiza o registro existente
                _fineRepository.Update(l => l.Id == fine.Id, fine);
                MessageBox.Show(@"Fine updated successfully!", @"Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                // Adiciona um novo registro
                _fineRepository.Add(fine);
                MessageBox.Show(@"Fine added successfully!", @"Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            tabControlRegister.SelectedTab = tabPageList;
        }

        protected override void LoadList()
        {
            var fines = _fineRepository.GetAll();
            var fineView = fines.Select(fine => new
            {
                Id = fine.Id,
                IdMember = fine.Member.Id,
                MemberName = fine.Member.Name,
                IssuedDate = fine.IssuedDate,
                IsPaid = fine.IsPaid
            }).ToList();
            dataGridViewRegister.DataSource = fineView;
            dataGridViewRegister.Columns["Id"]!.Visible = false; // Hide the Id column
            dataGridViewRegister.Columns["IdBook"]!.Visible = false; // Hide the Id column
            dataGridViewRegister.Columns["IdMember"]!.Visible = false; // Hide the Id column
        }

        protected override void FillFormFields(DataGridViewRow row)
        {
            txtId.Text = row.Cells["Id"].Value.ToString();
            cboMember.SelectedValue = row.Cells["IdMember"].Value;
            dtmIssuedDate.Value = DateTime.Parse(row.Cells["IssuedDate"].Value.ToString());
            chbIsPaid.Checked = Boolean.Parse(row.Cells["IsPaid"].Value.ToString());
        }

        protected override void Delete(DataGridViewRow row)
        {
            if (row.DataBoundItem is Fine fine)
            {
                _fineRepository.Delete(a => a.Id == fine.Id);
                MessageBox.Show(@"Fine deleted successfully!", @"Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
