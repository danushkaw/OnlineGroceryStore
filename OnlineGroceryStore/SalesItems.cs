using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryStore
{
    //This class holds the each line of shopping cart (Group of items in specific pack size)
    //E.g. 2 pack of yogurt pack size of 3
   public class SalesItems
    {
        private string code;
        private int noOfpacks; // No of packs from specific packsize.
        private int packSize;
        private double itemValue; // product value * no of packs

        public SalesItems() { }

       public SalesItems(string code, int noOfpacks, int packSize, double itemValue )
        {
            this.code = code;
            this.noOfpacks = noOfpacks;
            this.packSize = packSize;
            this.itemValue = itemValue;
        }

        //Get Item value
        public double getItemValue()
        {
            return itemValue;
        }

        // Get details
        public override string ToString()
        {
            return ""+code+"\t"+noOfpacks+" x "+packSize+" = "+itemValue+"";
        }
    }
}
