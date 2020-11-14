using System.Collections;

namespace AmazingQuotation
{
    class ClothingStore
    {
        public string name { get; set; }
        public string address { get; set; }
        public ArrayList stock { get; set; }

        public ClothingStore(string name, string address, ArrayList stock)
        {
            this.name = name;
            this.address = address;
            this.stock = stock;
        }
    }
}
