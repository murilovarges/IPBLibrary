namespace IPBLibrary.App.RegisterForms
{
    partial class FormMember
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
            dtmStartDate = new ReaLTaiizor.Controls.PoisonDateTime();
            metroLabel2 = new ReaLTaiizor.Controls.MetroLabel();
            dtmEndDate = new ReaLTaiizor.Controls.PoisonDateTime();
            metroLabel3 = new ReaLTaiizor.Controls.MetroLabel();
            cboRole = new ReaLTaiizor.Controls.MaterialComboBox();
            tabPageRegister.SuspendLayout();
            tabControlRegister.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageRegister
            // 
            tabPageRegister.Controls.Add(cboRole);
            tabPageRegister.Controls.Add(dtmEndDate);
            tabPageRegister.Controls.Add(metroLabel3);
            tabPageRegister.Controls.Add(dtmStartDate);
            tabPageRegister.Controls.Add(metroLabel2);
            tabPageRegister.Controls.Add(dtmDateOfBird);
            tabPageRegister.Controls.Add(txtPhone);
            tabPageRegister.Controls.Add(txtEmail);
            tabPageRegister.Controls.Add(txtName);
            tabPageRegister.Controls.Add(metroLabel1);
            tabPageRegister.Size = new Size(758, 417);
            tabPageRegister.Controls.SetChildIndex(metroLabel1, 0);
            tabPageRegister.Controls.SetChildIndex(txtId, 0);
            tabPageRegister.Controls.SetChildIndex(txtName, 0);
            tabPageRegister.Controls.SetChildIndex(txtEmail, 0);
            tabPageRegister.Controls.SetChildIndex(txtPhone, 0);
            tabPageRegister.Controls.SetChildIndex(dtmDateOfBird, 0);
            tabPageRegister.Controls.SetChildIndex(metroLabel2, 0);
            tabPageRegister.Controls.SetChildIndex(dtmStartDate, 0);
            tabPageRegister.Controls.SetChildIndex(metroLabel3, 0);
            tabPageRegister.Controls.SetChildIndex(dtmEndDate, 0);
            tabPageRegister.Controls.SetChildIndex(cboRole, 0);
            // 
            // tabControlRegister
            // 
            tabControlRegister.Size = new Size(766, 450);
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
            dtmDateOfBird.Location = new Point(6, 164);
            dtmDateOfBird.MinimumSize = new Size(0, 35);
            dtmDateOfBird.Name = "dtmDateOfBird";
            dtmDateOfBird.Size = new Size(234, 35);
            dtmDateOfBird.TabIndex = 5;
            // 
            // metroLabel1
            // 
            metroLabel1.Font = new Font("Microsoft Sans Serif", 10F);
            metroLabel1.IsDerivedStyle = true;
            metroLabel1.Location = new Point(6, 144);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(125, 29);
            metroLabel1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroLabel1.StyleManager = null;
            metroLabel1.TabIndex = 4;
            metroLabel1.Text = "Date of Birth";
            metroLabel1.ThemeAuthor = "Taiizor";
            metroLabel1.ThemeName = "MetroLight";
            // 
            // dtmStartDate
            // 
            dtmStartDate.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Tall;
            dtmStartDate.Format = DateTimePickerFormat.Short;
            dtmStartDate.Location = new Point(255, 164);
            dtmStartDate.MinimumSize = new Size(0, 35);
            dtmStartDate.Name = "dtmStartDate";
            dtmStartDate.Size = new Size(234, 35);
            dtmStartDate.TabIndex = 7;
            // 
            // metroLabel2
            // 
            metroLabel2.Font = new Font("Microsoft Sans Serif", 10F);
            metroLabel2.IsDerivedStyle = true;
            metroLabel2.Location = new Point(255, 144);
            metroLabel2.Name = "metroLabel2";
            metroLabel2.Size = new Size(125, 29);
            metroLabel2.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroLabel2.StyleManager = null;
            metroLabel2.TabIndex = 6;
            metroLabel2.Text = "Start Date";
            metroLabel2.ThemeAuthor = "Taiizor";
            metroLabel2.ThemeName = "MetroLight";
            // 
            // dtmEndDate
            // 
            dtmEndDate.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Tall;
            dtmEndDate.Format = DateTimePickerFormat.Short;
            dtmEndDate.Location = new Point(505, 164);
            dtmEndDate.MinimumSize = new Size(0, 35);
            dtmEndDate.Name = "dtmEndDate";
            dtmEndDate.Size = new Size(234, 35);
            dtmEndDate.TabIndex = 9;
            // 
            // metroLabel3
            // 
            metroLabel3.Font = new Font("Microsoft Sans Serif", 10F);
            metroLabel3.IsDerivedStyle = true;
            metroLabel3.Location = new Point(505, 144);
            metroLabel3.Name = "metroLabel3";
            metroLabel3.Size = new Size(125, 29);
            metroLabel3.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroLabel3.StyleManager = null;
            metroLabel3.TabIndex = 8;
            metroLabel3.Text = "End Date";
            metroLabel3.ThemeAuthor = "Taiizor";
            metroLabel3.ThemeName = "MetroLight";
            // 
            // cboRole
            // 
            cboRole.AutoResize = false;
            cboRole.BackColor = Color.FromArgb(255, 255, 255);
            cboRole.Depth = 0;
            cboRole.DrawMode = DrawMode.OwnerDrawVariable;
            cboRole.DropDownHeight = 174;
            cboRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRole.DropDownWidth = 121;
            cboRole.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboRole.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboRole.FormattingEnabled = true;
            cboRole.Hint = "Role";
            cboRole.IntegralHeight = false;
            cboRole.ItemHeight = 43;
            cboRole.Items.AddRange(new object[] { "Student", "Professor", "Employee", "Others" });
            cboRole.Location = new Point(6, 221);
            cboRole.MaxDropDownItems = 4;
            cboRole.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(733, 49);
            cboRole.StartIndex = 0;
            cboRole.TabIndex = 10;
            // 
            // FormMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 517);
            Location = new Point(0, 0);
            Name = "FormMember";
            Text = "Member Register";
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
        private ReaLTaiizor.Controls.PoisonDateTime dtmEndDate;
        private ReaLTaiizor.Controls.MetroLabel metroLabel3;
        private ReaLTaiizor.Controls.PoisonDateTime dtmStartDate;
        private ReaLTaiizor.Controls.MetroLabel metroLabel2;
        private ReaLTaiizor.Controls.MaterialComboBox cboRole;
    }
}