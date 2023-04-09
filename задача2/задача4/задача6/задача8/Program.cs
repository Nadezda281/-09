Console.WriteLine("Введите число: ");
string text = Console.ReadLine();
int N = Convert.ToInt32(text);


int i=0;
while (i<N) 

{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
    
    i=i+1;
}
;