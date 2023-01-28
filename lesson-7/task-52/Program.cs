// Task 52
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("----- Task 52 -----");
Console.WriteLine("Generating 2D array...");

int[,] gen2DArr(int m, int n)
{
    Random rnd = new Random();

    int[,] res = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = rnd.Next(0, 10);
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
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("--------------");
}

double[] calcAvgForColumns(int[,] arr) {
    double[] res = new double[arr.GetLength(0)];
    for (int j = 0; j < arr.GetLength(1); j++) {
        int sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++) {
            sum += arr[i, j];
        }
        res[j] = (double) sum / arr.GetLength(0);
    }

    return res;
}

void main()
{
    int m =5, n = 5;

    int[,] arr = gen2DArr(m, n);

    print2DArr(arr);

    foreach (double x in calcAvgForColumns(arr))
    {
        Console.Write($"{x} ");
    }
    Console.WriteLine();

}

main();

Console.WriteLine("------------------");