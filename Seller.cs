using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazingQuotation
{
    class Seller
    {
        public int id_seller { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }

        public Seller(int id_seller, string name, string lastname)
        {
            this.id_seller = id_seller;
            this.name = name;
            this.lastname = lastname;
        }
    }
}
