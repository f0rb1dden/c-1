using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoliObjectsAndFields
{
    public class koli
    {

        //create a blueprint for a house object
        //non-static or instance fields
        public string brand = "";
        public string model = "";
        public int price = 0;
        public bool sold = false;

        //static field
        public static int CarTypesForSale = 0;
        public static int TotalCarsForSale = 0;

        public void AddDetailsOfKoli(string brand, int price)
        {
            this.brand = brand;
            this.price = price;
            this.sold = false;
            CarTypesForSale++;
        }
        public void DisplayCars()
        {
            Console.WriteLine("Brand: {0} model {3} numberOfCars {1} price{2} ", brand, price, model );
            if (sold)
            {
                Console.WriteLine("This Car has been sold.");
            }
            else
            {
                Console.WriteLine("This Car is available to buy.");
            }
            Console.WriteLine();

        }
        public void Sellkoli(int price)
        {
            this.sold = true;
            this.price = price;

            CarTypesForSale--;

            Console.WriteLine("The brand at {0} has been sold for £{1:N0}.", this.brand, this.price);
            Console.WriteLine();
        }
        public static void DisplayAllkoli(List<koli> koliList)
        {
            int totalValueSold = 0;
            int totalValueAvailable = 0;

            Console.WriteLine("The details of the cars on our books are: ");
            Console.WriteLine();
            //go through the houses list, displaying details and calculating totals
            foreach (koli item in koliList)
            {

                Console.WriteLine("Brand: {0} \n No. Model {1}\n Price: £{2:N0}.", item.brand,  item.price);  //:N0 formats the number
                if (item.sold)
                {
                    Console.WriteLine("This house has been sold.");
                    totalValueSold += item.price;
                }
                else
                {
                    Console.WriteLine("This car is available to buy.");
                    totalValueAvailable += item.price;
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            //display summary data
            Console.WriteLine("The total number of cars for sale is: " + koli.CarTypesForSale);
            Console.WriteLine();
            Console.WriteLine("The total value of cars sold is: £{0:N0}.", totalValueSold);
            Console.WriteLine("The total value of cars available is: £{0:N0}.", totalValueAvailable);
            Console.WriteLine();
        }

    

}
    class Program
    {
        static void Main(string[] args)
        {

            koli.CarTypesForSale = 0;
            koli.TotalCarsForSale = 0;
            List<koli> koliList = new List<koli>();



            koli kola1 = new koli();
            kola1.brand = "Audi";
            kola1.model = "R8";

            kola1.price = 400000;
            koli.CarTypesForSale++;

            koli kola2 = new koli();
            kola2.brand = "BMW";
            kola2.model = "X6";
            kola2.price = 100000;

            koli.CarTypesForSale++;

            koli kola3 = new koli();
            kola3.brand = "Mazda";
            kola3.model = "rx6";
            kola3.price = 70000;

            koli.CarTypesForSale++;
            koli.DisplayAllkoli(koliList);
            kola1.Sellkoli(400000);
            koli.DisplayAllkoli(koliList);




            Console.WriteLine("These are the details of the cars on our dealership:");
            Console.WriteLine();
            Console.WriteLine(kola1.brand + "\n Model: {0}\n Quantity of this model: {1}\n Price: £{2:N0}", kola1.model, kola1.price);
            Console.WriteLine();
            Console.WriteLine(kola2.brand + "\n Model: {0}\n Quantity of this model: {1}\n Price: £{2:N0}", kola2.model, kola2.price);
            Console.WriteLine();
            Console.WriteLine(kola3.brand + "\n Model: {0}\n Quantity of this model: {1}\n Price: £{2:N0}", kola3.model, kola3.price);
            //Console.WriteLine(kola3.brand + "\n Model: " + kola3.model + "\n Quantity of this model: " + kola3.numberOfCars + "\n Price: £" + kola3.price);
            // upper line is for the just without the £ symbol and the , between the price

            Console.WriteLine();
            Console.WriteLine("Types of cars that we sell: " + koli.CarTypesForSale + "\nTotal quantity of all cars that we have: " + koli.TotalCarsForSale);
        }
    }
}
