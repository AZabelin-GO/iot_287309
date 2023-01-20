// Task 25
//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("----- Task 25 -----");
Console.WriteLine("Enter TWO numbers");

int[] readNumbers(int n) {
    int[] res = new int[n];

    for (int i = 0; i < n; i++) {
        string num = Console.ReadLine().Trim();
        
        int tmp;
        if (!int.TryParse(num, out tmp)) {
            Console.WriteLine("Error: cannot parse number");
            Environment.Exit(1);
        }

        res[i] = tmp;
    }

    return res;
}

void main() {
    int[] numbers = readNumbers(2);

    Console.WriteLine(Math.Pow(numbers[0], numbers[1]));
}

main();

Console.WriteLine("------------------");