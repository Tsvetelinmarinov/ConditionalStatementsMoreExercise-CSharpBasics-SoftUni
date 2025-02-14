/**
 * 01. Pipes In Pool
 */




//Вход
//От конзолата се четат четири реда:
//•	Първият ред съдържа числото V – Обем на басейна в литри – цяло число в интервала [1…10000].
//•	Вторият ред съдържа числото P1 – дебит на първата тръба за час – цяло число в интервала [1…5000].
//•	Третият ред съдържа числото P2 – дебит на втората тръба за час– цяло число в интервала [1…5000].
//•	Четвъртият ред H – часовете които работникът отсъства – реално число в интервала [1.0…24.00]

//Изход
//Да се отпечата на конзолата едно от двете възможни състояния:
//•	До колко се е запълнил басейна и коя тръба с колко процента е допринесла.
//o	"The pool is {запълненост на басейна в проценти}% full. Pipe 1: {процент вода от първата тръба}%. Pipe 2: {процент вода от втората тръба}%."
//Aко басейнът се е препълнил – с колко литра е прелял за даденото време.
//o	"For {часовете, които тръбите са пълнили вода} hours the pool overflows with {литрите вода в повече} liters."



int poolVolume = int.Parse(Console.ReadLine());
int leftPipeDebit = int.Parse(Console.ReadLine());
int rigthPipeDebit = int.Parse(Console.ReadLine());
double missingHours = double.Parse(Console.ReadLine());



double totalForLeftPipe = leftPipeDebit * missingHours;
double totalForRigthPipe = rigthPipeDebit * missingHours;


double totalVolumeInto = totalForLeftPipe + totalForRigthPipe;

double volumeIntoPercentage = totalVolumeInto / poolVolume * 100;
double leftPipePercentage = totalForLeftPipe / totalVolumeInto * 100;
double rigthPipePercentage = totalForRigthPipe / totalVolumeInto * 100;




if (totalVolumeInto <= poolVolume)
{
    Console.WriteLine($"The pool is {volumeIntoPercentage:F2}% full. Pipe 1: {leftPipePercentage:F2}%. Pipe 2: {rigthPipePercentage:F2}%.");
}
else
{
    Console.WriteLine($"For {missingHours:F2} hours the pool overflows with {totalVolumeInto - poolVolume:F2} liters.");
}