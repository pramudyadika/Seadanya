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
        public SearchPage()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Recipe recipe = new Recipe();
            recipe.Show();
            this.Hide();
        }
    }
}
