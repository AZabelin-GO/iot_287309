// Task 50
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("----- Task 50 -----");

int readNumber()
{
    string num = Console.ReadLine().Trim();

    int tmp;
    if (!int.TryParse(num, out tmp))
    {
        Console.WriteLine("Error: cannot parse number");
        Environment.Exit(1);
    }

    if (tmp <= 0) {
        Console.WriteLine("Error: number should be greater than 0");
        Environment.Exit(1);
    }

    return tmp;
}

int[,] gen2DArr(int m, int n)
{
    Random rnd = new Random();

    int[,] res = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = rnd.Next(-10, 10);
        }
    }

    return res;
}

void print2DArr(int[,] arr)
{
    Console.WriteLine("---2D-Array---");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"[{i * arr.GetLength(0) + j + 1}]={arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("--------------");
}

void main()
{
    int m =5, n = 5;

    int[,] arr = gen2DArr(m, n);

    print2DArr(arr);

    Console.WriteLine("Enter One number");
    int pos = readNumber();

    if (pos > m * n) {
        Console.WriteLine("Out of index");
    } else {
        Console.WriteLine($"x = {arr[(pos - 1) / m, (pos - 1) % n]}");
    }
}

main();

Console.WriteLine("------------------");