Console.Write("Type a number: ");
int number = int.Parse(Console.ReadLine());

Console.Write("Type a digit: ");
int digit = int.Parse(Console.ReadLine());

int count = 0;

if (number < 0)
{
    number = -number;
}
while (number > 0)
{
    int lastDigit = number % 10;
    if (lastDigit == digit)
    {
        count++;
    }
    number = number / 10; 
}

Console.WriteLine(count);

