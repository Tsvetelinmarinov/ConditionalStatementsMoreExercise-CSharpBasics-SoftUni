/**
 * 06. Flower Shop
 */





//Входът се чете от конзолата и се състои от 5 реда:
//•	Брой магнолии – цяло число в интервала [0 … 50]
//•	Брой зюмбюли – цяло число в интервала [0 … 50]
//•	Брой рози – цяло число в интервала [0 … 50]
//•	Брой кактуси – цяло число в интервала [0 … 50]
//•	Цена на подаръка – реално число в интервала [0.00 … 500.00]


int magnoli = int.Parse(Console.ReadLine());
int zumbuli = int.Parse(Console.ReadLine());
int roses = int.Parse(Console.ReadLine());
int kaktusi = int.Parse(Console.ReadLine());
double giftPrice = double.Parse(Console.ReadLine());


//•	Магнолии – 3.25 лева
//•	Зюмбюли – 4 лева
//•	Рози – 3.50 лева
//•	Кактуси – 8 лева
//От общата сума, Мария трябва да плати 5% данъци.


//•	Ако парите СА стигнали: "She is left with {останали} leva."
// – сумата трябва да е закръглена към по-малко цяло число (пр. 1.90 -> 1).
//•	Ако парите НЕ достигат: "She will have to borrow {останали} leva."
// – сумата трябва да е закръглена към по-голямо цяло число (пр. 1.10 -> 2).



double total = (magnoli * 3.25) + (zumbuli * 4) + (roses * 3.50) + (kaktusi * 8);
total -= total * 0.05;

double difference = Math.Abs(total - giftPrice);



if (total < giftPrice)
{
    Console.WriteLine($"She will have to borrow {Math.Ceiling(difference)} leva.");
}
else
{
    Console.WriteLine($"She is left with {Math.Floor(difference)} leva.");
}