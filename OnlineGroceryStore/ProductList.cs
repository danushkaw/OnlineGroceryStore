using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryStore
{

    // This is a singleton class which is one instance available for entire programe
    // Assumptions: each product has min order qty
    // Each product has fix amount of pack sizes as given in description E.g Ham has only 2 sizes not more than that 
   public sealed class  ProductList
    {

        private List<Product> itemList;
        private static ProductList instance = null;


        // Invoke or read the product list when initialize  
        private ProductList()
        {
            Product slicedHam = new Product("SH3","Sliced Ham",3);
            slicedHam.addPackSize(3,2.99);
            slicedHam.addPackSize(5, 4.49);

            Product yoghurt = new Product("YT2", "Yoghurt ", 4);
            yoghurt.addPackSize(4, 4.95);
            yoghurt.addPackSize(10, 9.95);
            yoghurt.addPackSize(15, 13.95);

            Product toiletRolls = new Product("TR", "Toilet Rolls",3);
            toiletRolls.addPackSize(3,2.95);
            toiletRolls.addPackSize(5, 4.45);
            toiletRolls.addPackSize(9, 7.99);


            //Add products to the item list
            itemList = new List<Product>();
            itemList.Add(slicedHam);
            itemList.Add(yoghurt);
            itemList.Add(toiletRolls);    
        }


        //get singleton instance of productList
        public static ProductList getIstance
        {
            get {
                if (instance == null)         
                    instance = new ProductList();
                    return instance;             
            }
        }
        // Return all available products
        public List<Product> getItemList()
        {
            return this.itemList;
        }





    }
}
