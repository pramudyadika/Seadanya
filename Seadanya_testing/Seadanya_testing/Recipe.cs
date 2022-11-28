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
    public partial class Recipe : Form
    //public class Recipe : Form
    {
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=seadanyajunpro";
        private string sql;
        static NpgsqlCommand cmd;
        private recipeDetail recipe;
        public Recipe(recipeDetail recipe)
        {
            InitializeComponent();
            this.recipe = recipe;
            lbTitle.Text = recipe.Nama;
            lbDesc.Text = recipe.Desc;
            lbBahan.Text = recipe.Jumlah;
            lbLangkah.Text = recipe.Step;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            SearchPage srchPage = new SearchPage();
            srchPage.Show();
            this.Hide();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            EditRecipe editrecipe = new EditRecipe();
            editrecipe.Show();
            this.Hide();
        }

        private void isidetailresep1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Batal_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = "select * from deleteResep(:_nama)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_nama", recipe.Nama);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("data berhasil dihapus");
                    this.Dispose();
                    SearchPage.srchPage.Show();
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
                conn.Close();
            }
        }

        private void Recipe_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void backSearch(object sender, FormClosedEventArgs e)
        {
            SearchPage.srchPage.Show();
        }

        /*private void getRecipe(object sender, EventArgs e)
        {
            isidetailresep card = new isidetailresep();
            flowCard.Controls.Clear();
            for (int i = 0; i < card.Length; i++)
            {
                card[i] = new cardResep(recipes[i]);
                card[i].Title = recipes[i].Nama;
                card[i].Desc = recipes[i].Desc;
                card[i].Image = recipes[i].Image;

                flowCard.Controls.Add(card[i]);
            }
        }*/


    }
}
