/**
 * 05. Pets
 */




//•	Първи ред – брой дни – цяло число в интервал [1…5000]
//•	Втори ред – оставена храна в килограми – цяло число в интервал [0…100000]
//•	Трети ред – храна на ден за кучето в килограми – реално число в интервал [0.00…100.00]
//•	Четвърти ред – храна на ден за котката в килограми– реално число в интервал [0.00…100.00]
//•	Пети ред – храна на ден за костенурката в грамове – реално число в интервал [0.00…10000.00]



int days = int.Parse(Console.ReadLine());
int leftFood = int.Parse(Console.ReadLine());
double foodPerDayForDog = double.Parse(Console.ReadLine());
double foodPerDayForCat = double.Parse(Console.ReadLine());
//в грамове
double foodPerDayforTortoise = double.Parse(Console.ReadLine());



//На конзолата трябва да се отпечата на един ред:
//•	Ако оставената храна Е достатъчна:
//o   "{килограма остатък} kilos of food left."
//	Резултатът трябва да е закръглен към по-ниското цяло число
//•	Ако оставената храна НЕ Е достатъчна:
//o   “{килограма недостигат} more kilos of food are needed.”
//	Резултатът трябва да е закръглен към по-високото цяло число



double totalForDog = foodPerDayForDog * days;
double totalForCat = foodPerDayForCat * days;
double totalForTortoise = (foodPerDayforTortoise / 1000) * days;


double finalSum = totalForDog + totalForCat + totalForTortoise;



if (finalSum <= leftFood)
{
    Console.WriteLine($"{Math.Floor(leftFood - finalSum)} kilos of food left.");
}
else
{
    Console.WriteLine($"{Math.Ceiling(Math.Abs(leftFood - finalSum))} more kilos of food are needed.");
}