using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Seadanya_testing
{
    public partial class Login : Form
    {
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=seadanyajunpro";

        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql;

        public Login()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {


            if (tb_Username.Text != "" && tb_Password.Text != "")
            {
                try
                {
                    conn.Open();
                    sql = "select * from reguser where uname_user=@uname_user and pw_user =@pw_user";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@uname_user", tb_Username.Text);
                    cmd.Parameters.AddWithValue("@pw_user", tb_Password.Text);
                    NpgsqlDataAdapter adapt = new NpgsqlDataAdapter(cmd);
                    dt = new DataTable();
                    adapt.Fill(dt);
                    int i = cmd.ExecuteNonQuery();
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Login Sukses!");
                        conn.Close();
                        Homepage homepage = new Homepage();
                        homepage.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Pastikan Username dan Password telah benar!");
                        conn.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error = " + ex.Message);
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Mohon Masukan Username dan Password");
                conn.Close();
            }
            conn.Close();
        }

        private void lbl_SignUp_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            signup.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }
    }
}
