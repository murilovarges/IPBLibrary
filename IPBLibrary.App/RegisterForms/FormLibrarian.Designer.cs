namespace IPBLibrary.App.RegisterForms
{
    partial class FormLibrarian
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtEmail = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPhone = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            dtmDateOfBird = new ReaLTaiizor.Controls.PoisonDateTime();
            metroLabel1 = new ReaLTaiizor.Controls.MetroLabel();
            cmbRole = new ReaLTaiizor.Controls.MaterialComboBox();
            txtEmployeeNumber = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPassword = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPageRegister.SuspendLayout();
            tabControlRegister.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageRegister
            // 
            tabPageRegister.Controls.Add(txtPassword);
            tabPageRegister.Controls.Add(txtEmployeeNumber);
            tabPageRegister.Controls.Add(cmbRole);
            tabPageRegister.Controls.Add(dtmDateOfBird);
            tabPageRegister.Controls.Add(txtPhone);
            tabPageRegister.Controls.Add(txtEmail);
            tabPageRegister.Controls.Add(txtName);
            tabPageRegister.Controls.Add(metroLabel1);
            tabPageRegister.Size = new Size(758, 344);
            tabPageRegister.Controls.SetChildIndex(metroLabel1, 0);
            tabPageRegister.Controls.SetChildIndex(txtName, 0);
            tabPageRegister.Controls.SetChildIndex(txtEmail, 0);
            tabPageRegister.Controls.SetChildIndex(txtPhone, 0);
            tabPageRegister.Controls.SetChildIndex(dtmDateOfBird, 0);
            tabPageRegister.Controls.SetChildIndex(cmbRole, 0);
            tabPageRegister.Controls.SetChildIndex(txtId, 0);
            tabPageRegister.Controls.SetChildIndex(txtEmployeeNumber, 0);
            tabPageRegister.Controls.SetChildIndex(txtPassword, 0);
            // 
            // tabControlRegister
            // 
            tabControlRegister.Size = new Size(766, 377);
            // 
            // txtName
            // 
            txtName.AnimateReadOnly = false;
            txtName.AutoCompleteMode = AutoCompleteMode.None;
            txtName.AutoCompleteSource = AutoCompleteSource.None;
            txtName.BackgroundImageLayout = ImageLayout.None;
            txtName.CharacterCasing = CharacterCasing.Normal;
            txtName.Depth = 0;
            txtName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtName.HideSelection = true;
            txtName.Hint = "Name";
            txtName.LeadingIcon = null;
            txtName.Location = new Point(123, 16);
            txtName.MaxLength = 32767;
            txtName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PrefixSuffixText = null;
            txtName.ReadOnly = false;
            txtName.RightToLeft = RightToLeft.No;
            txtName.SelectedText = "";
            txtName.SelectionLength = 0;
            txtName.SelectionStart = 0;
            txtName.ShortcutsEnabled = true;
            txtName.Size = new Size(616, 48);
            txtName.TabIndex = 1;
            txtName.TabStop = false;
            txtName.TextAlign = HorizontalAlignment.Left;
            txtName.TrailingIcon = null;
            txtName.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.AutoCompleteMode = AutoCompleteMode.None;
            txtEmail.AutoCompleteSource = AutoCompleteSource.None;
            txtEmail.BackgroundImageLayout = ImageLayout.None;
            txtEmail.CharacterCasing = CharacterCasing.Normal;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.HideSelection = true;
            txtEmail.Hint = "E-mail";
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(6, 81);
            txtEmail.MaxLength = 32767;
            txtEmail.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PrefixSuffixText = null;
            txtEmail.ReadOnly = false;
            txtEmail.RightToLeft = RightToLeft.No;
            txtEmail.SelectedText = "";
            txtEmail.SelectionLength = 0;
            txtEmail.SelectionStart = 0;
            txtEmail.ShortcutsEnabled = true;
            txtEmail.Size = new Size(311, 48);
            txtEmail.TabIndex = 2;
            txtEmail.TabStop = false;
            txtEmail.TextAlign = HorizontalAlignment.Left;
            txtEmail.TrailingIcon = null;
            txtEmail.UseSystemPasswordChar = false;
            // 
            // txtPhone
            // 
            txtPhone.AnimateReadOnly = false;
            txtPhone.AutoCompleteMode = AutoCompleteMode.None;
            txtPhone.AutoCompleteSource = AutoCompleteSource.None;
            txtPhone.BackgroundImageLayout = ImageLayout.None;
            txtPhone.CharacterCasing = CharacterCasing.Normal;
            txtPhone.Depth = 0;
            txtPhone.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPhone.HideSelection = true;
            txtPhone.Hint = "Phone";
            txtPhone.LeadingIcon = null;
            txtPhone.Location = new Point(323, 81);
            txtPhone.MaxLength = 32767;
            txtPhone.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPhone.Name = "txtPhone";
            txtPhone.PasswordChar = '\0';
            txtPhone.PrefixSuffixText = null;
            txtPhone.ReadOnly = false;
            txtPhone.RightToLeft = RightToLeft.No;
            txtPhone.SelectedText = "";
            txtPhone.SelectionLength = 0;
            txtPhone.SelectionStart = 0;
            txtPhone.ShortcutsEnabled = true;
            txtPhone.Size = new Size(416, 48);
            txtPhone.TabIndex = 3;
            txtPhone.TabStop = false;
            txtPhone.TextAlign = HorizontalAlignment.Left;
            txtPhone.TrailingIcon = null;
            txtPhone.UseSystemPasswordChar = false;
            // 
            // dtmDateOfBird
            // 
            dtmDateOfBird.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Tall;
            dtmDateOfBird.Format = DateTimePickerFormat.Short;
            dtmDateOfBird.Location = new Point(584, 203);
            dtmDateOfBird.MinimumSize = new Size(0, 35);
            dtmDateOfBird.Name = "dtmDateOfBird";
            dtmDateOfBird.Size = new Size(155, 35);
            dtmDateOfBird.TabIndex = 8;
            // 
            // metroLabel1
            // 
            metroLabel1.Font = new Font("Microsoft Sans Serif", 10F);
            metroLabel1.IsDerivedStyle = true;
            metroLabel1.Location = new Point(580, 185);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(125, 29);
            metroLabel1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroLabel1.StyleManager = null;
            metroLabel1.TabIndex = 7;
            metroLabel1.Text = "Date of Birth";
            metroLabel1.ThemeAuthor = "Taiizor";
            metroLabel1.ThemeName = "MetroLight";
            // 
            // cmbRole
            // 
            cmbRole.AutoResize = false;
            cmbRole.BackColor = Color.FromArgb(255, 255, 255);
            cmbRole.Depth = 0;
            cmbRole.DrawMode = DrawMode.OwnerDrawVariable;
            cmbRole.DropDownHeight = 174;
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.DropDownWidth = 121;
            cmbRole.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbRole.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbRole.FormattingEnabled = true;
            cmbRole.Hint = "Role";
            cmbRole.IntegralHeight = false;
            cmbRole.ItemHeight = 43;
            cmbRole.Items.AddRange(new object[] { "Librarian", "Assistant", "Other" });
            cmbRole.Location = new Point(323, 135);
            cmbRole.MaxDropDownItems = 4;
            cmbRole.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(416, 49);
            cmbRole.StartIndex = 0;
            cmbRole.TabIndex = 5;
            // 
            // txtEmployeeNumber
            // 
            txtEmployeeNumber.AnimateReadOnly = false;
            txtEmployeeNumber.AutoCompleteMode = AutoCompleteMode.None;
            txtEmployeeNumber.AutoCompleteSource = AutoCompleteSource.None;
            txtEmployeeNumber.BackgroundImageLayout = ImageLayout.None;
            txtEmployeeNumber.CharacterCasing = CharacterCasing.Normal;
            txtEmployeeNumber.Depth = 0;
            txtEmployeeNumber.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmployeeNumber.HideSelection = true;
            txtEmployeeNumber.Hint = "Employee Number";
            txtEmployeeNumber.LeadingIcon = null;
            txtEmployeeNumber.Location = new Point(6, 136);
            txtEmployeeNumber.MaxLength = 32767;
            txtEmployeeNumber.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEmployeeNumber.Name = "txtEmployeeNumber";
            txtEmployeeNumber.PasswordChar = '\0';
            txtEmployeeNumber.PrefixSuffixText = null;
            txtEmployeeNumber.ReadOnly = false;
            txtEmployeeNumber.RightToLeft = RightToLeft.No;
            txtEmployeeNumber.SelectedText = "";
            txtEmployeeNumber.SelectionLength = 0;
            txtEmployeeNumber.SelectionStart = 0;
            txtEmployeeNumber.ShortcutsEnabled = true;
            txtEmployeeNumber.Size = new Size(311, 48);
            txtEmployeeNumber.TabIndex = 4;
            txtEmployeeNumber.TabStop = false;
            txtEmployeeNumber.TextAlign = HorizontalAlignment.Left;
            txtEmployeeNumber.TrailingIcon = null;
            txtEmployeeNumber.UseSystemPasswordChar = false;
            // 
            // txtPassword
            // 
            txtPassword.AnimateReadOnly = false;
            txtPassword.AutoCompleteMode = AutoCompleteMode.None;
            txtPassword.AutoCompleteSource = AutoCompleteSource.None;
            txtPassword.BackgroundImageLayout = ImageLayout.None;
            txtPassword.CharacterCasing = CharacterCasing.Normal;
            txtPassword.Depth = 0;
            txtPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPassword.HideSelection = true;
            txtPassword.Hint = "Password";
            txtPassword.LeadingIcon = null;
            txtPassword.Location = new Point(3, 190);
            txtPassword.MaxLength = 32767;
            txtPassword.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.PrefixSuffixText = null;
            txtPassword.ReadOnly = false;
            txtPassword.RightToLeft = RightToLeft.No;
            txtPassword.SelectedText = "";
            txtPassword.SelectionLength = 0;
            txtPassword.SelectionStart = 0;
            txtPassword.ShortcutsEnabled = true;
            txtPassword.Size = new Size(571, 48);
            txtPassword.TabIndex = 6;
            txtPassword.TabStop = false;
            txtPassword.TextAlign = HorizontalAlignment.Left;
            txtPassword.TrailingIcon = null;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // FormLibrarian
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 444);
            Location = new Point(0, 0);
            Name = "FormLibrarian";
            Text = "Librarian Register";
            tabPageRegister.ResumeLayout(false);
            tabControlRegister.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MetroLabel metroLabel1;
        private ReaLTaiizor.Controls.PoisonDateTime dtmDateOfBird;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPhone;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEmail;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtName;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEmployeeNumber;
        private ReaLTaiizor.Controls.MaterialComboBox cmbRole;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPassword;
    }
}