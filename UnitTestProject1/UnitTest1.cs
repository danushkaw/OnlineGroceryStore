using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineGroceryStore;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            //inputs
            string[] codes = new string[] {"sh3","tr","yt2" };
            int[] orderQuantity = new int[] { 12, 23, 15 };
            ProcessOrder p = new ProcessOrder();
            List<List<SalesItems>> itemsInCart = new List<List<SalesItems>>();
        //Outputs
        SalesItems sh = new SalesItems("sh", 2, 5, 8.98);
            SalesItems tr = new SalesItems("tr", 2, 9, 15.98);
            SalesItems tr2 = new SalesItems("tr", 1, 5, 4.45);
            SalesItems yt2 = new SalesItems("yt2", 1, 15, 43.36);
            //Hold expected outpun in a list
            List<SalesItems> expectedItems = new List<SalesItems>();
            expectedItems.Add(sh);
            expectedItems.Add(tr);
            expectedItems.Add(tr2);
            expectedItems.Add(yt2);

            List<SalesItems> testItems = new List<SalesItems>();

            double x;
            //Act
            for (int i=0; i<codes.Length; i++) {

                List<SalesItems> salesItems = p.processQuantity(codes[i], orderQuantity[i]);
                foreach(SalesItems s in salesItems)
                {
                    testItems.Add(s);
                }
                                   
            }

            //Assert Compare two salesItemLists
            IEnumerable<SalesItems> list3;
            list3 = expectedItems.Except(testItems);
            foreach (SalesItems result in list3)
            {
                Console.WriteLine(result);
            }

        }
    }
}
