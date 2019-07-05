using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryStore
{
    
   public class ShoppingCart
    {
        //Shopping cart List holds lists of Sales items
        private List<List<SalesItems>> itemsInCart = new List<List<SalesItems>>();


        //Add new Item to the shopping cart
        public void addNewItem(List<SalesItems> s)
        {
            itemsInCart.Add(s);
        }


        // Calculate total value of shopping cart
        //Dispaly reciept
        public void calculateTotalValue()
        {
            double totalAmount=0.0;
            foreach(List<SalesItems> cartElement in itemsInCart)
            {
                foreach (SalesItems item in cartElement) {
                    totalAmount += item.getItemValue();
                    Console.WriteLine(item.ToString());
                }
            }
            Console.WriteLine("Total Amount = " + totalAmount + "");
        }

    }
}
