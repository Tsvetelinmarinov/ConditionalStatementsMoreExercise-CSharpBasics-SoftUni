/**
 * 07. Fuel Tank
 */




//. От конзолата се четат два реда – текст и реално число, на първия ред се чете типа на горивото
//  – текст с възможности: "Diesel", "Gasoline" или "Gas",а на втория литрите гориво,
//  които има в резервоара.



string fuelType = Console.ReadLine();
double litersOfFuelIn = double.Parse(Console.ReadLine());



//Ако литрите гориво са повече или равни на 25,
//на конзолата да се отпечата "You have enough {вида на горивото}."

//ако са по-малко от 25, да се отпечата "Fill your tank with {вида на горивото}!". 

//В случай, че бъде въведено гориво, различно от посоченото, да се отпечата "Invalid fuel!".


switch (fuelType)
{
    case "Diesel":
        if (litersOfFuelIn < 25)
        {
            Console.WriteLine($"Fill your tank with {fuelType.ToLower()}!");
        }
        else
        {
            Console.WriteLine($"You have enough {fuelType.ToLower()}.");
        }
        break;
    case "Gasoline":
        if (litersOfFuelIn < 25)
        {
            Console.WriteLine($"Fill your tank with {fuelType.ToLower()}!");
        }
        else
        {
            Console.WriteLine($"You have enough {fuelType.ToLower()}.");
        }
        break;
    case "Gas":
        if (litersOfFuelIn < 25)
        {
            Console.WriteLine($"Fill your tank with {fuelType.ToLower()}!");
        }
        else
        {
            Console.WriteLine($"You have enough {fuelType.ToLower()}.");
        }
        break;
    default:
        Console.WriteLine("Invalid fuel!");
    break;
}