using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousesObjectsAndFields
{
    public class koli
    {
        //create a blueprint for a house object
        //non-static or instance fields
        public string brand = "";
        public string model = "";
        public int numberOfCars = 0;
        public int price = 0;

        //static field
        public static int CarTypesForSale = 0;
        public static int TotalCarsForSale = 0;

    }
    class Program
    {
        static void Main(string[] args)
        {
      
            koli.CarTypesForSale = 0;
            koli.TotalCarsForSale = 0;


     
            koli kola1 = new koli();
            kola1.brand = "Audi";
            kola1.model = "R8";
            kola1.numberOfCars = 3;
            kola1.price = 400000;

            koli.CarTypesForSale++;
            koli.TotalCarsForSale += kola1.numberOfCars;

            koli kola2 = new koli();
            kola2.brand = "BMW";
            kola2.model = "X6";
            kola2.numberOfCars = 8;
            kola2.price = 100000;

            koli.CarTypesForSale++;
            koli.TotalCarsForSale += kola2.numberOfCars;

            koli kola3 = new koli();
            kola3.brand = "Mazda";
            kola3.model = "rx6";
            kola3.numberOfCars = 13;
            kola3.price = 70000;

            koli.CarTypesForSale++;
            koli.TotalCarsForSale += kola3.numberOfCars;


            Console.WriteLine("These are the details of the cars on our dealership:");
            Console.WriteLine();
            Console.WriteLine(kola1.brand + "\n Model: {0}\n Quantity of this model: {1}\n Price: £{2:N0}", kola1.model,  kola1.numberOfCars, kola1.price); 
            Console.WriteLine();
            Console.WriteLine(kola2.brand + "\n Model: {0}\n Quantity of this model: {1}\n Price: £{2:N0}", kola2.model, kola2.numberOfCars, kola2.price);
            Console.WriteLine();
            Console.WriteLine(kola3.brand + "\n Model: {0}\n Quantity of this model: {1}\n Price: £{2:N0}", kola3.model, kola3.numberOfCars, kola3.price);
            //Console.WriteLine(kola3.brand + "\n Model: " + kola3.model + "\n Quantity of this model: " + kola3.numberOfCars + "\n Price: £" + kola3.price);
            // upper line is for the just without the £ symbol and the , between the price

            Console.WriteLine();
            Console.WriteLine("Types of cars that we sell: " + koli.CarTypesForSale + "\nTotal quantity of all cars that we have: " + koli.TotalCarsForSale);
        }
    }
}
