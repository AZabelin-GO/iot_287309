// Task 10 - print digit (input 1 number)
Console.WriteLine("----- Task 10 -----");
Console.WriteLine("Enter ONE positive number - from 100 to 999");

string num = Console.ReadLine().Trim();

if (num.Length != 3) {
    Console.WriteLine("Error: number should be from 100 to 999");
    Environment.Exit(1);
}

int tmp;
if (!int.TryParse(num, out tmp)) {
    Console.WriteLine("Error: cannot parse integer");
    Environment.Exit(1);
}

Console.WriteLine("Result: " + num[1]);

Console.WriteLine("------------------");
