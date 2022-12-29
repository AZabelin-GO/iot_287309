// Task 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

Console.WriteLine("----- Task 21 -----");
Console.WriteLine("Enter coordinates of first point (x, y, z)");

int[] firstPoint = new int[3];

for (int i = 0; i < 3; i++)
{
    string num = Console.ReadLine().Trim();

    int tmp;
    if (!int.TryParse(num, out tmp)) {
        Console.WriteLine("Error: cannot parse number");
        Environment.Exit(1);
    }

    firstPoint[i] = tmp;
}

Console.WriteLine("Enter coordinates of second point (x, y, z)");

int[] secondPoint = new int[3];

for (int i = 0; i < 3; i++)
{
    string num = Console.ReadLine().Trim();

    int tmp;
    if (!int.TryParse(num, out tmp)) {
        Console.WriteLine("Error: cannot parse number");
        Environment.Exit(1);
    }

    secondPoint[i] = tmp;
}

double distance = 0.0;

for (int i = 0; i < 3; i++)
{
    distance += Math.Pow(secondPoint[i] - firstPoint[i], 2);
}

distance = Math.Sqrt(distance);

Console.WriteLine(distance);

Console.WriteLine("------------------");