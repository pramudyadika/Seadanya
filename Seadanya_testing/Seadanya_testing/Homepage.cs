using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Seadanya_testing
{
    public partial class Homepage : Form
    {
        public static Homepage home;
        public recipeDetail recipe;
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=seadanyajunpro";
        private string sql;
        static NpgsqlCommand cmd;

        /*        private string title;
                private string desc;
                private string image;*/
        public Homepage()
        {
            InitializeComponent();
        }

        private void txtBoxSearchBar_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelSearchTags_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            getByName("Pisang Kukus");
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SearchPage searchpage = new SearchPage();
            searchpage.Show();
            this.Hide();
        }

        private void getByName(string name)
        {
            recipeDetail rec = new recipeDetail();
            try
            {
                conn.Open();
                sql = "select * from resep where resep.nama_resep = :_name";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_name", name);
                var data = cmd.ExecuteReader();
                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        rec = new recipeDetail
                        {
                            Nama = data[0].ToString(),
                            Desc = data[1].ToString(),
                            Bahan = data[2].ToString(),
                            Jumlah = data[3].ToString(),
                            Step = data[4].ToString(),
                            Image = data[5].ToString()
                        };
                    }
                }
                Recipe _recipe = new Recipe(rec);
                _recipe.Show();
                this.Hide();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                conn.Close();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            getByName("Telur Ceplok");   
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            getByName("Omelet Mie");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            getByName("Roti Bakar Kornet");
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            home = this;
        }
    }
}
