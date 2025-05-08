namespace IPBLibrary.App.RegisterForms
{
    partial class FormAuthor
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
            txtTitle = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtBiography = new ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit();
            tabPageRegister.SuspendLayout();
            tabControlRegister.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageRegister
            // 
            tabPageRegister.Controls.Add(txtBiography);
            tabPageRegister.Controls.Add(txtTitle);
            tabPageRegister.Controls.Add(metroLabel1);
            tabPageRegister.Controls.Add(dtmDateOfBird);
            tabPageRegister.Controls.Add(txtPhone);
            tabPageRegister.Controls.Add(txtEmail);
            tabPageRegister.Controls.Add(txtName);
            tabPageRegister.Size = new Size(758, 384);
            tabPageRegister.Controls.SetChildIndex(txtId, 0);
            tabPageRegister.Controls.SetChildIndex(txtName, 0);
            tabPageRegister.Controls.SetChildIndex(txtEmail, 0);
            tabPageRegister.Controls.SetChildIndex(txtPhone, 0);
            tabPageRegister.Controls.SetChildIndex(dtmDateOfBird, 0);
            tabPageRegister.Controls.SetChildIndex(metroLabel1, 0);
            tabPageRegister.Controls.SetChildIndex(txtTitle, 0);
            tabPageRegister.Controls.SetChildIndex(txtBiography, 0);
            // 
            // tabControlRegister
            // 
            tabControlRegister.Size = new Size(766, 417);
            // 
            // txtId
            // 
            txtId.TabIndex = 0;
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
            dtmDateOfBird.Location = new Point(15, 164);
            dtmDateOfBird.MinimumSize = new Size(0, 35);
            dtmDateOfBird.Name = "dtmDateOfBird";
            dtmDateOfBird.Size = new Size(302, 35);
            dtmDateOfBird.TabIndex = 5;
            // 
            // metroLabel1
            // 
            metroLabel1.Font = new Font("Microsoft Sans Serif", 10F);
            metroLabel1.IsDerivedStyle = true;
            metroLabel1.Location = new Point(15, 132);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(125, 29);
            metroLabel1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroLabel1.StyleManager = null;
            metroLabel1.TabIndex = 4;
            metroLabel1.Text = "Date of Birth";
            metroLabel1.ThemeAuthor = "Taiizor";
            metroLabel1.ThemeName = "MetroLight";
            // 
            // txtTitle
            // 
            txtTitle.AnimateReadOnly = false;
            txtTitle.AutoCompleteMode = AutoCompleteMode.None;
            txtTitle.AutoCompleteSource = AutoCompleteSource.None;
            txtTitle.BackgroundImageLayout = ImageLayout.None;
            txtTitle.CharacterCasing = CharacterCasing.Normal;
            txtTitle.Depth = 0;
            txtTitle.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTitle.HideSelection = true;
            txtTitle.Hint = "Title";
            txtTitle.LeadingIcon = null;
            txtTitle.Location = new Point(323, 151);
            txtTitle.MaxLength = 32767;
            txtTitle.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTitle.Name = "txtTitle";
            txtTitle.PasswordChar = '\0';
            txtTitle.PrefixSuffixText = null;
            txtTitle.ReadOnly = false;
            txtTitle.RightToLeft = RightToLeft.No;
            txtTitle.SelectedText = "";
            txtTitle.SelectionLength = 0;
            txtTitle.SelectionStart = 0;
            txtTitle.ShortcutsEnabled = true;
            txtTitle.Size = new Size(416, 48);
            txtTitle.TabIndex = 6;
            txtTitle.TabStop = false;
            txtTitle.TextAlign = HorizontalAlignment.Left;
            txtTitle.TrailingIcon = null;
            txtTitle.UseSystemPasswordChar = false;
            // 
            // txtBiography
            // 
            txtBiography.AnimateReadOnly = false;
            txtBiography.BackgroundImageLayout = ImageLayout.None;
            txtBiography.CharacterCasing = CharacterCasing.Normal;
            txtBiography.Depth = 0;
            txtBiography.HideSelection = true;
            txtBiography.Hint = "Biography";
            txtBiography.Location = new Point(15, 205);
            txtBiography.MaxLength = 32767;
            txtBiography.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBiography.Name = "txtBiography";
            txtBiography.PasswordChar = '\0';
            txtBiography.ReadOnly = false;
            txtBiography.ScrollBars = ScrollBars.None;
            txtBiography.SelectedText = "";
            txtBiography.SelectionLength = 0;
            txtBiography.SelectionStart = 0;
            txtBiography.ShortcutsEnabled = true;
            txtBiography.Size = new Size(733, 125);
            txtBiography.TabIndex = 7;
            txtBiography.TabStop = false;
            txtBiography.TextAlign = HorizontalAlignment.Left;
            txtBiography.UseSystemPasswordChar = false;
            // 
            // FormAuthor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 484);
            Location = new Point(0, 0);
            Name = "FormAuthor";
            Text = "Author Register";
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
        private ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit txtBiography;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTitle;
    }
}