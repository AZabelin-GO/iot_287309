// Task 47
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("----- Task 47 -----");
Console.WriteLine("Enter TWO numbers");


(int m, int n) read2DArrSize()
{
    int[] res = new int[2];

    for (int i = 0; i < 2; i++)
    {
        string num = Console.ReadLine().Trim();

        int tmp;
        if (!int.TryParse(num, out tmp))
        {
            Console.WriteLine("Error: cannot parse number");
            Environment.Exit(1);
        }

        res[i] = tmp;
    }

    return (res[0], res[1]);
}


double[,] gen2DArr(int m, int n) {
    Random rnd = new Random();

    double[,] res = new double[m, n];

    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = Math.Round(rnd.Next(-10, 10) / rnd.NextDouble(), 2);
        }
    }

    return res;
}

void print2DArr(double[,] arr) {
    Console.WriteLine("{");
    for(int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]}, ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("}");
}

void main() {
    var (m, n) = read2DArrSize();

    double[,] arr = gen2DArr(m, n);

    print2DArr(arr);
}

main();

Console.WriteLine("------------------");