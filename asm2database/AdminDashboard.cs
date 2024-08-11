using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class AdminDashboard : Form
    {
        private SqlConnection conn = new SqlConnection("server = LAPTOP-3E9R2QCF\\ADMIN; database = LibraryManagement2; integrated security = true");

        public AdminDashboard()
        {
            InitializeComponent();
        }

        public AdminDashboard(string username)
        {
            InitializeComponent();

            MessageBox.Show("Welcome, " + username);
        }

        public void GetAuthors()
        {
            string query = "select author_id, author_name from Authors";
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(table);
            cbBookMangementAuthor.DataSource = table;
            cbBookMangementAuthor.DisplayMember = "author_name";
            cbBookMangementAuthor.ValueMember = "author_id";
        }

        public void GetCategories()
        {
            string query = "select category_id, category_name from Categories";
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(table);
            cbBookMangementCategory.DataSource = table;
            cbBookMangementCategory.DisplayMember = "category_name";
            cbBookMangementCategory.ValueMember = "category_id";
        }

        public void GetPublishers()
        {
            string query = "select publisher_id, publisher_name from Publishers";
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(table);
            cbBookMangementPublisher.DataSource = table;
            cbBookMangementPublisher.DisplayMember = "publisher_name";
            cbBookMangementPublisher.ValueMember = "publisher_id";
        }

        public void GetBooks()
        {
            string query = "select book_id, book_name from Books";
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(table);
            cbTicketBook.DataSource = table;
            cbTicketBook.DisplayMember = "book_name";
            cbTicketBook.ValueMember = "book_id";
        }

        public void GetBorrowers()
        {
            string query = "select borrower_id, borrower_name from Borrowers";
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(table);
            cbTicketBorrower.DataSource = table;
            cbTicketBorrower.DisplayMember = "borrower_name";
            cbTicketBorrower.ValueMember = "borrower_id";
        }

        public void FillDataBooks()
        {
            string query = "select * from Books";
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(table);
            dgvBookMangementBookList.DataSource = table;
        }

        public void ClearDataBooks()
        {
            txtBookMangementId.Text = "";
            txtBookMangementName.Text = "";
            cbBookMangementAuthor.Text = "";
            cbBookMangementCategory.Text = "";
            cbBookMangementPublisher.Text = "";
        }

        public void FillDataBorrowers()
        {
            string query = "select * from Borrowers";
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(table);
            dgvBorrowerList.DataSource = table;
        }

        public void ClearDataBorrowers()
        {
            txtBorrowerId.Text = "";
            txtBorrowerName.Text = "";
            txtBorrowerAddress.Text = "";
            txtBorrowerEmail.Text = "";
            txtBorrowerPhone.Text = "";
        }

        public void FillDataTickets()
        {
            string query = "select * from Tickets";
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(table);
            dgvTicketList.DataSource = table;
        }

        public void ClearDataTickets()
        {
            txtTicketId.Text = "";
            cbTicketBook.Text = "";
            cbTicketBorrower.Text = "";
        }

        private void btnBookMangementAdd_Click(object sender, EventArgs e)
        {
            string name = txtBookMangementName.Text;
            string authorID = cbBookMangementAuthor.SelectedValue.ToString();
            string categoryID = cbBookMangementCategory.SelectedValue.ToString();
            string publisherID = cbBookMangementPublisher.SelectedValue.ToString();
            DateTime publishingDate = dtBookMangementPublishDate.Value;

            string insert = "insert into Books(book_name, author_id, category_id, publisher_id, publishing_date) values(@book_name, @author_id, @category_id, @publisher_id, @publishing_date)";
            conn.Open();
            SqlCommand cmd = new SqlCommand(insert, conn);
            cmd.Parameters.Add("@book_name", SqlDbType.VarChar);
            cmd.Parameters["@book_name"].Value = name;

            cmd.Parameters.Add("@author_id", SqlDbType.Int);
            cmd.Parameters["@author_id"].Value = authorID;

            cmd.Parameters.Add("@category_id", SqlDbType.Int);
            cmd.Parameters["@category_id"].Value = categoryID;

            cmd.Parameters.Add("@publisher_id", SqlDbType.Int);
            cmd.Parameters["@publisher_id"].Value = publisherID;

            cmd.Parameters.Add("@publishing_date", SqlDbType.DateTime);
            cmd.Parameters["@publishing_date"].Value = publishingDate;

            cmd.ExecuteNonQuery();
            FillDataBooks();
            ClearDataBooks();
            conn.Close();
/*            MessageBox.Show(this, "Inserted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);*/
            label1.Text = "";
        }

        private void dgvBookMangementBookList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBookMangementBookList.Rows[e.RowIndex];
                txtBookMangementId.Text = row.Cells["book_id"].Value.ToString();
                txtBookMangementName.Text = row.Cells["book_name"].Value.ToString();
                cbBookMangementAuthor.SelectedValue = row.Cells["author_id"].Value.ToString();
                cbBookMangementPublisher.SelectedValue = row.Cells["category_id"].Value.ToString();
                dtBookMangementPublishDate.Value = (DateTime)row.Cells["publishing_date"].Value;
            }
        }

        private void btnBookMangementUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to edit ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string update = "update Books set book_name = @book_name, author_id = @author_id, category_id = @category_id, publisher_id = @publisher_id, publishing_date = @publishing_date where book_id = @book_id";
                conn.Open();

                SqlCommand cmd = new SqlCommand(update, conn);
                cmd.Parameters.Add("@book_id", SqlDbType.Int);
                cmd.Parameters["@book_id"].Value = txtBookMangementId.Text;

                cmd.Parameters.Add("@book_name", SqlDbType.VarChar);
                cmd.Parameters["@book_name"].Value = txtBookMangementName.Text;

                cmd.Parameters.Add("@author_id", SqlDbType.Int);
                cmd.Parameters["@author_id"].Value = (cbBookMangementAuthor.SelectedValue.ToString());

                cmd.Parameters.Add("@category_id", SqlDbType.Int);
                cmd.Parameters["@category_id"].Value = (cbBookMangementCategory.SelectedValue.ToString());

                cmd.Parameters.Add("@publisher_id", SqlDbType.Int);
                cmd.Parameters["@publisher_id"].Value = (cbBookMangementPublisher.SelectedValue.ToString());

                cmd.Parameters.Add("@publishing_date", SqlDbType.VarChar);
                cmd.Parameters["@publishing_date"].Value = dtBookMangementPublishDate.Value;

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    FillDataBooks();
                    ClearDataBooks();
                    MessageBox.Show(this, "Updated successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                    conn.Close();
                }
            }
        }

        private void btnBookMangementDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to delete ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Open();
                string delete = "delete from Books where book_id = @book_id";

                SqlCommand cmd = new SqlCommand(delete, conn);
                cmd.Parameters.Add("@book_id", SqlDbType.Int);
                cmd.Parameters["@book_id"].Value = txtBookMangementId.Text;
                cmd.ExecuteNonQuery();

                FillDataBooks();
                ClearDataBooks();
                MessageBox.Show(this, "Deleted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                conn.Close();
            }
        }

        private void btnBookMangementClearData_Click(object sender, EventArgs e)
        {
            ClearDataBooks();
        }

        private void btnBorrowerClearData_Click(object sender, EventArgs e)
        {
            ClearDataBorrowers();
        }

        private void btnTicketClearData_Click(object sender, EventArgs e)
        {
            ClearDataTickets();
        }

        private void btnBorrowerAdd_Click(object sender, EventArgs e)
        {
            string borrowerName = txtBorrowerName.Text;
            string borrowerAddress = txtBorrowerAddress.Text;
            string borrowerPhone = txtBorrowerPhone.Text;
            string borrowerEmail = txtBorrowerEmail.Text;
            DateTime DOB = dtBorrowerDOB.Value;

            string insert = "insert into Borrowers(borrower_name, borrower_address, borrower_phone, borrower_email, borrower_DOB) values(@borrower_name, @borrower_address, @borrower_phone, @borrower_email, @borrower_DOB)";

            conn.Open();
            SqlCommand cmd = new SqlCommand(insert, conn);

            cmd.Parameters.Add("@borrower_name", SqlDbType.VarChar);
            cmd.Parameters["@borrower_name"].Value = borrowerName;

            cmd.Parameters.Add("@borrower_address", SqlDbType.VarChar);
            cmd.Parameters["@borrower_name"].Value = borrowerAddress;

            cmd.Parameters.Add("@borrower_phone", SqlDbType.VarChar);
            cmd.Parameters["@borrower_phone"].Value = borrowerPhone;

            cmd.Parameters.Add("@borrower_email", SqlDbType.VarChar);
            cmd.Parameters["@borrower_email"].Value = borrowerEmail;

            cmd.Parameters.Add("@borrower_DOB", SqlDbType.VarChar);
            cmd.Parameters["@borrower_DOB"].Value = DOB;

            cmd.ExecuteNonQuery();
            FillDataBorrowers();
            ClearDataBorrowers();
            conn.Close();
            MessageBox.Show(this, "Inserted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void dgvBorrowerList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBorrowerList.Rows[e.RowIndex];
                txtBorrowerId.Text = row.Cells["borrower_id"].Value.ToString();
                txtBorrowerName.Text = row.Cells["borrower_name"].Value.ToString();
                txtBorrowerAddress.Text = row.Cells["borrower_address"].Value.ToString();
                txtBorrowerPhone.Text = row.Cells["borrower_phone"].Value.ToString();
                txtBorrowerEmail.Text = row.Cells["borrower_email"].Value.ToString();
                dtBorrowerDOB.Value = (DateTime)row.Cells["borrower_DOB"].Value;
            }
        }

        private void btnBorrowerUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to edit ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string update = "update Borrowers set borrower_name = @borrower_name, borrower_address = @borrower_name, borrower_phone = @borrower_phone, borrower_email = @borrower_email, borrower_DOB = @borrower_DOB where borrower_id = @borrower_id";
                conn.Open();

                SqlCommand cmd = new SqlCommand(update, conn);
                cmd.Parameters.Add("@borrower_id", SqlDbType.Int);
                cmd.Parameters["@borrower_id"].Value = txtBorrowerId.Text;

                cmd.Parameters.Add("@borrower_name", SqlDbType.VarChar);
                cmd.Parameters["@borrower_name"].Value = txtBorrowerName.Text;

                cmd.Parameters.Add("@borrower_address", SqlDbType.VarChar);
                cmd.Parameters["@borrower_address"].Value = txtBorrowerAddress.Text;

                cmd.Parameters.Add("@borrower_phone", SqlDbType.VarChar);
                cmd.Parameters["@borrower_phone"].Value = txtBorrowerPhone.Text;

                cmd.Parameters.Add("@borrower_email", SqlDbType.VarChar);
                cmd.Parameters["@borrower_email"].Value = txtBorrowerEmail.Text;

                cmd.Parameters.Add("@borrower_DOB", SqlDbType.VarChar);
                cmd.Parameters["@borrower_DOB"].Value = dtBorrowerDOB.Value;

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    FillDataBorrowers();
                    ClearDataBorrowers();
                    MessageBox.Show(this, "Updated successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                    conn.Close();
                }
            }
        }

        private void btnBorrowerDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to delete ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Open();
                string delete = "delete from Borrowers where borrower_id = @borrower_id";

                SqlCommand cmd = new SqlCommand(delete, conn);
                cmd.Parameters.Add("@borrower_id", SqlDbType.Int);
                cmd.Parameters["@borrower_id"].Value = txtBorrowerId.Text;
                cmd.ExecuteNonQuery();

                FillDataBorrowers();
                ClearDataBorrowers();
                MessageBox.Show(this, "Deleted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                conn.Close();
            }
        }

        private void btnTicketAdd_Click(object sender, EventArgs e)
        {
            string bookID = cbTicketBook.SelectedValue.ToString();
            string borrowerID = cbTicketBorrower.SelectedValue.ToString();
            DateTime borrowerDate = dtTicketBorrowDate.Value;
            DateTime returnDate = dtTicketReturnDate.Value;

            
            string insert = "insert into Tickets(book_id, borrower_id, borrow_date, return_date) values(@book_id, @borrower_id, @borrow_date, @return_date)";
            conn.Open();
            SqlCommand cmd = new SqlCommand(insert, conn);
            cmd.Parameters.Add("@book_id", SqlDbType.Int);
            cmd.Parameters["@book_id"].Value = bookID;

            cmd.Parameters.Add("@borrower_id", SqlDbType.Int);
            cmd.Parameters["@borrower_id"].Value = borrowerID;

            cmd.Parameters.Add("@borrow_date", SqlDbType.DateTime);
            cmd.Parameters["@borrow_date"].Value = borrowerDate;

            cmd.Parameters.Add("@return_date", SqlDbType.DateTime);
            cmd.Parameters["@return_date"].Value = returnDate;

            cmd.ExecuteNonQuery();
            FillDataTickets();
            ClearDataTickets();
            conn.Close();
            MessageBox.Show(this, "Inserted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void dgvTicketList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTicketList.Rows[e.RowIndex];
                txtTicketId.Text = row.Cells["ticket_id"].Value.ToString();
                cbTicketBook.SelectedValue = row.Cells["book_id"].Value.ToString();
                cbTicketBorrower.SelectedValue = row.Cells["borrower_id"].Value.ToString();
                dtTicketBorrowDate.Value = (DateTime)row.Cells["borrow_date"].Value;
                dtTicketReturnDate.Value = (DateTime)row.Cells["return_date"].Value;
            }
        }

        private void btnTicketDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to delete ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Open();
                string delete = "delete from Tickets where ticket_id = @ticket_id";

                SqlCommand cmd = new SqlCommand(delete, conn);
                cmd.Parameters.Add("@ticket_id", SqlDbType.Int);
                cmd.Parameters["@ticket_id"].Value = int.Parse(txtTicketId.Text.ToString());
                cmd.ExecuteNonQuery();

                FillDataTickets();
                ClearDataTickets();
                MessageBox.Show(this, "Deleted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                conn.Close();
            }
        }

        private void btnTicketUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to edit ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string update = "update Tickets set book_id = @book_id, borrower_id = @borrower_id, borrow_date = @borrow_date, return_date = @return_date where ticket_id = @ticket_id";
                conn.Open();

                SqlCommand cmd = new SqlCommand(update, conn);
                cmd.Parameters.Add("@ticket_id", SqlDbType.Int);
                cmd.Parameters["@ticket_id"].Value = txtTicketId.Text;

                cmd.Parameters.Add("@book_id", SqlDbType.Int);
                cmd.Parameters["@book_id"].Value = (cbTicketBook.SelectedValue.ToString());

                cmd.Parameters.Add("@borrower_id", SqlDbType.Int);
                cmd.Parameters["@borrower_id"].Value = (cbTicketBorrower.SelectedValue.ToString());

                cmd.Parameters.Add("@borrow_date", SqlDbType.VarChar);
                cmd.Parameters["@borrow_date"].Value = dtTicketBorrowDate.Value;

                cmd.Parameters.Add("@return_date", SqlDbType.VarChar);
                cmd.Parameters["@return_date"].Value = dtTicketReturnDate.Value;

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    FillDataTickets();
                    ClearDataTickets();
                    MessageBox.Show(this, "Updated successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                    conn.Close();
                }
            }
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            GetAuthors();
            GetCategories();
            GetPublishers();
            GetBooks();
            GetBorrowers();
            FillDataBooks();
            FillDataTickets();
            FillDataBorrowers();
        }

        private void btnLogOut2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
                Login loginForm = new Login();
                loginForm.Show();
                this.Dispose();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
                Login loginForm = new Login();
                loginForm.Show();
                this.Dispose();
            }
        }

        private void btnLogOut1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
                Login loginForm = new Login();
                loginForm.Show();
                this.Dispose();
            }
        }

        private void tabPageTicket_Click(object sender, EventArgs e)
        {

        }

        private void tabPageBook_Click(object sender, EventArgs e)
        {

        }
    }
}
