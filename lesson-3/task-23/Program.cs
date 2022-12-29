// Task 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

Console.WriteLine("----- Task 21 -----");
Console.WriteLine("Enter a number (from 1 to N)");

string num = Console.ReadLine().Trim();

int tmp;
if (!int.TryParse(num, out tmp)) {
    Console.WriteLine("Error: cannot parse number");
    Environment.Exit(1);
}

if (tmp < 0) {
    Console.WriteLine("Error: number should be positive");
    Environment.Exit(1);
}

for (int i = 1; i <= tmp; i++)
{
    Console.Write(Math.Pow(i, 3));
    if (i < tmp) {
        Console.Write(", ");
    } else {
        Console.WriteLine();
    }
}


Console.WriteLine("------------------");