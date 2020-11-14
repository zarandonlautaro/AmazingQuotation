using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazingQuotation
{
    abstract class Clothing
    {
        public abstract Boolean standard { set; get; }
        public abstract float price { set; get; }
        public abstract int quantity { set; get; }

        public abstract void GetClothe();
    }
}
