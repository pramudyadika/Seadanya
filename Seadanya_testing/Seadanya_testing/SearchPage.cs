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
    public partial class SearchPage : Form
    {
        public static SearchPage srchPage;
        List<recipeDetail> recipes;
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=seadanyajunpro";
        private string sql;
        static NpgsqlCommand cmd;
        public SearchPage()
        {
            InitializeComponent();
            conn = new NpgsqlConnection(connstring);
            var recipes = getRecipes();
            getCard(recipes);
        }
        private List<recipeDetail> getRecipes()
        {
            var recipes = new List<recipeDetail>();
            try
            {
                conn.Open();
                sql = "select * from getResep()";
                cmd = new NpgsqlCommand(sql, conn);
                var data = cmd.ExecuteReader();
                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        var rec = new recipeDetail
                        {
                            Nama = data[0].ToString(),
                            Desc = data[1].ToString(),
                            Bahan = data[2].ToString(),
                            Jumlah = data[3].ToString(),
                            Step = data[4].ToString(),
                            Image = data[5].ToString()
                        };
                        recipes.Add(rec);
                    }
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return recipes;
        }

        private void getCard(List<recipeDetail> recipes)
        {
            cardResep[] card = new cardResep[recipes.Count];
            flowCard.Controls.Clear();
            for(int i = 0; i< card.Length; i++)
            {
                card[i] = new cardResep(recipes[i]);
                card[i].Title = recipes[i].Nama;
                card[i].Desc = recipes[i].Desc;
                card[i].Image = recipes[i].Image;

                flowCard.Controls.Add(card[i]);
            }
        }

        private void SearchPage_Load(object sender, EventArgs e)
        {
            srchPage = this;
        }
    }
}
