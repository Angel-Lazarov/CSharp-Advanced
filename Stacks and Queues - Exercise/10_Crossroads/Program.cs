using System.Collections;

int greenSeconds = int.Parse(Console.ReadLine());
int freeWindow = int.Parse(Console.ReadLine());

Queue<string> cars = new Queue<string>();

string command = string.Empty;
int carsPassed = 0;

while ((command = Console.ReadLine()) != "END")
{
    if (command != "green")
    {
        cars.Enqueue(command);
        continue;
    }

    int passingTime = greenSeconds;

    while (passingTime > 0 && cars.Any())
    {
        string car = cars.Dequeue();

        if (car.Length <= passingTime)
        {
            passingTime -= car.Length;
            carsPassed++;
            continue;
        }
        else if (car.Length <= passingTime + freeWindow)
        {
            carsPassed++;
            break;
        }
        else
        {
            char hittedSymbol = car[passingTime+freeWindow];
            Console.WriteLine("A crash happened!");
            Console.WriteLine($"{car} was hit at {hittedSymbol}.");
            Environment.Exit(0);
        }
    }
}

Console.WriteLine("Everyone is safe.");
Console.WriteLine($"{carsPassed} total cars passed the crossroads.");