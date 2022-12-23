// Task 13 - print digit (input 1 number)
Console.WriteLine("----- Task 13 -----");
Console.WriteLine("Enter ONE positive number");

string num = Console.ReadLine().Trim();

int tmp;
if (!int.TryParse(num, out tmp)) {
    Console.WriteLine("Error: cannot parse integer");
    Environment.Exit(1);
}

if (tmp < 0) {
    Console.WriteLine("Error: number should be positive (greater than 0)");
    Environment.Exit(1);
}

if (num.Length < 3) {
    Console.WriteLine("Number does not have third digit");
} else {
    Console.WriteLine("Result: " + num[2]);
}

Console.WriteLine("------------------");