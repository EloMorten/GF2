using System.Net.Security;

Console.WriteLine("Hello, World!");
Random rand = new Random();
int tal = rand.Next(1, 11);
Console.WriteLine(tal);
int number = int.Parse(Console.ReadLine());

while (number != tal)
{
    if (number > tal)
    {
        Console.WriteLine("lower");
    }
    else if (number < tal)
    {
        Console.WriteLine("higer!");
    }
    else if (number == tal)
    {
        Console.WriteLine("flot!");
    }
}
