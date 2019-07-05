using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGroceryStore
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate a menu
            Menu menu = new Menu();
            menu.printMenu();

            //Process order Object to process each product that ordered by customer
            ProcessOrder processOrder = new ProcessOrder();

            //Ref Variable to hold shopping cart empty at the begining
            ShoppingCart shoppingCart = new ShoppingCart();

            //Variable to store product code and order Qty
            string code;
            int orderQuantity;

            Console.WriteLine("Do you want to continue (Y/N)");
            string option = Console.ReadLine();
                while(option.ToLower() != "n")
                {
                    Console.WriteLine("Enter Item Code");
                    code = Console.ReadLine().ToUpper();
                if (menu.checkItem(code))
                {
                    //Progress with order if product available
                    Console.WriteLine("Enter Order Quantity");
                    string inputQty = Console.ReadLine();
                    bool isConvertionSuccessfull = int.TryParse(inputQty, out orderQuantity);
                    if (isConvertionSuccessfull) {
                        //Check min order quantity
                        if (menu.checkOrderQty(code, orderQuantity))
                        {
                            //Send code and qty to process salesItem
                            List<SalesItems> salesItems = processOrder.processQuantity(code, orderQuantity);
                            //Add sales Item to the shopping cart
                            shoppingCart.addNewItem(salesItems);
                            //Ask more orders
                            Console.WriteLine("Do you want to buy more? (Y/N)");
                            string i = Console.ReadLine();
                            if(i.ToLower() == "y")
                            {
                                continue;
                            }else if (i.ToLower() == "n")
                            {
                                //Display reciept
                                shoppingCart.calculateTotalValue();
                                Console.WriteLine("Thank you");
                                option = "n";
                            }
                         
                        }
                        else
                        {
                            Console.WriteLine("Order Quantity should be grater than min order quantity");
                            continue;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Invalid Quantity");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Item Code");
                    continue;
                }
                
            }
            


            Console.ReadLine();

        }
    }
}
