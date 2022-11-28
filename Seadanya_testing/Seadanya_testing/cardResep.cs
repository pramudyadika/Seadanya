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
    public partial class cardResep : UserControl
    {
        public recipeDetail recipe;

        private string title;
        private string desc;
        private string image;
        public cardResep(recipeDetail rec)
        {
            InitializeComponent();
            recipe = rec;
        }

        public string Title { get => title; set { title = value; cardTitle.Text = value; } }
        public string Desc { get => desc; set { desc = value; cardDesc.Text = value; } }
        public string Image { get => image; set { image = value; } }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {
            Recipe _recipe = new Recipe(recipe);
            _recipe.Show();
            SearchPage.srchPage.Hide();
        }
    }
}
