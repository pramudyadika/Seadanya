using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seadanya_testing
{
    public class recipeDetail
    {
        private string nama;
        private string desc;
        private string bahan;
        private string jumlah;
        private string step;
        private string image;
        public string Nama { get => nama; set => nama = value; }
        public string Desc { get => desc; set => desc = value; }
        public string Bahan { get => bahan; set => bahan = value; }
        public string Jumlah { get => jumlah; set => jumlah = value; }
        public string Step { get => step; set => step = value; }
        public string Image { get => image; set => image = value; }
    }
}
