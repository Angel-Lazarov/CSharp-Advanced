int n = int.Parse(Console.ReadLine());

Console.WriteLine(Factoriel(n));


static int Factoriel(int num)
{
    if (num == 0)
    {

        return 1;
    }

    //int sum = num * Factoriel(num -1);
    //return sum;
    return num * Factoriel(num - 1); ;
}