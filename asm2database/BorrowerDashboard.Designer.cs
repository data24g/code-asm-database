namespace LibraryManagement
{
    partial class BorrowerDashboard
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageBook = new System.Windows.Forms.TabPage();
            this.lbBookList = new System.Windows.Forms.Label();
            this.dgvBookList = new System.Windows.Forms.DataGridView();
            this.cbBookPublisher = new System.Windows.Forms.ComboBox();
            this.cbBookAuthor = new System.Windows.Forms.ComboBox();
            this.dtBookPublishDate = new System.Windows.Forms.DateTimePicker();
            this.lbBookPublishDate = new System.Windows.Forms.Label();
            this.lbBookPublisher = new System.Windows.Forms.Label();
            this.lbBookCategory = new System.Windows.Forms.Label();
            this.cbBookCategory = new System.Windows.Forms.ComboBox();
            this.lbBookAuthor = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.lbBookName = new System.Windows.Forms.Label();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.lbBookId = new System.Windows.Forms.Label();
            this.tabPageTicket = new System.Windows.Forms.TabPage();
            this.dtTicketBorrowDate = new System.Windows.Forms.DateTimePicker();
            this.lbTicketBorrowDate = new System.Windows.Forms.Label();
            this.cbTicketBorrower = new System.Windows.Forms.ComboBox();
            this.cbTicketBook = new System.Windows.Forms.ComboBox();
            this.lbTicketBorrower = new System.Windows.Forms.Label();
            this.lbTicketList = new System.Windows.Forms.Label();
            this.dgvTicketList = new System.Windows.Forms.DataGridView();
            this.dtTicketReturnDate = new System.Windows.Forms.DateTimePicker();
            this.lbTicketReturnDate = new System.Windows.Forms.Label();
            this.lbTicketBook = new System.Windows.Forms.Label();
            this.txtTicketId = new System.Windows.Forms.TextBox();
            this.lbTicketId = new System.Windows.Forms.Label();
            this.lbTicketTitle = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).BeginInit();
            this.tabPageTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicketList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageBook);
            this.tabControl1.Controls.Add(this.tabPageTicket);
            this.tabControl1.Location = new System.Drawing.Point(-4, -1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(969, 614);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageBook
            // 
            this.tabPageBook.Controls.Add(this.lbBookList);
            this.tabPageBook.Controls.Add(this.dgvBookList);
            this.tabPageBook.Controls.Add(this.cbBookPublisher);
            this.tabPageBook.Controls.Add(this.cbBookAuthor);
            this.tabPageBook.Controls.Add(this.dtBookPublishDate);
            this.tabPageBook.Controls.Add(this.lbBookPublishDate);
            this.tabPageBook.Controls.Add(this.lbBookPublisher);
            this.tabPageBook.Controls.Add(this.lbBookCategory);
            this.tabPageBook.Controls.Add(this.cbBookCategory);
            this.tabPageBook.Controls.Add(this.lbBookAuthor);
            this.tabPageBook.Controls.Add(this.txtBookName);
            this.tabPageBook.Controls.Add(this.lbBookName);
            this.tabPageBook.Controls.Add(this.txtBookId);
            this.tabPageBook.Controls.Add(this.lbBookId);
            this.tabPageBook.Location = new System.Drawing.Point(4, 29);
            this.tabPageBook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageBook.Name = "tabPageBook";
            this.tabPageBook.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageBook.Size = new System.Drawing.Size(961, 581);
            this.tabPageBook.TabIndex = 0;
            this.tabPageBook.Text = "pppppp";
            this.tabPageBook.UseVisualStyleBackColor = true;
            // 
            // lbBookList
            // 
            this.lbBookList.AutoSize = true;
            this.lbBookList.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookList.Location = new System.Drawing.Point(369, 252);
            this.lbBookList.Name = "lbBookList";
            this.lbBookList.Size = new System.Drawing.Size(223, 40);
            this.lbBookList.TabIndex = 20;
            this.lbBookList.Text = "List of Books";
            // 
            // dgvBookList
            // 
            this.dgvBookList.AccessibleDescription = "ddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd" +
    "dddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd" +
    "ddddddddddddddddd";
            this.dgvBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookList.Location = new System.Drawing.Point(10, 305);
            this.dgvBookList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvBookList.Name = "dgvBookList";
            this.dgvBookList.RowHeadersWidth = 51;
            this.dgvBookList.RowTemplate.Height = 24;
            this.dgvBookList.Size = new System.Drawing.Size(933, 259);
            this.dgvBookList.TabIndex = 19;
            this.dgvBookList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookList_CellClick);
            this.dgvBookList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookList_CellContentClick);
            // 
            // cbBookPublisher
            // 
            this.cbBookPublisher.FormattingEnabled = true;
            this.cbBookPublisher.Location = new System.Drawing.Point(622, 89);
            this.cbBookPublisher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbBookPublisher.Name = "cbBookPublisher";
            this.cbBookPublisher.Size = new System.Drawing.Size(224, 28);
            this.cbBookPublisher.TabIndex = 18;
            // 
            // cbBookAuthor
            // 
            this.cbBookAuthor.FormattingEnabled = true;
            this.cbBookAuthor.Location = new System.Drawing.Point(94, 159);
            this.cbBookAuthor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbBookAuthor.Name = "cbBookAuthor";
            this.cbBookAuthor.Size = new System.Drawing.Size(186, 28);
            this.cbBookAuthor.TabIndex = 17;
            this.cbBookAuthor.SelectedIndexChanged += new System.EventHandler(this.cbBookAuthor_SelectedIndexChanged);
            // 
            // dtBookPublishDate
            // 
            this.dtBookPublishDate.Location = new System.Drawing.Point(622, 128);
            this.dtBookPublishDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtBookPublishDate.Name = "dtBookPublishDate";
            this.dtBookPublishDate.Size = new System.Drawing.Size(224, 26);
            this.dtBookPublishDate.TabIndex = 12;
            this.dtBookPublishDate.Value = new System.DateTime(2024, 7, 30, 0, 0, 0, 0);
            // 
            // lbBookPublishDate
            // 
            this.lbBookPublishDate.AutoSize = true;
            this.lbBookPublishDate.Location = new System.Drawing.Point(498, 131);
            this.lbBookPublishDate.Name = "lbBookPublishDate";
            this.lbBookPublishDate.Size = new System.Drawing.Size(124, 20);
            this.lbBookPublishDate.TabIndex = 11;
            this.lbBookPublishDate.Text = "Publishing Date:";
            // 
            // lbBookPublisher
            // 
            this.lbBookPublisher.AutoSize = true;
            this.lbBookPublisher.Location = new System.Drawing.Point(498, 96);
            this.lbBookPublisher.Name = "lbBookPublisher";
            this.lbBookPublisher.Size = new System.Drawing.Size(78, 20);
            this.lbBookPublisher.TabIndex = 9;
            this.lbBookPublisher.Text = "Publisher:";
            // 
            // lbBookCategory
            // 
            this.lbBookCategory.AutoSize = true;
            this.lbBookCategory.Location = new System.Drawing.Point(15, 200);
            this.lbBookCategory.Name = "lbBookCategory";
            this.lbBookCategory.Size = new System.Drawing.Size(77, 20);
            this.lbBookCategory.TabIndex = 8;
            this.lbBookCategory.Text = "Category:";
            // 
            // cbBookCategory
            // 
            this.cbBookCategory.FormattingEnabled = true;
            this.cbBookCategory.Location = new System.Drawing.Point(94, 196);
            this.cbBookCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbBookCategory.Name = "cbBookCategory";
            this.cbBookCategory.Size = new System.Drawing.Size(186, 28);
            this.cbBookCategory.TabIndex = 7;
            // 
            // lbBookAuthor
            // 
            this.lbBookAuthor.AutoSize = true;
            this.lbBookAuthor.Location = new System.Drawing.Point(15, 162);
            this.lbBookAuthor.Name = "lbBookAuthor";
            this.lbBookAuthor.Size = new System.Drawing.Size(61, 20);
            this.lbBookAuthor.TabIndex = 5;
            this.lbBookAuthor.Text = "Author:";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(94, 124);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(186, 26);
            this.txtBookName.TabIndex = 4;
            // 
            // lbBookName
            // 
            this.lbBookName.AutoSize = true;
            this.lbBookName.Location = new System.Drawing.Point(15, 128);
            this.lbBookName.Name = "lbBookName";
            this.lbBookName.Size = new System.Drawing.Size(55, 20);
            this.lbBookName.TabIndex = 3;
            this.lbBookName.Text = "Name:";
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(94, 89);
            this.txtBookId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(186, 26);
            this.txtBookId.TabIndex = 2;
            // 
            // lbBookId
            // 
            this.lbBookId.AutoSize = true;
            this.lbBookId.Location = new System.Drawing.Point(15, 92);
            this.lbBookId.Name = "lbBookId";
            this.lbBookId.Size = new System.Drawing.Size(30, 20);
            this.lbBookId.TabIndex = 1;
            this.lbBookId.Text = "ID:";
            // 
            // tabPageTicket
            // 
            this.tabPageTicket.Controls.Add(this.dtTicketBorrowDate);
            this.tabPageTicket.Controls.Add(this.lbTicketBorrowDate);
            this.tabPageTicket.Controls.Add(this.cbTicketBorrower);
            this.tabPageTicket.Controls.Add(this.cbTicketBook);
            this.tabPageTicket.Controls.Add(this.lbTicketBorrower);
            this.tabPageTicket.Controls.Add(this.lbTicketList);
            this.tabPageTicket.Controls.Add(this.dgvTicketList);
            this.tabPageTicket.Controls.Add(this.dtTicketReturnDate);
            this.tabPageTicket.Controls.Add(this.lbTicketReturnDate);
            this.tabPageTicket.Controls.Add(this.lbTicketBook);
            this.tabPageTicket.Controls.Add(this.txtTicketId);
            this.tabPageTicket.Controls.Add(this.lbTicketId);
            this.tabPageTicket.Controls.Add(this.lbTicketTitle);
            this.tabPageTicket.Location = new System.Drawing.Point(4, 29);
            this.tabPageTicket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageTicket.Name = "tabPageTicket";
            this.tabPageTicket.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageTicket.Size = new System.Drawing.Size(961, 581);
            this.tabPageTicket.TabIndex = 1;
            this.tabPageTicket.Text = "Ticket";
            this.tabPageTicket.UseVisualStyleBackColor = true;
            // 
            // dtTicketBorrowDate
            // 
            this.dtTicketBorrowDate.Location = new System.Drawing.Point(620, 88);
            this.dtTicketBorrowDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtTicketBorrowDate.Name = "dtTicketBorrowDate";
            this.dtTicketBorrowDate.Size = new System.Drawing.Size(224, 26);
            this.dtTicketBorrowDate.TabIndex = 81;
            this.dtTicketBorrowDate.Value = new System.DateTime(2024, 7, 30, 0, 0, 0, 0);
            // 
            // lbTicketBorrowDate
            // 
            this.lbTicketBorrowDate.AutoSize = true;
            this.lbTicketBorrowDate.Location = new System.Drawing.Point(496, 91);
            this.lbTicketBorrowDate.Name = "lbTicketBorrowDate";
            this.lbTicketBorrowDate.Size = new System.Drawing.Size(102, 20);
            this.lbTicketBorrowDate.TabIndex = 80;
            this.lbTicketBorrowDate.Text = "Borrow Date:";
            // 
            // cbTicketBorrower
            // 
            this.cbTicketBorrower.FormattingEnabled = true;
            this.cbTicketBorrower.Location = new System.Drawing.Point(92, 154);
            this.cbTicketBorrower.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTicketBorrower.Name = "cbTicketBorrower";
            this.cbTicketBorrower.Size = new System.Drawing.Size(186, 28);
            this.cbTicketBorrower.TabIndex = 79;
            // 
            // cbTicketBook
            // 
            this.cbTicketBook.FormattingEnabled = true;
            this.cbTicketBook.Location = new System.Drawing.Point(92, 119);
            this.cbTicketBook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTicketBook.Name = "cbTicketBook";
            this.cbTicketBook.Size = new System.Drawing.Size(186, 28);
            this.cbTicketBook.TabIndex = 78;
            // 
            // lbTicketBorrower
            // 
            this.lbTicketBorrower.AutoSize = true;
            this.lbTicketBorrower.Location = new System.Drawing.Point(12, 158);
            this.lbTicketBorrower.Name = "lbTicketBorrower";
            this.lbTicketBorrower.Size = new System.Drawing.Size(77, 20);
            this.lbTicketBorrower.TabIndex = 77;
            this.lbTicketBorrower.Text = "Borrower:";
            // 
            // lbTicketList
            // 
            this.lbTicketList.AutoSize = true;
            this.lbTicketList.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTicketList.Location = new System.Drawing.Point(396, 256);
            this.lbTicketList.Name = "lbTicketList";
            this.lbTicketList.Size = new System.Drawing.Size(237, 40);
            this.lbTicketList.TabIndex = 76;
            this.lbTicketList.Text = "List of Tickets";
            // 
            // dgvTicketList
            // 
            this.dgvTicketList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTicketList.Location = new System.Drawing.Point(8, 300);
            this.dgvTicketList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTicketList.Name = "dgvTicketList";
            this.dgvTicketList.RowHeadersWidth = 51;
            this.dgvTicketList.RowTemplate.Height = 24;
            this.dgvTicketList.Size = new System.Drawing.Size(935, 260);
            this.dgvTicketList.TabIndex = 75;
            this.dgvTicketList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTicketList_CellClick);
            this.dgvTicketList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTicketList_CellContentClick);
            // 
            // dtTicketReturnDate
            // 
            this.dtTicketReturnDate.Location = new System.Drawing.Point(620, 122);
            this.dtTicketReturnDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtTicketReturnDate.Name = "dtTicketReturnDate";
            this.dtTicketReturnDate.Size = new System.Drawing.Size(224, 26);
            this.dtTicketReturnDate.TabIndex = 74;
            this.dtTicketReturnDate.Value = new System.DateTime(2024, 7, 30, 0, 0, 0, 0);
            // 
            // lbTicketReturnDate
            // 
            this.lbTicketReturnDate.AutoSize = true;
            this.lbTicketReturnDate.Location = new System.Drawing.Point(496, 126);
            this.lbTicketReturnDate.Name = "lbTicketReturnDate";
            this.lbTicketReturnDate.Size = new System.Drawing.Size(101, 20);
            this.lbTicketReturnDate.TabIndex = 73;
            this.lbTicketReturnDate.Text = "Return Date:";
            // 
            // lbTicketBook
            // 
            this.lbTicketBook.AutoSize = true;
            this.lbTicketBook.Location = new System.Drawing.Point(12, 122);
            this.lbTicketBook.Name = "lbTicketBook";
            this.lbTicketBook.Size = new System.Drawing.Size(50, 20);
            this.lbTicketBook.TabIndex = 72;
            this.lbTicketBook.Text = "Book:";
            // 
            // txtTicketId
            // 
            this.txtTicketId.Location = new System.Drawing.Point(92, 84);
            this.txtTicketId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTicketId.Name = "txtTicketId";
            this.txtTicketId.Size = new System.Drawing.Size(186, 26);
            this.txtTicketId.TabIndex = 71;
            // 
            // lbTicketId
            // 
            this.lbTicketId.AutoSize = true;
            this.lbTicketId.Location = new System.Drawing.Point(12, 88);
            this.lbTicketId.Name = "lbTicketId";
            this.lbTicketId.Size = new System.Drawing.Size(30, 20);
            this.lbTicketId.TabIndex = 70;
            this.lbTicketId.Text = "ID:";
            // 
            // lbTicketTitle
            // 
            this.lbTicketTitle.AutoSize = true;
            this.lbTicketTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTicketTitle.Location = new System.Drawing.Point(344, 4);
            this.lbTicketTitle.Name = "lbTicketTitle";
            this.lbTicketTitle.Size = new System.Drawing.Size(313, 40);
            this.lbTicketTitle.TabIndex = 69;
            this.lbTicketTitle.Text = "Ticket Mangement";
            // 
            // BorrowerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 626);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BorrowerDashboard";
            this.Text = "BorrowerDashboard";
            this.Load += new System.EventHandler(this.BorrowerDashboard_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageBook.ResumeLayout(false);
            this.tabPageBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).EndInit();
            this.tabPageTicket.ResumeLayout(false);
            this.tabPageTicket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicketList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageBook;
        private System.Windows.Forms.Label lbBookList;
        private System.Windows.Forms.DataGridView dgvBookList;
        private System.Windows.Forms.ComboBox cbBookPublisher;
        private System.Windows.Forms.ComboBox cbBookAuthor;
        private System.Windows.Forms.DateTimePicker dtBookPublishDate;
        private System.Windows.Forms.Label lbBookPublishDate;
        private System.Windows.Forms.Label lbBookPublisher;
        private System.Windows.Forms.Label lbBookCategory;
        private System.Windows.Forms.ComboBox cbBookCategory;
        private System.Windows.Forms.Label lbBookAuthor;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label lbBookName;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Label lbBookId;
        private System.Windows.Forms.TabPage tabPageTicket;
        private System.Windows.Forms.DateTimePicker dtTicketBorrowDate;
        private System.Windows.Forms.Label lbTicketBorrowDate;
        private System.Windows.Forms.ComboBox cbTicketBorrower;
        private System.Windows.Forms.ComboBox cbTicketBook;
        private System.Windows.Forms.Label lbTicketBorrower;
        private System.Windows.Forms.Label lbTicketList;
        private System.Windows.Forms.DataGridView dgvTicketList;
        private System.Windows.Forms.DateTimePicker dtTicketReturnDate;
        private System.Windows.Forms.Label lbTicketReturnDate;
        private System.Windows.Forms.Label lbTicketBook;
        private System.Windows.Forms.TextBox txtTicketId;
        private System.Windows.Forms.Label lbTicketId;
        private System.Windows.Forms.Label lbTicketTitle;
    }
}