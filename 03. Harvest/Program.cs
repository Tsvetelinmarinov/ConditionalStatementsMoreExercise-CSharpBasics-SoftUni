/**
 * 03. Harvest
 */



//•	1ви ред: X кв.м е лозето – цяло число в интервала [10 … 5000]
//•	2ри ред: Y грозде за един кв.м – реално число в интервала [0.00 … 10.00]
//•	3ти ред: Z нужни литри вино – цяло число в интервала [10 … 600]
//•	4ти ред: брой работници – цяло число в интервала [1 … 20]



int graundInSquareMeters = int.Parse(Console.ReadLine());
double grapeFromOneSquareMeter = double.Parse(Console.ReadLine());
int litersOfWineNeeded = int.Parse(Console.ReadLine());
int workers = int.Parse(Console.ReadLine());



//От лозе с площ X квадратни метри се заделя 40% от реколтата за производство на вино.
//От 1 кв.м лозе се изкарват Y килограма грозде. За 1 литър вино са нужни 2,5 кг. грозде.
//Желаното количество вино за продан е Z литра.
//Напишете програма, която пресмята колко вино може да се произведе и дали това количествое достатъчно.
//Ако е достатъчно, остатъкът се разделя по равно между работниците на лозето.



double totalGrape = graundInSquareMeters * grapeFromOneSquareMeter;
double grapeForWine = totalGrape * 0.4;
double grapeForWineInLiters = grapeForWine / 2.5;



double difference = Math.Abs(grapeForWineInLiters - litersOfWineNeeded);



//•	Ако произведеното вино е по-малко от нужното:
//o   “It will be a tough winter! More {недостигащо вино} liters wine needed.”
//	Резултатът трябва да е закръглен към по-ниско цяло число
//•	Ако произведеното вино е колкото или повече от нужното:
//o   “Good harvest this year! Total wine: {общо вино} liters.”
//	Резултатът трябва да е закръглен към по-ниско цяло число
//o	“{Оставащо вино} liters left -> {вино за 1 работник} liters per person.”
//	И двата резултата трябва да са закръглени към по-високото цяло число



if (grapeForWineInLiters < litersOfWineNeeded)
{
    Console.WriteLine($"It will be a tough winter! More {Math.Floor(difference)} liters wine needed.");
}
else
{
    Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(grapeForWineInLiters)} liters.");
    Console.WriteLine($"{Math.Ceiling(difference)} liters left -> {Math.Ceiling(difference / workers)} liters per person.");
}