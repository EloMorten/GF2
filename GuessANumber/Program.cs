using System.Net.Security;
using static System.Runtime.InteropServices.JavaScript.JSType;

Random rand = new Random();
int tal = rand.Next(1, 101);
Console.WriteLine("spiller 1 skal gæt et tal mellem 1 og 100!");
List<int> list = new List<int>();
int guess = 0;

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

    guess++;

    if (number > tal)
    {
        Console.WriteLine("lower!");
        list.Add(number);
    }
    else if (number < tal)
    {
        Console.WriteLine("higer!");
        list.Add(number);
    }
    else
    {
        Console.WriteLine($"du brugte {guess} forsøg");
        list.Add(number);
        break;
    }
}

Console.WriteLine(string.Join(" ,", list));

// spiller 2
List<int> list2 = new List<int>();
Random rand2 = new Random();
int tal2 = rand2.Next(1, 101);
Console.WriteLine("Nu skal din modstander gæt et tal mellem 1 og 100");

int guess2 = 0;

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
        Console.WriteLine("Tallet skal være mellem 1 og 100");
        continue;
    }

    guess2++;

    if (number2 > tal2)
    {
        Console.WriteLine("lower!");
        list2.Add(number2);
    }
    else if (number2 < tal2)
    {
        Console.WriteLine("higer!");
        list2.Add(number2);
    }
    else
    {
        Console.WriteLine($"du brugte {guess2} forsøg");
        list2.Add(number2);
        Console.WriteLine(string.Join(" ,", list2));
        break;
    }
}

if (guess < guess2)
{
    Console.WriteLine("spiller et vandt");
}
else if (guess > guess2)
{
    Console.WriteLine("spiller 2 vandt");
}
else
{
    Console.WriteLine("i brugte lige mange forsøg!");
}