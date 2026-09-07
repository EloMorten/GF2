using System.Reflection.Metadata.Ecma335;
Random random = new Random();

Console.WriteLine("Vælg: sten, saks eller papir");

int pcTal = random.Next(1, 4);
int Spoints = 0;
int PSpoints = 0;
string pc = "";
while ((Spoints == 3) || (PSpoints == 3))
{
    string spiller = Console.ReadLine().ToLower();

    if (pcTal == 1)
    {
        pc = "sten";
    }
    else if (pcTal == 2)
    {
        pc = "saks";
    }
    else if (pcTal == 3)
    {
        pc = "papir";
    }

    Console.WriteLine("Du valgte: " + spiller);
    Console.WriteLine("Computeren valgte: " + pc);


    if (spiller == pc)
    {
        Console.WriteLine("Det blev uafgjort!");
    }
    else if (
        (spiller == "sten" && pc == "saks") ||
        (spiller == "saks" && pc == "papir") ||
        (spiller == "papir" && pc == "sten")
    )
    {
        Console.WriteLine("Du vandt!");
        Spoints++;
    }
    else if (
        spiller == "sten" ||
        spiller == "saks" ||
        spiller == "papir"
    )
    {
        Console.WriteLine("Computeren vandt!");
        PSpoints++;
    }
    else
    {
        Console.WriteLine("Du skal skrive sten, saks eller papir.");
    }
    Console.WriteLine($"computer points = {PSpoints}");
    Console.WriteLine($"dine points = {Spoints}");
}