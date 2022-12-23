// See https://aka.ms/new-console-template for more information
// Task 6 - num is even? (input 1 number)
Console.WriteLine("----- Task 6 -----");
Console.WriteLine("Enter ONE number");

int num = Convert.ToInt32(Console.ReadLine());

// if-else operator can be used here, but WriteLine works with bool,
// so it is enough just to print results of logical operation
Console.WriteLine(num % 2 == 0);

Console.WriteLine("------------------");
