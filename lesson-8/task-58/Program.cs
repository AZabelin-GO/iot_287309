// Task 58
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.WriteLine("----- Task 58 -----");
Console.WriteLine("Generating arrays...");


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
    Console.WriteLine("-----2D-JArray-----");
    for (int i = 0; i < arr.Length; i++)
    {
        printArr(arr[i]);
        Console.WriteLine();
    }
    Console.WriteLine("-------------------");
}

void print2DArr(int[,] arr)
{
    Console.WriteLine("-----2D-Array-----");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++) {
            Console.Write($"{arr[i, j], 3}");
        }

        Console.WriteLine();
    }
    Console.WriteLine("------------------");
}

int[] getRow(int[][] arr, int idx) {
    return arr[idx];
}

int[] getColumn(int[][] arr, int idx) {
    int[] res = new int[arr.Length];

    for (int i = 0; i < arr.Length; i++) {
        res[i] = arr[i][idx];
    }

    return res;
}

int calcMultipliedMatrixElem(int[] row, int[] col) {
    int res = 0;

    for (int i = 0; i < row.Length; i++) {
        res += row[i] * col[i];
    }

    return res;
}

int[,] calcMultipliedMatrix(int[][] a, int[][] b) {
    int[,] res = new int[a.Length, b[0].Length];

    for (int i = 0; i < res.GetLength(0); i++) {
        for (int j = 0; j < res.GetLength(1); j++) {
            res[i, j] = calcMultipliedMatrixElem(getRow(a, i), getColumn(b, j));
        }
    }

    return res;
}

void main()
{
    int[][] a = genJaggedArray(2, 2);
    int[][] b = genJaggedArray(2, 2);
    printJaggedArr(a);
    printJaggedArr(b);

    var x = calcMultipliedMatrix(a, b);

    print2DArr(x);
}

main();

Console.WriteLine("------------------");