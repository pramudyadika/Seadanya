using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seadanya_testing
{
    internal class recipeDetail
    {
        private string _nama;
        private string[] _bahan;
        private string[] _langkah;
        private string _link;
        private string[] _tags;

        public string Nama { get => _nama; set => _nama = value; }
        public string[] Bahan { get => _bahan; set => _bahan = value; }
        public string[] Langkah { get => _langkah; set => _langkah = value; }
        public string Link { get => _link; set => _link = value; }
        public string[] Tags { get => _tags; set => _tags = value; }
    }
}
