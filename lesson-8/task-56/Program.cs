// Task 56
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("----- Task 56 -----");
Console.WriteLine("Generating array...");


int[] genArray(int n)
{
    int[] res = new int[n];

    Random rnd = new Random();

    for (int i = 0; i < n; i++)
    {
        res[i] = rnd.Next(0, 10);
    }

    return res;
}

int[][] genJaggedArray(int m, int n)
{
    int[][] res = new int[m][];

    for (int i = 0; i < m; i++)
    {
        res[i] = genArray(n);
    }

    return res;
}

void printArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i],2}");
    }
}


void printJaggedArr(int[][] arr)
{
    Console.WriteLine("-----2D-Array-----");
    for (int i = 0; i < arr.Length; i++)
    {
        printArr(arr[i]);
        Console.WriteLine();
    }
    Console.WriteLine("------------------");
}

(int idx, int sum) findMinSumInJaggedArr(int[][] arr)
{
    int idx = 0;
    int sum = arr[0].Sum();

    for (int i = 0; i < arr.Length; i++)
    {
        int sum_tmp = arr[i].Sum();
        if (sum > sum_tmp) {
            idx = i;
            sum = sum_tmp;
        }
    }

    return (idx, sum);
}

void main()
{
    int[][] arr = genJaggedArray(3, 4);
    printJaggedArr(arr);

    var (row, sum) = findMinSumInJaggedArr(arr);

    Console.WriteLine($"Row = {row}; sum = {sum}");
}

main();

Console.WriteLine("------------------");