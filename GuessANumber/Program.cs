using System.Net.Security;

Random rand = new Random();
int tal = rand.Next(1, 101);
Console.WriteLine("gæt et tal mellem 1 og 100");

int gues = 0;
int number = int.Parse(Console.ReadLine());
gues++;

while (number != tal)
{
    if (number > tal)
    {
        Console.WriteLine("lower!");
    }
    else if (number < tal)
    {
        Console.WriteLine("higer!");
    }

    number = int.Parse(Console.ReadLine());
    gues++;
}
Console.WriteLine($" flot! du brugte {gues} forsøg");