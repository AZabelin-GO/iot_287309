// Task 43
// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("----- Task 43 -----");
Console.WriteLine("Enter FOUR numbers: k1, b1, k2, b2");

int[] readNumbers(int n)
{
    int[] res = new int[n];

    for (int i = 0; i < n; i++)
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

    return res;
}

(float x, float y) getLinesIntersection(int[] consts)
{
    float x = (float) (consts[3] - consts[1]) / (consts[0] - consts[2]);
    float y = consts[0] * x + consts[1];

    return (x, y);
}

void main()
{
    int[] consts = readNumbers(4);

    Console.WriteLine($"{consts}");

    var (x, y) = getLinesIntersection(consts);

    Console.WriteLine($"({x}, {y})");
}

main();

Console.WriteLine("------------------");