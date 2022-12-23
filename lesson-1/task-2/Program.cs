// See https://aka.ms/new-console-template for more information

// Task 2 - find maximum number (input 2 numbers)
Console.WriteLine("----- Task 2 -----");
Console.WriteLine("Enter TWO numbers");

int max = Convert.ToInt32(Console.ReadLine());

int b = Convert.ToInt32(Console.ReadLine());

if (max < b) {
    max = b;
}

Console.WriteLine("Maximum number is " + max);

Console.WriteLine("------------------");
