namespace IPBLibrary.App.OperationForms
{
    partial class FormLoan
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
            cboMember = new ReaLTaiizor.Controls.MaterialComboBox();
            cboBook = new ReaLTaiizor.Controls.MaterialComboBox();
            dtmLoanDate = new ReaLTaiizor.Controls.PoisonDateTime();
            metroLabel1 = new ReaLTaiizor.Controls.MetroLabel();
            dtmReturnDate = new ReaLTaiizor.Controls.PoisonDateTime();
            metroLabel2 = new ReaLTaiizor.Controls.MetroLabel();
            chkReturned = new ReaLTaiizor.Controls.MaterialCheckBox();
            cboLibrarian = new ReaLTaiizor.Controls.MaterialComboBox();
            tabPageRegister.SuspendLayout();
            tabControlRegister.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageRegister
            // 
            tabPageRegister.Controls.Add(cboLibrarian);
            tabPageRegister.Controls.Add(chkReturned);
            tabPageRegister.Controls.Add(dtmReturnDate);
            tabPageRegister.Controls.Add(metroLabel2);
            tabPageRegister.Controls.Add(dtmLoanDate);
            tabPageRegister.Controls.Add(metroLabel1);
            tabPageRegister.Controls.Add(cboMember);
            tabPageRegister.Controls.Add(cboBook);
            tabPageRegister.Size = new Size(758, 350);
            tabPageRegister.Controls.SetChildIndex(txtId, 0);
            tabPageRegister.Controls.SetChildIndex(cboBook, 0);
            tabPageRegister.Controls.SetChildIndex(cboMember, 0);
            tabPageRegister.Controls.SetChildIndex(metroLabel1, 0);
            tabPageRegister.Controls.SetChildIndex(dtmLoanDate, 0);
            tabPageRegister.Controls.SetChildIndex(metroLabel2, 0);
            tabPageRegister.Controls.SetChildIndex(dtmReturnDate, 0);
            tabPageRegister.Controls.SetChildIndex(chkReturned, 0);
            tabPageRegister.Controls.SetChildIndex(cboLibrarian, 0);
            // 
            // tabControlRegister
            // 
            tabControlRegister.Size = new Size(766, 383);
            // 
            // cboMember
            // 
            cboMember.AutoResize = false;
            cboMember.BackColor = Color.FromArgb(255, 255, 255);
            cboMember.Depth = 0;
            cboMember.DrawMode = DrawMode.OwnerDrawVariable;
            cboMember.DropDownHeight = 174;
            cboMember.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMember.DropDownWidth = 121;
            cboMember.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboMember.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboMember.Hint = "Member";
            cboMember.IntegralHeight = false;
            cboMember.ItemHeight = 43;
            cboMember.Location = new Point(123, 15);
            cboMember.MaxDropDownItems = 4;
            cboMember.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboMember.Name = "cboMember";
            cboMember.Size = new Size(626, 49);
            cboMember.StartIndex = 0;
            cboMember.TabIndex = 8;
            // 
            // cboBook
            // 
            cboBook.AutoResize = false;
            cboBook.BackColor = Color.FromArgb(255, 255, 255);
            cboBook.Depth = 0;
            cboBook.DrawMode = DrawMode.OwnerDrawVariable;
            cboBook.DropDownHeight = 174;
            cboBook.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBook.DropDownWidth = 121;
            cboBook.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboBook.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboBook.Hint = "Book";
            cboBook.IntegralHeight = false;
            cboBook.ItemHeight = 43;
            cboBook.Location = new Point(6, 70);
            cboBook.MaxDropDownItems = 4;
            cboBook.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboBook.Name = "cboBook";
            cboBook.Size = new Size(743, 49);
            cboBook.StartIndex = 0;
            cboBook.TabIndex = 9;
            // 
            // dtmLoanDate
            // 
            dtmLoanDate.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Tall;
            dtmLoanDate.Format = DateTimePickerFormat.Short;
            dtmLoanDate.Location = new Point(6, 142);
            dtmLoanDate.MinimumSize = new Size(0, 35);
            dtmLoanDate.Name = "dtmLoanDate";
            dtmLoanDate.Size = new Size(222, 35);
            dtmLoanDate.TabIndex = 11;
            // 
            // metroLabel1
            // 
            metroLabel1.Font = new Font("Microsoft Sans Serif", 10F);
            metroLabel1.IsDerivedStyle = true;
            metroLabel1.Location = new Point(6, 122);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(125, 29);
            metroLabel1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroLabel1.StyleManager = null;
            metroLabel1.TabIndex = 10;
            metroLabel1.Text = "Loan Date";
            metroLabel1.ThemeAuthor = "Taiizor";
            metroLabel1.ThemeName = "MetroLight";
            // 
            // dtmReturnDate
            // 
            dtmReturnDate.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Tall;
            dtmReturnDate.Format = DateTimePickerFormat.Short;
            dtmReturnDate.Location = new Point(253, 142);
            dtmReturnDate.MinimumSize = new Size(0, 35);
            dtmReturnDate.Name = "dtmReturnDate";
            dtmReturnDate.Size = new Size(222, 35);
            dtmReturnDate.TabIndex = 13;
            // 
            // metroLabel2
            // 
            metroLabel2.Font = new Font("Microsoft Sans Serif", 10F);
            metroLabel2.IsDerivedStyle = true;
            metroLabel2.Location = new Point(253, 122);
            metroLabel2.Name = "metroLabel2";
            metroLabel2.Size = new Size(125, 29);
            metroLabel2.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroLabel2.StyleManager = null;
            metroLabel2.TabIndex = 12;
            metroLabel2.Text = "Return Date";
            metroLabel2.ThemeAuthor = "Taiizor";
            metroLabel2.ThemeName = "MetroLight";
            // 
            // chkReturned
            // 
            chkReturned.AutoSize = true;
            chkReturned.Depth = 0;
            chkReturned.Location = new Point(490, 140);
            chkReturned.Margin = new Padding(0);
            chkReturned.MouseLocation = new Point(-1, -1);
            chkReturned.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            chkReturned.Name = "chkReturned";
            chkReturned.ReadOnly = false;
            chkReturned.Ripple = true;
            chkReturned.Size = new Size(98, 37);
            chkReturned.TabIndex = 14;
            chkReturned.Text = "Returned";
            chkReturned.UseAccentColor = false;
            chkReturned.UseVisualStyleBackColor = true;
            // 
            // cboLibrarian
            // 
            cboLibrarian.AutoResize = false;
            cboLibrarian.BackColor = Color.FromArgb(255, 255, 255);
            cboLibrarian.Depth = 0;
            cboLibrarian.DrawMode = DrawMode.OwnerDrawVariable;
            cboLibrarian.DropDownHeight = 174;
            cboLibrarian.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLibrarian.DropDownWidth = 121;
            cboLibrarian.Enabled = false;
            cboLibrarian.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboLibrarian.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboLibrarian.Hint = "Librarian";
            cboLibrarian.IntegralHeight = false;
            cboLibrarian.ItemHeight = 43;
            cboLibrarian.Location = new Point(6, 183);
            cboLibrarian.MaxDropDownItems = 4;
            cboLibrarian.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboLibrarian.Name = "cboLibrarian";
            cboLibrarian.Size = new Size(740, 49);
            cboLibrarian.StartIndex = 0;
            cboLibrarian.TabIndex = 15;
            // 
            // FormLoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 450);
            Location = new Point(0, 0);
            Name = "FormLoan";
            Text = "Loan Operation";
            tabPageRegister.ResumeLayout(false);
            tabPageRegister.PerformLayout();
            tabControlRegister.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox cboMember;
        private ReaLTaiizor.Controls.MaterialComboBox cboBook;
        private ReaLTaiizor.Controls.PoisonDateTime dtmReturnDate;
        private ReaLTaiizor.Controls.MetroLabel metroLabel2;
        private ReaLTaiizor.Controls.PoisonDateTime dtmLoanDate;
        private ReaLTaiizor.Controls.MetroLabel metroLabel1;
        private ReaLTaiizor.Controls.MaterialCheckBox chkReturned;
        private ReaLTaiizor.Controls.MaterialComboBox cboLibrarian;
    }
}