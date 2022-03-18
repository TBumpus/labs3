using UsedCarLot;


CarLot carLot = new CarLot();
carLot.SetupCarLot();
string repeat = "y";

while (repeat == "y")
{
    Console.WriteLine("Welcome to our Fantastic used car lot!  The best in the world!");
    carLot.ListCars();
    Console.WriteLine("[7] Add a car");
    Console.WriteLine("[8] Quit");

    Console.WriteLine("Please enter the number for the car or selection you would like");

    int parsedChoice;
    var userChoice = Console.ReadLine();
    bool isInt = int.TryParse(userChoice, out parsedChoice);
    parsedChoice--;


    if (isInt && parsedChoice == 6)
    {
        carLot.AddCar();       
    }
    else if(parsedChoice == 7)
    {
        break;
    }
    else if(isInt)
    {
        //parsedChoice--;
        carLot.ShowCar(parsedChoice);
        Console.WriteLine("Would you like to buy this car? (y/n)");
        string yesOrNo = Console.ReadLine();

        if (yesOrNo == "y")
        {
            carLot.RemoveCar(parsedChoice);
            Console.WriteLine("Excellent! Our finance department will be in touch shortly");
        }

        //Console.WriteLine("would you like to look at our cars again?(y/n) ");
        //repeat = Console.ReadLine();
    }
    else
    {
        Console.WriteLine("that is not a correct number or choice, please try again");
    }

    Console.WriteLine("would you like to look at our cars again?(y/n) ");
    repeat = Console.ReadLine();
}

Console.WriteLine("Goodbye!");











