using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace Seadanya_testing
{
    public partial class SignUp : Form
    {
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=seadanyajunpro";


        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql;

        public SignUp()
        {
            InitializeComponent();
        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            if(tb_Email.Text != "" && tb_Password.Text != "" && tb_Username.Text != "")
            {
                try
                {
                    conn.Open();
                    sql = @"select * from signup(:_email_user,:_uname_user,:_pw_user)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_email_user", tb_Email.Text);
                    cmd.Parameters.AddWithValue("_uname_user", tb_Username.Text);
                    cmd.Parameters.AddWithValue("_pw_user", tb_Password.Text);
                    if ((int)cmd.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Sign Up Berhasil!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error = " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lengkapi Data!");
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }
    }
}
