
Console.Write("Введите A: ");
string text1 = Console.ReadLine();
int number1 = Convert.ToInt32(text1);
Console.Write("Введите B: ");
string text2 = Console.ReadLine();
int number2 = Convert.ToInt32(text2);
Console.Write("Введите C: ");
string text3 = Console.ReadLine();
int number3 = Convert.ToInt32(text3);
int max = number1;

if (number1 > max) max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;

Console.Write(max);