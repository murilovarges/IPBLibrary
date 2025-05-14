using IPBLibrary.App.Base;
using IPBLibrary.Domain.Entities;
using IPBLibrary.Repository;

namespace IPBLibrary.App.RegisterForms
{
    public partial class FormMember: FormBase
    {
        private readonly Repository<Member> _memberRepository;

        public FormMember()
        {
            InitializeComponent();
            _memberRepository = new Repository<Member>("data/members.json");
        }

        protected override void Save()
        {
            var member = new Member
            {
                Id = int.TryParse(txtId.Text, out var id) ? id : 0,
                Name = txtName.Text,
                Email = txtEmail.Text,
                PhoneNumber = txtPhone.Text,
                DateOfBirth = dtmDateOfBird.Value,
                MembershipStartDate = dtmStartDate.Value,
                MembershipEndDate = dtmEndDate.Value,
                Role = cmbRole.Text
            };

            // Verifica se o mebro já existe no repositório
            var existingMember = _memberRepository.GetById(a => a.Id == member.Id);

            if (existingMember != null)
            {
                // Atualiza o registro existente
                var existingAuthor = _memberRepository.GetById(a => a.Id == member.Id);
                _memberRepository.Update(a => a.Id == member.Id, member);
                MessageBox.Show(@"Member updated successfully!", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Adiciona um novo registro
                _memberRepository.Add(member);
                MessageBox.Show(@"Member saved successfully!", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            tabControlRegister.SelectedTab = tabPageList;
        }


        protected override void LoadList()
        {
            var members = _memberRepository.GetAll();
            dataGridViewRegister.DataSource = members;
            dataGridViewRegister.Columns["Id"]!.Visible = false; // Hide the Id column
        }

        protected override void FillFormFields(DataGridViewRow row)
        {
            if (row.DataBoundItem is Member member)
            {
                txtId.Text = member.Id.ToString();
                txtName.Text = member.Name;
                txtEmail.Text = member.Email;
                txtPhone.Text = member.PhoneNumber;
                dtmDateOfBird.Value = member.DateOfBirth;
                dtmStartDate.Value = member.MembershipStartDate;
                dtmEndDate.Value = member.MembershipEndDate ?? DateTime.Now; // Handle nullable DateTime  
                cmbRole.Text = member.Role;
            }
            else
            {
                MessageBox.Show(@"Please select a valid author.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Delete(DataGridViewRow row)
        {
            if (row.DataBoundItem is Member member)
            {
                _memberRepository.Delete(a => a.Id == member.Id);
                MessageBox.Show(@"Member deleted successfully!", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }

}
