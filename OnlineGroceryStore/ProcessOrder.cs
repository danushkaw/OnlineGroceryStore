using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryStore
{
    public class ProcessOrder
    {
        private ProductList pList;
        //List to store processed items
        private List<SalesItems> itemsList = new List<SalesItems>();

        //Ready with ProductList when initialize
        public ProcessOrder()
        {
            this.pList = ProductList.getIstance;
        }

        //This method process the individucal product and its ordered quantity and make it as SalesItem object
        //Break down the total order qunatity
        public List<SalesItems> processQuantity(string code, int orderQty)
        {

            //Initialise salesItemsList 
            itemsList = new List<SalesItems>();
            //Search ProductList(pList) for ordered product get it's pack sizes and item value
            foreach (Product p in pList.getItemList())
            {
                if (p.getCode() == code)
                {
                    //Read pack size and prize 
                    List<KeyValuePair<int, double>> packSizedata = p.getPackDetails();
                    //Sort List DESC
                    packSizedata.Sort((x, y) => (y.Key.CompareTo(x.Key)));
                    //Hold curent order quantiry
                    int qty = orderQty;
                    //Count checked packsizes
                    //foreach (KeyValuePair<int, double> pk in packSizedata)
                    for(int counter=0; counter<packSizedata.Count; counter++ )
                    {                   
                                             
                        // Calculate no of packs based on pack size
                        int noOfPacks = qty / packSizedata[counter].Key;
                        // set new quantity
                        qty = qty - (packSizedata[counter].Key * noOfPacks);
                        if (noOfPacks >= 1)
                        {
                            //Create SalesItem and store in shopping cart array
                            SalesItems salesItem = new SalesItems(code, noOfPacks, packSizedata[counter].Key, ((packSizedata[counter].Value) * noOfPacks) );
                            itemsList.Add(salesItem);
                        }
                    }
                }
            }
            return this.itemsList;
        }













    }
}
