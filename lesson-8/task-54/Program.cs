// Task 54
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine("----- Task 54 -----");
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
    for (int i = 0; i < arr.Length; i++) {
        Console.Write($"{arr[i], 2}");
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

void main()
{
    int[][] arr = genJaggedArray(3, 4);
    printJaggedArr(arr);

    for (int i = 0; i < arr.Length; i++) {
        Array.Sort(arr[i]);
        Array.Reverse(arr[i]);
    }

    printJaggedArr(arr);
}

main();

Console.WriteLine("------------------");