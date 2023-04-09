Console.Write("Введите A: ");
string text1 = Console.ReadLine();
int number1 = Convert.ToInt32(text1);
Console.Write("Введите B: ");
string text2 = Console.ReadLine();
int number2 = Convert.ToInt32(text2);


if (number1 > number2)
{
    Console.WriteLine("A это max,B это min ");
}
else
{
    Console.WriteLine("A это min,B это max ");
};

