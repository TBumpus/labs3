using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedCarLot
{
    public class CarLot
    {
        private List<Car> _currentInventory { get; set; }

        public void SetupCarLot()
        {
            //seeding data
            _currentInventory = new List<Car>()
            {
            new Car("Ford", "Fusion", 2022, 20000),
            new Car("Chevy", "Camaro", 2022, 32000),  
            new Car("Dodge", "Challenger", 2022, 35000),
            new UsedCar("Honda", "Civic", 2010, 10000, 74976),
            new UsedCar("Mecury", "Cougar", 2007, 7500, 156000),
            new UsedCar("Toyota", "Camry", 2010, 6500, 96000)
            };
        }  



        public void AddCar(/*Car userCar*/) // should take a car as an argument
        {
            Console.WriteLine("Please enter a make: ");
            string userMake = Console.ReadLine();

            Console.WriteLine("Please enter a Model: ");
            string userModel = Console.ReadLine();

            Console.WriteLine("Please enter a year: ");
            int userYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a price: ");
            decimal userPrice = decimal.Parse(Console.ReadLine());

            _currentInventory.Add(new Car(userMake, userModel, userYear, userPrice) { });

            //_currentInventory.Add(userCar);
        }


        public void ListCars()
        {
            for (var i=0; i < _currentInventory.Count(); i++ )
            {
                
                Console.WriteLine($"[{i+1}]" + _currentInventory[i].ToString());
            }
            
        }

        public void ShowCar(int carChoice)
        {
            Console.WriteLine(_currentInventory[carChoice].ToString());
            //Console.WriteLine("Would you like to buy this car? (y/n)");

        }


        public void RemoveCar(int carIndex) //should take in a car as an argument
        {
            //check to see if there is a car at this index

            _currentInventory.Remove(_currentInventory[carIndex]);         

          
           
        }


       

    }


}
