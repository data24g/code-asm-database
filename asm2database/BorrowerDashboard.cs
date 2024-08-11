using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class BorrowerDashboard : Form
    {
        private SqlConnection conn = new SqlConnection("server = LAPTOP-3E9R2QCF\\ADMIN; database = LibraryManagement2; integrated security = true");

        public BorrowerDashboard()
        {
            InitializeComponent();
        }

        public BorrowerDashboard(string username)
        {
            InitializeComponent();

            MessageBox.Show("Welcome " + username);
        }

        public void GetAuthors()
        {
            string query = "select author_id, author_name from Authors";
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(table);
            cbBookAuthor.DataSource = table;
            cbBookAuthor.DisplayMember = "author_name";
            cbBookAuthor.ValueMember = "author_id";
        }

        public void GetCategories()
        {
            string query = "select category_id, category_name from Categories";
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(table);
            cbBookCategory.DataSource = table;
            cbBookCategory.DisplayMember = "category_name";
            cbBookCategory.ValueMember = "category_id";
        }

        public void GetPublishers()
        {
            string query = "select publisher_id, publisher_name from Publishers";
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(table);
            cbBookPublisher.DataSource = table;
            cbBookPublisher.DisplayMember = "publisher_name";
            cbBookPublisher.ValueMember = "publisher_id";
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
            dgvBookList.DataSource = table;
        }

        public void ClearDataBooks()
        {
            txtBookId.Text = "";
            txtBookName.Text = "";
            cbBookAuthor.Text = "";
            cbBookCategory.Text = "";
            cbBookPublisher.Text = "";
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

        private void dgvBookList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBookList.Rows[e.RowIndex];
                txtBookId.Text = row.Cells["book_id"].Value.ToString();
                txtBookName.Text = row.Cells["book_name"].Value.ToString();
                cbBookAuthor.SelectedValue = row.Cells["author_id"].Value.ToString();
                cbBookPublisher.SelectedValue = row.Cells["category_id"].Value.ToString();
                dtBookPublishDate.Value = (DateTime)row.Cells["publishing_date"].Value;
            }
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

        private void cbBookAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtBookName.Text;
            string authorID = cbBookAuthor.SelectedValue.ToString();
            string categoryID = cbBookCategory.SelectedValue.ToString();
            string publisherID = cbBookPublisher.SelectedValue.ToString();
            DateTime publishingDate = dtBookPublishDate.Value;

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
            MessageBox.Show(this, "Inserted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to edit ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string update = "update Books set book_name = @book_name, author_id = @author_id, category_id = @category_id, publisher_id = @publisher_id, publishing_date = @publishing_date where book_id = @book_id";
                conn.Open();

                SqlCommand cmd = new SqlCommand(update, conn);
                cmd.Parameters.Add("@book_id", SqlDbType.Int);
                cmd.Parameters["@book_id"].Value = txtBookId.Text;

                cmd.Parameters.Add("@book_name", SqlDbType.VarChar);
                cmd.Parameters["@book_name"].Value = txtBookName.Text;

                cmd.Parameters.Add("@author_id", SqlDbType.Int);
                cmd.Parameters["@author_id"].Value = (cbBookAuthor.SelectedValue.ToString());

                cmd.Parameters.Add("@category_id", SqlDbType.Int);
                cmd.Parameters["@category_id"].Value = (cbBookCategory.SelectedValue.ToString());

                cmd.Parameters.Add("@publisher_id", SqlDbType.Int);
                cmd.Parameters["@publisher_id"].Value = (cbBookPublisher.SelectedValue.ToString());

                cmd.Parameters.Add("@publishing_date", SqlDbType.VarChar);
                cmd.Parameters["@publishing_date"].Value = dtBookPublishDate.Value;

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show(this, "Do you want to delete ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    string delete = "delete from Borrowers where borrower_id = @borrower_id";

                    SqlCommand cmd = new SqlCommand(delete, conn);
                    cmd.Parameters.Add("@borrower_id", SqlDbType.Int);
                    cmd.Parameters["@borrower_id"].Value = txtBookId.Text;
                    cmd.ExecuteNonQuery();

                    FillDataBorrowers();
                    ClearDataBorrowers();
                    MessageBox.Show(this, "Deleted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                    conn.Close();
                }
            }
        }

        private void BorrowerDashboard_Load(object sender, EventArgs e)
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

        private void dgvBookList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBookList.Rows[e.RowIndex];
                txtBookId.Text = row.Cells["book_id"].Value.ToString();
                txtBookName.Text = row.Cells["book_name"].Value.ToString();
                cbBookAuthor.SelectedValue = row.Cells["author_id"].Value.ToString();
                cbBookPublisher.SelectedValue = row.Cells["category_id"].Value.ToString();
                dtBookPublishDate.Value = (DateTime)row.Cells["publishing_date"].Value;
            }
        }
        public void FillDataBorrowers()
        {
            string query = "select * from Borrowers";
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(table);
            dgvBookList.DataSource = table;
        }
        public void ClearDataBorrowers()
        {
            txtBookId.Text = "";
            txtBookName.Text = "";
           
        }

        private void btnTickAdd_Click(object sender, EventArgs e)
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

        private void btnTickUpdate_Click(object sender, EventArgs e)
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

        private void btnTickDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to delete ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Open();
                string delete = "delete from Tickets where ticket_id = @ticket_id";

                SqlCommand cmd = new SqlCommand(delete, conn);
                
                cmd.Parameters["@ticket_id"].Value = int.Parse(txtTicketId.Text.ToString());
                cmd.ExecuteNonQuery();

                FillDataTickets();
                ClearDataTickets();
                MessageBox.Show(this, "Deleted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                conn.Close();
            }
        }

        private void btnClearTick_Click(object sender, EventArgs e)
        {
            ClearDataTickets();
        }

        private void dgvTicketList_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                cmd.Parameters["@ticket_id"].Value = txtTicketId.Text;
                cmd.ExecuteNonQuery();

                FillDataTickets();
                ClearDataTickets();
                MessageBox.Show(this, "Deleted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                conn.Close();
            }
        }
    }
    }
