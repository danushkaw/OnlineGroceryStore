using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryStore
{
   public class Menu
    {
        private ProductList menuItems;


        public Menu()
        {
            this.menuItems = ProductList.getIstance;
        }



        //Check Item avaialbility for order
        public bool checkItem(string code)
        {
            bool isavailable = false;
            foreach (Product p in menuItems.getItemList())
            {
                if (code == p.getCode())
                
                    isavailable = true;              
            }
            return isavailable;
        }

        //Check order grater than min order Qunatity
        public bool checkOrderQty(string code, int qty)
        {
            bool isGraterThanMinQty = false;
            foreach (Product p in menuItems.getItemList())
            {
                if ((p.getCode() == code) && (p.getMinQty() <= qty))

                    isGraterThanMinQty = true;
            }
            return isGraterThanMinQty;

        }


        public void printMenu()
        {
            Console.WriteLine("Welcome To Online Grocery Store");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Code"+"\t"+"Name"+"\t"+"Min Order");
            foreach (Product p in menuItems.getItemList())
            {
                Console.WriteLine(p.ToString());
            }
        }






    }
}
