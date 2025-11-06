Console.WriteLine("Type a positive number");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i < n; i ++)
{
    if (n % i == 0)
    {
        if (i == n / 2 || n % (i + 1) != 0 && i > n / 2)
            Console.Write(i);
        else
            Console.Write(i + ", ");
    }
}   