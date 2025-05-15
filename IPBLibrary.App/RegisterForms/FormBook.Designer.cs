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
            cboAuthor = new MaterialComboBox();
            cboCategory = new MaterialComboBox();
            metroLabel1 = new MetroLabel();
            cboPublisher = new MaterialComboBox();
            tabPageRegister.SuspendLayout();
            tabControlRegister.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageRegister
            // 
            tabPageRegister.Controls.Add(cboPublisher);
            tabPageRegister.Controls.Add(txtTitle);
            tabPageRegister.Controls.Add(txtISBN);
            tabPageRegister.Controls.Add(txtGenre);
            tabPageRegister.Controls.Add(dtmPublishedDate);
            tabPageRegister.Controls.Add(cboAuthor);
            tabPageRegister.Controls.Add(cboCategory);
            tabPageRegister.Controls.Add(metroLabel1);
            tabPageRegister.Size = new Size(774, 400);
            tabPageRegister.Controls.SetChildIndex(metroLabel1, 0);
            tabPageRegister.Controls.SetChildIndex(cboCategory, 0);
            tabPageRegister.Controls.SetChildIndex(cboAuthor, 0);
            tabPageRegister.Controls.SetChildIndex(dtmPublishedDate, 0);
            tabPageRegister.Controls.SetChildIndex(txtGenre, 0);
            tabPageRegister.Controls.SetChildIndex(txtISBN, 0);
            tabPageRegister.Controls.SetChildIndex(txtTitle, 0);
            tabPageRegister.Controls.SetChildIndex(txtId, 0);
            tabPageRegister.Controls.SetChildIndex(cboPublisher, 0);
            // 
            // tabControlRegister
            // 
            tabControlRegister.Size = new Size(782, 433);
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
            dtmPublishedDate.Location = new Point(6, 87);
            dtmPublishedDate.MinimumSize = new Size(0, 35);
            dtmPublishedDate.Name = "dtmPublishedDate";
            dtmPublishedDate.Size = new Size(219, 35);
            dtmPublishedDate.TabIndex = 4;
            // 
            // cboAuthor
            // 
            cboAuthor.AutoResize = false;
            cboAuthor.BackColor = Color.FromArgb(255, 255, 255);
            cboAuthor.Depth = 0;
            cboAuthor.DrawMode = DrawMode.OwnerDrawVariable;
            cboAuthor.DropDownHeight = 174;
            cboAuthor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAuthor.DropDownWidth = 121;
            cboAuthor.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboAuthor.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboAuthor.Hint = "Author";
            cboAuthor.IntegralHeight = false;
            cboAuthor.ItemHeight = 43;
            cboAuthor.Location = new Point(6, 132);
            cboAuthor.MaxDropDownItems = 4;
            cboAuthor.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboAuthor.Name = "cboAuthor";
            cboAuthor.Size = new Size(758, 49);
            cboAuthor.StartIndex = 0;
            cboAuthor.TabIndex = 6;
            // 
            // cboCategory
            // 
            cboCategory.AutoResize = false;
            cboCategory.BackColor = Color.FromArgb(255, 255, 255);
            cboCategory.Depth = 0;
            cboCategory.DrawMode = DrawMode.OwnerDrawVariable;
            cboCategory.DropDownHeight = 174;
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.DropDownWidth = 121;
            cboCategory.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboCategory.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboCategory.Hint = "Category";
            cboCategory.IntegralHeight = false;
            cboCategory.ItemHeight = 43;
            cboCategory.Location = new Point(6, 246);
            cboCategory.MaxDropDownItems = 4;
            cboCategory.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(758, 49);
            cboCategory.StartIndex = 0;
            cboCategory.TabIndex = 8;
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
            // cboPublisher
            // 
            cboPublisher.AutoResize = false;
            cboPublisher.BackColor = Color.FromArgb(255, 255, 255);
            cboPublisher.Depth = 0;
            cboPublisher.DrawMode = DrawMode.OwnerDrawVariable;
            cboPublisher.DropDownHeight = 174;
            cboPublisher.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPublisher.DropDownWidth = 121;
            cboPublisher.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboPublisher.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboPublisher.Hint = "Publisher";
            cboPublisher.IntegralHeight = false;
            cboPublisher.ItemHeight = 43;
            cboPublisher.Location = new Point(6, 187);
            cboPublisher.MaxDropDownItems = 4;
            cboPublisher.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboPublisher.Name = "cboPublisher";
            cboPublisher.Size = new Size(758, 49);
            cboPublisher.StartIndex = 0;
            cboPublisher.TabIndex = 7;
            // 
            // FormBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 500);
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
        private MaterialComboBox cboAuthor;
        private MaterialComboBox cboCategory;
        private MetroLabel metroLabel1;
        private MaterialComboBox cboPublisher;
    }
}