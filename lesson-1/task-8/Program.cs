// See https://aka.ms/new-console-template for more information
// Task 8 -  (input 1 number)
Console.WriteLine("----- Task 8 -----");
Console.WriteLine("Enter ONE positive number");

int num = Convert.ToInt32(Console.ReadLine());

if (num <= 0) {
    Console.WriteLine("Error: number should be greater than 0");
    Environment.Exit(1);
}

for (int i = 2; i <= num; i++)
{
    if (i % 2 == 0) {
        Console.Write(i);
        if (i + 2 <= num) {
            Console.Write(", ");
        }
    }
}

Console.WriteLine("");

Console.WriteLine("------------------");
