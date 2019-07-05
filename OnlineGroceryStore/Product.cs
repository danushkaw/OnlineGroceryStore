using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryStore
{
   public class Product
    {
        private string code;
        private string name;
        private int minQty;
        private List<KeyValuePair<int,double>> packSizes;

        public Product(string code, string name, int minQty)
        {
            this.code = code;
            this.name = name;
            this.minQty = minQty;
            //Initialize the ArrayList to store pack size and price
            packSizes = new List<KeyValuePair<int, double>>();
        }

        // Add new pack size
        public void addPackSize(int size, double price)
        {
            packSizes.Add(new KeyValuePair<int, double>(size, price));
        }

        // Get details of pack sizes
        public List<KeyValuePair<int, double>> getPackDetails()
        {
            return this.packSizes;
        }

        // Get minimum order qunitity
        public int getMinQty()
        {
            return this.minQty;
        }
        //Get product's base details
        public override string ToString()
        {
            return code + "\t" + name + "\t" + minQty;
        }

        //Get product code
        public  string getCode()
        {
            return this.code;
        }

        //Get product code
        public int minOrder()
        {
            return this.minQty;
        }
    }
}
