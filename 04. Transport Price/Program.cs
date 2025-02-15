/**
 * 04. Transport Price
 */




//Студент трябва да пропътува n километра. Той има избор измежду три вида транспорт:
//•	Такси. Начална такса: 0.70 лв. Дневна тарифа: 0.79 лв. / км. Нощна тарифа: 0.90 лв. / км.
//•	Автобус. Дневна / нощна тарифа: 0.09 лв. / км. Може да се използва за разстояния минимум 20 км.
//•	Влак. Дневна / нощна тарифа: 0.06 лв. / км. Може да се използва за разстояния минимум 100 км.
//Напишете програма, която въвежда броя километри n и период от деня (ден или нощ) и изчислява цената
//на най-евтиния транспорт.
//Вход
//От конзолата се четат два реда:
//•	Първият ред съдържа числото n – брой километри – цяло число в интервала [1…5000]
//•	Вторият ред съдържа дума “day” или “night” – пътуване през деня или през нощта
//Изход
//Да се отпечата на конзолата най-ниската цена за посочения брой километри, форматирана до втория
//знак след десетичния разделител



int kilometers = int.Parse(Console.ReadLine());
string partOfTheDay = Console.ReadLine();


double transportPrice = 0;
double startTax = 0;



if (kilometers < 20)
{
    startTax = 0.7;
    
    if (partOfTheDay == "day")
    {
        transportPrice = 0.79;
    }
    else if (partOfTheDay == "night")
    {
        transportPrice = 0.9;
    }
}
else if (kilometers >= 20 && kilometers < 100)
{
    transportPrice = 0.09;
}
else if (kilometers >= 100)
{
    transportPrice = 0.06;
}





double total = kilometers * transportPrice + startTax;




Console.WriteLine($"{total:F2}");