using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazingQuotation
{
    class Shirts : Clothing
    {
        public Boolean shortSleeve { get; set; }
        public Boolean maoNeck { get; set; }
        public override bool standard { get; set; }
        public override float price { get; set; }
        public override int quantity { get; set; }

        public Shirts(bool shortSleeve, bool maoNeck, int quantity)
        {
            this.shortSleeve = shortSleeve;
            this.maoNeck = maoNeck;
            this.quantity = quantity;
        }

        public override void GetClothe()
        {
            Console.WriteLine("REMERA: " + shortSleeve + " " + standard + price + quantity);
        }
    }
}
