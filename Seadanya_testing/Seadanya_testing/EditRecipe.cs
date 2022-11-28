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
    public partial class EditRecipe : Form
    {
        public EditRecipe()
        {
            InitializeComponent();
        }

        private void AddRecipe_Load(object sender, EventArgs e)
        {

        }

        private void btn_Batal_Click(object sender, EventArgs e)
        {
            SearchPage searchpage = new SearchPage();
            searchpage.Show();
            this.Hide();
        }
    }
}
