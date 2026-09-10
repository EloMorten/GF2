Console.WriteLine("Hello, World!");
Console.WriteLine("");
string[] grid = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9"};

Console.WriteLine("------");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(grid[i * 3 + j] + "|");
    }
    Console.WriteLine("");
    Console.WriteLine("------");
}

bool checkwin()
{
    if
    (grid[0] == "O" && grid[1] == "O" && grid[2] == "O" ||
   grid[3] == "O" && grid[4] == "O" && grid[5] == "O" ||
   grid[6] == "O" && grid[7] == "O" && grid[8] == "O" ||
   grid[0] == "O" && grid[3] == "O" && grid[6] == "O" ||
   grid[1] == "O" && grid[4] == "O" && grid[7] == "O" ||
   grid[2] == "O" && grid[5] == "O" && grid[8] == "O" ||
   grid[0] == "O" && grid[4] == "O" && grid[8] == "O" ||
   grid[2] == "O" && grid[4] == "O" && grid[6] == "O")
    {
        Console.WriteLine("Spiller 2 vinder!");
        return true;
    }
    else if
    (grid[0] == "X" && grid[1] == "X" && grid[2] == "X" ||
     grid[3] == "X" && grid[4] == "X" && grid[5] == "X" ||
     grid[6] == "X" && grid[7] == "X" && grid[8] == "X" ||
     grid[0] == "X" && grid[3] == "X" && grid[6] == "X" ||
     grid[1] == "X" && grid[4] == "X" && grid[7] == "X" ||
     grid[2] == "X" && grid[5] == "X" && grid[8] == "X" ||
     grid[0] == "X" && grid[4] == "X" && grid[8] == "X" ||
     grid[2] == "X" && grid[4] == "X" && grid[6] == "X")
    {
        Console.WriteLine("Spiller 1 vinder!");
        return true;
    }
    else if
        (grid[0] != "1"
        && grid[1] != "2"
        && grid[2] != "3"
        && grid[3] != "4"
        && grid[4] != "5"
        && grid[5] != "6"
        && grid[6] != "7"
        && grid[7] != "8"
        && grid[8] != "9")
    {
        Console.WriteLine("Uafgjordt!");
        return true;
    }

    return false;
}
bool GameOver = false;
while (true)
{
    if (GameOver)
    {
        break;
    }
    // spiller 1
    while (true)
    {
        Console.WriteLine("Spiller1 skal vælge et felt");


        string input = Console.ReadLine();
        int valg;

        if (!int.TryParse(input, out valg))
        {
            Console.WriteLine("Du skal skrive et gyldigt tal!");
            continue;
        }

        if (valg < 1 || valg > 9)
        {
            Console.WriteLine("Tallet skal være mellem 1 og 9!");
            continue;
        }

        if (grid[valg - 1] == "X" || grid[valg - 1] == "O")
        {
            Console.WriteLine("felt er optaget vælge et andet felt");
            continue;
        }

        grid[valg - 1] = "X";

        Console.WriteLine("------");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(grid[i * 3 + j] + "|");
            }
            Console.WriteLine("");
            Console.WriteLine("------");
        }
        break;
    }

    if(checkwin() == true)
    {
        break;
    }

    // spiller 2
    while (true)
    {
        Console.WriteLine("spiller2 skal vælge et felt");
        string input2 = Console.ReadLine();
        int valg2;

        if (!int.TryParse(input2, out valg2))
        {
            Console.WriteLine("Du skal skrive et gyldigt tal!");
            continue;
        }

        if (valg2 < 1 || valg2 > 9)
        {
            Console.WriteLine("Tallet skal være mellem 1 og 9!");
            continue;
        }

        if (grid[valg2 - 1] == "X" || grid[valg2 - 1] == "O")
        {
            Console.WriteLine("felt er optaget vælge et andet felt");
            continue;
        }

        grid[valg2 - 1] = "O";

        Console.WriteLine("------");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(grid[i * 3 + j] + "|");
            }
            Console.WriteLine("");
            Console.WriteLine("------");
        }
        break;
    }

    if (checkwin() == true)
    {
        break;
    }
}