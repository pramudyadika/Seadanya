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
    public partial class flowPanel : Form
    {
        public flowPanel()
        {
            InitializeComponent();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Add(new Button() { Text = "Button Coba" });
            flowLayoutPanel1.Controls.Add(new Button() { Text = "test" });
            flowLayoutPanel1.Controls.Add(new Button() { Text = "1" });
        }
    }
}
