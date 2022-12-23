// Task 15 - check weekend (input 1 number)
Console.WriteLine("----- Task 15 -----");
Console.WriteLine("Enter ONE positive number - from 1 to 7");

string num = Console.ReadLine().Trim();

int tmp;
if (!int.TryParse(num, out tmp)) {
    Console.WriteLine("Error: cannot parse number");
    Environment.Exit(1);
}

if ((tmp < 1) || (tmp > 7)) {
    Console.WriteLine("Error: number should be from 1 to 7");
    Environment.Exit(1);
}

if ((tmp == 6) || (tmp == 7)) {
    Console.WriteLine(true);
} else {
    Console.WriteLine(false);
}

Console.WriteLine("------------------");