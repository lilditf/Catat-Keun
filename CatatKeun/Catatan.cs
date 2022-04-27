using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatatKeun
{
    class Catatan
    {
        private string id, nama, type, cat, jumlah;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }


        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Cat
        {
            get { return cat; }
            set { cat = value; }
        }

        public string Jumlah
        {
            get { return jumlah; }
            set { jumlah = value; }
        }
    }
}
