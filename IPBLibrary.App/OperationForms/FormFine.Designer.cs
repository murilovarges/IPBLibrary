namespace IPBLibrary.App.OperationForms
{
    partial class FormFine
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
            dtmIssuedDate = new ReaLTaiizor.Controls.PoisonDateTime();
            metroLabel1 = new ReaLTaiizor.Controls.MetroLabel();
            txtAmount = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            chbIsPaid = new ReaLTaiizor.Controls.MaterialCheckBox();
            tabPageRegister.SuspendLayout();
            tabControlRegister.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageRegister
            // 
            tabPageRegister.Controls.Add(chbIsPaid);
            tabPageRegister.Controls.Add(txtAmount);
            tabPageRegister.Controls.Add(dtmIssuedDate);
            tabPageRegister.Controls.Add(metroLabel1);
            tabPageRegister.Controls.Add(cboMember);
            tabPageRegister.Size = new Size(758, 286);
            tabPageRegister.Controls.SetChildIndex(txtId, 0);
            tabPageRegister.Controls.SetChildIndex(cboMember, 0);
            tabPageRegister.Controls.SetChildIndex(metroLabel1, 0);
            tabPageRegister.Controls.SetChildIndex(dtmIssuedDate, 0);
            tabPageRegister.Controls.SetChildIndex(txtAmount, 0);
            tabPageRegister.Controls.SetChildIndex(chbIsPaid, 0);
            // 
            // tabControlRegister
            // 
            tabControlRegister.Size = new Size(766, 319);
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
            cboMember.TabIndex = 1;
            // 
            // dtmIssuedDate
            // 
            dtmIssuedDate.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Tall;
            dtmIssuedDate.Format = DateTimePickerFormat.Short;
            dtmIssuedDate.Location = new Point(474, 83);
            dtmIssuedDate.MinimumSize = new Size(0, 35);
            dtmIssuedDate.Name = "dtmIssuedDate";
            dtmIssuedDate.Size = new Size(168, 35);
            dtmIssuedDate.TabIndex = 4;
            // 
            // metroLabel1
            // 
            metroLabel1.Font = new Font("Microsoft Sans Serif", 10F);
            metroLabel1.IsDerivedStyle = true;
            metroLabel1.Location = new Point(474, 63);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(125, 29);
            metroLabel1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroLabel1.StyleManager = null;
            metroLabel1.TabIndex = 3;
            metroLabel1.Text = "Issue Date";
            metroLabel1.ThemeAuthor = "Taiizor";
            metroLabel1.ThemeName = "MetroLight";
            // 
            // txtAmount
            // 
            txtAmount.AllowPromptAsInput = true;
            txtAmount.AnimateReadOnly = false;
            txtAmount.AsciiOnly = false;
            txtAmount.BackgroundImageLayout = ImageLayout.None;
            txtAmount.BeepOnError = false;
            txtAmount.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtAmount.Depth = 0;
            txtAmount.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAmount.HidePromptOnLeave = false;
            txtAmount.HideSelection = true;
            txtAmount.Hint = "Amount";
            txtAmount.InsertKeyMode = InsertKeyMode.Default;
            txtAmount.LeadingIcon = null;
            txtAmount.Location = new Point(6, 70);
            txtAmount.Mask = "$ #####9,99";
            txtAmount.MaxLength = 32767;
            txtAmount.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtAmount.Name = "txtAmount";
            txtAmount.PasswordChar = '\0';
            txtAmount.PrefixSuffixText = null;
            txtAmount.PromptChar = '_';
            txtAmount.ReadOnly = false;
            txtAmount.RejectInputOnFirstFailure = false;
            txtAmount.ResetOnPrompt = true;
            txtAmount.ResetOnSpace = true;
            txtAmount.RightToLeft = RightToLeft.No;
            txtAmount.SelectedText = "";
            txtAmount.SelectionLength = 0;
            txtAmount.SelectionStart = 0;
            txtAmount.ShortcutsEnabled = true;
            txtAmount.Size = new Size(442, 48);
            txtAmount.SkipLiterals = true;
            txtAmount.TabIndex = 2;
            txtAmount.TabStop = false;
            txtAmount.Text = "R$       .";
            txtAmount.TextAlign = HorizontalAlignment.Right;
            txtAmount.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtAmount.TrailingIcon = null;
            txtAmount.UseSystemPasswordChar = false;
            txtAmount.ValidatingType = null;
            // 
            // chbIsPaid
            // 
            chbIsPaid.AutoSize = true;
            chbIsPaid.Depth = 0;
            chbIsPaid.Location = new Point(655, 81);
            chbIsPaid.Margin = new Padding(0);
            chbIsPaid.MouseLocation = new Point(-1, -1);
            chbIsPaid.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            chbIsPaid.Name = "chbIsPaid";
            chbIsPaid.ReadOnly = false;
            chbIsPaid.Ripple = true;
            chbIsPaid.Size = new Size(83, 37);
            chbIsPaid.TabIndex = 5;
            chbIsPaid.Text = "Is Paid";
            chbIsPaid.UseAccentColor = false;
            chbIsPaid.UseVisualStyleBackColor = true;
            // 
            // FormFine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 386);
            Location = new Point(0, 0);
            Name = "FormFine";
            Text = "Fine Operation";
            tabPageRegister.ResumeLayout(false);
            tabPageRegister.PerformLayout();
            tabControlRegister.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox cboMember;
        private ReaLTaiizor.Controls.PoisonDateTime dtmExpirationDate;
        private ReaLTaiizor.Controls.MetroLabel metroLabel2;
        private ReaLTaiizor.Controls.PoisonDateTime dtmIssuedDate;
        private ReaLTaiizor.Controls.MetroLabel metroLabel1;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtAmount;
        private ReaLTaiizor.Controls.MaterialCheckBox chbIsPaid;
    }
}