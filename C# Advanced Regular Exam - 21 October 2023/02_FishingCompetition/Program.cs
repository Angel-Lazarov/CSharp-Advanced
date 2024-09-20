int n = int.Parse(Console.ReadLine());

char[,] area = new char[n, n];

int shipRow = 0;
int shipCol = 0;
int fish = 0;

for (int row = 0; row < area.GetLength(0); row++)
{
    string line = Console.ReadLine();

    for (int col = 0; col < area.GetLength(1); col++)
    {
        area[row, col] = line[col];
        if (line[col] == 'S')
        {
            shipRow = row;
            shipCol = col;
        }
    }
}

string move = string.Empty;
while ((move = Console.ReadLine()) != "collect the nets")
{
    area[shipRow, shipCol] = '-';

    switch (move)
    {
        case "up":
            if (shipRow - 1 < 0)
            {
                shipRow = area.GetLength(0) - 1;
            }
            else
            {
                shipRow--;
            }

            fish += CheckCell(area, shipRow, shipCol);
            break;

        case "down":
            if (shipRow + 1 > area.GetLength(0) - 1)
            {
                shipRow = 0;
            }
            else
            {
                shipRow++;
            }

            fish += CheckCell(area, shipRow, shipCol);
            break;

        case "left":
            if (shipCol - 1 < 0)
            {
                shipCol = area.GetLength(1) - 1;
            }
            else
            {
                shipCol--;

            }

            fish += CheckCell(area, shipRow, shipCol);
            break;

        case "right":
            if (shipCol + 1 > area.GetLength(1) - 1)
            {
                shipCol = 0;

            }
            else
            {
                shipCol++;
            }

            fish += CheckCell(area, shipRow, shipCol);
            break;
    }
    area[shipRow, shipCol] = 'S';
}

if (fish >= 20)
{
    Console.WriteLine("Success! You managed to reach the quota!");
}
else
{
    Console.WriteLine($"You didn't catch enough fish and didn't reach the quota! You need {20 - fish} tons of fish more.");
}

if (fish > 0)
{
    Console.WriteLine($"Amount of fish caught: {fish} tons.");
}

Print();


static int CheckCell(char[,] area, int shipRow, int shipCol)
{
    int result = 0;
    if (area[shipRow, shipCol] != '-') 
    {
        if (area[shipRow, shipCol] == 'W')
        {
            Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{shipRow},{shipCol}]");
            Environment.Exit(0);
        }
        else 
        {
            result = int.Parse(area[shipRow, shipCol].ToString());
        }
    }
    return result;
}


//Print
void Print()
{
    for (int row = 0; row < area.GetLength(0); row++)
    {
        for (int col = 0; col < area.GetLength(1); col++)
        {
            Console.Write(area[row, col]);
        }
        Console.WriteLine();
    }
    //Console.WriteLine();
    //Console.WriteLine();
}
