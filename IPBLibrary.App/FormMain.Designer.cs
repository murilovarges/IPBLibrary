
namespace IPBLibrary.App
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            statusStrip = new StatusStrip();
            lblUserName = new ToolStripStatusLabel();
            lblUserRole = new ToolStripStatusLabel();
            menuStrip = new MenuStrip();
            registerToolStripMenuItem = new ToolStripMenuItem();
            publisherToolStripMenuItem = new ToolStripMenuItem();
            authorToolStripMenuItem = new ToolStripMenuItem();
            bookCategoryToolStripMenuItem = new ToolStripMenuItem();
            bookToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            memberToolStripMenuItem = new ToolStripMenuItem();
            librarianToolStripMenuItem = new ToolStripMenuItem();
            operationsToolStripMenuItem = new ToolStripMenuItem();
            bookLoanToolStripMenuItem = new ToolStripMenuItem();
            bookReservationToolStripMenuItem = new ToolStripMenuItem();
            fineToolStripMenuItem = new ToolStripMenuItem();
            statusStrip.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { lblUserName, lblUserRole });
            statusStrip.Location = new Point(3, 421);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(794, 26);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "statusStrip1";
            // 
            // lblUserName
            // 
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(41, 20);
            lblUserName.Text = "User:";
            // 
            // lblUserRole
            // 
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(39, 20);
            lblUserRole.Text = "Role";
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { registerToolStripMenuItem, operationsToolStripMenuItem });
            menuStrip.Location = new Point(3, 64);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(794, 28);
            menuStrip.TabIndex = 8;
            menuStrip.Text = "menuStrip1";
            // 
            // registerToolStripMenuItem
            // 
            registerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { publisherToolStripMenuItem, authorToolStripMenuItem, bookCategoryToolStripMenuItem, bookToolStripMenuItem, toolStripMenuItem1, memberToolStripMenuItem, librarianToolStripMenuItem });
            registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            registerToolStripMenuItem.Size = new Size(77, 24);
            registerToolStripMenuItem.Text = "&Register";
            // 
            // publisherToolStripMenuItem
            // 
            publisherToolStripMenuItem.Name = "publisherToolStripMenuItem";
            publisherToolStripMenuItem.Size = new Size(190, 26);
            publisherToolStripMenuItem.Text = "&Publisher";
            publisherToolStripMenuItem.Click += publisherToolStripMenuItem_Click;
            // 
            // authorToolStripMenuItem
            // 
            authorToolStripMenuItem.Name = "authorToolStripMenuItem";
            authorToolStripMenuItem.Size = new Size(190, 26);
            authorToolStripMenuItem.Text = "&Author";
            authorToolStripMenuItem.Click += authorToolStripMenuItem_Click;
            // 
            // bookCategoryToolStripMenuItem
            // 
            bookCategoryToolStripMenuItem.Name = "bookCategoryToolStripMenuItem";
            bookCategoryToolStripMenuItem.Size = new Size(190, 26);
            bookCategoryToolStripMenuItem.Text = "Book &Category";
            bookCategoryToolStripMenuItem.Click += bookCategoryToolStripMenuItem_Click;
            // 
            // bookToolStripMenuItem
            // 
            bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            bookToolStripMenuItem.Size = new Size(190, 26);
            bookToolStripMenuItem.Text = "&Book";
            bookToolStripMenuItem.Click += bookToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(187, 6);
            // 
            // memberToolStripMenuItem
            // 
            memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            memberToolStripMenuItem.Size = new Size(190, 26);
            memberToolStripMenuItem.Text = "&Member";
            memberToolStripMenuItem.Click += memberToolStripMenuItem_Click;
            // 
            // librarianToolStripMenuItem
            // 
            librarianToolStripMenuItem.Name = "librarianToolStripMenuItem";
            librarianToolStripMenuItem.Size = new Size(190, 26);
            librarianToolStripMenuItem.Text = "&Librarian";
            librarianToolStripMenuItem.Click += librarianToolStripMenuItem_Click;
            // 
            // operationsToolStripMenuItem
            // 
            operationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bookLoanToolStripMenuItem, bookReservationToolStripMenuItem, fineToolStripMenuItem });
            operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            operationsToolStripMenuItem.Size = new Size(96, 24);
            operationsToolStripMenuItem.Text = "&Operations";
            // 
            // bookLoanToolStripMenuItem
            // 
            bookLoanToolStripMenuItem.Name = "bookLoanToolStripMenuItem";
            bookLoanToolStripMenuItem.Size = new Size(224, 26);
            bookLoanToolStripMenuItem.Text = "Book Loan";
            bookLoanToolStripMenuItem.Click += bookLoanToolStripMenuItem_Click;
            // 
            // bookReservationToolStripMenuItem
            // 
            bookReservationToolStripMenuItem.Name = "bookReservationToolStripMenuItem";
            bookReservationToolStripMenuItem.Size = new Size(224, 26);
            bookReservationToolStripMenuItem.Text = "Book Reservation";
            bookReservationToolStripMenuItem.Click += bookReservationToolStripMenuItem_Click;
            // 
            // fineToolStripMenuItem
            // 
            fineToolStripMenuItem.Name = "fineToolStripMenuItem";
            fineToolStripMenuItem.Size = new Size(224, 26);
            fineToolStripMenuItem.Text = "Fine";
            fineToolStripMenuItem.Click += fineToolStripMenuItem_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.logo_header;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Name = "FormMain";
            Text = "..:: IPB Library Software ::..";
            WindowState = FormWindowState.Maximized;
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion
        private StatusStrip statusStrip;
        private MenuStrip menuStrip;
        private ToolStripMenuItem registerToolStripMenuItem;
        private ToolStripMenuItem authorToolStripMenuItem;
        private ToolStripMenuItem bookCategoryToolStripMenuItem;
        private ToolStripMenuItem bookToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem memberToolStripMenuItem;
        private ToolStripMenuItem librarianToolStripMenuItem;
        private ToolStripMenuItem operationsToolStripMenuItem;
        private ToolStripMenuItem bookLoanToolStripMenuItem;
        private ToolStripMenuItem bookReservationToolStripMenuItem;
        private ToolStripMenuItem fineToolStripMenuItem;
        private ToolStripStatusLabel lblUserName;
        private ToolStripStatusLabel lblUserRole;
        private ToolStripMenuItem publisherToolStripMenuItem;
    }
}
