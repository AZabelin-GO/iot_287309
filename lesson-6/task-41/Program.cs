// Task 41
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("----- Task 41 -----");
Console.WriteLine("Enter Numbers; enter empty line to stop");

void main() {
    int numbersCounter = 0;

    while (true)
    {
        string num = Console.ReadLine().Trim();

        if (num.Length == 0) {
            break;
        }

        int tmp;
        if (!int.TryParse(num, out tmp)) {
            Console.WriteLine("Error: cannot parse number");
            Environment.Exit(1);
        }

        if (tmp > 0) {
            numbersCounter++;
        }
    }

    Console.WriteLine($"Amount of numbers greater than 0 is {numbersCounter}");
}

main();

Console.WriteLine("------------------");