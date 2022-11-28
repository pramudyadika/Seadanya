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
        public recipeDetail recipe;

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
            Recipe _recipe = new Recipe(recipe);
            _recipe.Show();
            this.Hide();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SearchPage searchpage = new SearchPage();
            searchpage.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Recipe _recipe = new Recipe(recipe);
            _recipe.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Recipe _recipe = new Recipe(recipe);
            _recipe.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Recipe _recipe = new Recipe(recipe);
            _recipe.Show();
            this.Hide();
        }
    }
}
