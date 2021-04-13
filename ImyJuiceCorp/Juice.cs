using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ImyJuiceCorp
{
    class Juice
    {
        //required fields.
        private string name;
        private string flavor;
        private float prodCostPerLtr;
        private float sellingPrice;
        private float qtyAvailable;

        //Name property
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        //flavor property
        public string Flavor
        {
            get
            {
                return flavor;
            }

            set
            {
                flavor = value;
            }
        }

        //ProdCostPerLiter property.
        public float ProdCostPerLtr
        {
            get
            {
                return prodCostPerLtr;
            }
            set
            {
                prodCostPerLtr = value;
            }

        }

        //selling price property.
        public float SellingPrice
        {
            get
            {
                return sellingPrice;
            }
            set
            {
                sellingPrice = value;
            }
        }

        //Quantity property
        public float QtyAvailable
        {
            get
            {
                return qtyAvailable;
            }
            set
            {
                qtyAvailable = value;
            }
        }

        //class constructor
        public Juice(string name, string flavor, float prodCostPerLtr, float sellingPrice, float qtyAvailable)
        {
            this.name = name;
            this.flavor = flavor;
            this.prodCostPerLtr = prodCostPerLtr;
            this.sellingPrice = sellingPrice;
            this.qtyAvailable = qtyAvailable;
        }

        public float UpdateQuantity(int juiceIndex)
        {
            Console.WriteLine(" The current quantity is: " + this.QtyAvailable + " Liters..");
            Console.WriteLine(" How much have you added to the stock? ");
            var quantity = float.Parse(Console.ReadLine());
            this.qtyAvailable += quantity;
            Console.WriteLine("You have added " + quantity + " To the stock, the current stock is " + this.QtyAvailable + ", liters.");

            return quantity;
        }

        public float Sale(int juiceIndex)
        {
            Console.WriteLine("It costed " + this.ProdCostPerLtr + " ugx to produce each unit of " + this.Name);
            Console.WriteLine("Currently, there are: " + this.QtyAvailable + " Units, how many would you love to sell? Each sales at "+
                this.SellingPrice);
            var salesQty = float.Parse(Console.ReadLine());
            var prodCost = salesQty * this.ProdCostPerLtr;
            Console.WriteLine(" It costed the company " + prodCost + " ugx, to produce those units.");
            //calculate the total price in the sale:
            var totalSales = this.SellingPrice * salesQty;
            //Calculate the profit from the sale:
            var profit = totalSales - prodCost;
            Console.WriteLine(" The profit made from the sale is: " + profit);
            this.qtyAvailable -= salesQty;
            Console.WriteLine(" You have sold "+ salesQty + " of "+ this.Name + " and the balance is " + this.qtyAvailable);

            return totalSales;
        }

        public void Manufacture()
        {
            string line;
            try
            {
                StreamReader formular = new StreamReader("D:\\Babirye###\\ImyJuiceCorp\\Formular1.txt");
                line = formular.ReadLine();

                while (line != null)
                {
                    //Print the line on the console.
                    Console.WriteLine(line);
                    //continue to read.
                    line = formular.ReadLine();
                }
                formular.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.Message);
                throw;
            }
            finally
            {
                Console.WriteLine("Done reading the formular.");
            }
        }

    }
}
