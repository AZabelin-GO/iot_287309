// See https://aka.ms/new-console-template for more information
// Task 4 - find maximum (input 3 numbers)
Console.WriteLine("----- Task 4 -----");
Console.WriteLine("Enter THREE numbers");

int max = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < 2; i++)
{
    int b = Convert.ToInt32(Console.ReadLine());

    if (max < b) {
        max = b;
    }
}

Console.WriteLine("Maximum number is " + max);

Console.WriteLine("------------------");
