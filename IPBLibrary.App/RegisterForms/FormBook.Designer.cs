using ReaLTaiizor.Controls;

namespace IPBLibrary.App.RegisterForms
{
    partial class FormBook
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
            txtTitle = new MaterialTextBoxEdit();
            txtISBN = new MaterialTextBoxEdit();
            txtGenre = new MaterialTextBoxEdit();
            dtmPublishedDate = new PoisonDateTime();
            cmbAuthor = new MaterialComboBox();
            cmbCategory = new MaterialComboBox();
            metroLabel1 = new MetroLabel();
            tabPageRegister.SuspendLayout();
            tabControlRegister.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageRegister
            // 
            tabPageRegister.Controls.Add(txtTitle);
            tabPageRegister.Controls.Add(txtISBN);
            tabPageRegister.Controls.Add(txtGenre);
            tabPageRegister.Controls.Add(dtmPublishedDate);
            tabPageRegister.Controls.Add(cmbAuthor);
            tabPageRegister.Controls.Add(cmbCategory);
            tabPageRegister.Controls.Add(metroLabel1);
            tabPageRegister.Size = new Size(774, 307);
            tabPageRegister.Controls.SetChildIndex(metroLabel1, 0);
            tabPageRegister.Controls.SetChildIndex(cmbCategory, 0);
            tabPageRegister.Controls.SetChildIndex(cmbAuthor, 0);
            tabPageRegister.Controls.SetChildIndex(dtmPublishedDate, 0);
            tabPageRegister.Controls.SetChildIndex(txtGenre, 0);
            tabPageRegister.Controls.SetChildIndex(txtISBN, 0);
            tabPageRegister.Controls.SetChildIndex(txtTitle, 0);
            tabPageRegister.Controls.SetChildIndex(txtId, 0);
            // 
            // tabControlRegister
            // 
            tabControlRegister.Size = new Size(782, 340);
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
            txtTitle.Location = new Point(123, 16);
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
            txtTitle.Size = new Size(400, 48);
            txtTitle.TabIndex = 1;
            txtTitle.TabStop = false;
            txtTitle.TextAlign = HorizontalAlignment.Left;
            txtTitle.TrailingIcon = null;
            txtTitle.UseSystemPasswordChar = false;
            // 
            // txtISBN
            // 
            txtISBN.AnimateReadOnly = false;
            txtISBN.AutoCompleteMode = AutoCompleteMode.None;
            txtISBN.AutoCompleteSource = AutoCompleteSource.None;
            txtISBN.BackgroundImageLayout = ImageLayout.None;
            txtISBN.CharacterCasing = CharacterCasing.Normal;
            txtISBN.Depth = 0;
            txtISBN.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtISBN.HideSelection = true;
            txtISBN.Hint = "ISBN";
            txtISBN.LeadingIcon = null;
            txtISBN.Location = new Point(564, 16);
            txtISBN.MaxLength = 32767;
            txtISBN.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtISBN.Name = "txtISBN";
            txtISBN.PasswordChar = '\0';
            txtISBN.PrefixSuffixText = null;
            txtISBN.ReadOnly = false;
            txtISBN.RightToLeft = RightToLeft.No;
            txtISBN.SelectedText = "";
            txtISBN.SelectionLength = 0;
            txtISBN.SelectionStart = 0;
            txtISBN.ShortcutsEnabled = true;
            txtISBN.Size = new Size(200, 48);
            txtISBN.TabIndex = 2;
            txtISBN.TabStop = false;
            txtISBN.TextAlign = HorizontalAlignment.Left;
            txtISBN.TrailingIcon = null;
            txtISBN.UseSystemPasswordChar = false;
            // 
            // txtGenre
            // 
            txtGenre.AnimateReadOnly = false;
            txtGenre.AutoCompleteMode = AutoCompleteMode.None;
            txtGenre.AutoCompleteSource = AutoCompleteSource.None;
            txtGenre.BackgroundImageLayout = ImageLayout.None;
            txtGenre.CharacterCasing = CharacterCasing.Normal;
            txtGenre.Depth = 0;
            txtGenre.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtGenre.HideSelection = true;
            txtGenre.Hint = "Genre";
            txtGenre.LeadingIcon = null;
            txtGenre.Location = new Point(234, 74);
            txtGenre.MaxLength = 32767;
            txtGenre.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtGenre.Name = "txtGenre";
            txtGenre.PasswordChar = '\0';
            txtGenre.PrefixSuffixText = null;
            txtGenre.ReadOnly = false;
            txtGenre.RightToLeft = RightToLeft.No;
            txtGenre.SelectedText = "";
            txtGenre.SelectionLength = 0;
            txtGenre.SelectionStart = 0;
            txtGenre.ShortcutsEnabled = true;
            txtGenre.Size = new Size(530, 48);
            txtGenre.TabIndex = 5;
            txtGenre.TabStop = false;
            txtGenre.TextAlign = HorizontalAlignment.Left;
            txtGenre.TrailingIcon = null;
            txtGenre.UseSystemPasswordChar = false;
            // 
            // dtmPublishedDate
            // 
            dtmPublishedDate.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Tall;
            dtmPublishedDate.Format = DateTimePickerFormat.Short;
            dtmPublishedDate.Location = new Point(3, 87);
            dtmPublishedDate.MinimumSize = new Size(0, 35);
            dtmPublishedDate.Name = "dtmPublishedDate";
            dtmPublishedDate.Size = new Size(222, 35);
            dtmPublishedDate.TabIndex = 4;
            // 
            // cmbAuthor
            // 
            cmbAuthor.AutoResize = false;
            cmbAuthor.BackColor = Color.FromArgb(255, 255, 255);
            cmbAuthor.Depth = 0;
            cmbAuthor.DrawMode = DrawMode.OwnerDrawVariable;
            cmbAuthor.DropDownHeight = 174;
            cmbAuthor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAuthor.DropDownWidth = 121;
            cmbAuthor.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbAuthor.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbAuthor.Hint = "Author";
            cmbAuthor.IntegralHeight = false;
            cmbAuthor.ItemHeight = 43;
            cmbAuthor.Location = new Point(6, 132);
            cmbAuthor.MaxDropDownItems = 4;
            cmbAuthor.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cmbAuthor.Name = "cmbAuthor";
            cmbAuthor.Size = new Size(758, 49);
            cmbAuthor.StartIndex = 0;
            cmbAuthor.TabIndex = 6;
            // 
            // cmbCategory
            // 
            cmbCategory.AutoResize = false;
            cmbCategory.BackColor = Color.FromArgb(255, 255, 255);
            cmbCategory.Depth = 0;
            cmbCategory.DrawMode = DrawMode.OwnerDrawVariable;
            cmbCategory.DropDownHeight = 174;
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.DropDownWidth = 121;
            cmbCategory.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbCategory.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbCategory.Hint = "Category";
            cmbCategory.IntegralHeight = false;
            cmbCategory.ItemHeight = 43;
            cmbCategory.Location = new Point(6, 187);
            cmbCategory.MaxDropDownItems = 4;
            cmbCategory.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(758, 49);
            cmbCategory.StartIndex = 0;
            cmbCategory.TabIndex = 7;
            // 
            // metroLabel1
            // 
            metroLabel1.Font = new Font("Microsoft Sans Serif", 10F);
            metroLabel1.IsDerivedStyle = true;
            metroLabel1.Location = new Point(3, 67);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(125, 29);
            metroLabel1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroLabel1.StyleManager = null;
            metroLabel1.TabIndex = 3;
            metroLabel1.Text = "Date of Publish";
            metroLabel1.ThemeAuthor = "Taiizor";
            metroLabel1.ThemeName = "MetroLight";
            // 
            // FormBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 407);
            Location = new Point(0, 0);
            Name = "FormBook";
            Text = "Book Register";
            tabPageRegister.ResumeLayout(false);
            tabControlRegister.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTitle;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtISBN;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtGenre;
        private PoisonDateTime dtmPublishedDate;
        private MaterialComboBox cmbAuthor;
        private MaterialComboBox cmbCategory;
        private MetroLabel metroLabel1;
    }
}