using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazingQuotation
{
    class Pants : Clothing
    {
        public Boolean commons { get; set; }
        public override bool standard { get; set; }
        public override float price { get; set; }
        public override int quantity { get; set; }

        public Pants(bool commons, int quantity)
        {
            this.commons = commons;
            this.quantity = quantity;
        }

        public override void GetClothe()
        {
            Console.WriteLine("PANTALON: " + commons + " " + standard + price + quantity);
        }
    }
}
