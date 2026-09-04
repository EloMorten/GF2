using System.Net.Security;

Random rand = new Random();
int tal = rand.Next(1, 101);
Console.WriteLine("spiller 1 skal gæt et tal mellem 1 og 100");

int gues = 0;

while (true)
{
    string input = Console.ReadLine();
    int number;

    if (!int.TryParse(input, out number))
    {
        Console.WriteLine("Du skal skrive et gyldigt tal!");
        continue;
    }

    if (number < 1 || number > 100)
    {
        Console.WriteLine("Tallet skal være mellem 1 og 100!");
        continue;
    }

    gues++;

    if (number > tal)
    {
        Console.WriteLine("lower!");
    }
    else if (number < tal)
    {
        Console.WriteLine("higer!");
    }
    else
    {
        Console.WriteLine($"du brugte {gues} forsøg");
        break;
    }
}

Random rand2 = new Random();
int tal2 = rand2.Next(1, 101);
Console.WriteLine("Nu skal din modstander gæt et tal mellem 1 og 100");

int gues2 = 0;

while (true)
{
    string input2 = Console.ReadLine();
    int number2;

    if (!int.TryParse(input2, out number2))
    {
        Console.WriteLine("Du skal skrive et gyldigt tal!");
        continue;
    }

    if (number2 < 1 || number2 > 100)
    {
        Console.WriteLine("Tallet skal være mellem 1 og 100!");
        continue;
    }

    gues2++;

    if (number2 > tal2)
    {
        Console.WriteLine("lower!");
    }
    else if (number2 < tal2)
    {
        Console.WriteLine("higer!");
    }
    else
    {
        Console.WriteLine($"du brugte {gues2} forsøg");
        break;
    }
}

if (gues < gues2)
{
    Console.WriteLine("spiller et vandt");
}
else if (gues > gues2)
{
    Console.WriteLine("spiller 2 vandt");
}
else
{
    Console.WriteLine("i brugte lige mange forsøg!");
}