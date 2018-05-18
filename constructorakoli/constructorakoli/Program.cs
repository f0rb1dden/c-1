using System;
using System.Collections.Generic;

namespace CarSalesStaticMethods
{
    class Car
    {
        public string make;
        public string model;
        public string doors;
        public int price;
        public Boolean sold;

        public static int numberOfCars;

        public Car(string make, string model, int price)
        {
            // v purvia constructor slagam novia opcia ---this.doors ="4"; i ne zabravqi gore da slojish public string: doors;
            // DO DOWN
    
            this.make = make;
            this.model = model;
            this.price = price;
            this.sold = false;
            this.doors = "4";
            Car.numberOfCars++;
        }
        public Car(string make, string model, int price, string doors)
        {
            this.make = make;
            this.model = model;
            this.price = price;
            this.sold = false;
            this.doors = doors;           
            Car.numberOfCars++;
        }

        public void ListCar()
        {
            //display details for an individual car
            Console.WriteLine("The details of this car are: ");
            //Tyka ne zabravqi da slojish novia string (doors)
            Console.Write("Make and model: {0} {1}, price: £{2:N0}.", make, model, price, doors);  //:N0 formats the number
            if (sold)
            {
                Console.WriteLine("This car has been sold.");
            }
            else
            {
                Console.WriteLine("This car has not yet been sold.");
            }
            Console.WriteLine();
        }

        //record the sale of a car
        public void Sold(bool isSold, int price)
        {
            this.sold = isSold;
            this.price = price;
            //adjust the number of cars
            Car.numberOfCars--;
        }

        //list all the cars
        public static void ListAllCars(List<Car> allCars)
        {
            int totalValueSold = 0;
            int totalValueInStock = 0;

            foreach (Car item in allCars)
            {
                Console.WriteLine("The details of this car are: ");
                //Tuka sushto trqq da slojish novata opcia sushto taka v "da napishesh doors i placehooldera {3}"
                Console.Write("Make and model: {0} {1}, price: £{2:N0}, doors: {3}", item.make, item.model, item.price, item.doors);  //:N0 formats the number
                if (item.sold)
                {
                    Console.WriteLine("This car has been sold.");
                    totalValueSold += item.price;
                }
                else
                {
                    Console.WriteLine("This car is unsold.");
                    totalValueInStock += item.price;
                }
                Console.WriteLine();
            }
            Console.WriteLine("The total value of cars sold is: £{0:N0}.", totalValueSold);
            Console.WriteLine("The total value of cars still in stock is: £{0:N0}.", totalValueInStock);
            Console.WriteLine();
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> allCars = new List<Car>();

            Car.numberOfCars = 0;
            Car car1 = new Car("RollsRoyce", "Silver Cloud", 35000);
            //Tuka nad vsqka kola trqq da slojish v skobite tva ot doly za da trugnat dvata konstruktora.
            //add cars
            //Car car1 = new Car();
            //car1.Car("RollsRoyce", "Silver Cloud", 35000);
            allCars.Add(car1);

            Car car2 = new Car("Aston Martin", "DB5", 750000);
            //car2.Car("Aston Martin", "DB5", 750000);
            allCars.Add(car2);
            // Pri kolata koqto e izkluchenie ne zabravqi da slojish druga cifra t.e tazi kola otdoly e s 3 gumi a ne s 4 kakto si zaqvil gore v public stringa ^^
            Car car3 = new Car("Reliant", "Robin", 550, "3");
            //car3.Car("Reliant", "Robin", 550);
            allCars.Add(car3);

            //display cars data
            Console.WriteLine("Total number of cars in stock is: {0}", Car.numberOfCars);
            Console.WriteLine();

            Car.ListAllCars(allCars);

            //record the sale of a car
            car3.Sold(true, 350);

            //display cars data
            Console.WriteLine("Total number of cars in stock is: {0}", Car.numberOfCars);
            Console.WriteLine();

            Car.ListAllCars(allCars);


        }
    }
}