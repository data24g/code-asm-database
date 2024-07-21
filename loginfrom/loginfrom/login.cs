using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginfrom
{
    public partial class login : Form
    {
        SqlConnection conn;
        public login()
        {
            InitializeComponent();
            conn = new SqlConnection("Server= DESKTOP-FPBPTF7\\SQLEXPRESS; Database=product_management; Integrated security = true;");
        }

        public login(string username)
        {
            InitializeComponent();
            conn = new SqlConnection("Server= DESKTOP-FPBPTF7\\SQLEXPRESS; Database=product_management; Integrated security = true;");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show(this, "do you want exit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtname.Text;
            string password = txtpass.Text;
            string query = "select * from account where usename =@username and u_password = pass";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@username", SqlDbType.VarChar);
            cmd.Parameters["@username"].Value = username;
            cmd.Parameters.AddWithValue("@password", SqlDbType.VarChar);
            cmd.Parameters["@username"].Value = password;
            SqlDataReader reader = cmd.ExecuteReader(); //tim cach fix loi khi chay
            if (reader.Read())
            {
                if (reader.Equals("admin"))
                {
                    MessageBox.Show(this, "login succsessful", "result", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Hide();
                    login p = new login(username);
                    p.ShowDialog();
                    this.Dispose();
                }
                /*else*/
                if (reader.Equals("user")) // chỉnh xong phần trên thì đổi if thành else if
                {
                    MessageBox.Show(this, "login succsessful", "result", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Hide();
                    login vp = new login(username);
                    vp.ShowDialog();
                    this.Dispose();
                }
                else
                {
                    /*lblError.text = " you are not allowed to access"*/
                    MessageBox.Show("you are not allowed to access");
                }
            }
            else
            {
                MessageBox.Show("you are not allowed to access");
            }
            conn.Close();
        }


        private void login_Load(object sender, EventArgs e)
        {
            // kiem tra ket noi voi database
           /* conn.Open();
            MessageBox.Show("Ket noi thanh cong");
            conn.Close();*/
        }
    }
}
