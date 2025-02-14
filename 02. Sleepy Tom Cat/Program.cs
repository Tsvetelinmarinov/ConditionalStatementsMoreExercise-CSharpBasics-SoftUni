/**
 * 02. Sleepy Tom Cat
 */




int freeDays = int.Parse(Console.ReadLine());

// 63 / 127

int workingDays = 365 - freeDays;

double minutesFromWorkingDays = workingDays * 63;
double minutesFromFreeDays = freeDays * 127;


double totalMinutes = minutesFromFreeDays + minutesFromWorkingDays;


//конзолата трябва да се отпечатат два реда.
//•	Ако времето за игра на Том е над нормата за текущата година:
//o На първия ред отпечатайте: “Tom will run away”
//o	 На втория ред отпечатайте разликата от нормата във формат:
//   “{H} hours and {M} minutes more for play”
//•	Ако времето за игра на Том е под нормата за текущата година:
//o На първия ред отпечатайте: “Tom sleeps well”
//o	 На втория ред отпечатайте разликата от нормата във формат:
//   “{H} hours and {M} minutes less for play”


double difference = Math.Abs(30000 - totalMinutes);



if (totalMinutes <= 30000)
{
    Console.WriteLine("Tom sleeps well");
    Console.WriteLine($"{Math.Floor(difference / 60)} hours and {difference % 60} minutes less for play");
}
else
{
    Console.WriteLine("Tom will run away");
    Console.WriteLine($"{Math.Floor(difference / 60)} hours and {difference % 60} minutes more for play");
}