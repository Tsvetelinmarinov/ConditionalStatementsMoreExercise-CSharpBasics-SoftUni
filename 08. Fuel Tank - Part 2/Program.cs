/**
 * 08. Fuel Tank - Part 2
 */

//•	Типа на горивото – текст с възможности: "Gas", "Gasoline" или "Diesel"
//•	Количество гориво – реално число в интервала [1.00 … 50.00]
//•	Притежание на клубна карта – текст с възможности: "Yes" или "No"

string fuelType = Console.ReadLine();
double fuelQuantity = double.Parse(Console.ReadLine());
string clubCardOwner = Console.ReadLine();

double fuelPrice = 0;

//•	Бензин – 2.22 лева за един литър,
//•	Дизел – 2.33 лева за един литър
//•	Газ – 0.93 лева за литър

switch (fuelType)
{
    case "Diesel":
        fuelPrice = 2.33;
        break;
    case "Gasoline":
        fuelPrice = 2.22;
        break;
    case "Gas":
        fuelPrice = 0.93;
    break;
}

//Ако водача има карта за отстъпки, той се възползва от следните намаления за литър гориво:
// 18 ст.за литър бензин, 12 ст. за литър дизел и 8 ст. за литър газ. 

if (clubCardOwner == "Yes")
{
    switch (fuelType)
    {
        case "Diesel":
            fuelPrice -= 0.12;
            break;
        case "Gasoline":
            fuelPrice -= 0.18;
            break;
        case "Gas":
            fuelPrice -= 0.08;
        break;
    }
}

//Ако шофьора е заредил между 20 и 25 литра включително, той получава 8 процента отстъпка
// от крайната цена, при повече от 25 литра гориво, той получава 10 процента отстъпка от крайната цена

double total = fuelQuantity * fuelPrice;

if (fuelQuantity >= 20 && fuelQuantity <= 25)
{
    total -= total * 0.08;
}
else if (fuelQuantity > 25)
{
    total -= total * 0.1;
}

//•	"{крайната цена на горивото} lv."
//Цената на горивото да бъде форматираната до втората цифра след десетичния знак.

Console.WriteLine($"{total:F2} lv.");